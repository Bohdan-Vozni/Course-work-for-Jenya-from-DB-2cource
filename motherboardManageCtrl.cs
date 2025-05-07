using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class motherboardManageCtrl : UserControl
    {
        public motherboardManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addMotherboard addMotherboard = new addMotherboard();
            addMotherboard.Show();
        }
    }
}