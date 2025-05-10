namespace jenya_lab_7
{
    partial class addTower
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
            costTB = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            typeSizeTB = new System.Windows.Forms.TextBox();
            titleTB = new System.Windows.Forms.TextBox();
            fanTypeTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            fanIncludedTB = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(413, 1);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 73;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new System.Drawing.Point(155, 376);
            saveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new System.Drawing.Size(129, 55);
            saveBTN.TabIndex = 72;
            saveBTN.Text = "Зберегти";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(237, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 31);
            label3.TabIndex = 71;
            label3.Text = "Ціна";
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(243, 210);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 70;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(13, 172);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(133, 31);
            label8.TabIndex = 69;
            label8.Text = "Тип кулера";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(13, 268);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 31);
            label7.TabIndex = 68;
            label7.Text = "Розмір";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(232, 58);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(146, 62);
            label6.TabIndex = 67;
            label6.Text = "Комплектні \r\nкулери\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(13, 81);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 31);
            label2.TabIndex = 66;
            label2.Text = "Назва";
            // 
            // typeSizeTB
            // 
            typeSizeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            typeSizeTB.Location = new System.Drawing.Point(19, 305);
            typeSizeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            typeSizeTB.Name = "typeSizeTB";
            typeSizeTB.Size = new System.Drawing.Size(176, 31);
            typeSizeTB.TabIndex = 65;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(19, 124);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 63;
            // 
            // fanTypeTB
            // 
            fanTypeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            fanTypeTB.Location = new System.Drawing.Point(19, 215);
            fanTypeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fanTypeTB.Name = "fanTypeTB";
            fanTypeTB.Size = new System.Drawing.Size(176, 31);
            fanTypeTB.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(125, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 31);
            label1.TabIndex = 61;
            label1.Text = "Додайте корпус";
            // 
            // fanIncludedTB
            // 
            fanIncludedTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            fanIncludedTB.Location = new System.Drawing.Point(232, 124);
            fanIncludedTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            fanIncludedTB.Name = "fanIncludedTB";
            fanIncludedTB.Size = new System.Drawing.Size(176, 31);
            fanIncludedTB.TabIndex = 74;
            // 
            // addTower
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(461, 442);
            Controls.Add(fanIncludedTB);
            Controls.Add(closeBTN);
            Controls.Add(saveBTN);
            Controls.Add(label3);
            Controls.Add(costTB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(typeSizeTB);
            Controls.Add(titleTB);
            Controls.Add(fanTypeTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "addTower";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addTower";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeSizeTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox fanTypeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fanIncludedTB;
    }
}