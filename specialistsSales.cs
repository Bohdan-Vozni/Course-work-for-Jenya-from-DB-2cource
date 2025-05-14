using Microsoft.Data.SqlClient;
using System;
using System.Data;
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
    }
}
