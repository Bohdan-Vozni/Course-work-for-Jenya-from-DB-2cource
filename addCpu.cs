using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addCpu : Form
    {
        public addCpu()
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

                if (titleTB.Text.Trim() == "" ||
                    coresTB.Text.Trim() == "" ||
                    threadsTB.Text.Trim() == "" ||
                    cacheTB.Text.Trim() == "" ||
                    clockTB.Text.Trim() == "" ||
                    architectureTB.Text.Trim() == "" ||
                    costTB.Text.Trim() == ""
                    )
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("AddCPU", connection);

                    string cpuId = Guid.NewGuid().ToString();

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CPU_ID", cpuId);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Cores", coresTB.Text);
                    command.Parameters.AddWithValue("@Threads", threadsTB.Text);
                    command.Parameters.AddWithValue("@Cache", cacheTB.Text);
                    command.Parameters.AddWithValue("@Clock", clockTB.Text);
                    command.Parameters.AddWithValue("@Architecture", architectureTB.Text);
                    command.Parameters.AddWithValue("@Cost", costTB.Text);

                    command.ExecuteNonQuery();

                }

                MessageBox.Show("CPU успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                emptyTB();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні CPU:\n{ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}