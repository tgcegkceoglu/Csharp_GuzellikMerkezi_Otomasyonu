using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace guzellikmerkezison
{
    public partial class mailgonderme : Form
    {
        public mailgonderme()
        {
            InitializeComponent();
        }
  
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = dataGridView1.Rows[0].Cells[3].Value.ToString();
            string mailsifre = dataGridView1.Rows[0].Cells[4].Value.ToString();
            MessageBox.Show(mail);
            MailMessage mesajım = new MailMessage();
            SmtpClient istemci = new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential(mail,mailsifre);
            istemci.Port = 587;
            istemci.Host = "smtp.live.com";
            istemci.EnableSsl = true;
            mesajım.To.Add(textBox1.Text);
            mesajım.From = new MailAddress(mail);
            mesajım.Subject = textBox2.Text;
            mesajım.Body = textBox3.Text;
            istemci.Send(mesajım);
            MessageBox.Show("Mesaj Gönderildi");
        }

        private void mailgönderme_Load(object sender, EventArgs e)
        {
            göster();

        }
       
        void göster()
        {
            baglanti bgl = new baglanti();
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select * from ayarlar";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
