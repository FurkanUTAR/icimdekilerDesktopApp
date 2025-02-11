using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace icimdekiler
{
    public partial class urun : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icimdekilerDb.mdb");

        public string barkodNo { get; set; }
        public string urunAdi { get; set; }
        public string icindekiler { get; set; }

        public urun()
        {
            InitializeComponent();
        }

        private void urun_Load(object sender, EventArgs e)
        {
            barkodLabel.Text = barkodNo;
            urunLabel.Text = urunAdi;
            icindekilerLabel.Text = icindekiler;

            icindekilerLabel.AutoSize = false;
            icindekilerLabel.TextAlign = ContentAlignment.TopLeft;
            icindekilerLabel.Click += icindekilerLabel_Click;
        }

        // Label'a tıklama olayını işleyen metot
        private void icindekilerLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                Point mousePosition = clickedLabel.PointToClient(Cursor.Position);
                string clickedWord = GetClickedWord(clickedLabel, mousePosition);

                if (!string.IsNullOrEmpty(clickedWord))
                {
                    string sorgu = "SELECT aciklama FROM icerik WHERE urun = @urunAdi";

                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand(sorgu, baglan);
                    komut.Parameters.AddWithValue("@urunAdi", clickedWord);
                    OleDbDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        string aciklama = oku.GetString(0);
                        MessageBox.Show($"{clickedWord} nedir? {aciklama}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Seçili ürün bulunamamıştır!");
                    }

                    oku.Close();
                    baglan.Close();
                }
            }
        }

        private string GetClickedWord(Label label, Point mousePosition)
        {
            string labelText = label.Text;
            string[] words = labelText.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            using (Graphics g = label.CreateGraphics())
            {
                float currentX = 0;
                float currentY = 0;
                int lineHeight = TextRenderer.MeasureText("A", label.Font).Height + 5;

                foreach (string word in words)
                {
                    string cleanWord = word.Trim(new char[] { '.', ',', ';', '!', '?' });
                    SizeF wordSize = g.MeasureString(cleanWord, label.Font);

                    if (currentX + wordSize.Width > label.Width)
                    {
                        currentX = 0;
                        currentY += lineHeight;
                    }

                    // Kelime sınırlarını hesapla
                    RectangleF wordRect = new RectangleF(currentX, currentY, wordSize.Width, wordSize.Height);

                    // Tıklanan nokta kelime sınırları içindeyse, kelimeyi döndür
                    if (mousePosition.X >= wordRect.Left && mousePosition.X <= wordRect.Right &&
                        mousePosition.Y >= wordRect.Top && mousePosition.Y <= wordRect.Bottom)
                    {
                        return cleanWord;
                    }

                    currentX += wordSize.Width + 8;
                }
            }
            return null;
        }
    }
} 

