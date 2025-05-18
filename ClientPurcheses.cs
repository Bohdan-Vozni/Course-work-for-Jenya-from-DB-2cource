using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ClientPurcheses : Form
    {
        public ClientPurcheses()
        {
            InitializeComponent();
        }
        private void SetColumnHeaders()
        {
            dataGridView1.Columns["Purchase_ID"].Visible = false;
            dataGridView1.Columns["DateCreate"].HeaderText = "Дата створення";
            dataGridView1.Columns["ClientName"].HeaderText = "Повне ім'я кліента";
            dataGridView1.Columns["ClientPhone"].HeaderText = "Номер клієнта";
            dataGridView1.Columns["SpecialistName"].HeaderText = "Повне ім'я спеціаліста";
            dataGridView1.Columns["PCCost"].HeaderText = "Ціна PC";

        }

        private DataTable GetAllClientsPurrcheses()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from vw_ClientPurchases", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientPurcheses_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllClientsPurrcheses();
            SetColumnHeaders();

        }

        private void ExportToPDF(DataGridView dgv, string filename)
        {
            try
            {
                using (FileStream stream = new FileStream(filename, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f); // Пейзажна орієнтація з полями
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();

                    PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HeaderRows = 1;

                    // Пропорційні ширини колонок на основі ширини DataGridView
                    float[] widths = new float[dgv.ColumnCount];
                    float totalWidth = 0;
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {
                        widths[i] = dgv.Columns[i].Width;
                        totalWidth += dgv.Columns[i].Width;
                    }

                    for (int i = 0; i < widths.Length; i++)
                    {
                        widths[i] = widths[i] / totalWidth * 100;
                    }

                    pdfTable.SetWidths(widths);

                    // Заголовки
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText))
                        {
                            BackgroundColor = BaseColor.LIGHT_GRAY,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            VerticalAlignment = Element.ALIGN_MIDDLE,
                            Padding = 5,
                            NoWrap = false
                        };
                        pdfTable.AddCell(headerCell);
                    }

                    // Дані
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                PdfPCell dataCell = new PdfPCell(new Phrase(cell.Value?.ToString() ?? ""))
                                {
                                    HorizontalAlignment = Element.ALIGN_LEFT,
                                    VerticalAlignment = Element.ALIGN_MIDDLE,
                                    Padding = 4,
                                    NoWrap = false
                                };
                                pdfTable.AddCell(dataCell);
                            }
                        }
                    }

                    doc.Add(pdfTable);
                    doc.Close();
                    stream.Close();
                }

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
