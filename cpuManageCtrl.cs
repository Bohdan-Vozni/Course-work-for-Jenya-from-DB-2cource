using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class cpuManageCtrl : UserControl
    {
        public cpuManageCtrl()
        {
            InitializeComponent();
        }

        private void openEditCpuBtn_Click(object sender, EventArgs e)
        {
        }

        private void openAddCpuBtn_Click(object sender, EventArgs e)
        {
            addCpu addingCpu = new addCpu();
            addingCpu.Show();
        }
    }
}