namespace jenya_lab_7
{
    partial class wifiManageCtrl
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
            openAddWifiBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(855, 8);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(135, 29);
            reloadBTN.TabIndex = 13;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // openAddWifiBtn
            // 
            openAddWifiBtn.Location = new System.Drawing.Point(366, 478);
            openAddWifiBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddWifiBtn.Name = "openAddWifiBtn";
            openAddWifiBtn.Size = new System.Drawing.Size(237, 29);
            openAddWifiBtn.TabIndex = 12;
            openAddWifiBtn.Text = "Додати";
            openAddWifiBtn.UseVisualStyleBackColor = true;
            openAddWifiBtn.Click += openAddWifiBtn_Click;
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
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(0, 8);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(255, 28);
            label1.TabIndex = 14;
            label1.Text = "Управління wifi-адатаром";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(290, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(431, 20);
            label2.TabIndex = 15;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            // 
            // wifiManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reloadBTN);
            Controls.Add(openAddWifiBtn);
            Controls.Add(dataGridView1);
            Name = "wifiManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += wifiManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.Button openAddWifiBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
