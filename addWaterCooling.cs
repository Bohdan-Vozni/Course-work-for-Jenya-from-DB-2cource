using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addWaterCooling : Form
    {
        public addWaterCooling()
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

        private void closeBTN_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTB.Text.Trim();
                string typeSize = typeSizeTB.Text.Trim();
                string heatRemoval = heatRemovalTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" || heatRemoval == "" || typeSize == "" || cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddWaterCooling", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    string idUnic = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@WaterCooling_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@TypeSize", typeSize);
                    command.Parameters.AddWithValue("@HeatRemoval", heatRemoval);
                    command.Parameters.AddWithValue("@Cost", cost);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Водянне охолодження успішно додано!");

                    emptyTB();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні водянне охолодження");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неочікувана помилка");
            }
        }
    }
}
