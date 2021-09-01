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
    public partial class resim : Form
    {
        public resim()
        {
            InitializeComponent();
        }
        baglanti bgl = new baglanti();
      
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

        private void resim_Load(object sender, EventArgs e)
        {
            göster();
            pictureBox1.ImageLocation = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}
