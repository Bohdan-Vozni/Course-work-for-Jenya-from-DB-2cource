using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addSsd : Form
    {
        public addSsd()
        {
            InitializeComponent();
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

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTB.Text.Trim();
                string memoryQuantity = memoryQuantityTB.Text.Trim();
                string writeSpeed = writeSpeedTB.Text.Trim();
                string readingSpeed = readingSpeedTB.Text.Trim();
                string radiatorType = radiatorTypeTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" ||
                    memoryQuantity == "" ||
                    writeSpeed == "" ||
                    readingSpeed == "" ||
                    cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі обов’язкові поля.");
                    return;
                }


                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("AddSSD", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SSD_ID", Guid.NewGuid().ToString());
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@MemoryQuantity", memoryQuantity);
                    command.Parameters.AddWithValue("@ReadingSpeed", readingSpeed);
                    command.Parameters.AddWithValue("@WriteSpeed", writeSpeed);
                    command.Parameters.AddWithValue("@RadiatorType", radiatorType);
                    command.Parameters.AddWithValue("@Cost", cost);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Швидкісний накопичувач успішно додано");
                emptyTB();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка при додаванні швидкісного накопичувача:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка:\n{ex.Message}");
            }
        }
    }

}