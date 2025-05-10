using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ramManageCtrl : UserControl
    {
        public ramManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddRamBtn_Click(object sender, EventArgs e)
        {
            addRam addRam = new addRam();
            addRam.Show();
        }

        private DataTable GetAllRams()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllRAM", connection); // Название процедуры должно совпадать
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
                RAM ram = new RAM
                {
                    RAM_ID = row.Cells["RAM_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    MemoryType = row.Cells["MemoryType"].Value.ToString(),
                    MemoryQuantity = row.Cells["MemoryQuantity"].Value.ToString(),
                    RadiatorType = row.Cells["RadiatorType"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                edirRam editForm = new edirRam(ram);
                editForm.Show();

                dataGridView1.DataSource = GetAllRams();
            }
        }

        private void ramManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllRams();

        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllRams();
        }
    }
}