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
                    // Example: Show message box for clicked word.
                    MessageBox.Show($"{clickedWord} nedir? Açıklama burada gösterilebilir.");
                }
            }
        }

        private string GetClickedWord(Label label, Point mousePosition)
        {
            string labelText = label.Text;
            string[] words = labelText.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            float startX = 0;
            float yOffset = 0;
            int lineHeight = TextRenderer.MeasureText("A", label.Font).Height;

            using (Graphics g = label.CreateGraphics())
            {
                foreach (string word in words)
                {
                    string cleanWord = word.Trim(new char[] { '.', ',', ';', '!', '?' });
                    Size wordSize = TextRenderer.MeasureText(cleanWord + " ", label.Font);

                    if (startX + wordSize.Width > label.Width)
                    {
                        startX = 0;
                        yOffset += lineHeight;
                    }

                    if (mousePosition.X >= startX && mousePosition.X <= startX + wordSize.Width &&
                        mousePosition.Y >= yOffset && mousePosition.Y <= yOffset + lineHeight)
                    {
                        return cleanWord;
                    }
                    startX += wordSize.Width;
                }
            }
            return null;
        }

    }


    
} 

