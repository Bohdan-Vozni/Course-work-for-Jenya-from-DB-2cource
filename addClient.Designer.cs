namespace jenya_lab_7
{
    partial class addClient
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
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            phoneTB = new System.Windows.Forms.TextBox();
            clientNameTB = new System.Windows.Forms.TextBox();
            homeAddressTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(369, -2);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(42, 39);
            closeBTN.TabIndex = 71;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // saveBTN
            // 
            saveBTN.Location = new System.Drawing.Point(140, 190);
            saveBTN.Name = "saveBTN";
            saveBTN.Size = new System.Drawing.Size(113, 41);
            saveBTN.TabIndex = 70;
            saveBTN.Text = "Зберегти";
            saveBTN.UseVisualStyleBackColor = true;
            saveBTN.Click += saveBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(24, 112);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(164, 25);
            label8.TabIndex = 67;
            label8.Text = "Домашня адреса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(209, 46);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(162, 25);
            label6.TabIndex = 66;
            label6.Text = "Номер телефону";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(24, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(108, 25);
            label2.TabIndex = 65;
            label2.Text = "Повне ім'я";
            // 
            // phoneTB
            // 
            phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            phoneTB.Location = new System.Drawing.Point(214, 76);
            phoneTB.Name = "phoneTB";
            phoneTB.Size = new System.Drawing.Size(154, 27);
            phoneTB.TabIndex = 64;
            // 
            // clientNameTB
            // 
            clientNameTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            clientNameTB.Location = new System.Drawing.Point(30, 76);
            clientNameTB.Name = "clientNameTB";
            clientNameTB.Size = new System.Drawing.Size(154, 27);
            clientNameTB.TabIndex = 63;
            // 
            // homeAddressTB
            // 
            homeAddressTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            homeAddressTB.Location = new System.Drawing.Point(30, 145);
            homeAddressTB.Name = "homeAddressTB";
            homeAddressTB.Size = new System.Drawing.Size(154, 27);
            homeAddressTB.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(109, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 25);
            label1.TabIndex = 61;
            label1.Text = "Додайте Клієнта";
            // 
            // addClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(409, 244);
            Controls.Add(closeBTN);
            Controls.Add(saveBTN);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(phoneTB);
            Controls.Add(clientNameTB);
            Controls.Add(homeAddressTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "addClient";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addClient";
            Load += addClient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.TextBox homeAddressTB;
        private System.Windows.Forms.Label label1;
    }
}