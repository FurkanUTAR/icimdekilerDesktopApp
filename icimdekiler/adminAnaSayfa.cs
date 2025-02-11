using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace icimdekiler
{
    public partial class adminAnaSayfa : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icimdekilerDb.mdb");

        public adminAnaSayfa()
        {
            InitializeComponent();
        }

        private void adminAnaSayfa_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void araPictureBox_Click(object sender, EventArgs e)
        {
            urunAdiAra();
        }

        private void yenilePictureBox_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM urunler";

            baglan.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            urunlerDataGridView.DataSource = dt;
            urunlerDataGridView.Columns["Kimlik"].Visible = false;

            baglan.Close();
        }

        private void urunlerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int kimlik=int.Parse(urunlerDataGridView.CurrentRow.Cells[0].Value.ToString());
            string barkodNo=urunlerDataGridView.CurrentRow.Cells[1].Value.ToString();
            string urunAdi=urunlerDataGridView.CurrentRow.Cells[2].Value.ToString();
            string icindekiler=urunlerDataGridView.CurrentRow.Cells[3].Value.ToString();

            urunEkle urunEkle = new urunEkle();
            urunEkle.durum = "guncelle";
            urunEkle.kimlik= kimlik;
            urunEkle.barkodNo = barkodNo;
            urunEkle.urunAdi = urunAdi;
            urunEkle.icindekiler = icindekiler;
            urunEkle.Show();
            this.Hide();
        }

        private void urunEklePictureBox_Click(object sender, EventArgs e)
        {
            urunEkle urunEkle = new urunEkle();
            urunEkle.durum = "ekle";
            urunEkle.Show();
            this.Hide();   
        }

        void verileriGoster()
        {
            string sorgu = "SELECT * FROM urunler";

            baglan.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(sorgu,baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            urunlerDataGridView.DataSource = dt;
            urunlerDataGridView.Columns["Kimlik"].Visible = false;

            baglan.Close();
        }

        void urunAdiAra()
        {
            string urunAdi=araTextBox.Text;

            string sorgu = "SELECT * FROM urunler WHERE urunAdi LIKE '%"+urunAdi+"%' ";

            baglan.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(sorgu, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);

            urunlerDataGridView.DataSource = dt;
            urunlerDataGridView.Columns["Kimlik"].Visible = false;

            baglan.Close();
        }
    }
}
