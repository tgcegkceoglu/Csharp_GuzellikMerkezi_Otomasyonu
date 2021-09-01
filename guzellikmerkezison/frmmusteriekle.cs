using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guzellikmerkezison
{
    public partial class frmmusteriekle : Form
    {
        public frmmusteriekle()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
        
        void göster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select *  from musteri";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            foreach (Control item in groupBox1.Controls)
            {
                
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {

                       
                        MessageBox.Show("Boş Alan Bırakmayınız!", "Hata Mesajı",MessageBoxButtons.OK , MessageBoxIcon.Error);
                        kontrol = 1;
                    }

                }
            }
            if (kontrol == 0)
            {
                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into musteri(musterino,adivesoyadi,telefon,tarih,saat) values (@musterino,@adivesoyadi,@telefon,@tarih,@saat)", baglanti);
                komut.Parameters.AddWithValue("@musterino", txtmusterino.Text);
                komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                komut.Parameters.AddWithValue("@tarih", tarih.Text);
                komut.Parameters.AddWithValue("@saat", saat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri Başarı ile Eklendi","Müşteri Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                göster();

                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Yeni Bir Müşteri Eklemek İster Misiniz?", "Müşteri Ekleme", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {

                    txtmusterino.Enabled = false;
                    var nesneler = groupBox1.Controls.OfType<TextBox>();

                    foreach (var nesne in nesneler)
                    {
                        nesne.Clear();
                        txtmusterino.Enabled = true;
                        int sayi = dataGridView1.Rows.Count;
                        txtmusterino.Text = sayi.ToString();

                    }
                    txtmusterino.Enabled = false;


                }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToShortDateString();
            saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmmusteriekle_Load(object sender, EventArgs e)
        {
           
            göster();
            int sayi = dataGridView1.Rows.Count ;
            txtmusterino.Text = sayi.ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtadisoyadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txttelefon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txttelefon_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
