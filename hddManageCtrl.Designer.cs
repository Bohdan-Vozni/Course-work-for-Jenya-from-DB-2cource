namespace jenya_lab_7
{
    partial class hddManageCtrl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openDeleteHddBtn = new System.Windows.Forms.Button();
            this.openEditHddBtn = new System.Windows.Forms.Button();
            this.openAddHddBtn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadingSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WriteSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 372);
            this.dataGridView1.TabIndex = 1;
            // 
            // openDeleteHddBtn
            // 
            this.openDeleteHddBtn.Location = new System.Drawing.Point(231, 378);
            this.openDeleteHddBtn.Name = "openDeleteHddBtn";
            this.openDeleteHddBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteHddBtn.TabIndex = 7;
            this.openDeleteHddBtn.Text = "Видалити";
            this.openDeleteHddBtn.UseVisualStyleBackColor = true;
            // 
            // openEditHddBtn
            // 
            this.openEditHddBtn.Location = new System.Drawing.Point(117, 378);
            this.openEditHddBtn.Name = "openEditHddBtn";
            this.openEditHddBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditHddBtn.TabIndex = 6;
            this.openEditHddBtn.Text = "Редагувати";
            this.openEditHddBtn.UseVisualStyleBackColor = true;
            // 
            // openAddHddBtn
            // 
            this.openAddHddBtn.Location = new System.Drawing.Point(3, 378);
            this.openAddHddBtn.Name = "openAddHddBtn";
            this.openAddHddBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddHddBtn.TabIndex = 5;
            this.openAddHddBtn.Text = "Додати";
            this.openAddHddBtn.UseVisualStyleBackColor = true;
            this.openAddHddBtn.Click += new System.EventHandler(this.openAddHddBtn_Click);
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
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // hddManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteHddBtn);
            this.Controls.Add(this.openEditHddBtn);
            this.Controls.Add(this.openAddHddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "hddManageCtrl";
            this.Size = new System.Drawing.Size(1014, 416);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadingSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button openDeleteHddBtn;
        private System.Windows.Forms.Button openEditHddBtn;
        private System.Windows.Forms.Button openAddHddBtn;
    }
}
