using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addRam : Form
    {
        public addRam()
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
                string memoryType = memoryTypeTB.Text.Trim();
                string memoryQuantity = memQuantTB.Text.Trim();
                string radiatorType = radiatorTypeTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" ||
                    memoryType == "" ||
                    memoryQuantity == "" ||
                    cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі обов’язкові поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("AddRAM", connection); // Название процедуры должно совпадать
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@RAM_ID", Guid.NewGuid().ToString());
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@MemoryType", memoryType);
                    command.Parameters.AddWithValue("@MemoryQuantity", memoryQuantity);
                    command.Parameters.AddWithValue("@RadiatorType", radiatorType);
                    command.Parameters.AddWithValue("@Cost", float.Parse(cost));

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Оперативну пам'ять успішно додано");
                emptyTB();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка при додаванні оперативної пам'яті:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка:\n{ex.Message}");
            }
        }


        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}