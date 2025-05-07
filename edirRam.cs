using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class edirRam : Form
    {
        private RAM ram;

        public edirRam(RAM ram)
        {
            InitializeComponent();
            this.ram = ram;

            titleTB.Text = ram.Title;
            memoryTypeTB.Text = ram.MemoryType;
            memQuantTB.Text = ram.MemoryQuantity;
            radiatorTypeTB.Text = ram.RadiatorType;
            costTB.Text = ram.Cost.ToString();
        }
        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю оперативну пам'ять?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteRAM", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RAM_ID", ram.RAM_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Оперативну пам'ять успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL помилка при видаленні оперативної пам'яті:\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка:\n{ex.Message}");
                }
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            if (titleTB.Text.Trim() == "" ||
                memoryTypeTB.Text.Trim() == "" ||
                memQuantTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdateRAM", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@RAM_ID", ram.RAM_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@MemoryType", memoryTypeTB.Text);
                    command.Parameters.AddWithValue("@MemoryQuantity", memQuantTB.Text);
                    command.Parameters.AddWithValue("@RadiatorType", radiatorTypeTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Оперативну пам'ять успішно оновлено!");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка при оновленні оперативної пам'яті:\n{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні оперативної пам'яті:\n{ex.Message}");
            }
        }
    }
}
