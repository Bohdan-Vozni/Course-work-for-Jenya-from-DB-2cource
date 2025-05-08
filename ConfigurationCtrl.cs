using System;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ConfigurationCtrl : UserControl
    {
        public ConfigurationCtrl()
        {
            InitializeComponent();

        }

        private void updateAllFielAfterSelectItem()
        {
            cpu_textBox.Text = PcForSaveOrderForOneTime.Cpu;
            HDD_textBox.Text = PcForSaveOrderForOneTime.Hdd;
            powerSupply_textBox.Text = PcForSaveOrderForOneTime.popwerSupply;
            ram_textBox.Text = PcForSaveOrderForOneTime.ram;
            ssd_textBox.Text = PcForSaveOrderForOneTime.ssd;
            bluetooth_textBox.Text = PcForSaveOrderForOneTime.bluetooth;
            gpu_textBox.Text = PcForSaveOrderForOneTime.gpu;
        }

        private void ConfigurationCtrl_Load(object sender, EventArgs e)
        {
            updateAllFielAfterSelectItem();

            cpu_textBox.DoubleClick += cpu_textBox_Click;
            HDD_textBox.DoubleClick += HDD_textBox_DoubleClick;
            powerSupply_textBox.DoubleClick += popwerSupply_textBox_DoubleClick;
            ram_textBox.DoubleClick += ram_textBox_DoubleClick;
            ssd_textBox.DoubleClick += ssd_textBox_DoubleClick;
            bluetooth_textBox.DoubleClick += bluetooth_textBox_DoubleClick;
            gpu_textBox.DoubleClick += gpu_textBox_DoubleClick;
           
        }

        private void GoToSelctGritForConfig(string str)
        {
            var formForConfig = new ConfigurationForAllOrder(str);

            formForConfig.ShowDialog();

            updateAllFielAfterSelectItem();
        }

        private void cpu_textBox_Click(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllCPU");
        }

        private void HDD_textBox_DoubleClick(object sender, EventArgs e)
        {           
            GoToSelctGritForConfig("Config_GetAllHDD");
        }

        private void popwerSupply_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllPowerSupply");
        }
        private void ram_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllRam");
        }
        private void ssd_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllSsd");
        }
        private void bluetooth_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllBluetooth");
        }
        private void gpu_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllGpu");
        }



    }
}
