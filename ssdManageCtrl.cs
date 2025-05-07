using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ssdManageCtrl : UserControl
    {
        public ssdManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddSsdBtn_Click(object sender, System.EventArgs e)
        {
            addSsd addSsd = new addSsd();
            addSsd.Show();
        }
    }
}