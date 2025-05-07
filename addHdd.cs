using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addHdd : Form
    {
        public addHdd()
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

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTB.Text.Trim();
                string memoryQuantity = memoryQuantityTB.Text.Trim();
                string readingSpeed = readingSpeedTB.Text.Trim();
                string writeSpeed = writeSpeedTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" ||
                    memoryQuantity == "" ||
                    readingSpeed == "" ||
                    writeSpeed == "" ||
                    cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }



                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddHDD", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    string idUnic = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@HDD_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@MemoryQuantity", memoryQuantity);
                    command.Parameters.AddWithValue("@ReadingSpeed", readingSpeed);
                    command.Parameters.AddWithValue("@WriteSpeed", writeSpeed);
                    command.Parameters.AddWithValue("@Cost", cost);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Жерсткий накопичувач успішно додано!");

                    emptyTB();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні жерсткого накопичувача");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неочікувана помилка");
            }
        }


        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}