﻿namespace AnhVIet
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bl1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.MeanBox = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bl1
            // 
            this.bl1.AutoSize = true;
            this.bl1.Location = new System.Drawing.Point(16, 50);
            this.bl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bl1.Name = "bl1";
            this.bl1.Size = new System.Drawing.Size(58, 17);
            this.bl1.TabIndex = 0;
            this.bl1.Text = "English:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "VietNamese";
            // 
            // WordBox
            // 
            this.WordBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.WordBox.Location = new System.Drawing.Point(113, 36);
            this.WordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WordBox.Multiline = true;
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(305, 41);
            this.WordBox.TabIndex = 1;
            this.WordBox.TextChanged += new System.EventHandler(this.WordBox_TextChanged);
            // 
            // MeanBox
            // 
            this.MeanBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.MeanBox.Location = new System.Drawing.Point(113, 110);
            this.MeanBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MeanBox.Multiline = true;
            this.MeanBox.Name = "MeanBox";
            this.MeanBox.Size = new System.Drawing.Size(305, 43);
            this.MeanBox.TabIndex = 1;
            this.MeanBox.TextChanged += new System.EventHandler(this.MeanBox_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::AnhVIet.Properties.Resources.Designcontest_Ecommerce_Business_Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(315, 161);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 57);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 230);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.MeanBox);
            this.Controls.Add(this.WordBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.TextBox MeanBox;
        private System.Windows.Forms.Button btnSave;
    }
}