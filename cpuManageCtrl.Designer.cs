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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            reloadBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddCpuBtn
            // 
            openAddCpuBtn.Location = new System.Drawing.Point(425, 472);
            openAddCpuBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddCpuBtn.Name = "openAddCpuBtn";
            openAddCpuBtn.Size = new System.Drawing.Size(197, 29);
            openAddCpuBtn.TabIndex = 2;
            openAddCpuBtn.Text = "Додати";
            openAddCpuBtn.UseVisualStyleBackColor = true;
            openAddCpuBtn.Click += openAddCpuBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 43);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 421);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(288, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(431, 20);
            label2.TabIndex = 22;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(0, -1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(254, 28);
            label1.TabIndex = 21;
            label1.Text = "Управління процесорами";
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(847, 7);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(143, 29);
            reloadBTN.TabIndex = 20;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // cpuManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reloadBTN);
            Controls.Add(openAddCpuBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "cpuManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += cpuManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openAddCpuBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBTN;
    }
}
