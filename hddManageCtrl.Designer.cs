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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MemoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReadingSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WriteSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            openAddHddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, Cost });
            dataGridView1.Location = new System.Drawing.Point(0, 41);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 424);
            dataGridView1.TabIndex = 1;
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
            // MemoryQuantity
            // 
            MemoryQuantity.HeaderText = "MemoryQuantity";
            MemoryQuantity.MinimumWidth = 6;
            MemoryQuantity.Name = "MemoryQuantity";
            MemoryQuantity.Width = 150;
            // 
            // ReadingSpeed
            // 
            ReadingSpeed.HeaderText = "ReadingSpeed";
            ReadingSpeed.MinimumWidth = 6;
            ReadingSpeed.Name = "ReadingSpeed";
            ReadingSpeed.Width = 150;
            // 
            // WriteSpeed
            // 
            WriteSpeed.HeaderText = "WriteSpeed";
            WriteSpeed.MinimumWidth = 6;
            WriteSpeed.Name = "WriteSpeed";
            WriteSpeed.Width = 150;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 150;
            // 
            // openAddHddBtn
            // 
            openAddHddBtn.Location = new System.Drawing.Point(3, 472);
            openAddHddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddHddBtn.Name = "openAddHddBtn";
            openAddHddBtn.Size = new System.Drawing.Size(108, 29);
            openAddHddBtn.TabIndex = 5;
            openAddHddBtn.Text = "Додати";
            openAddHddBtn.UseVisualStyleBackColor = true;
            openAddHddBtn.Click += openAddHddBtn_Click;
            // 
            // hddManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openAddHddBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "hddManageCtrl";
            Size = new System.Drawing.Size(1014, 520);
            Load += hddManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReadingSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn WriteSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.Button openAddHddBtn;
    }
}
