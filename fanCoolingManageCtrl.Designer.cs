namespace jenya_lab_7
{
    partial class fanCoolingManageCtrl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            reloadBTN = new System.Windows.Forms.Button();
            openAddMthrBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(891, 8);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(99, 29);
            reloadBTN.TabIndex = 10;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // openAddMthrBtn
            // 
            openAddMthrBtn.Location = new System.Drawing.Point(6, 477);
            openAddMthrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddMthrBtn.Name = "openAddMthrBtn";
            openAddMthrBtn.Size = new System.Drawing.Size(108, 29);
            openAddMthrBtn.TabIndex = 9;
            openAddMthrBtn.Text = "Додати";
            openAddMthrBtn.UseVisualStyleBackColor = true;
            openAddMthrBtn.Click += openAddMthrBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 44);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 426);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // fanCoolingManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(reloadBTN);
            Controls.Add(openAddMthrBtn);
            Controls.Add(dataGridView1);
            Name = "fanCoolingManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += fanCoolingManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.Button openAddMthrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
