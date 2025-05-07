using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class towerManageCtrl : UserControl
    {
        public towerManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddTowerBtn_Click(object sender, EventArgs e)
        {
            addTower addTower = new addTower();
            addTower.Show();
        }
        private DataTable GetAllTowers()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllTower", connection);
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
                Tower tower = new Tower
                {
                    Tower_ID = row.Cells["Tower_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    TypeSize = row.Cells["TypeSize"].Value.ToString(),
                    FanIncluded = row.Cells["FanIncluded"].Value.ToString(),
                    FanType = row.Cells["FanType"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editTower editForm = new editTower(tower);
                editForm.Show();

                dataGridView1.DataSource = GetAllTowers();
            }
        }

        private void towerManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllTowers();
        }
    }
}