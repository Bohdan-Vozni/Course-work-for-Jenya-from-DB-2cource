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
            openAddCpuBtn = new System.Windows.Forms.Button();
            Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Architecture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddCpuBtn
            // 
            openAddCpuBtn.Location = new System.Drawing.Point(6, 472);
            openAddCpuBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddCpuBtn.Name = "openAddCpuBtn";
            openAddCpuBtn.Size = new System.Drawing.Size(108, 29);
            openAddCpuBtn.TabIndex = 2;
            openAddCpuBtn.Text = "Додати";
            openAddCpuBtn.UseVisualStyleBackColor = true;
            openAddCpuBtn.Click += openAddCpuBtn_Click;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 125;
            // 
            // Architecture
            // 
            Architecture.HeaderText = "Architecture";
            Architecture.MinimumWidth = 6;
            Architecture.Name = "Architecture";
            Architecture.Width = 125;
            // 
            // Clock
            // 
            Clock.HeaderText = "Clock";
            Clock.MinimumWidth = 6;
            Clock.Name = "Clock";
            Clock.Width = 125;
            // 
            // Cache
            // 
            Cache.HeaderText = "Cache";
            Cache.MinimumWidth = 6;
            Cache.Name = "Cache";
            Cache.Width = 125;
            // 
            // Threads
            // 
            Threads.HeaderText = "Threads";
            Threads.MinimumWidth = 6;
            Threads.Name = "Threads";
            Threads.Width = 125;
            // 
            // Cores
            // 
            Cores.HeaderText = "Cores";
            Cores.MinimumWidth = 6;
            Cores.Name = "Cores";
            Cores.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, Title, Cores, Threads, Cache, Clock, Architecture, Cost });
            dataGridView1.Location = new System.Drawing.Point(0, 58);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 407);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // cpuManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openAddCpuBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "cpuManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += cpuManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button openAddCpuBtn;
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
