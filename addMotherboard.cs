using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addMotherboard : Form
    {
        public addMotherboard()
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
                string socket = socketTB.Text;
                string typeSize = typeSizeTB.Text;
                string readingSpeed = chipsetTB.Text;
                float cost = float.Parse(costTB.Text);

                MessageBox.Show("Motherboard успішно додано");

                emptyTB();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні Motherboard:\n{ex.Message}");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}