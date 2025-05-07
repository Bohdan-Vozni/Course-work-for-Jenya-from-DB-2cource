namespace jenya_lab_7
{
    partial class addGpu
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
            this.closeBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clockTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.threadsTB = new System.Windows.Forms.TextBox();
            this.cacheTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.coresTB = new System.Windows.Forms.TextBox();
            this.vramTypeTB = new System.Windows.Forms.TextBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vramQuantTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBTN.Location = new System.Drawing.Point(423, -2);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(48, 42);
            this.closeBTN.TabIndex = 65;
            this.closeBTN.Text = "X";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(173, 341);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(129, 44);
            this.saveBTN.TabIndex = 64;
            this.saveBTN.Text = "Зберегти";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 31);
            this.label3.TabIndex = 63;
            this.label3.Text = "Clock";
            // 
            // clockTB
            // 
            this.clockTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clockTB.Location = new System.Drawing.Point(47, 291);
            this.clockTB.Name = "clockTB";
            this.clockTB.Size = new System.Drawing.Size(176, 31);
            this.clockTB.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 31);
            this.label8.TabIndex = 61;
            this.label8.Text = "Cores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 60;
            this.label7.Text = "Threads";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "Cache";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(242, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 58;
            this.label5.Text = "VRAM type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 56;
            this.label2.Text = "Title";
            // 
            // threadsTB
            // 
            this.threadsTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threadsTB.Location = new System.Drawing.Point(47, 227);
            this.threadsTB.Name = "threadsTB";
            this.threadsTB.Size = new System.Drawing.Size(176, 31);
            this.threadsTB.TabIndex = 55;
            // 
            // cacheTB
            // 
            this.cacheTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cacheTB.Location = new System.Drawing.Point(248, 82);
            this.cacheTB.Name = "cacheTB";
            this.cacheTB.Size = new System.Drawing.Size(176, 31);
            this.cacheTB.TabIndex = 54;
            // 
            // titleTB
            // 
            this.titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTB.Location = new System.Drawing.Point(47, 82);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(176, 31);
            this.titleTB.TabIndex = 53;
            // 
            // coresTB
            // 
            this.coresTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coresTB.Location = new System.Drawing.Point(47, 155);
            this.coresTB.Name = "coresTB";
            this.coresTB.Size = new System.Drawing.Size(176, 31);
            this.coresTB.TabIndex = 52;
            // 
            // vramTypeTB
            // 
            this.vramTypeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vramTypeTB.Location = new System.Drawing.Point(248, 155);
            this.vramTypeTB.Name = "vramTypeTB";
            this.vramTypeTB.Size = new System.Drawing.Size(176, 31);
            this.vramTypeTB.TabIndex = 51;
            // 
            // costTB
            // 
            this.costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTB.Location = new System.Drawing.Point(248, 291);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(176, 31);
            this.costTB.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Додайте GPU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 31);
            this.label9.TabIndex = 67;
            this.label9.Text = "VRAM quantity";
            // 
            // vramQuantTB
            // 
            this.vramQuantTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vramQuantTB.Location = new System.Drawing.Point(248, 227);
            this.vramQuantTB.Name = "vramQuantTB";
            this.vramQuantTB.Size = new System.Drawing.Size(176, 31);
            this.vramQuantTB.TabIndex = 66;
            // 
            // addGpu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 397);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vramQuantTB);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clockTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.threadsTB);
            this.Controls.Add(this.cacheTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.coresTB);
            this.Controls.Add(this.vramTypeTB);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addGpu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addGpu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clockTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox threadsTB;
        private System.Windows.Forms.TextBox cacheTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox coresTB;
        private System.Windows.Forms.TextBox vramTypeTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vramQuantTB;
    }
}