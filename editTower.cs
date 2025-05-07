using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editTower : Form
    {
        private Tower tower;

        public editTower(Tower tower)
        {
            InitializeComponent();
            this.tower = tower;
            titleTB.Text = tower.Title;
            typeSizeTB.Text = tower.TypeSize;
            fanIncludedTB.Text = tower.FanIncluded;
            fanTypeTB.Text = tower.FanType;
            costTB.Text = tower.Cost.ToString();

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
            typeSizeTB.Text.Trim() == "" ||
            fanIncludedTB.Text.Trim() == "" ||
            fanTypeTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdateTower", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Tower_ID", tower.Tower_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@TypeSize", typeSizeTB.Text);
                    command.Parameters.AddWithValue("@FanIncluded", fanIncludedTB.Text);
                    command.Parameters.AddWithValue("@FanType", fanTypeTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Корпус успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні Корпус");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні корпуса: {ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей корпус?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteTower", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Tower_ID", tower.Tower_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Корпус успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні корпуса: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }
    }
}
