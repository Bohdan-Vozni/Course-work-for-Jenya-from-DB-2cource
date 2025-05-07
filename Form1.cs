using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void authBTN_Click(object sender, System.EventArgs e)
        {
            string userName = userNameTB.Text;
            string password = passwordTB.Text;
            userNameTB.Text = string.Empty;
            passwordTB.Text = string.Empty;

            if (userName == "" && password == "")
            {
                PCBuilder PCForm = new PCBuilder();
                PCForm.Show();
                Hide();
            }
        }

        private void exitAppBTN_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}