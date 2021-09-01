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
    public partial class seansss : Form
    {
        public seansss()
        {
            InitializeComponent();
        }
        private void göster1()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from musteri";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView2.DataSource = datatable;
            baglanti.Close();

        }
        private void göster2()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from tahsilat1";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView3.DataSource = datatable;
            baglanti.Close();

        }

        private void göster()
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

        int sonuc;
        string odeme = "";
        string durum = "Bekleniyor";


        private void seansss_Load(object sender, EventArgs e)
        {
            göster();
            göster1();
            göster2();
        }

        baglanti bgl = new baglanti();
       

        private void button1_Click(object sender, EventArgs e)
        {
            int kontrol = 0;
            foreach (Control item in groupBox1.Controls)
            {

                if (item is TextBox)
                {
                    if (item.Text == "")
                    {


                       
                        kontrol = 1;
                    }

                }
            }
            foreach (Control item in groupBox2.Controls)
            {

                if (item is TextBox)
                {
                    if (item.Text == "")
                    {


                      
                        kontrol = 1;
                    }

                }
            }
            foreach (Control item in groupBox3.Controls)
            {

                if (item is TextBox)
                {
                    if (item.Text == "")
                    {


                        
                        kontrol = 1;
                    }

                }
            }

            if (kontrol == 0)
            {
                SqlConnection baglanti = new SqlConnection(bgl.adres);


                if (sonuc == 0)
                {


                    for (int i = 0; i < Convert.ToInt32(txtseans.Text); i++)
                    {

                        baglanti.Open();
                        int sayi1 = dataGridView1.Rows.Count;
                        SqlCommand komut = new SqlCommand("insert into seansekleme1(sirano,adivesoyadi,telefon,yapilanis,seans,tarih,saat) values (@sirano,@adivesoyadi,@telefon,@yapilanis,@seans,@tarih,@saat)", baglanti);
                        komut.Parameters.AddWithValue("@sirano", sayi1.ToString());
                        komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        komut.Parameters.AddWithValue("@yapilanis", txtyapilanis.Text);
                        komut.Parameters.AddWithValue("@seans", txtseans.Text);
                        if (i == 0)
                        {
                            komut.Parameters.AddWithValue("@tarih",dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd-MM-yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut.Parameters.AddWithValue("@tarih",gun.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }



                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut1 = new SqlCommand("insert into tarih2(musteriadi,tarih,saat) values (@musteriadi,@tarih,@saat)", baglanti);
                        komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadı.Text);

                        if (i == 0)
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            DateTime gun = h.AddDays(-1);
                            komut1.Parameters.AddWithValue("@tarih", gun.ToString());

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            int ekle1 = ekle - 1;
                            DateTime gun = h.AddDays(ekle1);
                            komut1.Parameters.AddWithValue("@tarih", gun.ToString("dd.MM.yyyy"));

                        }
                        komut1.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        komut1.ExecuteNonQuery();
                        baglanti.Close();



                        göster();
                        anasayfa ana = new anasayfa();
                        ana.button8_Click(sender, e);
                    }

                    baglanti.Open();
                    int sayi = dataGridView3.Rows.Count;
                    SqlCommand komut2 = new SqlCommand("insert into tahsilat1(sirano,adivesoyadi,telefon,odenecektutar,yatirilantutar,kalantutar,odemeturu,durum,tarih) values(@sirano,@adivesoyadi,@telefon,@odenecektutar,@yatirilantutar,@kalantutar,@odemeturu,@durum,@tarih)", baglanti);
                    komut2.Parameters.AddWithValue("@sirano", sayi.ToString());
                    komut2.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                    komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
                    komut2.Parameters.AddWithValue("@odenecektutar",txtucret.Text);
                    komut2.Parameters.AddWithValue("@yatirilantutar", 0.ToString());
                    komut2.Parameters.AddWithValue("@kalantutar", txtucret.Text);
                    komut2.Parameters.AddWithValue("@odemeturu", odeme);
                    komut2.Parameters.AddWithValue("@durum", durum);
                    komut2.Parameters.AddWithValue("@tarih", dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    göster2();
                }

                if (sonuc == 3)
                {
                    for (int i = 0; i < Convert.ToInt32(txtseans.Text); i++)
                    {

                        baglanti.Open();
                        int sayi = dataGridView1.Rows.Count;
                        SqlCommand komut = new SqlCommand("insert into seansekleme1(sirano,adivesoyadi,telefon,yapilanis,seans,tarih,saat) values (@sirano,@adivesoyadi,@telefon,@yapilanis,@seans,@tarih,@saat)", baglanti);
                        komut.Parameters.AddWithValue("@sirano", sayi.ToString());
                        komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        komut.Parameters.AddWithValue("@yapilanis", txtyapilanis.Text);
                        komut.Parameters.AddWithValue("@seans", txtseans.Text);
                        if (i == 0)
                        {
                            komut.Parameters.AddWithValue("@tarih", dateTimePicker2.Value.ToString("dd.M.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut.Parameters.AddWithValue("@tarih",gun.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }



                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut1 = new SqlCommand("insert into tarih2(musteriadi,tarih,saat) values (@musteriadi,@tarih,@saat)", baglanti);
                        komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadı.Text);

                        if (i == 0)
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            DateTime gun = h.AddDays(-1);
                            komut1.Parameters.AddWithValue("@tarih", gun.ToString());

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            int ekle1 = ekle - 1;
                            DateTime gun = h.AddDays(ekle1);
                            komut1.Parameters.AddWithValue("@tarih",gun.ToString("dd.MM.yyyy"));

                        }
                        komut1.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        komut1.ExecuteNonQuery();
                        baglanti.Close();


                        göster();
                        anasayfa ana = new anasayfa();
                        ana.button8_Click(sender, e);
                    }


                    for (int i = 0; i < 3; i++)
                    {

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("insert into tahsilat1(sirano,adivesoyadi,telefon,odenecektutar,yatirilantutar,kalantutar,odemeturu,durum,tarih) values(@sirano,@adivesoyadi,@telefon,@odenecektutar,@yatirilantutar,@kalantutar,@odemeturu,@durum,@tarih)", baglanti);
                        int sayi = dataGridView3.Rows.Count;
                        komut2.Parameters.AddWithValue("@sirano", sayi.ToString());
                        komut2.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        double toplam = Convert.ToDouble(txtucret.Text) / 3;
                        toplam = Math.Round(toplam, 2);

                        komut2.Parameters.AddWithValue("@odenecektutar", toplam.ToString());
                        komut2.Parameters.AddWithValue("@yatirilantutar", 0.ToString());
                        komut2.Parameters.AddWithValue("@kalantutar", toplam.ToString());
                        komut2.Parameters.AddWithValue("@odemeturu", odeme);
                        komut2.Parameters.AddWithValue("@durum", durum);

                        if (i == 0)
                        {
                            komut2.Parameters.AddWithValue("@tarih",dateTimePicker2.Value.ToString("dd.MM.yyyy"));

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut2.Parameters.AddWithValue("@tarih", gun.ToString("dd.MM.yyyy"));

                        }
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        göster2();


                    }
                }
                if (sonuc == 6)
                {

                    for (int i = 0; i < Convert.ToInt32(txtseans.Text); i++)
                    {

                        baglanti.Open();
                        int sayi = dataGridView1.Rows.Count;
                        SqlCommand komut = new SqlCommand("insert into seansekleme1(sirano,adivesoyadi,telefon,yapilanis,seans,tarih,saat) values (@sirano,@adivesoyadi,@telefon,@yapilanis,@seans,@tarih,@saat)", baglanti);
                        komut.Parameters.AddWithValue("@sirano", sayi.ToString());
                        komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        komut.Parameters.AddWithValue("@yapilanis", txtyapilanis.Text);
                        komut.Parameters.AddWithValue("@seans", txtseans.Text);
                        if (i == 0)
                        {
                            komut.Parameters.AddWithValue("@tarih",dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut.Parameters.AddWithValue("@tarih", gun.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }



                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut1 = new SqlCommand("insert into tarih2(musteriadi,tarih,saat) values (@musteriadi,@tarih,@saat)", baglanti);
                        komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadı.Text);

                        if (i == 0)
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM-yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            DateTime gun = h.AddDays(-1);
                            komut1.Parameters.AddWithValue("@tarih", gun.ToString());

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            int ekle1 = ekle - 1;
                            DateTime gun = h.AddDays(ekle1);
                            komut1.Parameters.AddWithValue("@tarih",gun.ToString("dd.MM.yyyy"));

                        }
                        komut1.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        komut1.ExecuteNonQuery();
                        baglanti.Close();




                        göster();
                        anasayfa ana = new anasayfa();
                        ana.button8_Click(sender, e);
                    }
                    for (int i = 0; i < 6; i++)
                    {

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("insert into tahsilat1(sirano,adivesoyadi,telefon,odenecektutar,yatirilantutar,kalantutar,odemeturu,durum,tarih) values(@sirano,@adivesoyadi,@telefon,@odenecektutar,@yatirilantutar,@kalantutar,@odemeturu,@durum,@tarih)", baglanti);
                        int sayi = dataGridView3.Rows.Count;
                        komut2.Parameters.AddWithValue("@sirano", sayi.ToString());
                        komut2.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        double toplam = Convert.ToDouble(txtucret.Text) / 6;
                        toplam = Math.Round(toplam, 2);

                        komut2.Parameters.AddWithValue("@odenecektutar", toplam.ToString());
                        komut2.Parameters.AddWithValue("@yatirilantutar", 0.ToString());
                        komut2.Parameters.AddWithValue("@kalantutar", toplam.ToString());
                        komut2.Parameters.AddWithValue("@odemeturu", odeme);
                        komut2.Parameters.AddWithValue("@durum", durum);

                        if (i == 0)
                        {
                            komut2.Parameters.AddWithValue("@tarih", dateTimePicker2.Value.ToString("dd.MM.yyyy"));

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut2.Parameters.AddWithValue("@tarih", gun.ToString("dd.MM.yyyy"));

                        }
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        göster2();
                    }
                }

                if (sonuc == 9)
                {
                    for (int i = 0; i < Convert.ToInt32(txtseans.Text); i++)
                    {


                        baglanti.Open();
                        int sayi = dataGridView1.Rows.Count;
                        SqlCommand komut = new SqlCommand("insert into seansekleme1(sirano,adivesoyadi,telefon,yapilanis,seans,tarih,saat) values (@sirano,@adivesoyadi,@telefon,@yapilanis,@seans,@tarih,@saat)", baglanti);
                        komut.Parameters.AddWithValue("@sirano", sayi.ToString());
                        komut.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        komut.Parameters.AddWithValue("@yapilanis", txtyapilanis.Text);
                        komut.Parameters.AddWithValue("@seans", txtseans.Text);
                        if (i == 0)
                        {
                            komut.Parameters.AddWithValue("@tarih",dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut.Parameters.AddWithValue("@tarih", gun.ToString("dd.MM.yyyy"));
                            komut.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        }



                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut1 = new SqlCommand("insert into tarih2(musteriadi,tarih,saat) values (@musteriadi,@tarih,@saat)", baglanti);
                        komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadı.Text);

                        if (i == 0)
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            DateTime gun = h.AddDays(-1);
                            komut1.Parameters.AddWithValue("@tarih", gun.ToString());

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            int ekle1 = ekle - 1;
                            DateTime gun = h.AddDays(ekle1);
                            komut1.Parameters.AddWithValue("@tarih",gun.ToString("dd.MM.yyyy"));

                        }
                        komut1.Parameters.AddWithValue("@saat", dateTimePicker1.Value.ToString("HH:mm:ss"));
                        komut1.ExecuteNonQuery();
                        baglanti.Close();


                      



                        göster();
                        anasayfa ana = new anasayfa();
                        ana.button8_Click(sender, e);
                    }
                    for (int i = 0; i < 9; i++)
                    {

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand("insert into tahsilat1(sirano,adivesoyadi,telefon,odenecektutar,yatirilantutar,kalantutar,odemeturu,durum,tarih) values(@sirano,@adivesoyadi,@telefon,@odenecektutar,@yatirilantutar,@kalantutar,@odemeturu,@durum,@tarih)", baglanti);
                        int sayi = dataGridView3.Rows.Count;
                        komut2.Parameters.AddWithValue("@sirano", sayi.ToString());
                        komut2.Parameters.AddWithValue("@adivesoyadi", txtadisoyadı.Text);
                        komut2.Parameters.AddWithValue("@telefon", txttelefon.Text);
                        double toplam = Convert.ToDouble(txtucret.Text) / 9;
                        toplam = Math.Round(toplam, 2);
          
                        komut2.Parameters.AddWithValue("@odenecektutar", toplam.ToString());
                        komut2.Parameters.AddWithValue("@yatirilantutar", 0.ToString());
                        komut2.Parameters.AddWithValue("@kalantutar", toplam.ToString());
                        komut2.Parameters.AddWithValue("@odemeturu", odeme);
                        komut2.Parameters.AddWithValue("@durum", durum);

                        if (i == 0)
                        {
                            komut2.Parameters.AddWithValue("@tarih", dateTimePicker2.Value.ToString("dd.MM.yyyy"));

                        }

                        else
                        {

                            string s = Convert.ToString(dateTimePicker2.Value.ToString("dd-MM-yyyy"));
                            DateTime h = Convert.ToDateTime(s);
                            int ekle = Convert.ToInt32(textBox2.Text) * i;
                            DateTime gun = h.AddDays(ekle);
                            komut2.Parameters.AddWithValue("@tarih",gun.ToString("dd.MM.yyyy"));

                        }
                        komut2.ExecuteNonQuery();
                        baglanti.Close();
                        göster2();
                    }
                }

                MessageBox.Show("Seans Başarı ile Eklendi");
            }

            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime yeni = DateTime.Parse(dateTimePicker2.Text);
            
            if (yeni < bugün)
            {
                MessageBox.Show("Eskiye Dönük İşlem Yapmayınız!");

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            odeme = "Nakit Ödeme";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            sonuc = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            odeme = "Elden Taksit";
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
        }


        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmusterino.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtadisoyadı.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txttarih.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtsaat.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            sonuc = 3;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            sonuc = 6;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            sonuc = 9;
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
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();
            var nesneler2 = groupBox2.Controls.OfType<TextBox>();
            var nesneler3 = groupBox3.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }

            foreach (var nesne in nesneler2)
            {
                nesne.Clear();
            }

            foreach (var nesne in nesneler3)
            {
                nesne.Clear();
            }


        }

        private void txtadisoyadı_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtseans_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtucret_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
