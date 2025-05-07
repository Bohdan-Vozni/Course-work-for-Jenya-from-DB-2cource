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
            this.closeBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.costTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeSizeTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.fanTypeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fanIncludedRadioBTN = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBTN.Location = new System.Drawing.Point(413, 1);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(48, 42);
            this.closeBTN.TabIndex = 73;
            this.closeBTN.Text = "X";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(155, 301);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(129, 44);
            this.saveBTN.TabIndex = 72;
            this.saveBTN.Text = "Зберегти";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 71;
            this.label3.Text = "Cost";
            // 
            // costTB
            // 
            this.costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTB.Location = new System.Drawing.Point(243, 168);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(176, 31);
            this.costTB.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 31);
            this.label8.TabIndex = 69;
            this.label8.Text = "Fan type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 31);
            this.label7.TabIndex = 68;
            this.label7.Text = "Type size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(232, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 31);
            this.label6.TabIndex = 67;
            this.label6.Text = "Fan included";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 66;
            this.label2.Text = "Title";
            // 
            // typeSizeTB
            // 
            this.typeSizeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeSizeTB.Location = new System.Drawing.Point(19, 244);
            this.typeSizeTB.Name = "typeSizeTB";
            this.typeSizeTB.Size = new System.Drawing.Size(176, 31);
            this.typeSizeTB.TabIndex = 65;
            // 
            // titleTB
            // 
            this.titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTB.Location = new System.Drawing.Point(19, 99);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(176, 31);
            this.titleTB.TabIndex = 63;
            // 
            // fanTypeTB
            // 
            this.fanTypeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fanTypeTB.Location = new System.Drawing.Point(19, 172);
            this.fanTypeTB.Name = "fanTypeTB";
            this.fanTypeTB.Size = new System.Drawing.Size(176, 31);
            this.fanTypeTB.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 61;
            this.label1.Text = "Додайте tower";
            // 
            // fanIncludedRadioBTN
            // 
            this.fanIncludedRadioBTN.AutoSize = true;
            this.fanIncludedRadioBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fanIncludedRadioBTN.Location = new System.Drawing.Point(238, 101);
            this.fanIncludedRadioBTN.Name = "fanIncludedRadioBTN";
            this.fanIncludedRadioBTN.Size = new System.Drawing.Size(146, 32);
            this.fanIncludedRadioBTN.TabIndex = 74;
            this.fanIncludedRadioBTN.Text = "fan included";
            this.fanIncludedRadioBTN.UseVisualStyleBackColor = true;
            // 
            // addTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 354);
            this.Controls.Add(this.fanIncludedRadioBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeSizeTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.fanTypeTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addTower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addTower";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RadioButton fanIncludedRadioBTN;
    }
}