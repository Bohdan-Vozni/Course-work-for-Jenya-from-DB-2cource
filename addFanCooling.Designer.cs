namespace jenya_lab_7
{
    partial class addFanCooling
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
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            typeSizeTB = new System.Windows.Forms.TextBox();
            titleTB = new System.Windows.Forms.TextBox();
            heatRemovalTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(419, -1);
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
            saveBTN.Location = new System.Drawing.Point(165, 267);
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
            label3.Location = new System.Drawing.Point(247, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 31);
            label3.TabIndex = 58;
            label3.Text = "Cost";
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(253, 190);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 57;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(31, 152);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(154, 31);
            label8.TabIndex = 56;
            label8.Text = "Heat removal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(242, 64);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 31);
            label6.TabIndex = 54;
            label6.Text = "Type Size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(31, 61);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(59, 31);
            label2.TabIndex = 53;
            label2.Text = "Title";
            // 
            // typeSizeTB
            // 
            typeSizeTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            typeSizeTB.Location = new System.Drawing.Point(248, 104);
            typeSizeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            typeSizeTB.Name = "typeSizeTB";
            typeSizeTB.Size = new System.Drawing.Size(176, 31);
            typeSizeTB.TabIndex = 51;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(37, 104);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 50;
            // 
            // heatRemovalTB
            // 
            heatRemovalTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            heatRemovalTB.Location = new System.Drawing.Point(37, 195);
            heatRemovalTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            heatRemovalTB.Name = "heatRemovalTB";
            heatRemovalTB.Size = new System.Drawing.Size(176, 31);
            heatRemovalTB.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(37, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(365, 31);
            label1.TabIndex = 48;
            label1.Text = "Додайте башенне охолодження";
            // 
            // addFanCooling
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 352);
            Controls.Add(closeBTN);
            Controls.Add(saveBTN);
            Controls.Add(label3);
            Controls.Add(costTB);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(typeSizeTB);
            Controls.Add(titleTB);
            Controls.Add(heatRemovalTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "addFanCooling";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addFanCooling";
            Load += addFanCooling_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeSizeTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.TextBox heatRemovalTB;
        private System.Windows.Forms.Label label1;
    }
}