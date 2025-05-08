using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class editGpu : Form
    {
        private GPU gpu;


        public editGpu(GPU gpu)
        {
            InitializeComponent();
            this.gpu = gpu;
            titleTB.Text = gpu.Title;
            coresTB.Text = gpu.Cores;
            threadsTB.Text = gpu.Threads;
            vramTypeTB.Text = gpu.VRAMType;
            vramQuantTB.Text = gpu.VRAMQuantity;
            cacheTB.Text = gpu.Cache;
            clockTB.Text = gpu.Clock;
            costTB.Text = gpu.Cost.ToString();
        }



        private void editGpu_Load(object sender, EventArgs e)
        {

        }

        private void editBTN_Click(object sender, EventArgs e)
        {

            if (titleTB.Text.Trim() == "" ||
                coresTB.Text.Trim() == "" ||
                threadsTB.Text.Trim() == "" ||
                cacheTB.Text.Trim() == "" ||
                clockTB.Text.Trim() == "" ||
                vramTypeTB.Text.Trim() == "" ||
                vramQuantTB.Text.Trim() == "" ||
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
                    SqlCommand command = new SqlCommand("UpdateGPU", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Передача параметров для редактирования
                    command.Parameters.AddWithValue("@GPU_ID", gpu.GPU_ID);
                    command.Parameters.AddWithValue("@Title", titleTB.Text);
                    command.Parameters.AddWithValue("@Cores", coresTB.Text);
                    command.Parameters.AddWithValue("@Threads", threadsTB.Text);
                    command.Parameters.AddWithValue("@Cache", cacheTB.Text);
                    command.Parameters.AddWithValue("@Clock", clockTB.Text);
                    command.Parameters.AddWithValue("@VRAMType", vramTypeTB.Text);
                    command.Parameters.AddWithValue("@VRAMQuantity", vramQuantTB.Text);
                    command.Parameters.AddWithValue("@Cost", float.Parse(costTB.Text));

                    command.ExecuteNonQuery();
                    MessageBox.Show("Відеокарта успішно оновлено!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оновленні Відеокарта: {ex.Message}");
            }
        }

        // Удаление GPU
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю відеокарту?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand("DeleteGPU", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@GPU_ID", gpu.GPU_ID);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Відеокарту успішно видалено!");
                        this.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Помилка при видаленні Відеокарти: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неочікувана помилка: {ex.Message}");
                }
            }
        }

        private void closeBTN_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
