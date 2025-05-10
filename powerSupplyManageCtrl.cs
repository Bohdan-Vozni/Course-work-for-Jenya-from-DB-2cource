using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class powerSupplyManageCtrl : UserControl
    {
        private DataTable fullPowerSupplyTable;

        public powerSupplyManageCtrl()
        {
            InitializeComponent();
        }

        private DataTable GetAllPowerSupplies()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllPowerSupply", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullPowerSupplyTable = GetAllPowerSupplies();
            ApplySearchFilter();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PowerSupply psu = new PowerSupply
                {
                    PowerSupply_ID = row.Cells["PowerSupply_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Strength = row.Cells["Strength"].Value.ToString(),
                    Sertificate = row.Cells["Sertificate"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editPowerSupply editForm = new editPowerSupply(psu);
                editForm.Show();

                fullPowerSupplyTable = GetAllPowerSupplies();
                ApplySearchFilter();
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["PowerSupply_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["Strength"].HeaderText = "Потужність";
            dataGridView1.Columns["Sertificate"].HeaderText = "Сертифікат";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void openAddRamBtn_Click(object sender, EventArgs e)
        {
            addPowerSupply addForm = new addPowerSupply();
            addForm.Show();
        }

        private void powerSupplyManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullPowerSupplyTable = GetAllPowerSupplies();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullPowerSupplyTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullPowerSupplyTable);

            if (!string.IsNullOrEmpty(filterText))
            {

                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
