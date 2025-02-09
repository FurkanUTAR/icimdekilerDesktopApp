using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace icimdekiler
{
    public partial class Form1 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icimdekilerDb.mdb");

        public Form1()
        {
            InitializeComponent();
        }

        private void girisYapButton_Click(object sender, EventArgs e)
        {
            girisYap();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            kayitOl kayitOl = new kayitOl();
            kayitOl.Show();
            this.Hide();

        }

        private void telefonNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true; // Karakterin girişini engelle
        }

        void girisYap()
        {
            if (kullaniciAdiTextBox.Text == " " && adSoyadTextBox.Text == " " && parolaTextBox.Text == " " && ePostaTextBox.Text == " " && telefonNoTextBox.Text == " ")
            {
                MessageBox.Show("Bilgiler Eksiksiz Doldurulmalı !!!");
            }
            else 
            {
                string kullaniciAdi = kullaniciAdiTextBox.Text;
                string adSoyad = adSoyadTextBox.Text;
                string parola = parolaTextBox.Text;
                string ePosta = ePostaTextBox.Text;
                string telNo = telefonNoTextBox.Text;
              
                baglan.Open();

                string sorgu = "SELECT * FROM kullanicilar WHERE kullaniciAdi='" + kullaniciAdi + "' AND adSoyad='" + adSoyad + "' AND parola='" + parola + "' AND ePosta='" + ePosta + "' AND telNo='" + telNo + "'";
                OleDbCommand komut = new OleDbCommand(sorgu,baglan);
                OleDbDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    string yetki = oku.GetString(1);
                    if (yetki == "1")
                    {
                        kullaniciAnaSayfa kullaniciAnaSayfa = new kullaniciAnaSayfa();
                        kullaniciAnaSayfa.Show();
                        this.Hide();
                    }
                    else if (yetki == "0")
                    {
                        adminAnaSayfa adminAnaSayfa = new adminAnaSayfa();
                        adminAnaSayfa.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Kullanıcı bulunamadı!!!!");
                baglan.Close();
            }
        }


    }
}
