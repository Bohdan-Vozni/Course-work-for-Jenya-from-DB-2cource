using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addClient : Form
    {
        public addClient()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void emptyTB()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string name = clientNameTB.Text.Trim();
                string phone = phoneTB.Text.Trim();
                string address = homeAddressTB.Text.Trim();

                if (name == "" || phone == "" || address == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddClient", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    string id = Guid.NewGuid().ToString();
                    command.Parameters.AddWithValue("@Client_ID", id);
                    command.Parameters.AddWithValue("@ClientName", name);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@HomeAddress", address);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Клієнта успішно додано!");

                    emptyTB();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні клієнта");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неочікувана помилка");
            }
        }
    }
}
