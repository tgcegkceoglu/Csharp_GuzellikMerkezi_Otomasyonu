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
    public partial class frmtahsilat : Form
    {
        public frmtahsilat()
        {
            InitializeComponent();

        }
        baglanti bgl = new baglanti();
      
        
        void göster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from tahsilat1";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }

        void göster1()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from tahsilat";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView2.DataSource = datatable;
            baglanti.Close();
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

        string dd = "Ödendi";
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtyatırılantoplam.Text != "")
            {
                int yatirilantoplam = Convert.ToInt32(txtyatırılantoplam.Text);
                int kalan = Convert.ToInt32(txttoplamborc.Text) - Convert.ToInt32(txtyatırılantoplam.Text);
                SqlConnection baglanti = new SqlConnection(bgl.adres);

                if (Convert.ToInt32(txttoplamborc.Text) >= yatirilantoplam)
                {

                    string sorgu = "update tahsilat1 set  yatirilantutar=@yatirilantutar, kalantutar=@kalantutar where  sirano=@sirano";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    txtkalanborc.Text = kalan.ToString();
                    komut.Parameters.AddWithValue("@sirano", txtmusterino.Text);
                    string yatirilan = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    komut.Parameters.AddWithValue("@yatirilantutar", yatirilantoplam);
                    komut.Parameters.AddWithValue("@kalantutar", kalan.ToString());
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();



                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("insert into tahsilat(musteriadi,toplamtutar ,yatirilantutar,kalantutar) values (@musteriadi,@toplamtutar,@yatirilantutar,@kalantutar)", baglanti);
                    komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadı.Text);
                    komut1.Parameters.AddWithValue("@toplamtutar", txttoplamborc.Text);
                    komut1.Parameters.AddWithValue("@yatirilantutar", yatirilantoplam);
                    komut1.Parameters.AddWithValue("@kalantutar", kalan.ToString());
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    göster1();

                    button2.Enabled = true;
                    int g = Convert.ToInt32(txtkalanborc.Text);
                    if (g == 0)
                    {

                        string sorgu3 = "update tahsilat1 set  durum=@durum where  sirano=@sirano";
                        SqlCommand komut4 = new SqlCommand(sorgu3, baglanti);
                        komut4.Parameters.AddWithValue("@sirano", txtmusterino.Text);
                        komut4.Parameters.AddWithValue("@durum", dd);
                        baglanti.Open();
                        komut4.ExecuteNonQuery();
                        baglanti.Close();

                        göster();


                    }


                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DataGridViewCellStyle renk = new DataGridViewCellStyle();
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[7].Value) == "Ödendi")
                        {

                            renk.BackColor = Color.LightSkyBlue;

                        }

                        else if (Convert.ToString(dataGridView1.Rows[i].Cells[7].Value) == "Bekleniyor")
                        {

                            renk.BackColor = Color.Gold;

                        }

                        dataGridView1.Rows[i].DefaultCellStyle = renk;
                    }


                }
                else
                {
                    MessageBox.Show("Toplam tutardan daha büyük bir değer girmeyiniz","Hata Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

            
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {

            ppdiyalog.ShowDialog();
           button1.Enabled = false;
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            txtmusterino.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadisoyadı.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txttoplamborc.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        




            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                 DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToString(dataGridView1.Rows[i].Cells[7].Value) == "Ödendi")
                {

                   renk.BackColor = Color.LightSkyBlue;

                }

                else if (Convert.ToString(dataGridView1.Rows[i].Cells[7].Value) == "Bekleniyor")
                {

                    renk.BackColor = Color.Gold;

                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }





        }
        Font baslık = new Font("Verdana", 12, FontStyle.Bold);
        Font govde = new Font("Times New Roman", 12);
        Font govde1 = new Font("Times New Roman", 12, FontStyle.Italic);
        SolidBrush sb = new SolidBrush(Color.Black);
        SolidBrush sb1 = new SolidBrush(Color.Red);

        private void frmtahsilat_Load(object sender, EventArgs e)
        {
            göster();
            göster1();
            

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToString(dataGridView1.Rows[i].Cells[7].Value) == "Ödendi")
                {

                    renk.BackColor = Color.LightSkyBlue;

                }

                else if (Convert.ToString(dataGridView1.Rows[i].Cells[7].Value) == "Bekleniyor")
                {

                    renk.BackColor = Color.Gold;

                }

                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }


        }

        private void pdyazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringFormat sformat = new StringFormat();
            sformat.Alignment = StringAlignment.Near;
            e.Graphics.DrawString("Hesap Haraketleri", baslık, sb1, 300, 100);
            e.Graphics.DrawString("Adı Ve Soyadı:", baslık, sb1, 100, 150);
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), govde, sb, 300, 150);
            e.Graphics.DrawString("Telefon:", baslık, sb1, 100, 180);
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), govde, sb, 300, 180);
            e.Graphics.DrawString("Toplam Borç:", baslık, sb1, 100, 210);
            e.Graphics.DrawString(txttoplamborc.Text, govde, sb, 300, 210);
            e.Graphics.DrawString("Yatırılan Miktar:", baslık, sb1, 100, 240);
            e.Graphics.DrawString(txtyatırılantoplam.Text, govde, sb, 300, 240);
            e.Graphics.DrawString("Kalan Miktar:", baslık, sb1, 100, 270);
            e.Graphics.DrawString(txtkalanborc.Text, govde, sb, 300, 270);
          
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------- ", baslık, sb, 10, 300);      
            e.Graphics.DrawString("Bilgilendirme Amaçlıdır.Fatura Yerine Geçmez ", govde1, sb1, 230, 320);
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------- ", baslık, sb, 10, 340);


        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            string cümle = "Select *from tahsilat1 where adivesoyadi like '%" + txtara.Text + "%'";
            SqlDataAdapter adtr = new SqlDataAdapter();
            arama aramayap = new arama();
            dataGridView1.DataSource = aramayap.listele(adtr, cümle);
            if (txtara.Text == "")
            {
                göster();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtmusterino_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
    }

        private void txtadisoyadı_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        { 
              
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void txttoplamborc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtyatırılantoplam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtkalanborc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtara_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            string sorgu = "delete from tahsilat1 where sirano=@adivesoyadi";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adivesoyadi", txtmusterino.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            göster();



            string sorgu1 = "delete from tahsilat where musteriadi=@musteriadi";
            SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
            komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadı.Text);
            baglanti.Open();
            komut1.ExecuteNonQuery();
            baglanti.Close();
            göster1();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            string sorgu1 = "delete from tahsilat";
            SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
            baglanti.Open();
            komut1.ExecuteNonQuery();
            baglanti.Close();
            göster1();
        }

        private void txttelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            göster();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            odendi();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bekleniyor();
        }
    }
}
