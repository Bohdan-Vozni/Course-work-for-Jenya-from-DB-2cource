using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class AsistentForUpdateAndDelete_UserControl : UserControl
    {
        public AsistentForUpdateAndDelete_UserControl()
        {
            InitializeComponent();
        }

        private void AsistentForUpdateAndDelete_UserControl_Load(object sender, EventArgs e)
        {
            if (DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;
            ShowDataToGrit();
            RenameHeaderTextInGrit();

        }

        private void RenameHeaderTextInGrit()
        {

            dataGridView.Columns["Specialist_ID"].Visible = true;
            dataGridView.Columns["Specialist_ID"].HeaderText = "Індетифікатор асистента";
            dataGridView.Columns["SpecialistName"].HeaderText = "ПІБ асистента";
            dataGridView.Columns["Phone"].HeaderText = "Номер телефону";

        }

        private void ShowDataToGrit()
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                SqlCommand command = new SqlCommand("GetAllSpecialists", connection);
                command.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView.DataSource = dt;
            }
        }

        string idAsistent;

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView.CurrentRow.Selected = true;

                idAsistent = dataGridView.Rows[e.RowIndex].Cells["Specialist_ID"].FormattedValue.ToString();

                name_TextBox.Text = dataGridView
                    .Rows[e.RowIndex]
                    .Cells["SpecialistName"]
                    .FormattedValue.ToString();

                phone_textBox.Text = dataGridView
                    .Rows[e.RowIndex]
                    .Cells["Phone"]
                    .FormattedValue.ToString();



            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
          
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете оновити дані?",
                "Підтвердження дії",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }

            

            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {


                SqlCommand command = new SqlCommand("UpdateSpecialist", connection);
                command.CommandType = CommandType.StoredProcedure;


                var idUnic = Guid.NewGuid().ToString();

                //додати параметри
                command.Parameters.AddWithValue("@Specialist_ID", idAsistent);
                command.Parameters.AddWithValue("@SpecialistName", name_TextBox.Text);
                command.Parameters.AddWithValue("@Phone", phone_textBox.Text);
               

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Асистент успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        MessageBox.Show(error.Message, "Помилка додавання асистента", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Інші неочікувані помилки
                    MessageBox.Show(ex.Message, "Неочікувана помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            ShowDataToGrit();
        }

        private void delete_buttoan_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете видалити дані?",
                "Підтвердження дії",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                return;
            }



            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {


                SqlCommand command = new SqlCommand("DeleteSpecialist", connection);
                command.CommandType = CommandType.StoredProcedure;


                var idUnic = Guid.NewGuid().ToString();

                //додати параметри
                command.Parameters.AddWithValue("@Specialist_ID", idAsistent);
               

                connection.Open();

                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Асистент успішно видалено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    foreach (SqlError error in ex.Errors)
                    {
                        MessageBox.Show(error.Message, "Помилка видалення асистента", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Інші неочікувані помилки
                    MessageBox.Show(ex.Message, "Неочікувана помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            ShowDataToGrit();
        }
    }
}
