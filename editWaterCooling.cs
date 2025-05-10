using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editWaterCooling : Form
    {

        WaterCooling waterCooling;
        public editWaterCooling(WaterCooling waterCooling)
        {
            InitializeComponent();
            this.waterCooling = waterCooling;

            titleTB.Text = waterCooling.Title;
            typeSizeTB.Text = waterCooling.TypeSize;
            heatRemovalTB.Text = waterCooling.HeatRemoval;
            costTB.Text = waterCooling.Cost.ToString();
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
                    SqlCommand command = new SqlCommand("UpdateWaterCooling", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@WaterCooling_ID", waterCooling.WaterCooling_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@TypeSize", typeSizeTB.Text);
                    command.Parameters.AddWithValue("@HeatRemoval", heatRemovalTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Водяне охолодження успішно оновлено!");
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
                        SqlCommand command = new SqlCommand("DeleteWaterCooling", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@WaterCooling_ID", waterCooling.WaterCooling_ID);

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

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
