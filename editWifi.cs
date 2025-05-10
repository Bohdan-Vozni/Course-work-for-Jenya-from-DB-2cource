using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editWifi : Form
    {

        private Wifi wifi;

        public editWifi(Wifi wifi)
        {
            InitializeComponent();

            this.wifi = wifi;

            titleTB.Text = wifi.Title;
            generationTB.Text = wifi.Generation;
            costTB.Text = wifi.Cost.ToString();

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
                generationTB.Text.Trim() == "" ||
                costTB.Text.Trim() == "")
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdateWifi", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Wifi_ID", wifi.Wifi_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Generation", generationTB.Text);
                    command.Parameters.AddWithValue("@Cost", costTB.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Wi-Fi адаптер успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка SQL при оновленні Wi-Fi адаптера: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка: {ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей Wi-Fi адаптер?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteWifi", connection); // имя процедуры
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Wifi_ID", wifi.Wifi_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Wi-Fi адаптер успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні Wi-Fi адаптера: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }
    }
}
