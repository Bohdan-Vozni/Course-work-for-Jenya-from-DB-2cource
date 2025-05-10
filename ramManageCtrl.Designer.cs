namespace jenya_lab_7
{
    partial class ramManageCtrl
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
            openAddRamBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            reloadBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // openAddRamBtn
            // 
            openAddRamBtn.Location = new System.Drawing.Point(407, 473);
            openAddRamBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddRamBtn.Name = "openAddRamBtn";
            openAddRamBtn.Size = new System.Drawing.Size(220, 29);
            openAddRamBtn.TabIndex = 6;
            openAddRamBtn.Text = "Додати";
            openAddRamBtn.UseVisualStyleBackColor = true;
            openAddRamBtn.Click += openAddRamBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 43);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 422);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(357, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(431, 20);
            label2.TabIndex = 19;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(351, 28);
            label1.TabIndex = 18;
            label1.Text = "Управління оперативною пам'ятью";
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(841, 3);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(152, 29);
            reloadBTN.TabIndex = 20;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // ramManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(reloadBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openAddRamBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "ramManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += ramManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openAddRamBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBTN;
    }
}
