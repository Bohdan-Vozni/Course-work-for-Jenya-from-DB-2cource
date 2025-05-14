using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class AllClientInfo : Form
    {
        public AllClientInfo()
        {
            InitializeComponent();
        }
        private void LoadClientsToComboBox()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("GetDataClientForComboBox", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var specialist = new ClientForCombox
                    {
                        idClient = reader["Client_ID"].ToString(),
                        nameClient = reader["ClientName"].ToString()
                    };
                    clients.Items.Add(specialist);
                }

                reader.Close();
            }

            clients.DisplayMember = "nameClients";
            clients.ValueMember = "idClients";
        }

        private DataTable GetAllSpecialistsSales(string ClientId)
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM vw_FullClientInfo WHERE Client_ID = @id", connection);
                command.Parameters.AddWithValue("@id", ClientId);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }


        private void SetColumnHeaders()
        {
            dataGridView1.Columns["PC_ID"].Visible = false;
            dataGridView1.Columns["Client_ID"].Visible = false;
            dataGridView1.Columns["Specialist_ID"].Visible = false;
            dataGridView1.Columns["Purchase_ID"].Visible = false;
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
            dataGridView1.Columns["Cost"].HeaderText = "Ціна";
            dataGridView1.Columns["DateCreate"].HeaderText = "Дата створення";
            dataGridView1.Columns["HomeAddress"].HeaderText = "Домашня адреса клієнта";
            dataGridView1.Columns["ClientName"].HeaderText = "Повне ім'я кліента";
            dataGridView1.Columns["ClientPhone"].HeaderText = "Номер клієнта";
            dataGridView1.Columns["SpecialistPhone"].HeaderText = "Номер спеціаліста";
            dataGridView1.Columns["SpecialistName"].HeaderText = "Повне ім'я спеціаліста";
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clients.SelectedItem is ClientForCombox selectedClient)
            {
                dataGridView1.DataSource = GetAllSpecialistsSales(selectedClient.idClient);
                SetColumnHeaders();
            }
        }

        private void AllClientInfo_Load(object sender, EventArgs e)
        {
            LoadClientsToComboBox();
        }
    }
}
