using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addRam : Form
    {
        public addRam()
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
                string title = titleTB.Text;
                string memortyQuantity = memoryTypeTB.Text;
                string writeSpeed = radiatorTypeTB.Text;
                string readingSpeed = memQuantTB.Text;
                float cost = float.Parse(costTB.Text);

                MessageBox.Show("RAM успішно додано");

                emptyTB();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні RAM:\n{ex.Message}");
            }
        }

        private void exitAppBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}