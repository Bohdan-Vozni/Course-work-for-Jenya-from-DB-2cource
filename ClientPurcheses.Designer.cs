﻿namespace jenya_lab_7
{
    partial class ClientPurcheses
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new System.Windows.Forms.DataGridView();
            exitAppBTN = new System.Windows.Forms.Button();
            btnExportPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(0, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new System.Drawing.Size(919, 401);
            dataGridView1.TabIndex = 0;
            // 
            // exitAppBTN
            // 
            exitAppBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            exitAppBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            exitAppBTN.ForeColor = System.Drawing.Color.FromArgb(255, 128, 128);
            exitAppBTN.Location = new System.Drawing.Point(871, 2);
            exitAppBTN.Name = "exitAppBTN";
            exitAppBTN.Size = new System.Drawing.Size(48, 51);
            exitAppBTN.TabIndex = 7;
            exitAppBTN.Text = "X";
            exitAppBTN.UseVisualStyleBackColor = true;
            exitAppBTN.Click += exitAppBTN_Click;
            // 
            // btnExportPDF
            // 
            btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            btnExportPDF.Location = new System.Drawing.Point(0, 423);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new System.Drawing.Size(135, 37);
            btnExportPDF.TabIndex = 11;
            btnExportPDF.Text = "Зберегти в PDF";
            btnExportPDF.UseVisualStyleBackColor = true;
            btnExportPDF.Click += btnExportPDF_Click;
            // 
            // ClientPurcheses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(922, 462);
            Controls.Add(btnExportPDF);
            Controls.Add(exitAppBTN);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ClientPurcheses";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ClientPurcheses";
            Load += ClientPurcheses_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitAppBTN;
        private System.Windows.Forms.Button btnExportPDF;
    }
}