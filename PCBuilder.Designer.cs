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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTL = new System.Windows.Forms.ToolStripMenuItem();
            this.configTL = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogTL = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentManageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ramMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterCoolingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fanCoolingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.towerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blutoothMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wifiMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerSupplyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherboardManageCtrl1 = new jenya_lab_7.motherboardManageCtrl();
            this.ramManageCtrl1 = new jenya_lab_7.ramManageCtrl();
            this.hddManageCtrl1 = new jenya_lab_7.hddManageCtrl();
            this.cpuManageCtrl1 = new jenya_lab_7.cpuManageCtrl();
            this.Configuration = new jenya_lab_7.ConfigurationCtrl();
            this.Catalog = new jenya_lab_7.CatalogCtrl();
            this.gpuManageCtrl1 = new jenya_lab_7.gpuManageCtrl();
            this.ssdManageCtrl1 = new jenya_lab_7.ssdManageCtrl();
            this.towerManageCtrl1 = new jenya_lab_7.towerManageCtrl();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.configTL,
            this.catalogTL,
            this.clientsMenuItem,
            this.componentManageMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainTL,
            this.toolStripMenuItem2,
            this.exitTL});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // mainTL
            // 
            this.mainTL.Name = "mainTL";
            this.mainTL.Size = new System.Drawing.Size(224, 26);
            this.mainTL.Text = "Головна";
            this.mainTL.Click += new System.EventHandler(this.mainTL_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "Профіль";
            // 
            // exitTL
            // 
            this.exitTL.Name = "exitTL";
            this.exitTL.Size = new System.Drawing.Size(224, 26);
            this.exitTL.Text = "Вийти";
            this.exitTL.Click += new System.EventHandler(this.exitTL_Click);
            // 
            // configTL
            // 
            this.configTL.Name = "configTL";
            this.configTL.Size = new System.Drawing.Size(118, 24);
            this.configTL.Text = "Конфігуратор";
            this.configTL.Click += new System.EventHandler(this.configBTN_Click);
            // 
            // catalogTL
            // 
            this.catalogTL.Name = "catalogTL";
            this.catalogTL.Size = new System.Drawing.Size(77, 24);
            this.catalogTL.Text = "Каталог";
            this.catalogTL.Click += new System.EventHandler(this.catalogTL_Click);
            // 
            // clientsMenuItem
            // 
            this.clientsMenuItem.Name = "clientsMenuItem";
            this.clientsMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientsMenuItem.Text = "Клієнти";
            // 
            // componentManageMenuItem
            // 
            this.componentManageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cpuMenuItem,
            this.hddMenuItem,
            this.ramMenuItem,
            this.gpuMenuItem,
            this.motherboardMenuItem,
            this.waterCoolingMenuItem,
            this.fanCoolingMenuItem,
            this.towerMenuItem,
            this.blutoothMenuItem,
            this.wifiMenuItem,
            this.powerSupplyMenuItem,
            this.ssdMenuItem});
            this.componentManageMenuItem.Name = "componentManageMenuItem";
            this.componentManageMenuItem.Size = new System.Drawing.Size(231, 24);
            this.componentManageMenuItem.Text = "Управління комплекчуючими";
            // 
            // cpuMenuItem
            // 
            this.cpuMenuItem.Name = "cpuMenuItem";
            this.cpuMenuItem.Size = new System.Drawing.Size(185, 26);
            this.cpuMenuItem.Text = "CPU";
            this.cpuMenuItem.Click += new System.EventHandler(this.cpuMenuItem_Click);
            // 
            // hddMenuItem
            // 
            this.hddMenuItem.Name = "hddMenuItem";
            this.hddMenuItem.Size = new System.Drawing.Size(185, 26);
            this.hddMenuItem.Text = "HDD";
            this.hddMenuItem.Click += new System.EventHandler(this.hddMenuItem_Click);
            // 
            // ramMenuItem
            // 
            this.ramMenuItem.Name = "ramMenuItem";
            this.ramMenuItem.Size = new System.Drawing.Size(185, 26);
            this.ramMenuItem.Text = "RAM";
            this.ramMenuItem.Click += new System.EventHandler(this.ramMenuItem_Click);
            // 
            // gpuMenuItem
            // 
            this.gpuMenuItem.Name = "gpuMenuItem";
            this.gpuMenuItem.Size = new System.Drawing.Size(185, 26);
            this.gpuMenuItem.Text = "GPU";
            this.gpuMenuItem.Click += new System.EventHandler(this.gpuMenuItem_Click);
            // 
            // motherboardMenuItem
            // 
            this.motherboardMenuItem.Name = "motherboardMenuItem";
            this.motherboardMenuItem.Size = new System.Drawing.Size(185, 26);
            this.motherboardMenuItem.Text = "Motherboard";
            this.motherboardMenuItem.Click += new System.EventHandler(this.motherboardMenuItem_Click);
            // 
            // waterCoolingMenuItem
            // 
            this.waterCoolingMenuItem.Name = "waterCoolingMenuItem";
            this.waterCoolingMenuItem.Size = new System.Drawing.Size(185, 26);
            this.waterCoolingMenuItem.Text = "Water cooling";
            // 
            // fanCoolingMenuItem
            // 
            this.fanCoolingMenuItem.Name = "fanCoolingMenuItem";
            this.fanCoolingMenuItem.Size = new System.Drawing.Size(185, 26);
            this.fanCoolingMenuItem.Text = "Fan cooling";
            // 
            // towerMenuItem
            // 
            this.towerMenuItem.Name = "towerMenuItem";
            this.towerMenuItem.Size = new System.Drawing.Size(185, 26);
            this.towerMenuItem.Text = "Tower";
            this.towerMenuItem.Click += new System.EventHandler(this.towerMenuItem_Click);
            // 
            // blutoothMenuItem
            // 
            this.blutoothMenuItem.Name = "blutoothMenuItem";
            this.blutoothMenuItem.Size = new System.Drawing.Size(185, 26);
            this.blutoothMenuItem.Text = "Blutooth";
            // 
            // wifiMenuItem
            // 
            this.wifiMenuItem.Name = "wifiMenuItem";
            this.wifiMenuItem.Size = new System.Drawing.Size(185, 26);
            this.wifiMenuItem.Text = "Wifi";
            // 
            // powerSupplyMenuItem
            // 
            this.powerSupplyMenuItem.Name = "powerSupplyMenuItem";
            this.powerSupplyMenuItem.Size = new System.Drawing.Size(185, 26);
            this.powerSupplyMenuItem.Text = "Power supply";
            // 
            // ssdMenuItem
            // 
            this.ssdMenuItem.Name = "ssdMenuItem";
            this.ssdMenuItem.Size = new System.Drawing.Size(185, 26);
            this.ssdMenuItem.Text = "SSD";
            this.ssdMenuItem.Click += new System.EventHandler(this.ssdMenuItem_Click);
            // 
            // motherboardManageCtrl1
            // 
            this.motherboardManageCtrl1.Location = new System.Drawing.Point(0, 31);
            this.motherboardManageCtrl1.Name = "motherboardManageCtrl1";
            this.motherboardManageCtrl1.Size = new System.Drawing.Size(1014, 421);
            this.motherboardManageCtrl1.TabIndex = 6;
            // 
            // ramManageCtrl1
            // 
            this.ramManageCtrl1.Location = new System.Drawing.Point(0, 31);
            this.ramManageCtrl1.Name = "ramManageCtrl1";
            this.ramManageCtrl1.Size = new System.Drawing.Size(1014, 434);
            this.ramManageCtrl1.TabIndex = 5;
            // 
            // hddManageCtrl1
            // 
            this.hddManageCtrl1.Location = new System.Drawing.Point(0, 31);
            this.hddManageCtrl1.Name = "hddManageCtrl1";
            this.hddManageCtrl1.Size = new System.Drawing.Size(1014, 421);
            this.hddManageCtrl1.TabIndex = 4;
            // 
            // cpuManageCtrl1
            // 
            this.cpuManageCtrl1.Location = new System.Drawing.Point(0, 31);
            this.cpuManageCtrl1.Name = "cpuManageCtrl1";
            this.cpuManageCtrl1.Size = new System.Drawing.Size(1014, 421);
            this.cpuManageCtrl1.TabIndex = 3;
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.SystemColors.GrayText;
            this.Configuration.Location = new System.Drawing.Point(0, 31);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(1014, 421);
            this.Configuration.TabIndex = 2;
            // 
            // Catalog
            // 
            this.Catalog.BackColor = System.Drawing.SystemColors.GrayText;
            this.Catalog.Location = new System.Drawing.Point(0, 31);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(1014, 421);
            this.Catalog.TabIndex = 1;
            // 
            // gpuManageCtrl1
            // 
            this.gpuManageCtrl1.Location = new System.Drawing.Point(0, 26);
            this.gpuManageCtrl1.Name = "gpuManageCtrl1";
            this.gpuManageCtrl1.Size = new System.Drawing.Size(1014, 426);
            this.gpuManageCtrl1.TabIndex = 7;
            // 
            // ssdManageCtrl1
            // 
            this.ssdManageCtrl1.Location = new System.Drawing.Point(0, 26);
            this.ssdManageCtrl1.Name = "ssdManageCtrl1";
            this.ssdManageCtrl1.Size = new System.Drawing.Size(1014, 426);
            this.ssdManageCtrl1.TabIndex = 8;
            // 
            // towerManageCtrl1
            // 
            this.towerManageCtrl1.Location = new System.Drawing.Point(0, 26);
            this.towerManageCtrl1.Name = "towerManageCtrl1";
            this.towerManageCtrl1.Size = new System.Drawing.Size(1014, 426);
            this.towerManageCtrl1.TabIndex = 9;
            // 
            // PCBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.towerManageCtrl1);
            this.Controls.Add(this.ssdManageCtrl1);
            this.Controls.Add(this.gpuManageCtrl1);
            this.Controls.Add(this.motherboardManageCtrl1);
            this.Controls.Add(this.ramManageCtrl1);
            this.Controls.Add(this.hddManageCtrl1);
            this.Controls.Add(this.cpuManageCtrl1);
            this.Controls.Add(this.Configuration);
            this.Controls.Add(this.Catalog);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PCBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCBuilder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private cpuManageCtrl cpuManageCtrl1;
        private hddManageCtrl hddManageCtrl1;
        private ramManageCtrl ramManageCtrl1;
        private motherboardManageCtrl motherboardManageCtrl1;
        private gpuManageCtrl gpuManageCtrl1;
        private System.Windows.Forms.ToolStripMenuItem ssdMenuItem;
        private ssdManageCtrl ssdManageCtrl1;
        private towerManageCtrl towerManageCtrl1;
    }
}