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
            bluetoothManageCtrl1 = new bluetoothManageCtrl();
            clientManageCtrl1 = new clientManageCtrl();
            cpuManageCtrl1 = new cpuManageCtrl();
            fanCoolingManageCtrl1 = new fanCoolingManageCtrl();
            gpuManageCtrl1 = new gpuManageCtrl();
            hddManageCtrl1 = new hddManageCtrl();
            motherboardManageCtrl1 = new motherboardManageCtrl();
            powerSupplyManageCtrl1 = new powerSupplyManageCtrl();
            ramManageCtrl1 = new ramManageCtrl();
            ssdManageCtrl1 = new ssdManageCtrl();
            towerManageCtrl1 = new towerManageCtrl();
            wateCoolingManageCtrl1 = new wateCoolingManageCtrl();
            wifiManageCtrl1 = new wifiManageCtrl();
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
            menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1013, 30);
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
            mainTL.Size = new System.Drawing.Size(151, 26);
            mainTL.Text = "Головна";
            mainTL.Click += mainTL_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(151, 26);
            toolStripMenuItem2.Text = "Профіль";
            // 
            // exitTL
            // 
            exitTL.Name = "exitTL";
            exitTL.Size = new System.Drawing.Size(151, 26);
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
            clientsMenuItem.Click += clientsMenuItem_Click;
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
            waterCoolingMenuItem.Click += waterCoolingMenuItem_Click;
            // 
            // fanCoolingMenuItem
            // 
            fanCoolingMenuItem.Name = "fanCoolingMenuItem";
            fanCoolingMenuItem.Size = new System.Drawing.Size(185, 26);
            fanCoolingMenuItem.Text = "Fan cooling";
            fanCoolingMenuItem.Click += fanCoolingMenuItem_Click;
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
            blutoothMenuItem.Click += blutoothMenuItem_Click;
            // 
            // wifiMenuItem
            // 
            wifiMenuItem.Name = "wifiMenuItem";
            wifiMenuItem.Size = new System.Drawing.Size(185, 26);
            wifiMenuItem.Text = "Wifi";
            wifiMenuItem.Click += wifiMenuItem_Click;
            // 
            // powerSupplyMenuItem
            // 
            powerSupplyMenuItem.Name = "powerSupplyMenuItem";
            powerSupplyMenuItem.Size = new System.Drawing.Size(185, 26);
            powerSupplyMenuItem.Text = "Power supply";
            powerSupplyMenuItem.Click += powerSupplyMenuItem_Click;
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
            configurationCtrl2.Location = new System.Drawing.Point(12, 53);
            configurationCtrl2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            configurationCtrl2.Name = "configurationCtrl2";
            configurationCtrl2.Size = new System.Drawing.Size(1014, 527);
            configurationCtrl2.TabIndex = 1;
            // 
            // bluetoothManageCtrl1
            // 
            bluetoothManageCtrl1.Location = new System.Drawing.Point(0, 59);
            bluetoothManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bluetoothManageCtrl1.Name = "bluetoothManageCtrl1";
            bluetoothManageCtrl1.Size = new System.Drawing.Size(1275, 859);
            bluetoothManageCtrl1.TabIndex = 2;
            // 
            // clientManageCtrl1
            // 
            clientManageCtrl1.Location = new System.Drawing.Point(0, 59);
            clientManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            clientManageCtrl1.Name = "clientManageCtrl1";
            clientManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            clientManageCtrl1.TabIndex = 3;
            // 
            // cpuManageCtrl1
            // 
            cpuManageCtrl1.Location = new System.Drawing.Point(0, 59);
            cpuManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            cpuManageCtrl1.Name = "cpuManageCtrl1";
            cpuManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            cpuManageCtrl1.TabIndex = 4;
            // 
            // fanCoolingManageCtrl1
            // 
            fanCoolingManageCtrl1.Location = new System.Drawing.Point(0, 41);
            fanCoolingManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fanCoolingManageCtrl1.Name = "fanCoolingManageCtrl1";
            fanCoolingManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            fanCoolingManageCtrl1.TabIndex = 5;
            // 
            // gpuManageCtrl1
            // 
            gpuManageCtrl1.Location = new System.Drawing.Point(0, 43);
            gpuManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            gpuManageCtrl1.Name = "gpuManageCtrl1";
            gpuManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            gpuManageCtrl1.TabIndex = 6;
            // 
            // hddManageCtrl1
            // 
            hddManageCtrl1.Location = new System.Drawing.Point(0, 47);
            hddManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            hddManageCtrl1.Name = "hddManageCtrl1";
            hddManageCtrl1.Size = new System.Drawing.Size(1449, 855);
            hddManageCtrl1.TabIndex = 7;
            // 
            // motherboardManageCtrl1
            // 
            motherboardManageCtrl1.Location = new System.Drawing.Point(0, 41);
            motherboardManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            motherboardManageCtrl1.Name = "motherboardManageCtrl1";
            motherboardManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            motherboardManageCtrl1.TabIndex = 8;
            // 
            // powerSupplyManageCtrl1
            // 
            powerSupplyManageCtrl1.Location = new System.Drawing.Point(0, 41);
            powerSupplyManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            powerSupplyManageCtrl1.Name = "powerSupplyManageCtrl1";
            powerSupplyManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            powerSupplyManageCtrl1.TabIndex = 9;
            // 
            // ramManageCtrl1
            // 
            ramManageCtrl1.Location = new System.Drawing.Point(0, 59);
            ramManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ramManageCtrl1.Name = "ramManageCtrl1";
            ramManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            ramManageCtrl1.TabIndex = 10;
            // 
            // ssdManageCtrl1
            // 
            ssdManageCtrl1.Location = new System.Drawing.Point(0, 47);
            ssdManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            ssdManageCtrl1.Name = "ssdManageCtrl1";
            ssdManageCtrl1.Size = new System.Drawing.Size(1449, 843);
            ssdManageCtrl1.TabIndex = 11;
            // 
            // towerManageCtrl1
            // 
            towerManageCtrl1.Location = new System.Drawing.Point(0, 59);
            towerManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            towerManageCtrl1.Name = "towerManageCtrl1";
            towerManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            towerManageCtrl1.TabIndex = 12;
            // 
            // wateCoolingManageCtrl1
            // 
            wateCoolingManageCtrl1.Location = new System.Drawing.Point(0, 47);
            wateCoolingManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            wateCoolingManageCtrl1.Name = "wateCoolingManageCtrl1";
            wateCoolingManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            wateCoolingManageCtrl1.TabIndex = 13;
            // 
            // wifiManageCtrl1
            // 
            wifiManageCtrl1.Location = new System.Drawing.Point(0, 59);
            wifiManageCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            wifiManageCtrl1.Name = "wifiManageCtrl1";
            wifiManageCtrl1.Size = new System.Drawing.Size(1449, 859);
            wifiManageCtrl1.TabIndex = 14;
            // 
            // catalogCtrl2
            // 
            catalogCtrl2.BackColor = System.Drawing.SystemColors.GrayText;
            catalogCtrl2.Location = new System.Drawing.Point(25, 36);
            catalogCtrl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            catalogCtrl2.Name = "catalogCtrl2";
            catalogCtrl2.Size = new System.Drawing.Size(887, 412);
            catalogCtrl2.TabIndex = 2;
            // 
            // PCBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1013, 576);
            Controls.Add(wifiManageCtrl1);
            Controls.Add(wateCoolingManageCtrl1);
            Controls.Add(towerManageCtrl1);
            Controls.Add(ssdManageCtrl1);
            Controls.Add(ramManageCtrl1);
            Controls.Add(powerSupplyManageCtrl1);
            Controls.Add(motherboardManageCtrl1);
            Controls.Add(hddManageCtrl1);
            Controls.Add(gpuManageCtrl1);
            Controls.Add(fanCoolingManageCtrl1);
            Controls.Add(cpuManageCtrl1);
            Controls.Add(clientManageCtrl1);
            Controls.Add(bluetoothManageCtrl1);
            Controls.Add(catalogCtrl2);
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
        private bluetoothManageCtrl bluetoothManageCtrl1;
        private clientManageCtrl clientManageCtrl1;
        private fanCoolingManageCtrl fanCoolingManageCtrl1;
        private powerSupplyManageCtrl powerSupplyManageCtrl1;
        private wateCoolingManageCtrl wateCoolingManageCtrl1;
        private wifiManageCtrl wifiManageCtrl1;
        private CatalogCtrl catalogCtrl2;
    }
}