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
            openAddMthrBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Chipset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TypeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Socket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddMthrBtn
            // 
            openAddMthrBtn.Location = new System.Drawing.Point(6, 472);
            openAddMthrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddMthrBtn.Name = "openAddMthrBtn";
            openAddMthrBtn.Size = new System.Drawing.Size(108, 29);
            openAddMthrBtn.TabIndex = 6;
            openAddMthrBtn.Text = "Додати";
            openAddMthrBtn.UseVisualStyleBackColor = true;
            openAddMthrBtn.Click += openAddMthrBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, Title, Chipset, TypeSize, Socket, Cost });
            dataGridView1.Location = new System.Drawing.Point(0, 32);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 433);
            dataGridView1.TabIndex = 5;
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
            // Chipset
            // 
            Chipset.HeaderText = "Chipset";
            Chipset.MinimumWidth = 6;
            Chipset.Name = "Chipset";
            Chipset.Width = 150;
            // 
            // TypeSize
            // 
            TypeSize.HeaderText = "TypeSize";
            TypeSize.MinimumWidth = 6;
            TypeSize.Name = "TypeSize";
            TypeSize.Width = 150;
            // 
            // Socket
            // 
            Socket.HeaderText = "Socket";
            Socket.MinimumWidth = 6;
            Socket.Name = "Socket";
            Socket.Width = 150;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 150;
            // 
            // motherboardManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openAddMthrBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "motherboardManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += motherboardManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
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
