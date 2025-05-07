using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class towerManageCtrl : UserControl
    {
        public towerManageCtrl()
        {
            InitializeComponent();
        }

        private void openAddTowerBtn_Click(object sender, EventArgs e)
        {
            addTower addTower = new addTower();
            addTower.Show();
        }
    }
}