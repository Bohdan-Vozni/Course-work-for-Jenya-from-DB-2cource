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
            result_dataGridView.Location = new System.Drawing.Point(37, 16);
            result_dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            result_dataGridView.Name = "result_dataGridView";
            result_dataGridView.RowHeadersWidth = 51;
            result_dataGridView.Size = new System.Drawing.Size(1041, 653);
            result_dataGridView.TabIndex = 0;
            result_dataGridView.CellContentClick += result_dataGridView_CellContentClick;
            // 
            // return_button
            // 
            return_button.Location = new System.Drawing.Point(144, 677);
            return_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            return_button.Name = "return_button";
            return_button.Size = new System.Drawing.Size(887, 49);
            return_button.TabIndex = 1;
            return_button.Text = "Назад";
            return_button.UseVisualStyleBackColor = true;
            return_button.Click += return_button_Click;
            // 
            // ConfigurationForAllOrder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1091, 728);
            Controls.Add(return_button);
            Controls.Add(result_dataGridView);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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