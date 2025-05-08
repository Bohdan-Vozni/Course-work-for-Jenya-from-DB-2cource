using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editBluetooth : Form
    {

        private Bluetooth bluetooth;

        public editBluetooth(Bluetooth bluetooth)
        {
            InitializeComponent();

            this.bluetooth = bluetooth;

            titleTB.Text = bluetooth.Title;
            generationTB.Text = bluetooth.Generation;
            costTB.Text = bluetooth.Cost.ToString();
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
                    SqlCommand command = new SqlCommand("UpdateBluetooth", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Bluetooth_ID", bluetooth.Bluetooth_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Version", generationTB.Text);
                    command.Parameters.AddWithValue("@Cost", costTB.Text);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Bluetooth-адаптер успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка SQL при оновленні Bluetooth-адаптера: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка: {ex.Message}");
            }
        }


        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей Bluetooth-адаптер?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteBluetooth", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Bluetooth_ID", bluetooth.Bluetooth_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Bluetooth-адаптер успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні Bluetooth-адаптера: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }
    }
}
