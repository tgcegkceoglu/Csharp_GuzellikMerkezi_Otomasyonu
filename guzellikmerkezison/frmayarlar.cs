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
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
      
        private void frmayarlar_Load(object sender, EventArgs e)
        {
            göster();
        }


        void göster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select *  from ayarlar";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpeg;*.nef;*.png;*.jpg| Video|*.avi| Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pictureBox1.ImageLocation = DosyaYolu;

        }

        
        private void button3_Click(object sender, EventArgs e)
        {

                SqlConnection baglanti = new SqlConnection(bgl.adres);
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update  ayarlar set sirketadi=@sirketadi, telefon=@telefon, mail=@mail,mailsifre=@mailsifre, resim=@resim where  sirketno=@sirketno", baglanti);
                komut.Parameters.AddWithValue("@sirketno", 1.ToString());
                komut.Parameters.AddWithValue("@sirketadi", txtadi.Text);
                komut.Parameters.AddWithValue("@telefon", txttel.Text);
                 string mail = txtmail.Text + comboBox1.Text;
      
                komut.Parameters.AddWithValue("@mail", mail);
                komut.Parameters.AddWithValue("@mailsifre", txtmailsifre.Text);
                komut.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
                komut.ExecuteNonQuery();
                baglanti.Close();
                göster();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtmailsifre.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
