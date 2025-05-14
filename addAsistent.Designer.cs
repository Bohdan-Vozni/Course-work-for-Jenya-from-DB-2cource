namespace jenya_lab_7
{
    partial class addAsistent
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
            name_textBox = new System.Windows.Forms.TextBox();
            phone_textBox = new System.Windows.Forms.TextBox();
            add_button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // name_textBox
            // 
            name_textBox.Location = new System.Drawing.Point(180, 79);
            name_textBox.Name = "name_textBox";
            name_textBox.Size = new System.Drawing.Size(205, 23);
            name_textBox.TabIndex = 0;
            // 
            // phone_textBox
            // 
            phone_textBox.Location = new System.Drawing.Point(180, 123);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new System.Drawing.Size(205, 23);
            phone_textBox.TabIndex = 1;
            // 
            // add_button
            // 
            add_button.Location = new System.Drawing.Point(59, 181);
            add_button.Name = "add_button";
            add_button.Size = new System.Drawing.Size(269, 44);
            add_button.TabIndex = 2;
            add_button.Text = "Додати";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "ПІБ спеціаліста";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 126);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 15);
            label2.TabIndex = 4;
            label2.Text = "Номер телефона";
            // 
            // addAsistent
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 276);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(add_button);
            Controls.Add(phone_textBox);
            Controls.Add(name_textBox);
            Name = "addAsistent";
            Text = "addAsistent";
            Load += addAsistent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}