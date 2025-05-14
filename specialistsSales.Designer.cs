namespace jenya_lab_7
{
    partial class specialistsSales
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
            exitAppBTN = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            specialists = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // exitAppBTN
            // 
            exitAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            exitAppBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            exitAppBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            exitAppBTN.Location = new System.Drawing.Point(929, 0);
            exitAppBTN.Name = "exitAppBTN";
            exitAppBTN.Size = new System.Drawing.Size(48, 41);
            exitAppBTN.TabIndex = 7;
            exitAppBTN.Text = "X";
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += exitAppBTN_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-1, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(978, 404);
            dataGridView1.TabIndex = 8;
            // 
            // specialists
            // 
            specialists.FormattingEnabled = true;
            specialists.Location = new System.Drawing.Point(-1, 0);
            specialists.Name = "specialists";
            specialists.Size = new System.Drawing.Size(308, 28);
            specialists.TabIndex = 9;
            specialists.SelectedIndexChanged += specialists_SelectedIndexChanged;
            // 
            // specialistsSales
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(976, 450);
            Controls.Add(specialists);
            Controls.Add(dataGridView1);
            Controls.Add(exitAppBTN);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "specialistsSales";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "specialistsSales";
            Load += specialistsSales_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button exitAppBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox specialists;
    }
}