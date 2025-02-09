using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icimdekiler
{
    public partial class urunEkle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icimdekilerDb.mdb");

        public string durum { get; set; }
        public string barkodNo { get; set; }
        public string urunAdi { get; set; }
        public string icindekiler { get; set; }

        public urunEkle()
        {
            InitializeComponent();
        }

        private void urunEkle_Load(object sender, EventArgs e)
        {
            if (durum == "ekle") { kaydetButton.Enabled = false; guncelleButton.Enabled = true; }
            else if (durum == "guncelle") 
            {
                kaydetButton.Enabled = false; guncelleButton.Enabled = true;

                barkodTextBox.Text = barkodNo;
                urunAdiTextBox.Text = urunAdi;
                icindekilerTextBox.Text = icindekiler;
            }

            icindekilerTextBox.MouseDoubleClick += icindekilerTextBox_MouseDoubleClick;
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            adminAnaSayfa adminAnaSayfa = new adminAnaSayfa();
            adminAnaSayfa.Show();
            this.Hide();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            urunEkleDB();
        }

        void urunEkleDB()
        {
            string barkodNo = barkodTextBox.Text;
            string urunAdi = urunAdiTextBox.Text;
            string icindekiler = icindekilerTextBox.Text;

            string sorgu = "INSERT INTO urunler(barkodNo,urunAdi,icindekiler) VALUES ('" + barkodNo + "','" + urunAdi + "','" + icindekiler + "')";

            if (!string.IsNullOrWhiteSpace(barkodNo) && !string.IsNullOrWhiteSpace(urunAdi) && !string.IsNullOrWhiteSpace(icindekiler))
            {
                baglan.Open();

                OleDbCommand komut = new OleDbCommand(sorgu, baglan);
                komut.ExecuteNonQuery();

                baglan.Close();
            }
            else MessageBox.Show("Lütfen boş alan bırakmayınız!!");
        }


        private bool isMessageBoxOpen = false;

        private void icindekilerTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isMessageBoxOpen) return; // Eğer zaten gösterildiyse tekrar açma

            isMessageBoxOpen = true; // Mesaj kutusu açık olarak işaretle

            int index = icindekilerTextBox.GetCharIndexFromPosition(e.Location);
            string clickedWord = GetClickedWord(icindekilerTextBox, index);

            if (!string.IsNullOrEmpty(clickedWord))
            {
                icindekilerTextBox.MouseDoubleClick -= icindekilerTextBox_MouseDoubleClick;
                MessageBox.Show($"{clickedWord} nedir? Açıklama burada gösterilebilir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                icindekilerTextBox.MouseDoubleClick += icindekilerTextBox_MouseDoubleClick;
            }

            isMessageBoxOpen = false; // Mesaj kutusu kapandığında tekrar açılmasına izin ver
        }

        private string GetClickedWord(RichTextBox rtb, int index)
        {
            string text = rtb.Text;
            if (index < 0 || index >= text.Length)
                return null;

            int start = index;
            int end = index;

            while (start > 0 && char.IsLetterOrDigit(text[start - 1]))
                start--;

            while (end < text.Length && char.IsLetterOrDigit(text[end]))
                end++;

            return text.Substring(start, end - start);
        }
    }
}
