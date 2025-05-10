using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class cpuManageCtrl : UserControl
    {
        private DataTable fullCPUTable;

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

            addingCpu.FormClosed += (s, args) =>
            {
                fullCPUTable = GetAllCPUs();
                ApplySearchFilter();
            };
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

                editForm.FormClosed += (s, args) =>
                {
                    fullCPUTable = GetAllCPUs();
                    ApplySearchFilter();
                };
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["CPU_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["Cores"].HeaderText = "Ядра";
            dataGridView1.Columns["Threads"].HeaderText = "Потоки";
            dataGridView1.Columns["Cache"].HeaderText = "Кеш";
            dataGridView1.Columns["Clock"].HeaderText = "Таймінги";
            dataGridView1.Columns["Architecture"].HeaderText = "Архітектура";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void cpuManageCtrl_Load(object sender, EventArgs e)
        {
            fullCPUTable = GetAllCPUs();
            ApplySearchFilter();
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullCPUTable = GetAllCPUs();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void ApplySearchFilter()
        {
            if (fullCPUTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullCPUTable);

            if (!string.IsNullOrEmpty(filterText))
            {
                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }


    }
}
