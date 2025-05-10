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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            reloadBTN = new System.Windows.Forms.Button();
            openAddGpuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 49);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 416);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(279, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(431, 20);
            label2.TabIndex = 17;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 28);
            label1.TabIndex = 16;
            label1.Text = "Управління відеокартами";
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(840, 13);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(156, 29);
            reloadBTN.TabIndex = 18;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // openAddGpuBtn
            // 
            openAddGpuBtn.Location = new System.Drawing.Point(394, 472);
            openAddGpuBtn.Name = "openAddGpuBtn";
            openAddGpuBtn.Size = new System.Drawing.Size(246, 28);
            openAddGpuBtn.TabIndex = 0;
            openAddGpuBtn.Text = "Додати";
            openAddGpuBtn.Click += openAddGpuBtn_Click;
            // 
            // gpuManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(reloadBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openAddGpuBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "gpuManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += gpuManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.Button openAddGpuBtn;
    }
}
