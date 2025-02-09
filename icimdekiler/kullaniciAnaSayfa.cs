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

namespace icimdekiler
{
    public partial class kullaniciAnaSayfa : Form
    {
        public kullaniciAnaSayfa()
        {
            InitializeComponent();
        }

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.JET.OLEDB.4.0;Data Source=icimdekilerDb.mdb");


       
        private void kullaniciAnaSayfa_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }
        private void araPictureBox_Click(object sender, EventArgs e)
        {
            urunAdiAra();
        }
        private void urunlerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string barkodNo = urunlerDataGridView.CurrentRow.Cells[1].Value.ToString();
            string urunAdi = urunlerDataGridView.CurrentRow.Cells[2].Value.ToString();
            string icindekiler = urunlerDataGridView.CurrentRow.Cells[3].Value.ToString();
            urun urun = new urun();
            urun.barkodNo = barkodNo;
            urun.urunAdi = urunAdi;
            urun.icindekiler = icindekiler;
            urun.Show();
            this.Hide();
              
        }














        

        void verileriGoster()
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
        void urunAdiAra()
        {
            string urunAdi = araTextBox.Text;

            string sorgu = "SELECT * FROM urunler WHERE urunAdi LIKE '%" + urunAdi + "%' ";

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

