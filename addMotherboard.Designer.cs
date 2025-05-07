namespace jenya_lab_7
{
    partial class addMotherboard
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
            this.socketTB = new System.Windows.Forms.TextBox();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.chipsetTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBTN
            // 
            this.closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBTN.Location = new System.Drawing.Point(415, -2);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(48, 42);
            this.closeBTN.TabIndex = 60;
            this.closeBTN.Text = "X";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(157, 298);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(129, 44);
            this.saveBTN.TabIndex = 59;
            this.saveBTN.Text = "Зберегти";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 31);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cost";
            // 
            // costTB
            // 
            this.costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTB.Location = new System.Drawing.Point(245, 165);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(176, 31);
            this.costTB.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 31);
            this.label8.TabIndex = 56;
            this.label8.Text = "Chipset";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 31);
            this.label7.TabIndex = 55;
            this.label7.Text = "Type size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(234, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 54;
            this.label6.Text = "Socket";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Title";
            // 
            // typeSizeTB
            // 
            this.typeSizeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeSizeTB.Location = new System.Drawing.Point(21, 241);
            this.typeSizeTB.Name = "typeSizeTB";
            this.typeSizeTB.Size = new System.Drawing.Size(176, 31);
            this.typeSizeTB.TabIndex = 52;
            // 
            // socketTB
            // 
            this.socketTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socketTB.Location = new System.Drawing.Point(240, 96);
            this.socketTB.Name = "socketTB";
            this.socketTB.Size = new System.Drawing.Size(176, 31);
            this.socketTB.TabIndex = 51;
            // 
            // titleTB
            // 
            this.titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTB.Location = new System.Drawing.Point(21, 96);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(176, 31);
            this.titleTB.TabIndex = 50;
            // 
            // chipsetTB
            // 
            this.chipsetTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chipsetTB.Location = new System.Drawing.Point(21, 169);
            this.chipsetTB.Name = "chipsetTB";
            this.chipsetTB.Size = new System.Drawing.Size(176, 31);
            this.chipsetTB.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 48;
            this.label1.Text = "Додайте motherboard";
            // 
            // addMotherboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 354);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeSizeTB);
            this.Controls.Add(this.socketTB);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.chipsetTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMotherboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addMotherboard";
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
        private System.Windows.Forms.TextBox socketTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox chipsetTB;
        private System.Windows.Forms.Label label1;
    }
}