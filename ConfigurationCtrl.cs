using Microsoft.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Runtime.Intrinsics.X86;
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
            fanCooling_textBox.Text = PcForSaveOrderForOneTime.fanCooling;
            wifi_textBox.Text = PcForSaveOrderForOneTime.wifi;
            motherboard_textBox.Text = PcForSaveOrderForOneTime.motherboard;
            waterCooling_textBox.Text = PcForSaveOrderForOneTime.waterCooling;
            tower_textBox.Text = PcForSaveOrderForOneTime.tower;
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
            fanCooling_textBox.DoubleClick += fanCooling_textBox_DoubleClick;
            wifi_textBox.DoubleClick += wifi_textBox_DoubleClick;
            motherboard_textBox.DoubleClick += motherboard_textBox_DoubleClick;
            waterCooling_textBox.DoubleClick += waterCooling_textBox_DoubleClick;
            tower_textBox.DoubleClick += tower_textBox_DoubleClick;


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
        private void fanCooling_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllFanCooling");
        }
        private void wifi_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllWifi");
        }
        private void motherboard_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllMotherboard");
        }
        private void waterCooling_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllWaterCooling");
        }
        private void tower_textBox_DoubleClick(object sender, EventArgs e)
        {
            GoToSelctGritForConfig("Config_GetAllTower");
        }

        private void savePcBTN_Click(object sender, EventArgs e)
        {
            if(fanCooling_textBox.Text != "" && waterCooling_textBox.Text != "")
            {
                MessageBox.Show("Виберіть один з методів охолодження вашого пк");
                // Очищення вентиляторного охолодження
                PcForSaveOrderForOneTime.idFanCooling = null;
                PcForSaveOrderForOneTime.fanCooling = null;
                waterCooling_textBox.Text = string.Empty;

                // Очищення водяного охолодження
                PcForSaveOrderForOneTime.idWaterCooling = null;
                PcForSaveOrderForOneTime.waterCooling = null;
                fanCooling_textBox.Text = string.Empty;
                return;
            }

            if ((HDD_textBox.Text == "" && ssd_textBox.Text == ""))
            {
                MessageBox.Show("Виберіть один або два вида памяті");
               
                // Очищення HDD
                PcForSaveOrderForOneTime.idHdd = null;
                PcForSaveOrderForOneTime.Hdd = null;

                HDD_textBox.Text = string.Empty;

                // Очищення SSD
                PcForSaveOrderForOneTime.idSsd = null;
                PcForSaveOrderForOneTime.ssd = null;
                ssd_textBox.Text = string.Empty;
                return;
            }


            var unicId = Guid.NewGuid().ToString();

            if (string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idCpu) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idGpu) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idMotherboard) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idRam) ||
                //string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idHdd) ||
                //string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idSsd) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idPopwerSupply) ||
                //string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idWaterCooling) ||
                //string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idFanCooling) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idWifi) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idBluetooth) ||
                string.IsNullOrWhiteSpace(PcForSaveOrderForOneTime.idTower))
            {
                MessageBox.Show("Будь ласка, заповніть усі компоненти ПК перед збереженням!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                SqlCommand command = new SqlCommand("InsertPC", connection);
                command.CommandType = CommandType.StoredProcedure;



                command.Parameters.AddWithValue("@PC_ID", unicId);

                command.Parameters.AddWithValue("@CPU_ID", PcForSaveOrderForOneTime.idCpu);
                command.Parameters.AddWithValue("@GPU_ID", PcForSaveOrderForOneTime.idGpu);
                command.Parameters.AddWithValue("@Motherboard_ID", PcForSaveOrderForOneTime.idMotherboard);
                command.Parameters.AddWithValue("@RAM_ID", PcForSaveOrderForOneTime.idRam);
                command.Parameters.AddWithValue("@HDD_ID", PcForSaveOrderForOneTime.idHdd);
                command.Parameters.AddWithValue("@SSD_ID", PcForSaveOrderForOneTime.idSsd);
                command.Parameters.AddWithValue("@PowerSupply_ID", PcForSaveOrderForOneTime.idPopwerSupply);
                command.Parameters.AddWithValue("@WaterCooling_ID", PcForSaveOrderForOneTime.idWaterCooling);
                command.Parameters.AddWithValue("@FanCooling_ID", PcForSaveOrderForOneTime.idFanCooling);
                command.Parameters.AddWithValue("@Wifi_ID", PcForSaveOrderForOneTime.idWifi);
                command.Parameters.AddWithValue("@Bluetooth_ID", PcForSaveOrderForOneTime.idBluetooth);
                command.Parameters.AddWithValue("@Tower_ID", PcForSaveOrderForOneTime.idTower);
                command.Parameters.AddWithValue("@ExecutionDate", DateTime.Today);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("ПК успішно збережено!");

                    var form = new addPurchase(unicId);
                    form.ShowDialog();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Помилка при збереженні ПК: " + ex.Message);
                }
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            updateAllFielAfterSelectItem();
        }

        private void cleanData_button_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }               
            }

            PcForSaveOrderForOneTime.ClearAll();
        }
    }
}
