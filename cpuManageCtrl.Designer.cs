namespace jenya_lab_7
{
    partial class cpuManageCtrl
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
            this.openAddCpuBtn = new System.Windows.Forms.Button();
            this.openEditCpuBtn = new System.Windows.Forms.Button();
            this.openDeleteCpuBtn = new System.Windows.Forms.Button();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Architecture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openAddCpuBtn
            // 
            this.openAddCpuBtn.Location = new System.Drawing.Point(6, 378);
            this.openAddCpuBtn.Name = "openAddCpuBtn";
            this.openAddCpuBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddCpuBtn.TabIndex = 2;
            this.openAddCpuBtn.Text = "Додати";
            this.openAddCpuBtn.UseVisualStyleBackColor = true;
            this.openAddCpuBtn.Click += new System.EventHandler(this.openAddCpuBtn_Click);
            // 
            // openEditCpuBtn
            // 
            this.openEditCpuBtn.Location = new System.Drawing.Point(120, 378);
            this.openEditCpuBtn.Name = "openEditCpuBtn";
            this.openEditCpuBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditCpuBtn.TabIndex = 3;
            this.openEditCpuBtn.Text = "Редагувати";
            this.openEditCpuBtn.UseVisualStyleBackColor = true;
            this.openEditCpuBtn.Click += new System.EventHandler(this.openEditCpuBtn_Click);
            // 
            // openDeleteCpuBtn
            // 
            this.openDeleteCpuBtn.Location = new System.Drawing.Point(234, 378);
            this.openDeleteCpuBtn.Name = "openDeleteCpuBtn";
            this.openDeleteCpuBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteCpuBtn.TabIndex = 4;
            this.openDeleteCpuBtn.Text = "Видалити";
            this.openDeleteCpuBtn.UseVisualStyleBackColor = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 125;
            // 
            // Architecture
            // 
            this.Architecture.HeaderText = "Architecture";
            this.Architecture.MinimumWidth = 6;
            this.Architecture.Name = "Architecture";
            this.Architecture.Width = 125;
            // 
            // Clock
            // 
            this.Clock.HeaderText = "Clock";
            this.Clock.MinimumWidth = 6;
            this.Clock.Name = "Clock";
            this.Clock.Width = 125;
            // 
            // Cache
            // 
            this.Cache.HeaderText = "Cache";
            this.Cache.MinimumWidth = 6;
            this.Cache.Name = "Cache";
            this.Cache.Width = 125;
            // 
            // Threads
            // 
            this.Threads.HeaderText = "Threads";
            this.Threads.MinimumWidth = 6;
            this.Threads.Name = "Threads";
            this.Threads.Width = 125;
            // 
            // Cores
            // 
            this.Cores.HeaderText = "Cores";
            this.Cores.MinimumWidth = 6;
            this.Cores.Name = "Cores";
            this.Cores.Width = 125;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
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
            this.Cache,
            this.Clock,
            this.Architecture,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 372);
            this.dataGridView1.TabIndex = 0;
            // 
            // cpuManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteCpuBtn);
            this.Controls.Add(this.openEditCpuBtn);
            this.Controls.Add(this.openAddCpuBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "cpuManageCtrl";
            this.Size = new System.Drawing.Size(1014, 412);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openAddCpuBtn;
        private System.Windows.Forms.Button openEditCpuBtn;
        private System.Windows.Forms.Button openDeleteCpuBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Architecture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cache;
        private System.Windows.Forms.DataGridViewTextBoxColumn Threads;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
