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
            openAddHddBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            reloadBTN = new System.Windows.Forms.Button();
            searchTB = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 41);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(1014, 424);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // openAddHddBtn
            // 
            openAddHddBtn.Location = new System.Drawing.Point(569, 473);
            openAddHddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            openAddHddBtn.Name = "openAddHddBtn";
            openAddHddBtn.Size = new System.Drawing.Size(221, 29);
            openAddHddBtn.TabIndex = 5;
            openAddHddBtn.Text = "Додати";
            openAddHddBtn.UseVisualStyleBackColor = true;
            openAddHddBtn.Click += openAddHddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(52, 473);
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
            label1.Size = new System.Drawing.Size(319, 28);
            label1.TabIndex = 18;
            label1.Text = "Управління жерсткими дисками";
            // 
            // reloadBTN
            // 
            reloadBTN.Location = new System.Drawing.Point(854, 8);
            reloadBTN.Name = "reloadBTN";
            reloadBTN.Size = new System.Drawing.Size(148, 29);
            reloadBTN.TabIndex = 20;
            reloadBTN.Text = "Оновити";
            reloadBTN.UseVisualStyleBackColor = true;
            reloadBTN.Click += reloadBTN_Click;
            // 
            // searchTB
            // 
            searchTB.Location = new System.Drawing.Point(475, 7);
            searchTB.Name = "searchTB";
            searchTB.Size = new System.Drawing.Size(157, 27);
            searchTB.TabIndex = 32;
            searchTB.TextChanged += searchTB_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(407, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 20);
            label3.TabIndex = 31;
            label3.Text = "Пошук: ";
            // 
            // hddManageCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(searchTB);
            Controls.Add(label3);
            Controls.Add(reloadBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(openAddHddBtn);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "hddManageCtrl";
            Size = new System.Drawing.Size(1014, 513);
            Load += hddManageCtrl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button openAddHddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reloadBTN;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label3;
    }
}
