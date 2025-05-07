namespace jenya_lab_7
{
    partial class ramManageCtrl
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
            this.openDeleteRamBtn = new System.Windows.Forms.Button();
            this.openEditRamBtn = new System.Windows.Forms.Button();
            this.openAddRamBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RadiatorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDeleteRamBtn
            // 
            this.openDeleteRamBtn.Location = new System.Drawing.Point(231, 378);
            this.openDeleteRamBtn.Name = "openDeleteRamBtn";
            this.openDeleteRamBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteRamBtn.TabIndex = 8;
            this.openDeleteRamBtn.Text = "Видалити";
            this.openDeleteRamBtn.UseVisualStyleBackColor = true;
            // 
            // openEditRamBtn
            // 
            this.openEditRamBtn.Location = new System.Drawing.Point(117, 378);
            this.openEditRamBtn.Name = "openEditRamBtn";
            this.openEditRamBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditRamBtn.TabIndex = 7;
            this.openEditRamBtn.Text = "Редагувати";
            this.openEditRamBtn.UseVisualStyleBackColor = true;
            // 
            // openAddRamBtn
            // 
            this.openAddRamBtn.Location = new System.Drawing.Point(3, 378);
            this.openAddRamBtn.Name = "openAddRamBtn";
            this.openAddRamBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddRamBtn.TabIndex = 6;
            this.openAddRamBtn.Text = "Додати";
            this.openAddRamBtn.UseVisualStyleBackColor = true;
            this.openAddRamBtn.Click += new System.EventHandler(this.openAddRamBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.MemoryType,
            this.RadiatorType,
            this.MemoryQuantity,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 372);
            this.dataGridView1.TabIndex = 5;
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
            // MemoryType
            // 
            this.MemoryType.HeaderText = "MemoryType";
            this.MemoryType.MinimumWidth = 6;
            this.MemoryType.Name = "MemoryType";
            this.MemoryType.Width = 150;
            // 
            // RadiatorType
            // 
            this.RadiatorType.HeaderText = "RadiatorType";
            this.RadiatorType.MinimumWidth = 6;
            this.RadiatorType.Name = "RadiatorType";
            this.RadiatorType.Width = 150;
            // 
            // MemoryQuantity
            // 
            this.MemoryQuantity.HeaderText = "MemoryQuantity";
            this.MemoryQuantity.MinimumWidth = 6;
            this.MemoryQuantity.Name = "MemoryQuantity";
            this.MemoryQuantity.Width = 150;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // ramManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteRamBtn);
            this.Controls.Add(this.openEditRamBtn);
            this.Controls.Add(this.openAddRamBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ramManageCtrl";
            this.Size = new System.Drawing.Size(1014, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDeleteRamBtn;
        private System.Windows.Forms.Button openEditRamBtn;
        private System.Windows.Forms.Button openAddRamBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RadiatorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}
