using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addTower : Form
    {
        public addTower()
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
                string typeSize = typeSizeTB.Text.Trim();
                string fanType = fanTypeTB.Text.Trim();
                string fanIncluded = fanIncludedTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" ||
                    typeSize == "" ||
                    fanIncluded == "" ||
                    fanType == "" ||
                    cost == ""
                    )
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }



                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddTower", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    string idUnic = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@Tower_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@TypeSize", typeSize);
                    command.Parameters.AddWithValue("@FanType", fanType);
                    command.Parameters.AddWithValue("@FanIncluded", fanIncluded);
                    command.Parameters.AddWithValue("@Cost", cost);
                    command.ExecuteNonQuery();


                }

                MessageBox.Show("Корпус успішно додаванo ");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні Корпус");
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
