using System;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Windows.Forms;

namespace icimdekiler
{
    public partial class urunEkle : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icimdekilerDb.mdb");

        public string durum { get; set; }
        public int kimlik { get; set; }
        public string barkodNo { get; set; }
        public string urunAdi { get; set; }
        public string icindekiler { get; set; }

        adminAnaSayfa adminAnaSayfa = new adminAnaSayfa();

        public urunEkle()
        {
            InitializeComponent();
        }

        private void urunEkle_Load(object sender, EventArgs e)
        {
            icerikGoster();

            if (durum == "ekle") { kaydetButton.Enabled = true; guncelleButton.Enabled = false; silButton.Enabled = false; }
            else if (durum == "guncelle")
            {
                kaydetButton.Enabled = false; guncelleButton.Enabled = true; silButton.Enabled = true;

                barkodTextBox.Text = barkodNo;
                urunAdiTextBox.Text = urunAdi;
                icindekilerTextBox.Text = icindekiler;
            }
            icindekilerTextBox.MouseDoubleClick += icindekilerTextBox_MouseDoubleClick;
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            adminAnaSayfa.Show();
            this.Hide();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            urunEkleDB();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            urunGuncelleDB();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            urunSilDB();
        }

        private void urunEklePictureBox_Click(object sender, EventArgs e)
        {
            if (urunlerComboBox.SelectedItem != null) icindekilerTextBox.Text += $"{urunlerComboBox.SelectedItem.ToString()}, "; // Seçili ürün varsa
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


                adminAnaSayfa.Show();
                this.Hide();

                baglan.Close();
            }
            else MessageBox.Show("Lütfen boş alan bırakmayınız!!");
        }

        void urunGuncelleDB()
        {
            string barkodNo = barkodTextBox.Text;
            string urunAdi = urunAdiTextBox.Text;
            string icindekiler = icindekilerTextBox.Text;

            string sorgu = "UPDATE urunler SET barkodNo='" + barkodNo + "',urunAdi='" + urunAdi + "',icindekiler='" + icindekiler + "' WHERE Kimlik=" + kimlik + " ";

            if (!string.IsNullOrWhiteSpace(barkodNo) && !string.IsNullOrWhiteSpace(urunAdi) && !string.IsNullOrWhiteSpace(icindekiler))
            {
                baglan.Open();

                OleDbCommand komut = new OleDbCommand(sorgu, baglan);
                komut.ExecuteNonQuery();

                adminAnaSayfa.Show();
                this.Hide();

                baglan.Close();
            }
            else MessageBox.Show("Lütfen boş alan bırakmayınız!!");
        }

        void urunSilDB()
        {
            string sorgu = "DELETE FROM urunler WHERE Kimlik=" + kimlik + " ";

            baglan.Open();

            OleDbCommand komut = new OleDbCommand(sorgu,baglan);
            komut.ExecuteNonQuery();

            adminAnaSayfa.Show();
            this.Hide();

            baglan.Close();
        }

        void icerikGoster()
        {
            string sorgu = "SELECT urun FROM icerik";

            baglan.Open();

            OleDbCommand komut = new OleDbCommand(sorgu, baglan);
            OleDbDataReader oku = komut.ExecuteReader();

            urunlerComboBox.Items.Clear(); // Önceki verileri temizle

            while (oku.Read())
            {
                string urun = oku.GetString(0);
                urunlerComboBox.Items.Add(urun);
            }

            oku.Close();
            baglan.Close();
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

                string sorgu = "SELECT aciklama FROM icerik WHERE urun = @urunAdi";

                baglan.Open();

                OleDbCommand komut = new OleDbCommand(sorgu, baglan);
                komut.Parameters.AddWithValue("@urunAdi", clickedWord);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    string aciklama = oku.GetString(0);

                    // MouseDoubleClick event'ini geçici olarak kaldır
                    icindekilerTextBox.MouseDoubleClick -= icindekilerTextBox_MouseDoubleClick;

                    // MessageBox göster
                    MessageBox.Show($"{clickedWord} nedir? {aciklama}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // MessageBox kapandıktan sonra isMessageBoxOpen değişkenini false yap
                    isMessageBoxOpen = false;

                    // MouseDoubleClick event'ini tekrar ekle
                    icindekilerTextBox.MouseDoubleClick += icindekilerTextBox_MouseDoubleClick;
                }
                else MessageBox.Show("Seçili ürün bulunamamıştır!");
                oku.Close();
                baglan.Close();


            }
            else isMessageBoxOpen = false;
        }

        private string GetClickedWord(RichTextBox rtb, int index)
        {
            string text = rtb.Text;
            if (index < 0 || index >= text.Length)
                return null;

            int start = index;
            int end = index;

            // Kelimenin başlangıç pozisyonunu bul (Harf, rakam ve boşlukları al)
            while (start > 0 && (char.IsLetterOrDigit(text[start - 1]) || text[start - 1] == ' '))
                start--;

            // Kelimenin bitiş pozisyonunu bul (Harf, rakam ve boşlukları al)
            while (end < text.Length && (char.IsLetterOrDigit(text[end]) || text[end] == ' '))
                end++;

            // Kelimenin sonundaki boşlukları temizle
            return text.Substring(start, end - start).Trim();
        }

    }
}
