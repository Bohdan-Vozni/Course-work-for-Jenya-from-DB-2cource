using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ramManageCtrl : UserControl
    {
        private DataTable fullRamTable;

        public ramManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddRamBtn_Click(object sender, EventArgs e)
        {
            addRam addRam = new addRam();
            addRam.Show();

            addRam.FormClosed += (s, args) =>
            {
                fullRamTable = GetAllRams();
                ApplySearchFilter();
            };
        }

        private DataTable GetAllRams()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllRAM", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                RAM ram = new RAM
                {
                    RAM_ID = row.Cells["RAM_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    MemoryType = row.Cells["MemoryType"].Value.ToString(),
                    MemoryQuantity = row.Cells["MemoryQuantity"].Value.ToString(),
                    RadiatorType = row.Cells["RadiatorType"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                edirRam editForm = new edirRam(ram);
                editForm.Show();

                editForm.FormClosed += (s, args) =>
                {
                    fullRamTable = GetAllRams();
                    ApplySearchFilter();
                };


            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["RAM_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["MemoryType"].HeaderText = "Тип пам'яті";
            dataGridView1.Columns["MemoryQuantity"].HeaderText = "Кількість пам'яті";
            dataGridView1.Columns["RadiatorType"].HeaderText = "Тип радіатора";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void ramManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullRamTable = GetAllRams();
            ApplySearchFilter();
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullRamTable = GetAllRams();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullRamTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullRamTable);

            if (!string.IsNullOrEmpty(filterText))
            {

                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
