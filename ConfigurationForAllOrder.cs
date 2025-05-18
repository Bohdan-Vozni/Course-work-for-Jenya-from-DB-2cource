using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class ConfigurationForAllOrder : Form
    {
        public ConfigurationForAllOrder()
        {
            InitializeComponent();
        }

        public string nameProcedure;

        public ConfigurationForAllOrder(string nameProcedure)
        {
            InitializeComponent();
            this.nameProcedure = nameProcedure;
        }

        private void ConfigurationForAllOrder_Load(object sender, EventArgs e)
        {
            ShowDataToGrit(nameProcedure);

        }

        private void ShowDataToGrit(string nameProcedure)
        {
            using (SqlConnection connection = new SqlConnection(GetContectionString.getstr))
            {
                SqlCommand command = new SqlCommand(nameProcedure, connection);
                command.CommandType = CommandType.StoredProcedure;



                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                result_dataGridView.DataSource = dt;
            }
        }

        private void result_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Для девіда це просто шаболон, щоб не створювати багато форм буде одна для кофігуратора 

            // Перевіряємо, що натиснуто на клітинку в рядку даних
            if (result_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Перевіряємо, чи є стовпці з назвами "CPU" і "idCPU"
                bool hasCPU = result_dataGridView.Columns.Contains("CPU");
                bool hasIdCPU = result_dataGridView.Columns.Contains("idCPU");

                if (hasCPU && hasIdCPU)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["CPU"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["idCPU"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.Cpu = cpuValue;
                    PcForSaveOrderForOneTime.idCpu = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.Cpu}");
                    return;
                }


                bool hasHdd = result_dataGridView.Columns.Contains("Назва жосткого диску");
                bool hasidHdd = result_dataGridView.Columns.Contains("HDD_ID");

                if (hasHdd && hasidHdd)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва жосткого диску"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["HDD_ID"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.Hdd = cpuValue;
                    PcForSaveOrderForOneTime.idHdd = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.Hdd}");
                    return;
                }


                bool haspowerSupply = result_dataGridView.Columns.Contains("Назва блоку живлення");
                bool hasidpowerSupply = result_dataGridView.Columns.Contains("PowerSupply_ID");

                if (haspowerSupply && hasidpowerSupply)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва блоку живлення"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["PowerSupply_ID"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.popwerSupply = cpuValue;
                    PcForSaveOrderForOneTime.idPopwerSupply = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.popwerSupply}");
                    return;
                }

                bool hasRam = result_dataGridView.Columns.Contains("Назва оперативної пам’яті");
                bool hasIdRam = result_dataGridView.Columns.Contains("ID ОЗП");

                if (hasRam && hasIdRam)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва оперативної пам’яті"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID ОЗП"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.ram = cpuValue;
                    PcForSaveOrderForOneTime.idRam = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.ram}");
                    return;
                }

                bool hasSsd = result_dataGridView.Columns.Contains("Назва SSD");
                bool hasIdSsd = result_dataGridView.Columns.Contains("ID SSD");

                if (hasSsd && hasIdSsd)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва SSD"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID SSD"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.ssd = cpuValue;
                    PcForSaveOrderForOneTime.idSsd = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.ssd}");
                    return;
                }

                bool hasBluetooth = result_dataGridView.Columns.Contains("Назва Bluetooth модуля");
                bool hasIdBluetoth = result_dataGridView.Columns.Contains("ID Bluetooth");

                if (hasBluetooth && hasIdBluetoth)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва Bluetooth модуля"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Bluetooth"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.bluetooth = cpuValue;
                    PcForSaveOrderForOneTime.idBluetooth = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.bluetooth}");
                    return;
                }

                bool hasGpu = result_dataGridView.Columns.Contains("Назва відеокарти");
                bool hasIdGpu = result_dataGridView.Columns.Contains("ID Відеокарти");

                if (hasGpu && hasIdGpu)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва відеокарти"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Відеокарти"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.gpu = cpuValue;
                    PcForSaveOrderForOneTime.idGpu = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.gpu}");
                    return;
                }

                bool hasFanCooling = result_dataGridView.Columns.Contains("Назва кулера");
                bool hasIdFanCooling = result_dataGridView.Columns.Contains("ID Вентиляторного охолодження");

                if (hasFanCooling && hasIdFanCooling)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва кулера"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Вентиляторного охолодження"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.fanCooling = cpuValue;
                    PcForSaveOrderForOneTime.idFanCooling = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.fanCooling}");
                    return;
                }

                bool hasWifi = result_dataGridView.Columns.Contains("Назва Wi-Fi модуля");
                bool hasIdWifi = result_dataGridView.Columns.Contains("ID Wi-Fi модуля");

                if (hasWifi && hasIdWifi)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва Wi-Fi модуля"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Wi-Fi модуля"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.wifi = cpuValue;
                    PcForSaveOrderForOneTime.idWifi = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.wifi}");
                    return;
                }

                bool hasMotherboard = result_dataGridView.Columns.Contains("Назва материнської плати");
                bool hasIdMotherboard = result_dataGridView.Columns.Contains("ID Материнської плати");

                if (hasMotherboard && hasIdMotherboard)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва материнської плати"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Материнської плати"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.motherboard = cpuValue;
                    PcForSaveOrderForOneTime.idMotherboard = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.motherboard}");
                    return;
                }

                bool hasWaterCoolint = result_dataGridView.Columns.Contains("Назва водяного охолодження");
                bool hasIdWaterCoolint = result_dataGridView.Columns.Contains("ID Водяного охолодження");

                if (hasWaterCoolint && hasIdWaterCoolint)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва водяного охолодження"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Водяного охолодження"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.waterCooling = cpuValue;
                    PcForSaveOrderForOneTime.idWaterCooling = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.waterCooling}");
                    return;
                }

                bool hasTower = result_dataGridView.Columns.Contains("Назва корпуса");
                bool hasIdTower = result_dataGridView.Columns.Contains("ID Корпуса");

                if (hasTower && hasIdTower)
                {
                    var cpuValue = result_dataGridView.Rows[e.RowIndex].Cells["Назва корпуса"].FormattedValue.ToString();
                    var idCpuValue = result_dataGridView.Rows[e.RowIndex].Cells["ID Корпуса"].FormattedValue.ToString();

                    PcForSaveOrderForOneTime.tower = cpuValue;
                    PcForSaveOrderForOneTime.idTower = idCpuValue;

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.tower}");
                    return;
                }

            }
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
