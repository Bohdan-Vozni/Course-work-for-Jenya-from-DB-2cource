using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class wifiManageCtrl : UserControl
    {
        public wifiManageCtrl()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Wifi wifi = new Wifi
                {
                    Wifi_ID = row.Cells["Wifi_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Generation = row.Cells["Generation"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editWifi editForm = new editWifi(wifi);
                editForm.Show();

                dataGridView1.DataSource = GetAllWifis();
            }
        }

        private DataTable GetAllWifis()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllWifi", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllWifis();
        }

        private void openAddWifiBtn_Click(object sender, EventArgs e)
        {
            addWifi addForm = new addWifi();
            addForm.Show();
        }

        private void wifiManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllWifis();
        }
    }
}
