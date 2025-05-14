namespace jenya_lab_7
{
    partial class AsistentForUpdateAndDelete_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new System.Windows.Forms.DataGridView();
            name_TextBox = new System.Windows.Forms.TextBox();
            phone_textBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            update_button = new System.Windows.Forms.Button();
            delete_buttoan = new System.Windows.Forms.Button();
            updeteData_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new System.Drawing.Point(346, 27);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new System.Drawing.Size(537, 351);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // name_TextBox
            // 
            name_TextBox.Location = new System.Drawing.Point(73, 66);
            name_TextBox.Name = "name_TextBox";
            name_TextBox.Size = new System.Drawing.Size(254, 23);
            name_TextBox.TabIndex = 1;
            // 
            // phone_textBox
            // 
            phone_textBox.Location = new System.Drawing.Point(198, 115);
            phone_textBox.Name = "phone_textBox";
            phone_textBox.Size = new System.Drawing.Size(129, 23);
            phone_textBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(22, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 25);
            label1.TabIndex = 3;
            label1.Text = "ПІБ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label2.Location = new System.Drawing.Point(22, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(170, 25);
            label2.TabIndex = 4;
            label2.Text = "Номер телефону";
            // 
            // update_button
            // 
            update_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            update_button.Location = new System.Drawing.Point(73, 179);
            update_button.Name = "update_button";
            update_button.Size = new System.Drawing.Size(185, 35);
            update_button.TabIndex = 5;
            update_button.Text = "Оновити";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += update_button_Click;
            // 
            // delete_buttoan
            // 
            delete_buttoan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            delete_buttoan.Location = new System.Drawing.Point(73, 240);
            delete_buttoan.Name = "delete_buttoan";
            delete_buttoan.Size = new System.Drawing.Size(185, 35);
            delete_buttoan.TabIndex = 6;
            delete_buttoan.Text = "Видалити";
            delete_buttoan.UseVisualStyleBackColor = true;
            delete_buttoan.Click += delete_buttoan_Click;
            // 
            // updeteData_button
            // 
            updeteData_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            updeteData_button.Location = new System.Drawing.Point(73, 297);
            updeteData_button.Name = "updeteData_button";
            updeteData_button.Size = new System.Drawing.Size(185, 35);
            updeteData_button.TabIndex = 7;
            updeteData_button.Text = "Оновити дані ";
            updeteData_button.UseVisualStyleBackColor = true;
            updeteData_button.Click += updeteData_button_Click;
            // 
            // AsistentForUpdateAndDelete_UserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(updeteData_button);
            Controls.Add(delete_buttoan);
            Controls.Add(update_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(phone_textBox);
            Controls.Add(name_TextBox);
            Controls.Add(dataGridView);
            Name = "AsistentForUpdateAndDelete_UserControl";
            Size = new System.Drawing.Size(886, 396);
            Load += AsistentForUpdateAndDelete_UserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_buttoan;
        private System.Windows.Forms.Button updeteData_button;
    }
}
