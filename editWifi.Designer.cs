namespace jenya_lab_7
{
    partial class editWifi
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
            deleteBTN = new System.Windows.Forms.Button();
            closeBTN = new System.Windows.Forms.Button();
            editBTN = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            costTB = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            generationTB = new System.Windows.Forms.TextBox();
            titleTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new System.Drawing.Point(261, 256);
            deleteBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new System.Drawing.Size(129, 55);
            deleteBTN.TabIndex = 80;
            deleteBTN.Text = "Видалити";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(413, -3);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 79;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // editBTN
            // 
            editBTN.Location = new System.Drawing.Point(105, 256);
            editBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            editBTN.Name = "editBTN";
            editBTN.Size = new System.Drawing.Size(129, 55);
            editBTN.TabIndex = 78;
            editBTN.Text = "Редагувати";
            editBTN.UseVisualStyleBackColor = true;
            editBTN.Click += editBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(25, 155);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 31);
            label3.TabIndex = 77;
            label3.Text = "Ціна";
            // 
            // costTB
            // 
            costTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            costTB.Location = new System.Drawing.Point(31, 193);
            costTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            costTB.Name = "costTB";
            costTB.Size = new System.Drawing.Size(176, 31);
            costTB.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(236, 62);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(130, 31);
            label6.TabIndex = 75;
            label6.Text = "Покоління";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(25, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 31);
            label2.TabIndex = 74;
            label2.Text = "Назва";
            // 
            // generationTB
            // 
            generationTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            generationTB.Location = new System.Drawing.Point(242, 102);
            generationTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            generationTB.Name = "generationTB";
            generationTB.Size = new System.Drawing.Size(176, 31);
            generationTB.TabIndex = 73;
            // 
            // titleTB
            // 
            titleTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            titleTB.Location = new System.Drawing.Point(31, 102);
            titleTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            titleTB.Name = "titleTB";
            titleTB.Size = new System.Drawing.Size(176, 31);
            titleTB.TabIndex = 72;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(64, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(287, 31);
            label1.TabIndex = 71;
            label1.Text = "Відредагуйте wifi-модуль";
            // 
            // editWifi
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(458, 337);
            Controls.Add(deleteBTN);
            Controls.Add(closeBTN);
            Controls.Add(editBTN);
            Controls.Add(label3);
            Controls.Add(costTB);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(generationTB);
            Controls.Add(titleTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "editWifi";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "editWifi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox generationTB;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label1;
    }
}