using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addPurchase : Form
    {
        public string idPc;
        public addPurchase(string idPC)
        {
            InitializeComponent();
            this.idPc = idPC;
        }

        private void addPurchase_Load(object sender, EventArgs e)
        {
            ShowDataForClientDropDownList();
            ShowDataForSpecialistDropDownList();
        }

        List<ClientForCombox> allPatient;
        private void ShowDataForClientDropDownList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    SqlCommand command = new SqlCommand("GetDataClientForPurchase", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    allPatient = new List<ClientForCombox>();


                    while (reader.Read())
                    {
                        allPatient.Add(new ClientForCombox
                        {
                            idClient = reader.GetString(reader.GetOrdinal("Client_ID")),
                            nameClient = reader.GetString(reader.GetOrdinal("ClientName"))
                        });
                    }
                    client_comboBox.DataSource = allPatient;
                    client_comboBox.ValueMember = "idClient";
                    client_comboBox.DisplayMember = "nameClient";
                    client_comboBox.DropDownStyle = ComboBoxStyle.DropDown;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}");
            }

        }

        List<SpecialistForCombox> allSpecialist;
        private void ShowDataForSpecialistDropDownList()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    SqlCommand command = new SqlCommand("GetDataSpecialistForPurchase", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    allSpecialist = new List<SpecialistForCombox>();


                    while (reader.Read())
                    {
                        allSpecialist.Add(new SpecialistForCombox
                        {
                            idSpecialist = reader.GetString(reader.GetOrdinal("Specialist_ID")),
                            nameSpecialist = reader.GetString(reader.GetOrdinal("SpecialistName"))
                        });
                    }
                    sdpecialist_comboBox.DataSource = allSpecialist;
                    sdpecialist_comboBox.ValueMember = "idSpecialist";
                    sdpecialist_comboBox.DisplayMember = "nameSpecialist";
                    sdpecialist_comboBox.DropDownStyle = ComboBoxStyle.DropDown;

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка при завантаженні даних: {ex.Message}");
            }

        }

        private void addPurchase_button_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {


                SqlCommand command = new SqlCommand("AddPurchase", connection);
                command.CommandType = CommandType.StoredProcedure;


                var idUnic = Guid.NewGuid().ToString();
                var dateCreate = DateTime.Now;
                var selectedSpecialist = (SpecialistForCombox)sdpecialist_comboBox.SelectedItem;
                var selectedClientlist = (ClientForCombox)client_comboBox.SelectedItem;
                //додати параметри
                command.Parameters.AddWithValue("@Purchase_ID", idUnic);
                command.Parameters.AddWithValue("@DateCreate", dateCreate.Date);
                command.Parameters.AddWithValue("@Specialist_ID", selectedSpecialist.idSpecialist);
                command.Parameters.AddWithValue("@Client_ID", selectedClientlist.idClient);
                command.Parameters.AddWithValue("@PC_ID", idPc);

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Змовлення успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        MessageBox.Show(error.Message, "Помилка додавання замовлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Інші неочікувані помилки
                    MessageBox.Show(ex.Message, "Неочікувана помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
