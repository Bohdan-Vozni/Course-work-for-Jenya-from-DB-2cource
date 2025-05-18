using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class specialistsSales : Form
    {
        public specialistsSales()
        {
            InitializeComponent();
        }

        private void LoadSpecialistsToComboBox()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetDataSpecialistForPurchase", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var specialist = new SpecialistForCombox
                    {
                        idSpecialist = reader["Specialist_ID"].ToString(),
                        nameSpecialist = reader["SpecialistName"].ToString()
                    };
                    specialists.Items.Add(specialist);
                }

                reader.Close();
            }

            specialists.DisplayMember = "nameSpecialist";
            specialists.ValueMember = "idSpecialist";
        }

        private DataTable GetAllSpecialistsSales(string specialistId)
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM vw_SpecialistSales WHERE Specialist_ID = @id", connection);
                command.Parameters.AddWithValue("@id", specialistId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["Specialist_ID"].Visible = false;
            dataGridView1.Columns["SpecialistName"].HeaderText = "Повне ім'я спеціаліста";
            dataGridView1.Columns["TotalSales"].HeaderText = "Кількість Продажів";
            dataGridView1.Columns["TotalRevenue"].HeaderText = "Загальний дохід";

        }

        private void specialistsSales_Load(object sender, EventArgs e)
        {

            LoadSpecialistsToComboBox();

        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void specialists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (specialists.SelectedItem is SpecialistForCombox selectedSpecialist)
            {
                dataGridView1.DataSource = GetAllSpecialistsSales(selectedSpecialist.idSpecialist);
                SetColumnHeaders();
            }
        }

        private void ExportToPDF(DataGridView dgv, string filename)
        {
            try
            {
                Document doc = new Document(PageSize.A4, 10, 10, 10, 10);
                PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();

                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.WidthPercentage = 100;

                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                }

                doc.Add(pdfTable);
                doc.Close();

                MessageBox.Show("Файл успішно збережено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при експорті PDF: " + ex.Message);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                FileName = "звіт.pdf"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportToPDF(dataGridView1, sfd.FileName);
            }
        }
    }
}
