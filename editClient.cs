using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editClient : Form
    {

        private Client client;

        public editClient(Client client)
        {
            InitializeComponent();

            this.client = client;

            clientNameTB.Text = client.ClientName;
            phoneTB.Text = client.Phone;
            homeAddressTB.Text = client.HomeAddress;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (clientNameTB.Text.Trim() == "" ||
                phoneTB.Text.Trim() == "" ||
                homeAddressTB.Text.Trim() == "")
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdateClient", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Client_ID", client.Client_ID);
                    command.Parameters.AddWithValue("@ClientName", clientNameTB.Text);
                    command.Parameters.AddWithValue("@Phone", phoneTB.Text);
                    command.Parameters.AddWithValue("@HomeAddress", homeAddressTB.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Клієнта успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка SQL при оновленні: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка: {ex.Message}");
            }
        }
        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цього клієнта?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteClient", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Client_ID", client.Client_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Клієнта успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }
    }
}
