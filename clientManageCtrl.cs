using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class clientManageCtrl : UserControl
    {
        private DataTable fullClientTable;

        public clientManageCtrl()
        {
            InitializeComponent();
        }

        private DataTable GetAllClients()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllClient", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Client client = new Client
                {
                    Client_ID = row.Cells["Client_ID"].Value.ToString(),
                    ClientName = row.Cells["ClientName"].Value.ToString(),
                    Phone = row.Cells["Phone"].Value.ToString(),
                    HomeAddress = row.Cells["HomeAddress"].Value.ToString()
                };

                editClient editForm = new editClient(client);
                editForm.Show();

                editForm.FormClosed += (s, args) =>
                {
                    fullClientTable = GetAllClients();
                    ApplySearchFilter();
                };
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullClientTable = GetAllClients();
            ApplySearchFilter();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addClient addForm = new addClient();
            addForm.Show();

            addForm.FormClosed += (s, args) =>
            {
                fullClientTable = GetAllClients();
                ApplySearchFilter();
            };
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["Client_ID"].Visible = false;
            dataGridView1.Columns["ClientName"].HeaderText = "Повне ім'я";
            dataGridView1.Columns["Phone"].HeaderText = "Номер телефону";
            dataGridView1.Columns["HomeAddress"].HeaderText = "Домашня адреса";
        }

        private void clientManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullClientTable = GetAllClients();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            if (fullClientTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullClientTable);

            if (!string.IsNullOrEmpty(filterText))
            {
                view.RowFilter = $"ClientName LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
