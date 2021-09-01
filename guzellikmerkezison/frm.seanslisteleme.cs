using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace guzellikmerkezison
{
    public partial class seanslisteleme : Form
    {
        public seanslisteleme()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void göster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from seansekleme1";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }
        DataTable tablo = new DataTable();
        private void Seanslisteleme(string sql)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            SqlDataAdapter musteri = new SqlDataAdapter(sql, baglanti);
            musteri.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }


        private void seanslisteleme_Load(object sender, EventArgs e)
        {
            göster();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            tablo.Clear();
            Seanslisteleme("select*from seansekleme1");

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string cümle = "Select *from seansekleme1 where adivesoyadi like '%" + txtara.Text + "%'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            arama aramayap = new arama();
            dataGridView1.DataSource = aramayap.listele(adtr, cümle);
            if (txtara.Text == "")
            {
                göster();
            }
        }


        void odendi()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from tahsilat1 where durum='ödendi'";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }
        void bekleniyor()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from tahsilat1 where durum='Bekleniyor'";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            string sorgu = "delete from seansekleme1 where sirano=@sirano";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@sirano", txtmusterino.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            göster();

     
            string sorgu5 = "delete from tarih2 where musteriadi=@ad";
            SqlCommand komut5 = new SqlCommand(sorgu5, baglanti);
            komut5.Parameters.AddWithValue("@ad", txtadisoyadı.Text);
            baglanti.Open();
            komut5.ExecuteNonQuery();
            baglanti.Close();
     

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            string sorgu = "update seansekleme1 set  adivesoyadi=@adivesoyadi, telefon=@telefon,yapilanis=@yapilanis,seans=@seans, tarih=@tarih ,saat=@saat where  sirano=@sirano";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@sirano", txtmusterino.Text);
            komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@yapilanis", txtyapilanis.Text);
            komut.Parameters.AddWithValue("@seans", txtseans.Text);
            komut.Parameters.AddWithValue("@tarih", txttarih.Text);
            komut.Parameters.AddWithValue("@saat", txtsaat.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            göster();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmusterino.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadisoyadı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtyapilanis.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtseans.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
           txttarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsaat.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void txttarih_TextChanged(object sender, EventArgs e)
        {

            
        }
    }
}












