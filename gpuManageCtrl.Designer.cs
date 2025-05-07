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
            openDeleteMthrBtn = new System.Windows.Forms.Button();
            openEditMthrBtn = new System.Windows.Forms.Button();
            openAddMthrBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Threads = new System.Windows.Forms.DataGridViewTextBoxColumn();
            VRAMType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            VRAMQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cache = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Clock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openDeleteMthrBtn
            // 
            openDeleteMthrBtn.Location = new System.Drawing.Point(234, 472);
            openDeleteMthrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openDeleteMthrBtn.Name = "openDeleteMthrBtn";
            openDeleteMthrBtn.Size = new System.Drawing.Size(107, 29);
            openDeleteMthrBtn.TabIndex = 12;
            openDeleteMthrBtn.Text = "Видалити";
            openDeleteMthrBtn.UseVisualStyleBackColor = true;
            // 
            // openEditMthrBtn
            // 
            openEditMthrBtn.Location = new System.Drawing.Point(120, 472);
            openEditMthrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openEditMthrBtn.Name = "openEditMthrBtn";
            openEditMthrBtn.Size = new System.Drawing.Size(107, 29);
            openEditMthrBtn.TabIndex = 11;
            openEditMthrBtn.Text = "Редагувати";
            openEditMthrBtn.UseVisualStyleBackColor = true;
            // 
            // openAddMthrBtn
            // 
            openAddMthrBtn.Location = new System.Drawing.Point(6, 472);
            openAddMthrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddMthrBtn.Name = "openAddMthrBtn";
            openAddMthrBtn.Size = new System.Drawing.Size(107, 29);
            openAddMthrBtn.TabIndex = 10;
            openAddMthrBtn.Text = "Додати";
            openAddMthrBtn.UseVisualStyleBackColor = true;
            openAddMthrBtn.Click += openAddMthrBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, Title, Cores, Threads, VRAMType, VRAMQuantity, Cache, Clock, Cost });
            dataGridView1.Location = new System.Drawing.Point(0, 0);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 465);
            dataGridView1.TabIndex = 9;
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
            // Cores
            // 
            Cores.HeaderText = "Cores";
            Cores.MinimumWidth = 6;
            Cores.Name = "Cores";
            Cores.Width = 125;
            // 
            // Threads
            // 
            Threads.HeaderText = "Threads";
            Threads.MinimumWidth = 6;
            Threads.Name = "Threads";
            Threads.Width = 125;
            // 
            // VRAMType
            // 
            VRAMType.HeaderText = "VRAMType";
            VRAMType.MinimumWidth = 6;
            VRAMType.Name = "VRAMType";
            VRAMType.Width = 125;
            // 
            // VRAMQuantity
            // 
            VRAMQuantity.HeaderText = "VRAMQuantity";
            VRAMQuantity.MinimumWidth = 6;
            VRAMQuantity.Name = "VRAMQuantity";
            VRAMQuantity.Width = 125;
            // 
            // Cache
            // 
            Cache.HeaderText = "Cache";
            Cache.MinimumWidth = 6;
            Cache.Name = "Cache";
            Cache.Width = 125;
            // 
            // Clock
            // 
            Clock.HeaderText = "Clock";
            Clock.MinimumWidth = 6;
            Clock.Name = "Clock";
            Clock.Width = 125;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 150;
            // 
            // gpuManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openDeleteMthrBtn);
            Controls.Add(openEditMthrBtn);
            Controls.Add(openAddMthrBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "gpuManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
