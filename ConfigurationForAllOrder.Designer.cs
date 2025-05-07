namespace jenya_lab_7
{
    partial class ConfigurationForAllOrder
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
            result_dataGridView = new System.Windows.Forms.DataGridView();
            return_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)result_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // result_dataGridView
            // 
            result_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            result_dataGridView.Location = new System.Drawing.Point(32, 12);
            result_dataGridView.Name = "result_dataGridView";
            result_dataGridView.Size = new System.Drawing.Size(911, 490);
            result_dataGridView.TabIndex = 0;
            result_dataGridView.CellContentClick += result_dataGridView_CellContentClick;
            // 
            // return_button
            // 
            return_button.Location = new System.Drawing.Point(126, 508);
            return_button.Name = "return_button";
            return_button.Size = new System.Drawing.Size(776, 37);
            return_button.TabIndex = 1;
            return_button.Text = "Назад";
            return_button.UseVisualStyleBackColor = true;
            // 
            // ConfigurationForAllOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(955, 546);
            Controls.Add(return_button);
            Controls.Add(result_dataGridView);
            Name = "ConfigurationForAllOrder";
            Text = "ConfigurationForAllOrder";
            Load += ConfigurationForAllOrder_Load;
            ((System.ComponentModel.ISupportInitialize)result_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView result_dataGridView;
        private System.Windows.Forms.Button return_button;
    }
}