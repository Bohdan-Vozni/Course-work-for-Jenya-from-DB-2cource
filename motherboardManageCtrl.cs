using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class motherboardManageCtrl : UserControl
    {
        public motherboardManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addMotherboard addMotherboard = new addMotherboard();
            addMotherboard.Show();
        }

        private DataTable GetAllMotherboards()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetAllMotherboard", connection);
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
                Motherboard motherboard = new Motherboard
                {
                    Motherboard_ID = row.Cells["Motherboard_ID"].Value.ToString(),
                    Title = row.Cells["Title"].Value.ToString(),
                    Socket = row.Cells["Socket"].Value.ToString(),
                    TypeSize = row.Cells["TypeSize"].Value.ToString(),
                    Chipset = row.Cells["Chipset"].Value.ToString(),
                    Cost = float.Parse(row.Cells["Cost"].Value.ToString())
                };

                editMotherBoard editForm = new editMotherBoard(motherboard);
                editForm.Show();

                dataGridView1.DataSource = GetAllMotherboards();
            }
        }

        private void motherboardManageCtrl_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllMotherboards();

        }
    }
}