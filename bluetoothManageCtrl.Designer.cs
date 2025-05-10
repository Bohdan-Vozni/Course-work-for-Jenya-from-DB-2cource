namespace jenya_lab_7
{
    partial class bluetoothManageCtrl
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
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            searchTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(759, 6);
            reloadBTN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(108, 22);
            reloadBTN.TabIndex = 10;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // openAddMthrBtn
            // 
            openAddMthrBtn.Location = new System.Drawing.Point(509, 356);
            openAddMthrBtn.Name = "openAddMthrBtn";
            openAddMthrBtn.Size = new System.Drawing.Size(182, 22);
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
            dataGridView1.Location = new System.Drawing.Point(0, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(892, 320);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(3, 363);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(364, 17);
            label2.TabIndex = 17;
            label2.Text = "Для редагування даних зробіть двойний клік по рядку";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(257, 21);
            label1.TabIndex = 16;
            label1.Text = "Управління bluetooth-адатарами";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(324, 6);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 18;
            label3.Text = "Пошук: ";
            // 
            // searchTB
            // 
            searchTB.Location = new System.Drawing.Point(383, 4);
            searchTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            searchTB.Name = "searchTB";
            searchTB.Size = new System.Drawing.Size(138, 23);
            searchTB.TabIndex = 19;
            searchTB.TextChanged += searchTB_TextChanged;
            // 
            // bluetoothManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(searchTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(reloadBTN);
            Controls.Add(openAddMthrBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "bluetoothManageCtrl";
            Size = new System.Drawing.Size(887, 386);
            Load += bluetoothManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.Button openAddMthrBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTB;
    }
}
