using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class hddManageCtrl : UserControl
    {
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

                dataGridView1.DataSource = GetAllHDDs();
            }
        }

        private void hddManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllHDDs();

        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllHDDs();
        }
    }
}