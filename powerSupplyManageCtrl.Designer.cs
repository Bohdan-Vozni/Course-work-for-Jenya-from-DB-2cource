namespace jenya_lab_7
{
    partial class powerSupplyManageCtrl
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            openAddRamBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(841, 9);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(152, 29);
            reloadBTN.TabIndex = 25;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(289, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(431, 20);
            label2.TabIndex = 24;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(0, 6);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(273, 28);
            label1.TabIndex = 23;
            label1.Text = "Управління блок живлення";
            // 
            // openAddRamBtn
            // 
            openAddRamBtn.Location = new System.Drawing.Point(405, 479);
            openAddRamBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddRamBtn.Name = "openAddRamBtn";
            openAddRamBtn.Size = new System.Drawing.Size(201, 29);
            openAddRamBtn.TabIndex = 22;
            openAddRamBtn.Text = "Додати";
            openAddRamBtn.UseVisualStyleBackColor = true;
            openAddRamBtn.Click += openAddRamBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 49);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 422);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // powerSupplyManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(reloadBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openAddRamBtn);
            Controls.Add(dataGridView1);
            Name = "powerSupplyManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += powerSupplyManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openAddRamBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
