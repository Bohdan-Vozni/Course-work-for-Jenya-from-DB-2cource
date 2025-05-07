using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class hddManageCtrl : UserControl
    {
        public hddManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddHddBtn_Click(object sender, EventArgs e)
        {
            addHdd addHdd = new addHdd();
            addHdd.Show();
        }
    }
}