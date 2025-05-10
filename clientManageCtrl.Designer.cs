namespace jenya_lab_7
{
    partial class clientManageCtrl
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            reloadBTN = new System.Windows.Forms.Button();
            openAddMthrBtn = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            searchTB = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(3, 486);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(431, 20);
            label2.TabIndex = 22;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(219, 28);
            label1.TabIndex = 21;
            label1.Text = "Управління клієнтами";
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(864, 13);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(123, 29);
            reloadBTN.TabIndex = 20;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // openAddMthrBtn
            // 
            openAddMthrBtn.Location = new System.Drawing.Point(512, 480);
            openAddMthrBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddMthrBtn.Name = "openAddMthrBtn";
            openAddMthrBtn.Size = new System.Drawing.Size(208, 29);
            openAddMthrBtn.TabIndex = 19;
            openAddMthrBtn.Text = "Додати";
            openAddMthrBtn.UseVisualStyleBackColor = true;
            openAddMthrBtn.Click += openAddMthrBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(-3, 46);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1020, 426);
            dataGridView1.TabIndex = 18;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // searchTB
            // 
            searchTB.Location = new System.Drawing.Point(407, 4);
            searchTB.Name = "searchTB";
            searchTB.Size = new System.Drawing.Size(157, 27);
            searchTB.TabIndex = 24;
            searchTB.TextChanged += this.searchTB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(339, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 20);
            label3.TabIndex = 23;
            label3.Text = "Пошук: ";
            label3.Click += label3_Click;
            // 
            // clientManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(searchTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reloadBTN);
            Controls.Add(openAddMthrBtn);
            Controls.Add(dataGridView1);
            Name = "clientManageCtrl";
            Size = new System.Drawing.Size(1014, 515);
            Load += clientManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.Button openAddMthrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label3;
    }
}
