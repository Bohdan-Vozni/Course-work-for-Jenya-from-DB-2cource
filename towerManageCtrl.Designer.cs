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
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TypeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FanIncluded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, Title, TypeSize, FanType, FanIncluded, Cost });
            dataGridView1.Location = new System.Drawing.Point(0, 42);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 423);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 150;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 150;
            // 
            // TypeSize
            // 
            TypeSize.HeaderText = "TypeSize";
            TypeSize.MinimumWidth = 6;
            TypeSize.Name = "TypeSize";
            TypeSize.Width = 125;
            // 
            // FanType
            // 
            FanType.HeaderText = "FanType";
            FanType.MinimumWidth = 6;
            FanType.Name = "FanType";
            FanType.Width = 125;
            // 
            // FanIncluded
            // 
            FanIncluded.HeaderText = "Fan_Included";
            FanIncluded.MinimumWidth = 6;
            FanIncluded.Name = "FanIncluded";
            FanIncluded.Width = 125;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 150;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FanType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FanIncluded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}
