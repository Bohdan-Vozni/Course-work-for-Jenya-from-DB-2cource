using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addGpu : Form
    {
        public addGpu()
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
                string title = titleTB.Text.Trim();
                string cores = coresTB.Text.Trim();
                string clock = clockTB.Text.Trim();
                string vramType = vramTypeTB.Text.Trim();
                string vramQuant = vramQuantTB.Text.Trim();
                string threads = threadsTB.Text.Trim();
                string cache = cacheTB.Text.Trim();
                string costText = costTB.Text.Trim();

                if (title == "" ||
                    cores == "" ||
                    threads == "" ||
                    cache == "" ||
                    clock == "" ||
                    vramType == "" ||
                    vramQuant == "" ||
                    costText == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }


                // Преобразуем стоимость в число
                float cost;
                if (!float.TryParse(costText, out cost))
                {
                    MessageBox.Show("Невірно введена ціна!");
                    return;
                }

                // Подключение к базе данных и выполнение процедуры
                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddGPU", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    var idUnic = Guid.NewGuid().ToString();
                    command.Parameters.AddWithValue("@GPU_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Cores", cores);
                    command.Parameters.AddWithValue("@Threads", threads);
                    command.Parameters.AddWithValue("@VRAMType", vramType);
                    command.Parameters.AddWithValue("@VRAMQuantity", vramQuant);
                    command.Parameters.AddWithValue("@Cache", cache);
                    command.Parameters.AddWithValue("@Clock", clock);
                    command.Parameters.AddWithValue("@Cost", cost);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("GPU успішно додано!");
                        emptyTB();
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Помилка при додаванні GPU");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неочікувана помилка");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні GPU:\n{ex.Message}");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addGpu_Load(object sender, EventArgs e)
        {

        }
    }
}