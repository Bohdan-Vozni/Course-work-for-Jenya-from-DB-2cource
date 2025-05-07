using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editHdd : Form
    {

        private HDD hdd;
        public editHdd(HDD hdd)
        {
            InitializeComponent();
            this.hdd = hdd;
            titleTB.Text = hdd.Title;
            memoryQuantityTB.Text = hdd.MemoryQuantity;
            readingSpeedTB.Text = hdd.ReadingSpeed;
            writeSpeedTB.Text = hdd.WriteSpeed;
            costTB.Text = hdd.Cost.ToString();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
              memoryQuantityTB.Text.Trim() == "" ||
              readingSpeedTB.Text.Trim() == "" ||
              writeSpeedTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdateHDD", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@HDD_ID", hdd.HDD_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@MemoryQuantity", memoryQuantityTB.Text);
                    command.Parameters.AddWithValue("@ReadingSpeed", readingSpeedTB.Text);
                    command.Parameters.AddWithValue("@WriteSpeed", writeSpeedTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Жорсткий диск успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при оновленні Жорсткого диска");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні Жорсткого диска: {ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей жорсткий диск?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteHDD", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@HDD_ID", hdd.HDD_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Жорсткий диск успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні жорсткого диска: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }
    }
}
