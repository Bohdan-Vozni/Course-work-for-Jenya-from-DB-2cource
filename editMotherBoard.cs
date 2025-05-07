using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editMotherBoard : Form
    {
        private Motherboard motherboard;

        public editMotherBoard(Motherboard motherboard)
        {
            InitializeComponent();
            this.motherboard = motherboard;
            titleTB.Text = motherboard.Title;
            socketTB.Text = motherboard.Socket;
            typeSizeTB.Text = motherboard.TypeSize;
            chipsetTB.Text = motherboard.Chipset;
            costTB.Text = motherboard.Cost.ToString();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
                socketTB.Text.Trim() == "" ||
                typeSizeTB.Text.Trim() == "" ||
                chipsetTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdateMotherboard", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Motherboard_ID", motherboard.Motherboard_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Socket", socketTB.Text);
                    command.Parameters.AddWithValue("@TypeSize", typeSizeTB.Text);
                    command.Parameters.AddWithValue("@Chipset", chipsetTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Материнську плату успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при оновленні Материнської плати");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні Материнської плати: {ex.Message}");
            }
        }


        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю материнську плату?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteMotherboard", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Motherboard_ID", motherboard.Motherboard_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Материнську плату успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні материнської плати: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
