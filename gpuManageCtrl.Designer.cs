namespace jenya_lab_7
{
    partial class gpuManageCtrl
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
            this.openDeleteMthrBtn = new System.Windows.Forms.Button();
            this.openEditMthrBtn = new System.Windows.Forms.Button();
            this.openAddMthrBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VRAMType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VRAMQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDeleteMthrBtn
            // 
            this.openDeleteMthrBtn.Location = new System.Drawing.Point(234, 378);
            this.openDeleteMthrBtn.Name = "openDeleteMthrBtn";
            this.openDeleteMthrBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteMthrBtn.TabIndex = 12;
            this.openDeleteMthrBtn.Text = "Видалити";
            this.openDeleteMthrBtn.UseVisualStyleBackColor = true;
            // 
            // openEditMthrBtn
            // 
            this.openEditMthrBtn.Location = new System.Drawing.Point(120, 378);
            this.openEditMthrBtn.Name = "openEditMthrBtn";
            this.openEditMthrBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditMthrBtn.TabIndex = 11;
            this.openEditMthrBtn.Text = "Редагувати";
            this.openEditMthrBtn.UseVisualStyleBackColor = true;
            // 
            // openAddMthrBtn
            // 
            this.openAddMthrBtn.Location = new System.Drawing.Point(6, 378);
            this.openAddMthrBtn.Name = "openAddMthrBtn";
            this.openAddMthrBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddMthrBtn.TabIndex = 10;
            this.openAddMthrBtn.Text = "Додати";
            this.openAddMthrBtn.UseVisualStyleBackColor = true;
            this.openAddMthrBtn.Click += new System.EventHandler(this.openAddMthrBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Title,
            this.Cores,
            this.Threads,
            this.VRAMType,
            this.VRAMQuantity,
            this.Cache,
            this.Clock,
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
            // Cores
            // 
            this.Cores.HeaderText = "Cores";
            this.Cores.MinimumWidth = 6;
            this.Cores.Name = "Cores";
            this.Cores.Width = 125;
            // 
            // Threads
            // 
            this.Threads.HeaderText = "Threads";
            this.Threads.MinimumWidth = 6;
            this.Threads.Name = "Threads";
            this.Threads.Width = 125;
            // 
            // VRAMType
            // 
            this.VRAMType.HeaderText = "VRAMType";
            this.VRAMType.MinimumWidth = 6;
            this.VRAMType.Name = "VRAMType";
            this.VRAMType.Width = 125;
            // 
            // VRAMQuantity
            // 
            this.VRAMQuantity.HeaderText = "VRAMQuantity";
            this.VRAMQuantity.MinimumWidth = 6;
            this.VRAMQuantity.Name = "VRAMQuantity";
            this.VRAMQuantity.Width = 125;
            // 
            // Cache
            // 
            this.Cache.HeaderText = "Cache";
            this.Cache.MinimumWidth = 6;
            this.Cache.Name = "Cache";
            this.Cache.Width = 125;
            // 
            // Clock
            // 
            this.Clock.HeaderText = "Clock";
            this.Clock.MinimumWidth = 6;
            this.Clock.Name = "Clock";
            this.Clock.Width = 125;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // gpuManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteMthrBtn);
            this.Controls.Add(this.openEditMthrBtn);
            this.Controls.Add(this.openAddMthrBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gpuManageCtrl";
            this.Size = new System.Drawing.Size(1014, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openDeleteMthrBtn;
        private System.Windows.Forms.Button openEditMthrBtn;
        private System.Windows.Forms.Button openAddMthrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Threads;
        private System.Windows.Forms.DataGridViewTextBoxColumn VRAMType;
        private System.Windows.Forms.DataGridViewTextBoxColumn VRAMQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}
