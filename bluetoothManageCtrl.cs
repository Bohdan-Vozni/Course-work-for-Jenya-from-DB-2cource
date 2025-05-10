using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class bluetoothManageCtrl : UserControl
    {

        private DataTable allBluetooths;

        public bluetoothManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addBluetooth addBluetooth = new addBluetooth();
            addBluetooth.Show();

            addBluetooth.FormClosed += (s, args) =>
             {
                 allBluetooths = GetAllBluetooths();
                 dataGridView1.DataSource = allBluetooths;
                 SetColumnHeaders();
             };
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

                editForm.FormClosed += (s, args) =>
                {
                    allBluetooths = GetAllBluetooths();
                    dataGridView1.DataSource = allBluetooths;
                    SetColumnHeaders();
                };


            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["Bluetooth_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["Generation"].HeaderText = "Покоління";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            allBluetooths = GetAllBluetooths();
            dataGridView1.DataSource = allBluetooths;
            SetColumnHeaders();
        }

        private void bluetoothManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            allBluetooths = GetAllBluetooths();
            dataGridView1.DataSource = allBluetooths;
            SetColumnHeaders();

        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if (allBluetooths == null) return;

            string filter = searchTB.Text.Trim().Replace("'", "''");
            if (string.IsNullOrEmpty(filter))
            {
                dataGridView1.DataSource = allBluetooths;
            }
            else
            {
                DataView dv = allBluetooths.DefaultView;
                dv.RowFilter = $"Title LIKE '%{filter}%'";
                dataGridView1.DataSource = dv;
            }
            SetColumnHeaders();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
