using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class wateCoolingManageCtrl : UserControl
    {
        private DataTable fullWaterCoolingTable;

        public wateCoolingManageCtrl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                WaterCooling wc = new WaterCooling
                {
                    WaterCooling_ID = row.Cells["WaterCooling_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    TypeSize = row.Cells["TypeSize"].Value.ToString(),
                    HeatRemoval = row.Cells["HeatRemoval"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editWaterCooling editForm = new editWaterCooling(wc);
                editForm.Show();

                editForm.FormClosed += (s, arg) =>
                 {
                     fullWaterCoolingTable = GetAllWaterCoolings();
                     ApplySearchFilter();
                 };
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullWaterCoolingTable = GetAllWaterCoolings();
            ApplySearchFilter();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addWaterCooling addForm = new addWaterCooling();
            addForm.Show();

            addForm.FormClosed += (s, arg) =>
            {
                fullWaterCoolingTable = GetAllWaterCoolings();
                ApplySearchFilter();
            };
        }

        private DataTable GetAllWaterCoolings()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllWaterCooling", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["WaterCooling_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["TypeSize"].HeaderText = "Розмір";
            dataGridView1.Columns["HeatRemoval"].HeaderText = "Індекс відведення тепла";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void wateCoolingManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullWaterCoolingTable = GetAllWaterCoolings();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullWaterCoolingTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullWaterCoolingTable);

            if (!string.IsNullOrEmpty(filterText))
            {

                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
