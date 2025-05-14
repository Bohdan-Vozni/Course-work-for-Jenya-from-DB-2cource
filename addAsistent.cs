using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addAsistent : Form
    {
        public addAsistent()
        {
            InitializeComponent();
        }

        private void addAsistent_Load(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                string name = name_textBox.Text;
                string phone = phone_textBox.Text;



                if (name == "" || phone == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddSpecialist", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    string id = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@Specialist_ID", id);
                    command.Parameters.AddWithValue("@SpecialistName", name);
                    command.Parameters.AddWithValue("@Phone", phone);
                    


                    command.ExecuteNonQuery();
                    MessageBox.Show("Спеціаліста успішно додано!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні клієнта");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неочікувана помилка");
            }
        }
    }
}
