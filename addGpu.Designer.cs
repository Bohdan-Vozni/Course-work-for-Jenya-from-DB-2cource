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
            closeBTN = new System.Windows.Forms.Button();
            saveBTN = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            clockTB = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            threadsTB = new System.Windows.Forms.TextBox();
            cacheTB = new System.Windows.Forms.TextBox();
            titleTB = new System.Windows.Forms.TextBox();
            coresTB = new System.Windows.Forms.TextBox();
            vramTypeTB = new System.Windows.Forms.TextBox();
            costTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            vramQuantTB = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(423, -2);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 65;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new System.Drawing.Point(173, 426);
            saveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new System.Drawing.Size(129, 55);
            saveBTN.TabIndex = 64;
            saveBTN.Text = "Зберегти";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(41, 326);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 31);
            label3.TabIndex = 63;
            label3.Text = "Clock";
            // 
            // clockTB
            // 
            clockTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            clockTB.Location = new System.Drawing.Point(47, 364);
            clockTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            clockTB.Name = "clockTB";
            clockTB.Size = new System.Drawing.Size(176, 31);
            clockTB.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(41, 151);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 31);
            label8.TabIndex = 61;
            label8.Text = "Cores";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(41, 246);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(97, 31);
            label7.TabIndex = 60;
            label7.Text = "Threads";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(242, 62);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(76, 31);
            label6.TabIndex = 59;
            label6.Text = "Cache";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(242, 151);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(131, 31);
            label5.TabIndex = 58;
            label5.Text = "VRAM type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(242, 321);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 31);
            label4.TabIndex = 57;
            label4.Text = "Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(41, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 31);
            label2.TabIndex = 56;
            label2.Text = "Title";
            // 
            // threadsTB
            // 
            threadsTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            threadsTB.Location = new System.Drawing.Point(47, 284);
            threadsTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            threadsTB.Name = "threadsTB";
            threadsTB.Size = new System.Drawing.Size(176, 31);
            threadsTB.TabIndex = 55;
            // 
            // cacheTB
            // 
            cacheTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            cacheTB.Location = new System.Drawing.Point(248, 102);
            cacheTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cacheTB.Name = "cacheTB";
            cacheTB.Size = new System.Drawing.Size(176, 31);
            cacheTB.TabIndex = 54;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(47, 102);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 53;
            // 
            // coresTB
            // 
            coresTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            coresTB.Location = new System.Drawing.Point(47, 194);
            coresTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            coresTB.Name = "coresTB";
            coresTB.Size = new System.Drawing.Size(176, 31);
            coresTB.TabIndex = 52;
            // 
            // vramTypeTB
            // 
            vramTypeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            vramTypeTB.Location = new System.Drawing.Point(248, 194);
            vramTypeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            vramTypeTB.Name = "vramTypeTB";
            vramTypeTB.Size = new System.Drawing.Size(176, 31);
            vramTypeTB.TabIndex = 51;
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(248, 364);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(113, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(230, 31);
            label1.TabIndex = 49;
            label1.Text = "Додайте відеокарту";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(242, 241);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(171, 31);
            label9.TabIndex = 67;
            label9.Text = "VRAM quantity";
            // 
            // vramQuantTB
            // 
            vramQuantTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            vramQuantTB.Location = new System.Drawing.Point(248, 284);
            vramQuantTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            vramQuantTB.Name = "vramQuantTB";
            vramQuantTB.Size = new System.Drawing.Size(176, 31);
            vramQuantTB.TabIndex = 66;
            // 
            // addGpu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 496);
            Controls.Add(label9);
            Controls.Add(vramQuantTB);
            Controls.Add(closeBTN);
            Controls.Add(saveBTN);
            Controls.Add(label3);
            Controls.Add(clockTB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(threadsTB);
            Controls.Add(cacheTB);
            Controls.Add(titleTB);
            Controls.Add(coresTB);
            Controls.Add(vramTypeTB);
            Controls.Add(costTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "addGpu";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addGpu";
            ResumeLayout(false);
            PerformLayout();

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