namespace jenya_lab_7
{
    partial class Configurations
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            exitAppBTN = new System.Windows.Forms.Button();
            btnExportPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(1256, 490);
            dataGridView1.TabIndex = 1;
            // 
            // exitAppBTN
            // 
            exitAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            exitAppBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            exitAppBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            exitAppBTN.Location = new System.Drawing.Point(1220, 1);
            exitAppBTN.Name = "exitAppBTN";
            exitAppBTN.Size = new System.Drawing.Size(48, 39);
            exitAppBTN.TabIndex = 6;
            exitAppBTN.Text = "X";
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += exitAppBTN_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            btnExportPDF.Location = new System.Drawing.Point(0, 507);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new System.Drawing.Size(152, 29);
            btnExportPDF.TabIndex = 7;
            btnExportPDF.Text = "Зберегти в PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // Configurations
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1268, 537);
            Controls.Add(btnExportPDF);
            Controls.Add(exitAppBTN);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Configurations";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Configurations";
            Load += Configurations_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitAppBTN;
        private System.Windows.Forms.Button btnExportPDF;
    }
}