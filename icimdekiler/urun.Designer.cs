namespace icimdekiler
{
    partial class urun
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
            this.barkodLabel = new System.Windows.Forms.Label();
            this.urunLabel = new System.Windows.Forms.Label();
            this.icindekilerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // barkodLabel
            // 
            this.barkodLabel.AutoSize = true;
            this.barkodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodLabel.Location = new System.Drawing.Point(283, 60);
            this.barkodLabel.Name = "barkodLabel";
            this.barkodLabel.Size = new System.Drawing.Size(74, 24);
            this.barkodLabel.TabIndex = 0;
            this.barkodLabel.Text = "barkod";
            // 
            // urunLabel
            // 
            this.urunLabel.AutoSize = true;
            this.urunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunLabel.Location = new System.Drawing.Point(283, 94);
            this.urunLabel.Name = "urunLabel";
            this.urunLabel.Size = new System.Drawing.Size(53, 24);
            this.urunLabel.TabIndex = 1;
            this.urunLabel.Text = "urun";
            // 
            // icindekilerLabel
            // 
            this.icindekilerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.icindekilerLabel.Location = new System.Drawing.Point(284, 151);
            this.icindekilerLabel.Name = "icindekilerLabel";
            this.icindekilerLabel.Size = new System.Drawing.Size(200, 251);
            this.icindekilerLabel.TabIndex = 2;
            this.icindekilerLabel.Text = "İçindekiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(284, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "İçindekiler";
            // 
            // urun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icindekilerLabel);
            this.Controls.Add(this.urunLabel);
            this.Controls.Add(this.barkodLabel);
            this.Name = "urun";
            this.Text = "Ürün";
            this.Load += new System.EventHandler(this.urun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label barkodLabel;
        private System.Windows.Forms.Label urunLabel;
        private System.Windows.Forms.Label icindekilerLabel;
        private System.Windows.Forms.Label label1;
    }
}