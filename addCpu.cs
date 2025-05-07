using System;
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

        private void saveBTN_Click(object sender, System.EventArgs e)
        {
            try
            {
                string title = titleTB.Text;
                string cores = coresTB.Text;
                string clock = clockTB.Text;
                string architecture = architectureTB.Text;
                string cache = cacheTB.Text;
                string threads = threadsTB.Text;
                float cost = float.Parse(costTB.Text);

                MessageBox.Show("Cpu успішно додано");

                emptyTB();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні CPU:\n{ex.Message}");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}