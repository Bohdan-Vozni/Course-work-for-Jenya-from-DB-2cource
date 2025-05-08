using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addBluetooth : Form
    {
        public addBluetooth()
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
                string title = titleTB.Text.Trim();
                string generation = generationTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" || generation == "" || cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddBluetooth", connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    string idUnic = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@Bluetooth_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Generation", generation);
                    command.Parameters.AddWithValue("@Cost", cost);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Bluetooth-адаптер успішно додано!");

                    emptyTB();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні Bluetooth-адаптера");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неочікувана помилка");
            }
        }
        private void addBluetooth_Load(object sender, EventArgs e)
        {

        }
    }
}
