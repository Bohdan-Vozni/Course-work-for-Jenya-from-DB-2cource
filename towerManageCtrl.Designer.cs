namespace jenya_lab_7
{
    partial class towerManageCtrl
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
            openAddTowerBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddTowerBtn
            // 
            openAddTowerBtn.Location = new System.Drawing.Point(6, 472);
            openAddTowerBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddTowerBtn.Name = "openAddTowerBtn";
            openAddTowerBtn.Size = new System.Drawing.Size(108, 29);
            openAddTowerBtn.TabIndex = 10;
            openAddTowerBtn.Text = "Додати";
            openAddTowerBtn.UseVisualStyleBackColor = true;
            openAddTowerBtn.Click += openAddTowerBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 42);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 423);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // towerManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openAddTowerBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "towerManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += towerManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openAddTowerBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
