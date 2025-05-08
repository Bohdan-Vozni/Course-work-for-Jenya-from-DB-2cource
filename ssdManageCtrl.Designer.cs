namespace jenya_lab_7
{
    partial class ssdManageCtrl
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
            openAddSsdBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddSsdBtn
            // 
            openAddSsdBtn.Location = new System.Drawing.Point(3, 472);
            openAddSsdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddSsdBtn.Name = "openAddSsdBtn";
            openAddSsdBtn.Size = new System.Drawing.Size(108, 29);
            openAddSsdBtn.TabIndex = 9;
            openAddSsdBtn.Text = "Додати";
            openAddSsdBtn.UseVisualStyleBackColor = true;
            openAddSsdBtn.Click += openAddSsdBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 32);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 433);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // ssdManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openAddSsdBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ssdManageCtrl";
            Size = new System.Drawing.Size(1014, 520);
            Load += ssdManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openAddSsdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
