namespace jenya_lab_7
{
    partial class addBluetooth
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
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            generationTB = new System.Windows.Forms.TextBox();
            titleTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(417, 0);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 60;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new System.Drawing.Point(170, 260);
            saveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new System.Drawing.Size(129, 55);
            saveBTN.TabIndex = 59;
            saveBTN.Text = "Зберегти";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(29, 158);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 31);
            label3.TabIndex = 58;
            label3.Text = "Cost";
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(35, 196);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(240, 65);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(129, 31);
            label6.TabIndex = 54;
            label6.Text = "Generation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(29, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 31);
            label2.TabIndex = 53;
            label2.Text = "Title";
            // 
            // generationTB
            // 
            generationTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            generationTB.Location = new System.Drawing.Point(246, 105);
            generationTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            generationTB.Name = "generationTB";
            generationTB.Size = new System.Drawing.Size(176, 31);
            generationTB.TabIndex = 51;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(35, 105);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(86, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(277, 31);
            label1.TabIndex = 48;
            label1.Text = "Додайте блютуз модуль";
            // 
            // addBluetooth
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 337);
            Controls.Add(closeBTN);
            Controls.Add(saveBTN);
            Controls.Add(label3);
            Controls.Add(costTB);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(generationTB);
            Controls.Add(titleTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "addBluetooth";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addBluetooth";
            Load += addBluetooth_Load;
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
        private System.Windows.Forms.TextBox readingSpeedTB;
        private System.Windows.Forms.TextBox generationTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox memoryQuantityTB;
        private System.Windows.Forms.Label label1;
    }
}