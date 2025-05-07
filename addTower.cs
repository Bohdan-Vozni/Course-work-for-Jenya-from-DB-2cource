using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class addTower : Form
    {
        public addTower()
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
                string typeSize = typeSizeTB.Text;
                bool fanIncluded = fanIncludedRadioBTN.Checked;
                string fanType = fanIncluded ? fanTypeTB.Text : null;
                float cost = float.Parse(costTB.Text);

                MessageBox.Show("Tower успішно додано");

                emptyTB();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні Tower:\n{ex.Message}");
            }
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}