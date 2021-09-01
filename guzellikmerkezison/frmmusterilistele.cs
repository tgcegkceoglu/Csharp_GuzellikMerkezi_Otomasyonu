using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guzellikmerkezison
{
    public partial class frmmusterilistele : Form
    {
        public frmmusterilistele()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        private void göster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from musteri";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            string sorgu = "update musteri set adivesoyadi=@adivesoyadi, telefon=@telefon, tarih=@tarih ,saat=@saat where  musterino=@musterino";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@musterino", txtmusterino.Text);
            komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@tarih", txttarih.Text);
            komut.Parameters.AddWithValue("@saat", txtsaat.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            göster();
        }

        private void frmmusterilistele_Load(object sender, EventArgs e)
        {
            göster();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmusterino.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadisoyadı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttarih.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtsaat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Sil", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                string sorgu = "delete from musteri where musterino=@musterino";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@musterino", txtmusterino.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                

                string sorgu1 = "delete from seansekleme1 where adivesoyadi=@adivesoyadi";
                SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
                komut1.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                baglanti.Open();
                komut1.ExecuteNonQuery();
                baglanti.Close();

                string sorgu2 = "delete from tahsilat where musteriadi=@adivesoyadi";
                SqlCommand komut2 = new SqlCommand(sorgu2, baglanti);
                komut2.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                baglanti.Open();
                komut2.ExecuteNonQuery();
                baglanti.Close();

                string sorgu3 = "delete from tahsilat1 where adivesoyadi=@adivesoyadi";
                SqlCommand komut3 = new SqlCommand(sorgu3, baglanti);
                komut3.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                baglanti.Open();
                komut3.ExecuteNonQuery();
                baglanti.Close();
                göster();

                string sorgu4 = "delete from bugün where ad=@ad";
                SqlCommand komut4 = new SqlCommand(sorgu4, baglanti);
                komut4.Parameters.AddWithValue("@ad", txtadisoyadı.Text);
                baglanti.Open();
                komut4.ExecuteNonQuery();
                baglanti.Close();
                göster();

                string sorgu5 = "delete from tarih2 where musteriadi=@ad";
                SqlCommand komut5 = new SqlCommand(sorgu5, baglanti);
                komut5.Parameters.AddWithValue("@ad", txtadisoyadı.Text);
                baglanti.Open();
                komut5.ExecuteNonQuery();
                baglanti.Close();
                göster();

            }
        }

        
      
        

        private void button2_Click(object sender, EventArgs e)
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "Select *from musteri where adivesoyadi like '%" + txtara.Text + "%'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            arama aramayap = new arama();
            dataGridView1.DataSource = aramayap.listele(adtr, cümle);
            if (txtara.Text == "")
            {
                göster();
            }
        }

        private void txtmusterino_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtadisoyadı_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtadisoyadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    
}
