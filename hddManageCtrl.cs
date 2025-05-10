using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class hddManageCtrl : UserControl
    {
        private DataTable fullHddTable;

        public hddManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddHddBtn_Click(object sender, EventArgs e)
        {
            addHdd addHdd = new addHdd();
            addHdd.Show();
        }

        private DataTable GetAllHDDs()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllHDD", connection);
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
                HDD hdd = new HDD
                {
                    HDD_ID = row.Cells["HDD_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    MemoryQuantity = row.Cells["MemoryQuantity"].Value.ToString(),
                    ReadingSpeed = row.Cells["ReadingSpeed"].Value.ToString(),
                    WriteSpeed = row.Cells["WriteSpeed"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editHdd editForm = new editHdd(hdd);
                editForm.Show();

                fullHddTable = GetAllHDDs();
                ApplySearchFilter();
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["HDD_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["MemoryQuantity"].HeaderText = "Кількість пам'яті";
            dataGridView1.Columns["ReadingSpeed"].HeaderText = "Швидкість зчитування";
            dataGridView1.Columns["WriteSpeed"].HeaderText = "Швидкість запису";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void hddManageCtrl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullHddTable = GetAllHDDs();
            ApplySearchFilter();
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullHddTable = GetAllHDDs();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullHddTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullHddTable);

            if (!string.IsNullOrEmpty(filterText))
            {
                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
