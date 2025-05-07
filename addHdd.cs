using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addHdd : Form
    {
        public addHdd()
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

        private void saveBTN_Click(object sender, System.EventArgs e)
        {
            try
            {
                string title = titleTB.Text;
                string memortyQuantity = memoryQuantityTB.Text;
                string writeSpeed = writeSpeedTB.Text;
                string readingSpeed = readingSpeedTB.Text;
                float cost = float.Parse(costTB.Text);

                MessageBox.Show("HDD успішно додано");

                emptyTB();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні HDD:\n{ex.Message}");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}