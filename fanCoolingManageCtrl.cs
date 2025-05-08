using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class fanCoolingManageCtrl : UserControl
    {
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
            dataGridView1.DataSource = GetAllFanCooling();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    FanCooling fan = new FanCooling
                    {
                        FanCooling_ID = row.Cells["FanCooling_ID"].Value.ToString(),
                        Title = row.Cells["Title"].Value.ToString(),
                        TypeSize = row.Cells["Type"].Value.ToString(),
                        HeatRemoval = row.Cells["HeatRemoval"].Value.ToString(),
                        Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                    };

                    editFanCooling editForm = new editFanCooling(fan);
                    editForm.Show();

                    dataGridView1.DataSource = GetAllFanCooling();
                }
            }
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllFanCooling();
        }

        private void fanCoolingManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllFanCooling();
        }
    }
}
