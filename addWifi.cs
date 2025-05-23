﻿using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addWifi : Form
    {
        public addWifi()
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

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void saveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string title = titleTB.Text.Trim();
                string generation = generationTB.Text.Trim();
                string cost = costTB.Text.Trim();

                if (title == "" || generation == "" || cost == "")
                {
                    MessageBox.Show("Будь ласка, заповніть усі поля.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("AddWifi", connection); // имя процедуры
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    string idUnic = Guid.NewGuid().ToString();

                    command.Parameters.AddWithValue("@Wifi_ID", idUnic);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Generation", generation);
                    command.Parameters.AddWithValue("@Cost", cost);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Wi-Fi адаптер успішно додано!");

                    emptyTB();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Помилка SQL при додаванні Wi-Fi адаптера");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неочікувана помилка");
            }
        }
    }
}
