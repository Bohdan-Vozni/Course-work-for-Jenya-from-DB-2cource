using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class gpuManageCtrl : UserControl
    {
        private DataTable fullGpuTable;

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

                fullGpuTable = GetAllGPUs();
                ApplySearchFilter();
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["GPU_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["Cores"].HeaderText = "Ядра";
            dataGridView1.Columns["Threads"].HeaderText = "Потоки";
            dataGridView1.Columns["VRAMType"].HeaderText = "Тип відеопам'яті";
            dataGridView1.Columns["VRAMQuantity"].HeaderText = "Кількість відеопам'яті";
            dataGridView1.Columns["Cache"].HeaderText = "Кеш";
            dataGridView1.Columns["Clock"].HeaderText = "Таймінги";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void gpuManageCtrl_Load(object sender, EventArgs e)
        {
            fullGpuTable = GetAllGPUs();
            ApplySearchFilter();
        }

        private void openAddGpuBtn_Click(object sender, EventArgs e)
        {
            addGpu addGpu = new addGpu();
            addGpu.Show();

            addGpu.FormClosed += (s, args) =>
            {
                fullGpuTable = GetAllGPUs();
                ApplySearchFilter();
            };
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullGpuTable = GetAllGPUs();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            if (fullGpuTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullGpuTable);

            if (!string.IsNullOrEmpty(filterText))
            {
                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
