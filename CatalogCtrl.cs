using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class CatalogCtrl : UserControl
    {
        public CatalogCtrl()
        {
            InitializeComponent();
        }

        private void showRamBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllRam");
        }

        private void showFanCoolingBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllFanCooling");
        }

        private void GoToSelctGritForConfig(string str)
        {
            var formForConfig = new ConfigurationForAllOrder(str);

            formForConfig.ShowDialog();


        }

        private void showCpuBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllCPU");
        }

        private void showGpuBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllGpu");
        }

        private void showHddBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllHDD");
        }

        private void showPowerSupplyBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllPowerSupply");
        }

        private void showSsdBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllSsd");
        }

        private void showBluetoothBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllBluetooth");
        }

        private void showWIfiBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllWifi");
        }

        private void showMotheboardBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllMotherboard");
        }

        private void showWaterCoolingBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllWaterCooling");
        }

        private void showTowerBTN_Click(object sender, System.EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllTower");
        }
    }

}