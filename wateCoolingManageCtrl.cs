using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class wateCoolingManageCtrl : UserControl
    {
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

                dataGridView1.DataSource = GetAllWaterCoolings();
            }

        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllWaterCoolings();

        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addWaterCooling addForm = new addWaterCooling();
            addForm.Show();

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
        private void wateCoolingManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllWaterCoolings();

        }
    }
}
