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
        }



        // Label'a tıklama olayını işleyen metot
        private void icindekilerLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // Fare konumunu al
                Point mousePosition = clickedLabel.PointToClient(Cursor.Position);

                // Tıklanan kelimeyi bul
                string clickedWord = GetClickedWord(clickedLabel, mousePosition);

                if (!string.IsNullOrEmpty(clickedWord))
                {
                    // Tıklanan kelimeyi MessageBox ile göster
                    MessageBox.Show($"{clickedWord} nedir? Açıklama burada gösterilebilir.");
                }
            }
        }

        // Fare konumuna göre Label'daki kelimeyi bulan gelişmiş metot
        private string GetClickedWord(Label label, Point mousePosition)
        {
            string labelText = label.Text;
            string[] words = labelText.Split(' ');

            using (Graphics g = label.CreateGraphics())
            {
                float x = 0, y = 0; // Metnin başlangıç koordinatları
                float lineHeight = TextRenderer.MeasureText("A", label.Font).Height; // Satır yüksekliği

                foreach (string word in words)
                {
                    SizeF wordSize = g.MeasureString(word + " ", label.Font);

                    // Eğer satırın sınırını geçerse, alt satıra in
                    if (x + wordSize.Width > label.Width)
                    {
                        x = 0;  // Yeni satır başlangıcı
                        y += lineHeight; // Bir satır aşağı kay
                    }

                    // Eğer fare pozisyonu bu kelimenin içindeyse, kelimeyi döndür
                    if (mousePosition.X >= x && mousePosition.X <= x + wordSize.Width &&
                        mousePosition.Y >= y && mousePosition.Y <= y + lineHeight)
                    {
                        return word;
                    }

                    x += wordSize.Width; // Bir sonraki kelime için X'i güncelle
                }
            }

            return null;





        }
    } 
}
