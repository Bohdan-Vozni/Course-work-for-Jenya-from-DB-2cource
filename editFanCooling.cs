using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editFanCooling : Form
    {

        private FanCooling fanCooling;

        public editFanCooling(FanCooling fanCooling)
        {
            InitializeComponent();

            this.fanCooling = fanCooling;

            titleTB.Text = fanCooling.Title;
            typeSizeTB.Text = fanCooling.TypeSize;
            heatRemovalTB.Text = fanCooling.HeatRemoval;
            costTB.Text = fanCooling.Cost.ToString();

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити це охолодження?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteFanCooling", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@FanCooling_ID", fanCooling.FanCooling_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Башенне охолодження успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }

        }


        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
                typeSizeTB.Text.Trim() == "" ||
                heatRemovalTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdateFanCooling", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FanCooling_ID", fanCooling.FanCooling_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@TypeSize", typeSizeTB.Text);
                    command.Parameters.AddWithValue("@HeatRemoval", heatRemovalTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Башенне охолодження успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Помилка SQL при оновленні: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Неочікувана помилка: {ex.Message}");
            }
        }

    }

}
