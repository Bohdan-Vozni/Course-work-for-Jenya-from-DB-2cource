using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class fanCoolingManageCtrl : UserControl
    {
        private DataTable fullFanCoolingTable;

        public fanCoolingManageCtrl()
        {
            InitializeComponent();
        }

        private DataTable GetAllFanCooling()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllFanCooling", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullFanCoolingTable = GetAllFanCooling();
            ApplySearchFilter();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                FanCooling fan = new FanCooling
                {
                    FanCooling_ID = row.Cells["FanCooling_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    TypeSize = row.Cells["TypeSize"].Value.ToString(),
                    HeatRemoval = row.Cells["HeatRemoval"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editFanCooling editForm = new editFanCooling(fan);
                editForm.Show();

                editForm.FormClosed += (s, args) =>
                {
                    fullFanCoolingTable = GetAllFanCooling();
                    ApplySearchFilter();
                };
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["FanCooling_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["TypeSize"].HeaderText = "Розмір";
            dataGridView1.Columns["HeatRemoval"].HeaderText = "Індекс відведення тепла";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addFanCooling addForm = new addFanCooling();
            addForm.Show();

            addForm.FormClosed += (s, args) =>
            {
                fullFanCoolingTable = GetAllFanCooling();
                ApplySearchFilter();
            };
        }

        private void fanCoolingManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullFanCoolingTable = GetAllFanCooling();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            if (fullFanCoolingTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullFanCoolingTable);

            if (!string.IsNullOrEmpty(filterText))
            {
                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
