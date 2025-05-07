using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class cpuManageCtrl : UserControl
    {
        public cpuManageCtrl()
        {
            InitializeComponent();
        }



        private DataTable GetAllCPUs()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllCPU", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        private void openAddCpuBtn_Click(object sender, EventArgs e)
        {
            addCpu addingCpu = new addCpu();
            addingCpu.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                CPU cpu = new CPU
                {
                    CPU_ID = row.Cells["CPU_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Cores = row.Cells["Cores"].Value.ToString(),
                    Threads = row.Cells["Threads"].Value.ToString(),
                    Cache = row.Cells["Cache"].Value.ToString(),
                    Clock = row.Cells["Clock"].Value.ToString(),
                    Architecture = row.Cells["Architecture"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editCPU editForm = new editCPU(cpu);
                editForm.Show();

                dataGridView1.DataSource = GetAllCPUs();
            }
        }

        private void cpuManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllCPUs();

        }
    }
}