namespace jenya_lab_7
{
    partial class motherboardManageCtrl
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
            this.Chipset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openDeleteMthrBtn
            // 
            this.openDeleteMthrBtn.Location = new System.Drawing.Point(234, 378);
            this.openDeleteMthrBtn.Name = "openDeleteMthrBtn";
            this.openDeleteMthrBtn.Size = new System.Drawing.Size(108, 23);
            this.openDeleteMthrBtn.TabIndex = 8;
            this.openDeleteMthrBtn.Text = "Видалити";
            this.openDeleteMthrBtn.UseVisualStyleBackColor = true;
            // 
            // openEditMthrBtn
            // 
            this.openEditMthrBtn.Location = new System.Drawing.Point(120, 378);
            this.openEditMthrBtn.Name = "openEditMthrBtn";
            this.openEditMthrBtn.Size = new System.Drawing.Size(108, 23);
            this.openEditMthrBtn.TabIndex = 7;
            this.openEditMthrBtn.Text = "Редагувати";
            this.openEditMthrBtn.UseVisualStyleBackColor = true;
            // 
            // openAddMthrBtn
            // 
            this.openAddMthrBtn.Location = new System.Drawing.Point(6, 378);
            this.openAddMthrBtn.Name = "openAddMthrBtn";
            this.openAddMthrBtn.Size = new System.Drawing.Size(108, 23);
            this.openAddMthrBtn.TabIndex = 6;
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
            this.Chipset,
            this.TypeSize,
            this.Socket,
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
            // Chipset
            // 
            this.Chipset.HeaderText = "Chipset";
            this.Chipset.MinimumWidth = 6;
            this.Chipset.Name = "Chipset";
            this.Chipset.Width = 150;
            // 
            // TypeSize
            // 
            this.TypeSize.HeaderText = "TypeSize";
            this.TypeSize.MinimumWidth = 6;
            this.TypeSize.Name = "TypeSize";
            this.TypeSize.Width = 150;
            // 
            // Socket
            // 
            this.Socket.HeaderText = "Socket";
            this.Socket.MinimumWidth = 6;
            this.Socket.Name = "Socket";
            this.Socket.Width = 150;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.Width = 150;
            // 
            // motherboardManageCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openDeleteMthrBtn);
            this.Controls.Add(this.openEditMthrBtn);
            this.Controls.Add(this.openAddMthrBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "motherboardManageCtrl";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Chipset;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}
