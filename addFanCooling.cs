using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addFanCooling : Form
    {
        public addFanCooling()
        {
            InitializeComponent();
        }

        private void addFanCooling_Load(object sender, EventArgs e)
        {

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
                    SqlCommand command = new SqlCommand("AddFanCooling", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    string idUnic = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@FanCooling_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@TypeSize", typeSize);
                    command.Parameters.AddWithValue("@HeatRemoval", heatRemoval);
                    command.Parameters.AddWithValue("@Cost", cost);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Башенне охолодження успішно додано!");

                    emptyTB();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні башенного охолодження");
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
