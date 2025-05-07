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
        }

        private void ConfigurationCtrl_Load(object sender, EventArgs e)
        {
            updateAllFielAfterSelectItem();

            cpu_textBox.DoubleClick += cpu_textBox_Click;
        }

        private void cpu_textBox_Click(object sender, EventArgs e)
        {
            var formForConfig = new ConfigurationForAllOrder("GetAllCPU");

            formForConfig.ShowDialog();

            updateAllFielAfterSelectItem();

        }

        private void cpu_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
