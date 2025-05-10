using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editPowerSupply : Form
    {
        private PowerSupply powerSupply;


        public editPowerSupply(PowerSupply powerSupply)
        {
            InitializeComponent();

            this.powerSupply = powerSupply;

            titleTB.Text = powerSupply.Title;
            strengthTB.Text = powerSupply.Strength;
            sertificateTB.Text = powerSupply.Sertificate;
            costTB.Text = powerSupply.Cost.ToString();
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
                strengthTB.Text.Trim() == "" ||
                sertificateTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdatePowerSupply", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PowerSupply_ID", powerSupply.PowerSupply_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Strength", strengthTB.Text);
                    command.Parameters.AddWithValue("@Sertificate", sertificateTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Блок живлення успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка при оновленні блоку живлення:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні:\n{ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей блок живлення?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeletePowerSupply", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@PowerSupply_ID", powerSupply.PowerSupply_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Блок живлення успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL помилка при видаленні:\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка:\n{ex.Message}");
                }
            }
        }
    }
}
