using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editCPU : Form
    {

        CPU cpu;
        string cpuId;
        public editCPU(CPU cpu)
        {
            InitializeComponent();

            this.cpu = cpu;
            this.cpuId = this.cpu.CPU_ID;
            titleTB.Text = cpu.Title;
            coresTB.Text = cpu.Cores;
            threadsTB.Text = cpu.Threads;
            cacheTB.Text = cpu.Cache;
            clockTB.Text = cpu.Clock;
            architectureTB.Text = cpu.Architecture;
            costTB.Text = cpu.Cost.ToString();

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (titleTB.Text.Trim() == "" ||
                    coresTB.Text.Trim() == "" ||
                    threadsTB.Text.Trim() == "" ||
                    cacheTB.Text.Trim() == "" ||
                    clockTB.Text.Trim() == "" ||
                    architectureTB.Text.Trim() == "" ||
                    costTB.Text.Trim() == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UpdateCPU", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CPU_ID", cpuId);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Cores", coresTB.Text);
                    command.Parameters.AddWithValue("@Threads", threadsTB.Text);
                    command.Parameters.AddWithValue("@Cache", cacheTB.Text);
                    command.Parameters.AddWithValue("@Clock", clockTB.Text);
                    command.Parameters.AddWithValue("@Architecture", architectureTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("CPU успішно оновлено!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні CPU: {ex.Message}");
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("Ви дійсно хочете видалити цей CPU?", "Підтвердження", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("DeleteCPU", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CPU_ID", cpuId);

                    command.ExecuteNonQuery();
                    MessageBox.Show("CPU успішно видалено!");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при видаленні CPU: {ex.Message}");
            }
        }

    }
}
