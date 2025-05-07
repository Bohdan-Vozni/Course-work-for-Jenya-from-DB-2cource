using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ssdManageCtrl : UserControl
    {
        public ssdManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddSsdBtn_Click(object sender, System.EventArgs e)
        {
            addSsd addSsd = new addSsd();
            addSsd.Show();
        }

        private DataTable GetAllSsds()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllSsds", connection); // Имя хранимой процедуры
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

                dataGridView1.DataSource = GetAllSsds();
            }
        }

        private void ssdManageCtrl_Load(object sender, System.EventArgs e)
        {
            dataGridView1.DataSource = GetAllSsds();
        }
    }
}