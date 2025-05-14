using Microsoft.Data.SqlClient;
using System;
using System.Data;
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
    }
}
