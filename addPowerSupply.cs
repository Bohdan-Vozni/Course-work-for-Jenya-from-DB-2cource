using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addPowerSupply : Form
    {
        public addPowerSupply()
        {
            InitializeComponent();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
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
                string title = titleTB.Text.Trim();
                string strength = strengthTB.Text.Trim();
                string sertificate = sertificateTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" || strength == "" || cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі обов’язкові поля (Назва, Потужність, Ціна).");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("AddPowerSupply", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PowerSupply_ID", Guid.NewGuid().ToString());
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Strength", strength);
                    command.Parameters.AddWithValue("@Sertificate", sertificate);
                    command.Parameters.AddWithValue("@Cost", float.Parse(cost));

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Блок живлення успішно додано!");
                emptyTB();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка при додаванні блоку живлення:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка:\n{ex.Message}");
            }
        }
    }
}
