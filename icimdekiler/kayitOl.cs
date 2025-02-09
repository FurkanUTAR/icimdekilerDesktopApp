using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace icimdekiler
{
    public partial class kayitOl : Form
    {

        OleDbConnection baglan=new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icimdekilerDb.mdb");


        public kayitOl()
        {
            InitializeComponent();
        }

        private void girisYapLabel_Click(object sender, EventArgs e)
        {
            Form1 girisYap = new Form1();
            girisYap.Show();
            this.Hide();
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            kayitEkle();
        }

        private void telNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true; // Karakterin girişini engelle
        }

        void kayitEkle()
        {
            string kullaniciAdi = kullaniciAdiTextBox.Text.ToString();
            string adSoyad = adSoyadTextBox.Text.ToString();
            string ePosta = ePostaTextBox.Text.ToString();
            string telNo = telNoTextBox.Text.ToString();
            string parola = parolaTextBox.Text.ToString();

            string kontrolSorgu = "SELECT COUNT(*) FROM kullanicilar WHERE kullaniciAdi = '"+kullaniciAdi+"'";
            string sorgu = "INSERT INTO kullanicilar(kullaniciAdi,adSoyad,parola,ePosta,telNo) VALUES ('" + kullaniciAdi + "', '" + adSoyad + "', '" + parola + "', '" + ePosta + "', '" + telNo + "') ";

            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(adSoyad) && !string.IsNullOrEmpty(ePosta) && !string.IsNullOrEmpty(telNo) && !string.IsNullOrEmpty(parola))
            {
                baglan.Open();

                OleDbCommand kontrolKomut = new OleDbCommand(kontrolSorgu, baglan);
                int kullaniciSayisi = (int)kontrolKomut.ExecuteScalar();

                if (kullaniciSayisi > 0) MessageBox.Show("Bu kullanıcı adı daha önce alınmıştır, lütfen farklı bir kullanıcı adı deneyiniz!");
                else
                {
                    OleDbCommand komut = new OleDbCommand(sorgu, baglan);
                    komut.ExecuteNonQuery();

                    Form1 girisYap= new Form1();
                    girisYap.Show();
                    this.Hide();
                }

                baglan.Close();
            }
            else MessageBox.Show("Boş alan bırakmayınız");
        }
    }
}
