namespace jenya_lab_7
{
    partial class editClient
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
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            phoneTB = new System.Windows.Forms.TextBox();
            clientNameTB = new System.Windows.Forms.TextBox();
            homeAddressTB = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            deleteBTN = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // closeBTN
            // 
            closeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            closeBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            closeBTN.Location = new System.Drawing.Point(420, 0);
            closeBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new System.Drawing.Size(48, 52);
            closeBTN.TabIndex = 80;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // editBTN
            // 
            editBTN.Location = new System.Drawing.Point(79, 258);
            editBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            editBTN.Name = "editBTN";
            editBTN.Size = new System.Drawing.Size(129, 55);
            editBTN.TabIndex = 79;
            editBTN.Text = "Редагувати";
            editBTN.UseVisualStyleBackColor = true;
            editBTN.Click += editBTN_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(26, 153);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(199, 31);
            label8.TabIndex = 78;
            label8.Text = "Домашня адреса";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(237, 65);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(198, 31);
            label6.TabIndex = 77;
            label6.Text = "Номер телефону";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(26, 62);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 31);
            label2.TabIndex = 76;
            label2.Text = "Повне ім'я";
            // 
            // phoneTB
            // 
            phoneTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            phoneTB.Location = new System.Drawing.Point(243, 105);
            phoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            phoneTB.Name = "phoneTB";
            phoneTB.Size = new System.Drawing.Size(176, 31);
            phoneTB.TabIndex = 75;
            // 
            // clientNameTB
            // 
            clientNameTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            clientNameTB.Location = new System.Drawing.Point(32, 105);
            clientNameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            clientNameTB.Name = "clientNameTB";
            clientNameTB.Size = new System.Drawing.Size(176, 31);
            clientNameTB.TabIndex = 74;
            // 
            // homeAddressTB
            // 
            homeAddressTB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            homeAddressTB.Location = new System.Drawing.Point(32, 196);
            homeAddressTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            homeAddressTB.Name = "homeAddressTB";
            homeAddressTB.Size = new System.Drawing.Size(176, 31);
            homeAddressTB.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(123, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(239, 31);
            label1.TabIndex = 72;
            label1.Text = "Відредагуйте клієнта";
            // 
            // deleteBTN
            // 
            deleteBTN.Location = new System.Drawing.Point(243, 258);
            deleteBTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new System.Drawing.Size(129, 55);
            deleteBTN.TabIndex = 81;
            deleteBTN.Text = "Видалити";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // editClient
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(467, 326);
            Controls.Add(deleteBTN);
            Controls.Add(closeBTN);
            Controls.Add(editBTN);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(phoneTB);
            Controls.Add(clientNameTB);
            Controls.Add(homeAddressTB);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "editClient";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "editClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button editBTN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox clientNameTB;
        private System.Windows.Forms.TextBox homeAddressTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBTN;
    }
}