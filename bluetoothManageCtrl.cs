using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class bluetoothManageCtrl : UserControl
    {
        public bluetoothManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addBluetooth addBluetooth = new addBluetooth();
            addBluetooth.Show();
        }

        private DataTable GetAllBluetooths()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllBluetooth", connection);
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
                Bluetooth bluetooth = new Bluetooth
                {
                    Bluetooth_ID = row.Cells["Bluetooth_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Generation = row.Cells["Generation"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editBluetooth editForm = new editBluetooth(bluetooth);
                editForm.Show();

                dataGridView1.DataSource = GetAllBluetooths();
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllBluetooths();
        }

        private void bluetoothManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllBluetooths();
        }
    }
}
