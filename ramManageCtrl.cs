using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ramManageCtrl : UserControl
    {
        public ramManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddRamBtn_Click(object sender, EventArgs e)
        {
            addRam addRam = new addRam();
            addRam.Show();
        }
    }
}