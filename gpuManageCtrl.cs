using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class gpuManageCtrl : UserControl
    {
        public gpuManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddMthrBtn_Click(object sender, EventArgs e)
        {
            addGpu addGpu = new addGpu();
            addGpu.Show();
        }
    }
}