using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icimdekiler
{
    public partial class kullaniciAnaSayfa : Form
    {
        public kullaniciAnaSayfa()
        {
            InitializeComponent();
        }

        // Label'a tıklama olayını işleyen metot
        private void IcindekilerLabel_Click(object sender, EventArgs e)
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

        // Fare konumuna göre Label'daki kelimeyi bulan metot
        private string GetClickedWord(Label label, Point mousePosition)
        {
            // Label'ın metnini al
            string labelText = label.Text;

            // Label'ın yazı tipi bilgilerini al
            using (Graphics g = label.CreateGraphics())
            {
                // Metni boşluklara göre parçalara ayır
                string[] words = labelText.Split(' ');

                // Kelimelerin başlangıç ve bitiş konumlarını hesapla
                float startX = 0;
                foreach (string word in words)
                {
                    // Kelimenin genişliğini ölç
                    SizeF wordSize = g.MeasureString(word + " ", label.Font);

                    // Fare konumu bu kelimenin içinde mi kontrol et
                    if (mousePosition.X >= startX && mousePosition.X <= startX + wordSize.Width)
                    {
                        return word;
                    }

                    // Bir sonraki kelimenin başlangıç konumunu güncelle
                    startX += wordSize.Width;
                }
            }

            return null; // Fare konumu hiçbir kelimeyle eşleşmiyorsa null döner
        }

        // Label1'e tıklama olayını yönlendiren metot (isteğe bağlı)
        private void label1_Click(object sender, EventArgs e)
        {
            IcindekilerLabel_Click(sender, e); // İsteğe bağlı, başka bir metodu çağırabilir
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

