﻿namespace AnhVIet
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DelBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DataGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DelBox
            // 
            this.DelBox.Location = new System.Drawing.Point(348, 12);
            this.DelBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelBox.Multiline = true;
            this.DelBox.Name = "DelBox";
            this.DelBox.Size = new System.Drawing.Size(557, 93);
            this.DelBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(131, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(131, 70);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Nhap Tu";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(963, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xoa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DataGV
            // 
            this.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DataGV.Location = new System.Drawing.Point(31, 172);
            this.DataGV.Name = "DataGV";
            this.DataGV.RowTemplate.Height = 24;
            this.DataGV.Size = new System.Drawing.Size(760, 432);
            this.DataGV.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "English";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "VietNamese";
            this.Column2.Name = "Column2";
            // 
            // Testbtn
            // 
            this.Testbtn.Location = new System.Drawing.Point(963, 59);
            this.Testbtn.Name = "Testbtn";
            this.Testbtn.Size = new System.Drawing.Size(125, 46);
            this.Testbtn.TabIndex = 5;
            this.Testbtn.Text = "KiemTra";
            this.Testbtn.UseVisualStyleBackColor = true;
            this.Testbtn.Click += new System.EventHandler(this.Testbtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 699);
            this.Controls.Add(this.Testbtn);
            this.Controls.Add(this.DataGV);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DelBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DelBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView DataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button Testbtn;
    }
}