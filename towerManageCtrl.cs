using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class towerManageCtrl : UserControl
    {
        private DataTable fullTowerTable;

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

                fullTowerTable = GetAllTowers();
                ApplySearchFilter();
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["Tower_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["TypeSize"].HeaderText = "Розмір";
            dataGridView1.Columns["FanIncluded"].HeaderText = "Наявність кулера";
            dataGridView1.Columns["FanType"].HeaderText = "Тип кулера";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void towerManageCtrl_Load(object sender, EventArgs e)
        {
            fullTowerTable = GetAllTowers();
            ApplySearchFilter();
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullTowerTable = GetAllTowers();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullTowerTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullTowerTable);

            if (!string.IsNullOrEmpty(filterText))
            {

                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
