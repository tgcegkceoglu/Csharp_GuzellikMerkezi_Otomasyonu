using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Data.SqlClient;

namespace guzellikmerkezison
{
    public partial class frmhatırlatıcı : Form
    {
        public frmhatırlatıcı()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();

        void tarih()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select *  from tarih2";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView2.DataSource = datatable;
            baglanti.Close();
        }

        void goster()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            string cümle = "select *  from seansekleme1";
            SqlCommand komut = new SqlCommand(cümle, baglanti);
            SqlDataAdapter dataadapter = new SqlDataAdapter(komut);
            DataTable datatable = new DataTable();
            dataadapter.Fill(datatable);
            dataGridView1.DataSource = datatable;
            baglanti.Close();
        }

        private void frmhatırlatıcı_Load(object sender, EventArgs e)
        {
       
            tarih();
            goster();
            label1.Text = DateTime.Now.ToLongTimeString();

            label2.Text = DateTime.Now.ToShortDateString();

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
           
            label2.Text= DateTime.Now.ToShortDateString();
            
            cagır();

        }

        public void cagır()
        {

            
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (Convert.ToString(dataGridView2.Rows[i].Cells[2].Value) == label1.Text)
                {

                    if (Convert.ToDateTime(dataGridView2.Rows[i].Cells[1].Value) ==Convert.ToDateTime(label2.Text))
                    {

                        MessageBox.Show( dataGridView2.Rows[i].Cells[0].Value.ToString() + "      yarın saat "
                            + dataGridView2.Rows[i].Cells[2].Value.ToString() + "     randevusu bulunmaktadır." ,"Bilgilendirme Mesajı" ,MessageBoxButtons.OK ,MessageBoxIcon.Information);


                    }
                 
                }
           

                
              
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            string sorgu1 = "delete from tarih2 where musteriadi=@musteriadi";
            SqlCommand komut1 = new SqlCommand(sorgu1, baglanti);
            komut1.Parameters.AddWithValue("@musteriadi", txtadisoyadi.Text);
            baglanti.Open();
            komut1.ExecuteNonQuery();
            baglanti.Close();
            tarih();

        }
 
        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txtadisoyadi.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
 

        
    

        
            

