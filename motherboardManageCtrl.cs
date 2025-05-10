using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class motherboardManageCtrl : UserControl
    {
        private DataTable fullMotherboardTable;

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

                fullMotherboardTable = GetAllMotherboards();
                ApplySearchFilter();
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["Motherboard_ID"].Visible = false;
            dataGridView1.Columns["Title"].HeaderText = "Назва";
            dataGridView1.Columns["Socket"].HeaderText = "Сокет";
            dataGridView1.Columns["TypeSize"].HeaderText = "Розмір";
            dataGridView1.Columns["Chipset"].HeaderText = "Чіпсет";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
        }

        private void motherboardManageCtrl_Load(object sender, EventArgs e)
        {
            fullMotherboardTable = GetAllMotherboards();
            ApplySearchFilter();
        }

        private void reloadBTN_Click(object sender, EventArgs e)
        {
            fullMotherboardTable = GetAllMotherboards();
            ApplySearchFilter();
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }


        private void ApplySearchFilter()
        {
            if (fullMotherboardTable == null) return;

            string filterText = searchTB.Text.Trim().Replace("'", "''");
            DataView view = new DataView(fullMotherboardTable);

            if (!string.IsNullOrEmpty(filterText))
            {
                view.RowFilter = $"Title LIKE '%{filterText}%'";
            }

            dataGridView1.DataSource = view;
            SetColumnHeaders();
        }
    }
}
