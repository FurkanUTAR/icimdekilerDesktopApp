﻿namespace icimdekiler
{
    partial class adminAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminAnaSayfa));
            this.araTextBox = new System.Windows.Forms.TextBox();
            this.urunlerDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.urunEklePictureBox = new System.Windows.Forms.PictureBox();
            this.araPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // araTextBox
            // 
            this.araTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.araTextBox.Location = new System.Drawing.Point(259, 31);
            this.araTextBox.Multiline = true;
            this.araTextBox.Name = "araTextBox";
            this.araTextBox.Size = new System.Drawing.Size(238, 25);
            this.araTextBox.TabIndex = 0;
            // 
            // urunlerDataGridView
            // 
            this.urunlerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerDataGridView.Location = new System.Drawing.Point(12, 62);
            this.urunlerDataGridView.Name = "urunlerDataGridView";
            this.urunlerDataGridView.Size = new System.Drawing.Size(776, 376);
            this.urunlerDataGridView.TabIndex = 3;
            this.urunlerDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunlerDataGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı";
            // 
            // urunEklePictureBox
            // 
            this.urunEklePictureBox.Image = global::icimdekiler.Properties.Resources.add;
            this.urunEklePictureBox.Location = new System.Drawing.Point(534, 31);
            this.urunEklePictureBox.Name = "urunEklePictureBox";
            this.urunEklePictureBox.Size = new System.Drawing.Size(25, 25);
            this.urunEklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urunEklePictureBox.TabIndex = 2;
            this.urunEklePictureBox.TabStop = false;
            this.urunEklePictureBox.Click += new System.EventHandler(this.urunEklePictureBox_Click);
            // 
            // araPictureBox
            // 
            this.araPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("araPictureBox.Image")));
            this.araPictureBox.Location = new System.Drawing.Point(503, 31);
            this.araPictureBox.Name = "araPictureBox";
            this.araPictureBox.Size = new System.Drawing.Size(25, 25);
            this.araPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araPictureBox.TabIndex = 1;
            this.araPictureBox.TabStop = false;
            this.araPictureBox.Click += new System.EventHandler(this.araPictureBox_Click);
            // 
            // adminAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urunlerDataGridView);
            this.Controls.Add(this.urunEklePictureBox);
            this.Controls.Add(this.araPictureBox);
            this.Controls.Add(this.araTextBox);
            this.Name = "adminAnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.adminAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunEklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox araTextBox;
        private System.Windows.Forms.PictureBox araPictureBox;
        private System.Windows.Forms.PictureBox urunEklePictureBox;
        private System.Windows.Forms.DataGridView urunlerDataGridView;
        private System.Windows.Forms.Label label1;
    }
}