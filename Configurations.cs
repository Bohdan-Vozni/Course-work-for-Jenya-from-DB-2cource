using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class Configurations : Form
    {
        public Configurations()
        {
            InitializeComponent();
        }

        private DataTable GetAllConfigurations()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from vw_PC_Details", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private void SetColumnHeaders()
        {
            dataGridView1.Columns["PC_ID"].Visible = false;
            dataGridView1.Columns["CPU_Title"].HeaderText = "Процесор";
            dataGridView1.Columns["GPU_Title"].HeaderText = "Відеокарта";
            dataGridView1.Columns["Motherboard_Title"].HeaderText = "Материнська плата";
            dataGridView1.Columns["RAM_Title"].HeaderText = "Оперативна пам'ять";
            dataGridView1.Columns["HDD_Title"].HeaderText = "Жорсткий диск";
            dataGridView1.Columns["SSD_Title"].HeaderText = "Швидкісний диск";
            dataGridView1.Columns["PowerSupply_Title"].HeaderText = "Блок живлення";
            dataGridView1.Columns["WaterCooling_Title"].HeaderText = "Водяне охолодження";
            dataGridView1.Columns["FanCooling_Title"].HeaderText = "Башенне охолодження";
            dataGridView1.Columns["Wifi_Title"].HeaderText = "Wifi-модуль";
            dataGridView1.Columns["Bluetooth_Title"].HeaderText = "Bluetooth-модуль";
            dataGridView1.Columns["Tower_Title"].HeaderText = "Корпус";
            dataGridView1.Columns["ExecutionDate"].HeaderText = "Дата створення";
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
            dataGridView1.Columns["FullName"].HeaderText = "Повне ім'я клієнта";
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Configurations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetAllConfigurations();
            SetColumnHeaders();
        }
    }
}
