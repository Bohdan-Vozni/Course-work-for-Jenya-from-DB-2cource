using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class powerSupplyManageCtrl : UserControl
    {
        public powerSupplyManageCtrl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private DataTable GetAllPowerSupplies()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllPowerSupply", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllPowerSupplies();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                PowerSupply psu = new PowerSupply
                {
                    PowerSupply_ID = row.Cells["PowerSupply_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Strength = row.Cells["Strength"].Value.ToString(),
                    Sertificate = row.Cells["Sertificate"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editPowerSupply editForm = new editPowerSupply(psu);
                editForm.Show();

                dataGridView1.DataSource = GetAllPowerSupplies();
            }
        }

        private void openAddRamBtn_Click(object sender, EventArgs e)
        {
            addPowerSupply addForm = new addPowerSupply();
            addForm.Show();
        }

        private void powerSupplyManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllPowerSupplies();
        }
    }
}
