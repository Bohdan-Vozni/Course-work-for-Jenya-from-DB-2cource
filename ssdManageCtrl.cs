using Microsoft.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ssdManageCtrl : UserControl
    {
        private DataTable fullSsdTable;

        public ssdManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddSsdBtn_Click(object sender, System.EventArgs e)
        {
            addSsd addSsd = new addSsd();
            addSsd.Show();

            addSsd.FormClosed += (s, args) =>
            {
                fullSsdTable = GetAllSsds();
                ApplySearchFilter();
            };
        }

        private DataTable GetAllSsds()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllSSD", connection);
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
                SSD ssd = new SSD
                {
                    SSD_ID = row.Cells["SSD_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    MemoryQuantity = row.Cells["MemoryQuantity"].Value.ToString(),
                    ReadingSpeed = row.Cells["ReadingSpeed"].Value.ToString(),
                    WriteSpeed = row.Cells["WriteSpeed"].Value.ToString(),
                    RadiatorType = row.Cells["RadiatorType"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editSsd editForm = new editSsd(ssd);
                editForm.Show();

                editForm.FormClosed += (s, args) =>
                 {
                     fullSsdTable = GetAllSsds();
                     ApplySearchFilter();
                 };
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["SSD_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["MemoryQuantity"].HeaderText = "Кількість памʼяті";
            dataGridView1.Columns["ReadingSpeed"].HeaderText = "Швидкість зчитування";
            dataGridView1.Columns["WriteSpeed"].HeaderText = "Швидкість запису";
            dataGridView1.Columns["RadiatorType"].HeaderText = "Тип радіатора";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void ssdManageCtrl_Load(object sender, System.EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;


            fullSsdTable = GetAllSsds();
            ApplySearchFilter();
        }

        private void reloadBTN_Click(object sender, System.EventArgs e)
        {
            fullSsdTable = GetAllSsds();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, System.EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullSsdTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullSsdTable);

            if (!string.IsNullOrEmpty(filterText))
            {

                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
