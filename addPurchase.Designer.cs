namespace jenya_lab_7
{
    partial class addPurchase
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
            client_comboBox = new System.Windows.Forms.ComboBox();
            sdpecialist_comboBox = new System.Windows.Forms.ComboBox();
            addPurchase_button = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // client_comboBox
            // 
            client_comboBox.FormattingEnabled = true;
            client_comboBox.Location = new System.Drawing.Point(126, 45);
            client_comboBox.Name = "client_comboBox";
            client_comboBox.Size = new System.Drawing.Size(268, 23);
            client_comboBox.TabIndex = 0;
            // 
            // sdpecialist_comboBox
            // 
            sdpecialist_comboBox.FormattingEnabled = true;
            sdpecialist_comboBox.Location = new System.Drawing.Point(126, 103);
            sdpecialist_comboBox.Name = "sdpecialist_comboBox";
            sdpecialist_comboBox.Size = new System.Drawing.Size(268, 23);
            sdpecialist_comboBox.TabIndex = 1;
            // 
            // addPurchase_button
            // 
            addPurchase_button.Location = new System.Drawing.Point(91, 154);
            addPurchase_button.Name = "addPurchase_button";
            addPurchase_button.Size = new System.Drawing.Size(178, 43);
            addPurchase_button.TabIndex = 5;
            addPurchase_button.Text = "Додати замовлення";
            addPurchase_button.UseVisualStyleBackColor = true;
            addPurchase_button.Click += addPurchase_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(12, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 21);
            label1.TabIndex = 6;
            label1.Text = "Клієнт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label2.Location = new System.Drawing.Point(12, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 21);
            label2.TabIndex = 7;
            label2.Text = "Спеціаліст";
            // 
            // addPurchase
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 211);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addPurchase_button);
            Controls.Add(sdpecialist_comboBox);
            Controls.Add(client_comboBox);
            Name = "addPurchase";
            Text = "addPurchase";
            Load += addPurchase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox client_comboBox;
        private System.Windows.Forms.ComboBox sdpecialist_comboBox;
        private System.Windows.Forms.Button addPurchase_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}