﻿namespace jenya_lab_7
{
    partial class addWifi
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
            closeBTN.Location = new System.Drawing.Point(419, -3);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 69;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new System.Drawing.Point(172, 257);
            saveBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new System.Drawing.Size(129, 55);
            saveBTN.TabIndex = 68;
            saveBTN.Text = "Зберегти";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(31, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 31);
            label3.TabIndex = 67;
            label3.Text = "Ціна";
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(37, 193);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(242, 62);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(130, 31);
            label6.TabIndex = 65;
            label6.Text = "Покоління";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(31, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 31);
            label2.TabIndex = 64;
            label2.Text = "Назва";
            // 
            // generationTB
            // 
            generationTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            generationTB.Location = new System.Drawing.Point(248, 102);
            generationTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            generationTB.Name = "generationTB";
            generationTB.Size = new System.Drawing.Size(176, 31);
            generationTB.TabIndex = 63;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(37, 102);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(109, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 31);
            label1.TabIndex = 70;
            label1.Text = "Додайте wifi-адаптер";
            // 
            // addWifi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 337);
            Controls.Add(label1);
            Controls.Add(closeBTN);
            Controls.Add(saveBTN);
            Controls.Add(label3);
            Controls.Add(costTB);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(generationTB);
            Controls.Add(titleTB);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "addWifi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addWifi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox generationTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label1;
    }
}