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

                    MessageBox.Show($"Вибрано {PcForSaveOrderForOneTime.Cpu}");
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

            }
        }
    }
}
