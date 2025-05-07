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
            openAddSsdBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MemoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReadingSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WriteSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            RadiatorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddSsdBtn
            // 
            openAddSsdBtn.Location = new System.Drawing.Point(3, 472);
            openAddSsdBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddSsdBtn.Name = "openAddSsdBtn";
            openAddSsdBtn.Size = new System.Drawing.Size(108, 29);
            openAddSsdBtn.TabIndex = 9;
            openAddSsdBtn.Text = "Додати";
            openAddSsdBtn.UseVisualStyleBackColor = true;
            openAddSsdBtn.Click += openAddSsdBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, Title, MemoryQuantity, ReadingSpeed, WriteSpeed, RadiatorType, Cost });
            dataGridView1.Location = new System.Drawing.Point(0, 32);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 433);
            dataGridView1.TabIndex = 8;
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
            // RadiatorType
            // 
            RadiatorType.HeaderText = "RadiatorType";
            RadiatorType.MinimumWidth = 6;
            RadiatorType.Name = "RadiatorType";
            RadiatorType.Width = 125;
            // 
            // Cost
            // 
            Cost.HeaderText = "Cost";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 150;
            // 
            // ssdManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(openAddSsdBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ssdManageCtrl";
            Size = new System.Drawing.Size(1014, 520);
            Load += ssdManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion
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
