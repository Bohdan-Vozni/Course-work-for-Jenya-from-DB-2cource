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
            this.openDeleteSsdBtn = new System.Windows.Forms.Button();
            this.openEditSsdBtn = new System.Windows.Forms.Button();
            this.openAddSsdBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadingSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadiatorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDeleteSsdBtn
            // 
            this.openDeleteSsdBtn.Location = new System.Drawing.Point(231, 378);
            this.openDeleteSsdBtn.Name = "openDeleteSsdBtn";
            this.openDeleteSsdBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteSsdBtn.TabIndex = 11;
            this.openDeleteSsdBtn.Text = "Видалити";
            this.openDeleteSsdBtn.UseVisualStyleBackColor = true;
            // 
            // openEditSsdBtn
            // 
            this.openEditSsdBtn.Location = new System.Drawing.Point(117, 378);
            this.openEditSsdBtn.Name = "openEditSsdBtn";
            this.openEditSsdBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditSsdBtn.TabIndex = 10;
            this.openEditSsdBtn.Text = "Редагувати";
            this.openEditSsdBtn.UseVisualStyleBackColor = true;
            // 
            // openAddSsdBtn
            // 
            this.openAddSsdBtn.Location = new System.Drawing.Point(3, 378);
            this.openAddSsdBtn.Name = "openAddSsdBtn";
            this.openAddSsdBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddSsdBtn.TabIndex = 9;
            this.openAddSsdBtn.Text = "Додати";
            this.openAddSsdBtn.UseVisualStyleBackColor = true;
            this.openAddSsdBtn.Click += new System.EventHandler(this.openAddSsdBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.MemoryQuantity,
            this.ReadingSpeed,
            this.WriteSpeed,
            this.RadiatorType,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 372);
            this.dataGridView1.TabIndex = 8;
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
            // MemoryQuantity
            // 
            this.MemoryQuantity.HeaderText = "MemoryQuantity";
            this.MemoryQuantity.MinimumWidth = 6;
            this.MemoryQuantity.Name = "MemoryQuantity";
            this.MemoryQuantity.Width = 150;
            // 
            // ReadingSpeed
            // 
            this.ReadingSpeed.HeaderText = "ReadingSpeed";
            this.ReadingSpeed.MinimumWidth = 6;
            this.ReadingSpeed.Name = "ReadingSpeed";
            this.ReadingSpeed.Width = 150;
            // 
            // WriteSpeed
            // 
            this.WriteSpeed.HeaderText = "WriteSpeed";
            this.WriteSpeed.MinimumWidth = 6;
            this.WriteSpeed.Name = "WriteSpeed";
            this.WriteSpeed.Width = 150;
            // 
            // RadiatorType
            // 
            this.RadiatorType.HeaderText = "RadiatorType";
            this.RadiatorType.MinimumWidth = 6;
            this.RadiatorType.Name = "RadiatorType";
            this.RadiatorType.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // ssdManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteSsdBtn);
            this.Controls.Add(this.openEditSsdBtn);
            this.Controls.Add(this.openAddSsdBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ssdManageCtrl";
            this.Size = new System.Drawing.Size(1014, 416);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDeleteSsdBtn;
        private System.Windows.Forms.Button openEditSsdBtn;
        private System.Windows.Forms.Button openAddSsdBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadingSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadiatorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}
