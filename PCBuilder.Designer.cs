namespace jenya_lab_7
{
    partial class PCBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            mainTL = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            exitTL = new System.Windows.Forms.ToolStripMenuItem();
            configTL = new System.Windows.Forms.ToolStripMenuItem();
            catalogTL = new System.Windows.Forms.ToolStripMenuItem();
            clientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            componentManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            gpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            motherboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            waterCoolingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fanCoolingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            towerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            blutoothMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wifiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            powerSupplyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ssdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            configurationCtrl2 = new ConfigurationCtrl();
            catalogCtrl2 = new CatalogCtrl();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, configTL, catalogTL, clientsMenuItem, componentManageMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(967, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mainTL, toolStripMenuItem2, exitTL });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            toolStripMenuItem1.Text = "Меню";
            // 
            // mainTL
            // 
            mainTL.Name = "mainTL";
            mainTL.Size = new System.Drawing.Size(122, 22);
            mainTL.Text = "Головна";
            mainTL.Click += mainTL_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(122, 22);
            toolStripMenuItem2.Text = "Профіль";
            // 
            // exitTL
            // 
            exitTL.Name = "exitTL";
            exitTL.Size = new System.Drawing.Size(122, 22);
            exitTL.Text = "Вийти";
            exitTL.Click += exitTL_Click;
            // 
            // configTL
            // 
            configTL.Name = "configTL";
            configTL.Size = new System.Drawing.Size(95, 20);
            configTL.Text = "Конфігуратор";
            configTL.Click += configBTN_Click;
            // 
            // catalogTL
            // 
            catalogTL.Name = "catalogTL";
            catalogTL.Size = new System.Drawing.Size(62, 20);
            catalogTL.Text = "Каталог";
            catalogTL.Click += catalogTL_Click;
            // 
            // clientsMenuItem
            // 
            clientsMenuItem.Name = "clientsMenuItem";
            clientsMenuItem.Size = new System.Drawing.Size(61, 20);
            clientsMenuItem.Text = "Клієнти";
            // 
            // componentManageMenuItem
            // 
            componentManageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cpuMenuItem, hddMenuItem, ramMenuItem, gpuMenuItem, motherboardMenuItem, waterCoolingMenuItem, fanCoolingMenuItem, towerMenuItem, blutoothMenuItem, wifiMenuItem, powerSupplyMenuItem, ssdMenuItem });
            componentManageMenuItem.Name = "componentManageMenuItem";
            componentManageMenuItem.Size = new System.Drawing.Size(186, 20);
            componentManageMenuItem.Text = "Управління комплекчуючими";
            // 
            // cpuMenuItem
            // 
            cpuMenuItem.Name = "cpuMenuItem";
            cpuMenuItem.Size = new System.Drawing.Size(148, 22);
            cpuMenuItem.Text = "CPU";
            cpuMenuItem.Click += cpuMenuItem_Click;
            // 
            // hddMenuItem
            // 
            hddMenuItem.Name = "hddMenuItem";
            hddMenuItem.Size = new System.Drawing.Size(148, 22);
            hddMenuItem.Text = "HDD";
            hddMenuItem.Click += hddMenuItem_Click;
            // 
            // ramMenuItem
            // 
            ramMenuItem.Name = "ramMenuItem";
            ramMenuItem.Size = new System.Drawing.Size(148, 22);
            ramMenuItem.Text = "RAM";
            ramMenuItem.Click += ramMenuItem_Click;
            // 
            // gpuMenuItem
            // 
            gpuMenuItem.Name = "gpuMenuItem";
            gpuMenuItem.Size = new System.Drawing.Size(148, 22);
            gpuMenuItem.Text = "GPU";
            gpuMenuItem.Click += gpuMenuItem_Click;
            // 
            // motherboardMenuItem
            // 
            motherboardMenuItem.Name = "motherboardMenuItem";
            motherboardMenuItem.Size = new System.Drawing.Size(148, 22);
            motherboardMenuItem.Text = "Motherboard";
            motherboardMenuItem.Click += motherboardMenuItem_Click;
            // 
            // waterCoolingMenuItem
            // 
            waterCoolingMenuItem.Name = "waterCoolingMenuItem";
            waterCoolingMenuItem.Size = new System.Drawing.Size(148, 22);
            waterCoolingMenuItem.Text = "Water cooling";
            // 
            // fanCoolingMenuItem
            // 
            fanCoolingMenuItem.Name = "fanCoolingMenuItem";
            fanCoolingMenuItem.Size = new System.Drawing.Size(148, 22);
            fanCoolingMenuItem.Text = "Fan cooling";
            // 
            // towerMenuItem
            // 
            towerMenuItem.Name = "towerMenuItem";
            towerMenuItem.Size = new System.Drawing.Size(148, 22);
            towerMenuItem.Text = "Tower";
            towerMenuItem.Click += towerMenuItem_Click;
            // 
            // blutoothMenuItem
            // 
            blutoothMenuItem.Name = "blutoothMenuItem";
            blutoothMenuItem.Size = new System.Drawing.Size(148, 22);
            blutoothMenuItem.Text = "Blutooth";
            // 
            // wifiMenuItem
            // 
            wifiMenuItem.Name = "wifiMenuItem";
            wifiMenuItem.Size = new System.Drawing.Size(148, 22);
            wifiMenuItem.Text = "Wifi";
            // 
            // powerSupplyMenuItem
            // 
            powerSupplyMenuItem.Name = "powerSupplyMenuItem";
            powerSupplyMenuItem.Size = new System.Drawing.Size(148, 22);
            powerSupplyMenuItem.Text = "Power supply";
            // 
            // ssdMenuItem
            // 
            ssdMenuItem.Name = "ssdMenuItem";
            ssdMenuItem.Size = new System.Drawing.Size(148, 22);
            ssdMenuItem.Text = "SSD";
            ssdMenuItem.Click += ssdMenuItem_Click;
            // 
            // configurationCtrl2
            // 
            configurationCtrl2.BackColor = System.Drawing.SystemColors.GrayText;
            configurationCtrl2.Location = new System.Drawing.Point(12, 53);
            configurationCtrl2.Name = "configurationCtrl2";
            configurationCtrl2.Size = new System.Drawing.Size(887, 395);
            configurationCtrl2.TabIndex = 1;
            // 
            // catalogCtrl2
            // 
            catalogCtrl2.BackColor = System.Drawing.SystemColors.GrayText;
            catalogCtrl2.Location = new System.Drawing.Point(25, 36);
            catalogCtrl2.Name = "catalogCtrl2";
            catalogCtrl2.Size = new System.Drawing.Size(887, 412);
            catalogCtrl2.TabIndex = 2;
            // 
            // PCBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(967, 485);
            Controls.Add(catalogCtrl2);
            Controls.Add(configurationCtrl2);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "PCBuilder";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PCBuilder";
            Load += PCBuilder_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainTL;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitTL;
        private System.Windows.Forms.ToolStripMenuItem catalogTL;
        private System.Windows.Forms.ToolStripMenuItem configTL;
        private CatalogCtrl Catalog;
        private ConfigurationCtrl Configuration;
        private System.Windows.Forms.ToolStripMenuItem clientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem componentManageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cpuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gpuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherboardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterCoolingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fanCoolingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem towerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blutoothMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wifiMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerSupplyMenuItem;
        private hddManageCtrl hddManageCtrl1;
        private ramManageCtrl ramManageCtrl1;
        private motherboardManageCtrl motherboardManageCtrl1;
        private cpuManageCtrl cpuManageCtrl1;
        private gpuManageCtrl gpuManageCtrl1;
        private ssdManageCtrl ssdManageCtrl1;
        private ConfigurationCtrl configurationCtrl1;
        private CatalogCtrl catalogCtrl1;
        private towerManageCtrl towerManageCtrl1;
        private System.Windows.Forms.ToolStripMenuItem ssdMenuItem;
        private ConfigurationCtrl configurationCtrl2;
        private CatalogCtrl catalogCtrl2;
    }
}