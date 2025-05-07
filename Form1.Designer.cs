namespace jenya_lab_7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.authBTN = new System.Windows.Forms.Button();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitAppBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authBTN
            // 
            this.authBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authBTN.Location = new System.Drawing.Point(234, 263);
            this.authBTN.Name = "authBTN";
            this.authBTN.Size = new System.Drawing.Size(156, 45);
            this.authBTN.TabIndex = 0;
            this.authBTN.Text = "Login";
            this.authBTN.UseVisualStyleBackColor = true;
            this.authBTN.Click += new System.EventHandler(this.authBTN_Click);
            // 
            // userNameTB
            // 
            this.userNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameTB.Location = new System.Drawing.Point(213, 138);
            this.userNameTB.Multiline = true;
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(206, 37);
            this.userNameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(213, 212);
            this.passwordTB.Multiline = true;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(206, 37);
            this.passwordTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // exitAppBTN
            // 
            this.exitAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitAppBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitAppBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitAppBTN.Location = new System.Drawing.Point(583, 0);
            this.exitAppBTN.Name = "exitAppBTN";
            this.exitAppBTN.Size = new System.Drawing.Size(48, 42);
            this.exitAppBTN.TabIndex = 5;
            this.exitAppBTN.Text = "X";
            this.exitAppBTN.UseVisualStyleBackColor = true;
            this.exitAppBTN.Click += new System.EventHandler(this.exitAppBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(207, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конфігуратор ПК";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Створено Березюк Євгеній";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(631, 435);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitAppBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.authBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authorize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button authBTN;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitAppBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

