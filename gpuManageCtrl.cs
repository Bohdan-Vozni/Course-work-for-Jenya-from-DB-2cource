using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class gpuManageCtrl : UserControl
    {
        public gpuManageCtrl()
        {
            InitializeComponent();
        }


        private DataTable GetAllGPUs()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllGPU", connection);
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

                GPU GPU = new GPU
                {
                    GPU_ID = row.Cells["GPU_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Cores = row.Cells["Cores"].Value.ToString(),
                    Threads = row.Cells["Threads"].Value.ToString(),
                    VRAMType = row.Cells["VRAMType"].Value.ToString(),
                    VRAMQuantity = row.Cells["VRAMQuantity"].Value.ToString(),
                    Cache = row.Cells["Cache"].Value.ToString(),
                    Clock = row.Cells["Clock"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editGpu editGpuForm = new editGpu(GPU);
                editGpuForm.Show();

                dataGridView1.DataSource = GetAllGPUs();
            }
        }

        private void gpuManageCtrl_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = GetAllGPUs();
        }

        private void openAddGpuBtn_Click(object sender, System.EventArgs e)
        {
            addGpu addGpu = new addGpu();
            addGpu.Show();
        }
    }
}
