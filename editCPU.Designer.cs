namespace jenya_lab_7
{
    partial class editCPU
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
            editBTN = new System.Windows.Forms.Button();
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
            architectureTB = new System.Windows.Forms.TextBox();
            costTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            deleteBTN = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(420, -1);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 65;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // editBTN
            // 
            editBTN.Location = new System.Drawing.Point(86, 428);
            editBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            editBTN.Name = "editBTN";
            editBTN.Size = new System.Drawing.Size(129, 55);
            editBTN.TabIndex = 64;
            editBTN.Text = "Редагуварити";
            editBTN.UseVisualStyleBackColor = true;
            editBTN.Click += editBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(33, 327);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(111, 31);
            label3.TabIndex = 63;
            label3.Text = "Таймінги";
            // 
            // clockTB
            // 
            clockTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            clockTB.Location = new System.Drawing.Point(39, 365);
            clockTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            clockTB.Name = "clockTB";
            clockTB.Size = new System.Drawing.Size(176, 31);
            clockTB.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(33, 152);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(67, 31);
            label8.TabIndex = 61;
            label8.Text = "Ядра";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(33, 247);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(95, 31);
            label7.TabIndex = 60;
            label7.Text = "Потоки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(234, 63);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 31);
            label6.TabIndex = 59;
            label6.Text = "Кеш";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(234, 152);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(143, 31);
            label5.TabIndex = 58;
            label5.Text = "Архітектура";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(234, 242);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 31);
            label4.TabIndex = 57;
            label4.Text = "Ціна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(33, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 31);
            label2.TabIndex = 56;
            label2.Text = "Назва";
            // 
            // threadsTB
            // 
            threadsTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            threadsTB.Location = new System.Drawing.Point(39, 285);
            threadsTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            threadsTB.Name = "threadsTB";
            threadsTB.Size = new System.Drawing.Size(176, 31);
            threadsTB.TabIndex = 55;
            // 
            // cacheTB
            // 
            cacheTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            cacheTB.Location = new System.Drawing.Point(240, 103);
            cacheTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cacheTB.Name = "cacheTB";
            cacheTB.Size = new System.Drawing.Size(176, 31);
            cacheTB.TabIndex = 54;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(39, 103);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 53;
            // 
            // coresTB
            // 
            coresTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            coresTB.Location = new System.Drawing.Point(39, 195);
            coresTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            coresTB.Name = "coresTB";
            coresTB.Size = new System.Drawing.Size(176, 31);
            coresTB.TabIndex = 52;
            // 
            // architectureTB
            // 
            architectureTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            architectureTB.Location = new System.Drawing.Point(240, 195);
            architectureTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            architectureTB.Name = "architectureTB";
            architectureTB.Size = new System.Drawing.Size(176, 31);
            architectureTB.TabIndex = 51;
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(240, 285);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(86, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(268, 31);
            label1.TabIndex = 49;
            label1.Text = "Відредагуйте процесор";
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new System.Drawing.Point(246, 428);
            deleteBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new System.Drawing.Size(129, 55);
            deleteBTN.TabIndex = 66;
            deleteBTN.Text = "Видалити";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // editCPU
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 496);
            Controls.Add(deleteBTN);
            Controls.Add(closeBTN);
            Controls.Add(editBTN);
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
            Controls.Add(architectureTB);
            Controls.Add(costTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "editCPU";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "editCPU";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button editBTN;
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
        private System.Windows.Forms.TextBox architectureTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBTN;
    }
}