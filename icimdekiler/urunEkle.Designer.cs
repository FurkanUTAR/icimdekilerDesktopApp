namespace icimdekiler
{
    partial class urunEkle
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
            this.icindekilerTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barkodTextBox = new System.Windows.Forms.TextBox();
            this.kaydetButton = new System.Windows.Forms.Button();
            this.guncelleButton = new System.Windows.Forms.Button();
            this.urunlerComboBox = new System.Windows.Forms.ComboBox();
            this.urunEklePictureBox = new System.Windows.Forms.PictureBox();
            this.geriDonPictureBox = new System.Windows.Forms.PictureBox();
            this.barkodOkuPictureBox = new System.Windows.Forms.PictureBox();
            this.silButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunEklePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkodOkuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // icindekilerTextBox
            // 
            this.icindekilerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.icindekilerTextBox.Location = new System.Drawing.Point(262, 152);
            this.icindekilerTextBox.Name = "icindekilerTextBox";
            this.icindekilerTextBox.Size = new System.Drawing.Size(259, 142);
            this.icindekilerTextBox.TabIndex = 3;
            this.icindekilerTextBox.Text = "";
            this.icindekilerTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.icindekilerTextBox_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İçindekiler";
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunAdiTextBox.Location = new System.Drawing.Point(258, 95);
            this.urunAdiTextBox.Multiline = true;
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(263, 25);
            this.urunAdiTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(258, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barkod";
            // 
            // barkodTextBox
            // 
            this.barkodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barkodTextBox.Location = new System.Drawing.Point(258, 44);
            this.barkodTextBox.Multiline = true;
            this.barkodTextBox.Name = "barkodTextBox";
            this.barkodTextBox.Size = new System.Drawing.Size(263, 25);
            this.barkodTextBox.TabIndex = 0;
            // 
            // kaydetButton
            // 
            this.kaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetButton.Location = new System.Drawing.Point(258, 300);
            this.kaydetButton.Name = "kaydetButton";
            this.kaydetButton.Size = new System.Drawing.Size(263, 41);
            this.kaydetButton.TabIndex = 9;
            this.kaydetButton.Text = "Kaydet";
            this.kaydetButton.UseVisualStyleBackColor = true;
            this.kaydetButton.Click += new System.EventHandler(this.kaydetButton_Click);
            // 
            // guncelleButton
            // 
            this.guncelleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelleButton.Location = new System.Drawing.Point(258, 347);
            this.guncelleButton.Name = "guncelleButton";
            this.guncelleButton.Size = new System.Drawing.Size(263, 41);
            this.guncelleButton.TabIndex = 10;
            this.guncelleButton.Text = "Güncelle";
            this.guncelleButton.UseVisualStyleBackColor = true;
            this.guncelleButton.Click += new System.EventHandler(this.guncelleButton_Click);
            // 
            // urunlerComboBox
            // 
            this.urunlerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunlerComboBox.FormattingEnabled = true;
            this.urunlerComboBox.Location = new System.Drawing.Point(344, 125);
            this.urunlerComboBox.Name = "urunlerComboBox";
            this.urunlerComboBox.Size = new System.Drawing.Size(177, 21);
            this.urunlerComboBox.TabIndex = 13;
            // 
            // urunEklePictureBox
            // 
            this.urunEklePictureBox.Image = global::icimdekiler.Properties.Resources.add;
            this.urunEklePictureBox.Location = new System.Drawing.Point(526, 125);
            this.urunEklePictureBox.Name = "urunEklePictureBox";
            this.urunEklePictureBox.Size = new System.Drawing.Size(21, 21);
            this.urunEklePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.urunEklePictureBox.TabIndex = 14;
            this.urunEklePictureBox.TabStop = false;
            this.urunEklePictureBox.Click += new System.EventHandler(this.urunEklePictureBox_Click);
            // 
            // geriDonPictureBox
            // 
            this.geriDonPictureBox.Image = global::icimdekiler.Properties.Resources.left;
            this.geriDonPictureBox.Location = new System.Drawing.Point(3, 1);
            this.geriDonPictureBox.Name = "geriDonPictureBox";
            this.geriDonPictureBox.Size = new System.Drawing.Size(35, 25);
            this.geriDonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.geriDonPictureBox.TabIndex = 11;
            this.geriDonPictureBox.TabStop = false;
            this.geriDonPictureBox.Click += new System.EventHandler(this.geriDonPictureBox_Click);
            // 
            // barkodOkuPictureBox
            // 
            this.barkodOkuPictureBox.Image = global::icimdekiler.Properties.Resources.barcodeScanner;
            this.barkodOkuPictureBox.Location = new System.Drawing.Point(527, 44);
            this.barkodOkuPictureBox.Name = "barkodOkuPictureBox";
            this.barkodOkuPictureBox.Size = new System.Drawing.Size(20, 20);
            this.barkodOkuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barkodOkuPictureBox.TabIndex = 8;
            this.barkodOkuPictureBox.TabStop = false;
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(258, 394);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(263, 41);
            this.silButton.TabIndex = 15;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // urunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.urunEklePictureBox);
            this.Controls.Add(this.urunlerComboBox);
            this.Controls.Add(this.geriDonPictureBox);
            this.Controls.Add(this.guncelleButton);
            this.Controls.Add(this.kaydetButton);
            this.Controls.Add(this.barkodOkuPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barkodTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urunAdiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.icindekilerTextBox);
            this.Name = "urunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.urunEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunEklePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.geriDonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barkodOkuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox icindekilerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barkodTextBox;
        private System.Windows.Forms.PictureBox barkodOkuPictureBox;
        private System.Windows.Forms.Button kaydetButton;
        private System.Windows.Forms.Button guncelleButton;
        private System.Windows.Forms.PictureBox geriDonPictureBox;
        private System.Windows.Forms.ComboBox urunlerComboBox;
        private System.Windows.Forms.PictureBox urunEklePictureBox;
        private System.Windows.Forms.Button silButton;
    }
}