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
            this.openDeleteTowerBtn = new System.Windows.Forms.Button();
            this.openEditTowerBtn = new System.Windows.Forms.Button();
            this.openAddTowerBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FanType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FanIncluded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDeleteTowerBtn
            // 
            this.openDeleteTowerBtn.Location = new System.Drawing.Point(234, 378);
            this.openDeleteTowerBtn.Name = "openDeleteTowerBtn";
            this.openDeleteTowerBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteTowerBtn.TabIndex = 12;
            this.openDeleteTowerBtn.Text = "Видалити";
            this.openDeleteTowerBtn.UseVisualStyleBackColor = true;
            // 
            // openEditTowerBtn
            // 
            this.openEditTowerBtn.Location = new System.Drawing.Point(120, 378);
            this.openEditTowerBtn.Name = "openEditTowerBtn";
            this.openEditTowerBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditTowerBtn.TabIndex = 11;
            this.openEditTowerBtn.Text = "Редагувати";
            this.openEditTowerBtn.UseVisualStyleBackColor = true;
            // 
            // openAddTowerBtn
            // 
            this.openAddTowerBtn.Location = new System.Drawing.Point(6, 378);
            this.openAddTowerBtn.Name = "openAddTowerBtn";
            this.openAddTowerBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddTowerBtn.TabIndex = 10;
            this.openAddTowerBtn.Text = "Додати";
            this.openAddTowerBtn.UseVisualStyleBackColor = true;
            this.openAddTowerBtn.Click += new System.EventHandler(this.openAddTowerBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.TypeSize,
            this.FanType,
            this.FanIncluded,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 372);
            this.dataGridView1.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 150;
            // 
            // TypeSize
            // 
            this.TypeSize.HeaderText = "TypeSize";
            this.TypeSize.MinimumWidth = 6;
            this.TypeSize.Name = "TypeSize";
            this.TypeSize.Width = 125;
            // 
            // FanType
            // 
            this.FanType.HeaderText = "FanType";
            this.FanType.MinimumWidth = 6;
            this.FanType.Name = "FanType";
            this.FanType.Width = 125;
            // 
            // FanIncluded
            // 
            this.FanIncluded.HeaderText = "Fan_Included";
            this.FanIncluded.MinimumWidth = 6;
            this.FanIncluded.Name = "FanIncluded";
            this.FanIncluded.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // towerManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteTowerBtn);
            this.Controls.Add(this.openEditTowerBtn);
            this.Controls.Add(this.openAddTowerBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "towerManageCtrl";
            this.Size = new System.Drawing.Size(1014, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDeleteTowerBtn;
        private System.Windows.Forms.Button openEditTowerBtn;
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
