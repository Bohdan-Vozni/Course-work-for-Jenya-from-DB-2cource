using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editSsd : Form
    {
        private SSD ssd;

        public editSsd(SSD ssd)
        {
            InitializeComponent();
            this.ssd = ssd;

            titleTB.Text = ssd.Title;
            memoryQuantityTB.Text = ssd.MemoryQuantity;
            writeSpeedTB.Text = ssd.WriteSpeed;
            readingSpeedTB.Text = ssd.ReadingSpeed;
            radiatorTypeTB.Text = ssd.RadiatorType;
            costTB.Text = ssd.Cost.ToString();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
                memoryQuantityTB.Text.Trim() == "" ||
                writeSpeedTB.Text.Trim() == "" ||
                readingSpeedTB.Text.Trim() == "" ||
                costTB.Text.Trim() == "")
            {
                MessageBox.Show("Будь ласка, заповніть усі обов’язкові поля.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UpdateSSD", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@SSD_ID", ssd.SSD_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@MemoryQuantity", memoryQuantityTB.Text);
                    command.Parameters.AddWithValue("@WriteSpeed", writeSpeedTB.Text);
                    command.Parameters.AddWithValue("@ReadingSpeed", readingSpeedTB.Text);
                    command.Parameters.AddWithValue("@RadiatorType", radiatorTypeTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Швидкісний накопичувач успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка при оновленні швидкісного накрпичувача:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні швидкісного накрпичувача:\n{ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей SSD?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteSSD", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@SSD_ID", ssd.SSD_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Швидкісний накопичувач успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL помилка при видаленні швидкісного накрпичувача:\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка:\n{ex.Message}");
                }
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
