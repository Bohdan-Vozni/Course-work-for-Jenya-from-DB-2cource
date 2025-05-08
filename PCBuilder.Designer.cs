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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1, configTL, catalogTL, clientsMenuItem, componentManageMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(1014, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mainTL, toolStripMenuItem2, exitTL });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            toolStripMenuItem1.Text = "Меню";
            // 
            // mainTL
            // 
            mainTL.Name = "mainTL";
            mainTL.Size = new System.Drawing.Size(224, 26);
            mainTL.Text = "Головна";
            mainTL.Click += mainTL_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            toolStripMenuItem2.Text = "Профіль";
            // 
            // exitTL
            // 
            exitTL.Name = "exitTL";
            exitTL.Size = new System.Drawing.Size(224, 26);
            exitTL.Text = "Вийти";
            exitTL.Click += exitTL_Click;
            // 
            // configTL
            // 
            configTL.Name = "configTL";
            configTL.Size = new System.Drawing.Size(118, 24);
            configTL.Text = "Конфігуратор";
            configTL.Click += configBTN_Click;
            // 
            // catalogTL
            // 
            catalogTL.Name = "catalogTL";
            catalogTL.Size = new System.Drawing.Size(77, 24);
            catalogTL.Text = "Каталог";
            catalogTL.Click += catalogTL_Click;
            // 
            // clientsMenuItem
            // 
            clientsMenuItem.Name = "clientsMenuItem";
            clientsMenuItem.Size = new System.Drawing.Size(75, 24);
            clientsMenuItem.Text = "Клієнти";
            // 
            // componentManageMenuItem
            // 
            componentManageMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { cpuMenuItem, hddMenuItem, ramMenuItem, gpuMenuItem, motherboardMenuItem, waterCoolingMenuItem, fanCoolingMenuItem, towerMenuItem, blutoothMenuItem, wifiMenuItem, powerSupplyMenuItem, ssdMenuItem });
            componentManageMenuItem.Name = "componentManageMenuItem";
            componentManageMenuItem.Size = new System.Drawing.Size(231, 24);
            componentManageMenuItem.Text = "Управління комплекчуючими";
            // 
            // cpuMenuItem
            // 
            cpuMenuItem.Name = "cpuMenuItem";
            cpuMenuItem.Size = new System.Drawing.Size(185, 26);
            cpuMenuItem.Text = "CPU";
            cpuMenuItem.Click += cpuMenuItem_Click;
            // 
            // hddMenuItem
            // 
            hddMenuItem.Name = "hddMenuItem";
            hddMenuItem.Size = new System.Drawing.Size(185, 26);
            hddMenuItem.Text = "HDD";
            hddMenuItem.Click += hddMenuItem_Click;
            // 
            // ramMenuItem
            // 
            ramMenuItem.Name = "ramMenuItem";
            ramMenuItem.Size = new System.Drawing.Size(185, 26);
            ramMenuItem.Text = "RAM";
            ramMenuItem.Click += ramMenuItem_Click;
            // 
            // gpuMenuItem
            // 
            gpuMenuItem.Name = "gpuMenuItem";
            gpuMenuItem.Size = new System.Drawing.Size(185, 26);
            gpuMenuItem.Text = "GPU";
            gpuMenuItem.Click += gpuMenuItem_Click;
            // 
            // motherboardMenuItem
            // 
            motherboardMenuItem.Name = "motherboardMenuItem";
            motherboardMenuItem.Size = new System.Drawing.Size(185, 26);
            motherboardMenuItem.Text = "Motherboard";
            motherboardMenuItem.Click += motherboardMenuItem_Click;
            // 
            // waterCoolingMenuItem
            // 
            waterCoolingMenuItem.Name = "waterCoolingMenuItem";
            waterCoolingMenuItem.Size = new System.Drawing.Size(185, 26);
            waterCoolingMenuItem.Text = "Water cooling";
            // 
            // fanCoolingMenuItem
            // 
            fanCoolingMenuItem.Name = "fanCoolingMenuItem";
            fanCoolingMenuItem.Size = new System.Drawing.Size(185, 26);
            fanCoolingMenuItem.Text = "Fan cooling";
            // 
            // towerMenuItem
            // 
            towerMenuItem.Name = "towerMenuItem";
            towerMenuItem.Size = new System.Drawing.Size(185, 26);
            towerMenuItem.Text = "Tower";
            towerMenuItem.Click += towerMenuItem_Click;
            // 
            // blutoothMenuItem
            // 
            blutoothMenuItem.Name = "blutoothMenuItem";
            blutoothMenuItem.Size = new System.Drawing.Size(185, 26);
            blutoothMenuItem.Text = "Blutooth";
            // 
            // wifiMenuItem
            // 
            wifiMenuItem.Name = "wifiMenuItem";
            wifiMenuItem.Size = new System.Drawing.Size(185, 26);
            wifiMenuItem.Text = "Wifi";
            // 
            // powerSupplyMenuItem
            // 
            powerSupplyMenuItem.Name = "powerSupplyMenuItem";
            powerSupplyMenuItem.Size = new System.Drawing.Size(185, 26);
            powerSupplyMenuItem.Text = "Power supply";
            // 
            // ssdMenuItem
            // 
            ssdMenuItem.Name = "ssdMenuItem";
            ssdMenuItem.Size = new System.Drawing.Size(185, 26);
            ssdMenuItem.Text = "SSD";
            ssdMenuItem.Click += ssdMenuItem_Click;
            // 
            // configurationCtrl2
            // 
            configurationCtrl2.BackColor = System.Drawing.SystemColors.GrayText;
            configurationCtrl2.Location = new System.Drawing.Point(0, 32);
            configurationCtrl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            configurationCtrl2.Name = "configurationCtrl2";
            configurationCtrl2.Size = new System.Drawing.Size(1268, 659);
            configurationCtrl2.TabIndex = 1;
            // 
            // PCBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1014, 562);
            Controls.Add(configurationCtrl2);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
    }
}