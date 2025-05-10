using System.Windows.Forms;

namespace jenya_lab_7
{
    public partial class PCBuilder : Form
    {




        public PCBuilder()
        {
            InitializeComponent();
            InitializeControls();
            this.cleanView();
        }

        private void InitializeControls()
        {
            //cpuManageCtrl1 = new cpuManageCtrl();
            //hddManageCtrl1 = new hddManageCtrl();
            //ramManageCtrl1 = new ramManageCtrl();
            //motherboardManageCtrl1 = new motherboardManageCtrl();
            //gpuManageCtrl1 = new gpuManageCtrl();
            //ssdManageCtrl1 = new ssdManageCtrl();
            //towerManageCtrl1 = new towerManageCtrl();
            //configurationCtrl1 = new ConfigurationCtrl();
            //catalogCtrl1 = new CatalogCtrl();

            //this.Controls.Add(cpuManageCtrl1);
            //this.Controls.Add(hddManageCtrl1);
            //this.Controls.Add(ramManageCtrl1);
            //this.Controls.Add(motherboardManageCtrl1);
            //this.Controls.Add(gpuManageCtrl1);
            //this.Controls.Add(ssdManageCtrl1);
            //this.Controls.Add(towerManageCtrl1);
            //this.Controls.Add(configurationCtrl1);
            //this.Controls.Add(catalogCtrl1);

        }

        private void cleanView()
        {
            foreach (Control control in this.Controls)
            {
                if (control is UserControl userControl)
                {
                    userControl.Visible = false;
                }
            }
        }

        private void exitTL_Click(object sender, System.EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void configBTN_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            configurationCtrl1.Visible = true;
        }

        private void catalogTL_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            catalogCtrl1.Visible = true;
        }

        private void mainTL_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
        }

        private void cpuMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            cpuManageCtrl1.Visible = true;
        }

        private void hddMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            hddManageCtrl1.Visible = true;
        }

        private void ramMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            ramManageCtrl1.Visible = true;
        }

        private void motherboardMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            motherboardManageCtrl1.Visible = true;
        }

        private void gpuMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            gpuManageCtrl1.Visible = true;
        }

        private void ssdMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            ssdManageCtrl1.Visible = true;
        }

        private void towerMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();

            towerManageCtrl1.Visible = true;
        }

        private void configurationCtrl1_Load(object sender, System.EventArgs e)
        {

        }

        private void PCBuilder_Load(object sender, System.EventArgs e)
        {
        }

        private void waterCoolingMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            wateCoolingManageCtrl1.Visible = true;
        }

        private void fanCoolingMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            fanCoolingManageCtrl1.Visible = true;
        }

        private void blutoothMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            bluetoothManageCtrl1.Visible = true;

        }

        private void wifiMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            wifiManageCtrl1.Visible = true;
        }

        private void powerSupplyMenuItem_Click(object sender, System.EventArgs e)
        {
            this.cleanView();
            powerSupplyManageCtrl1.Visible = true;
        }
    }
}