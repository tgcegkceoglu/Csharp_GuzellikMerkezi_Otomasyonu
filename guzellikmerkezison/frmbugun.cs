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
    public partial class frmbugun : Form
    {
        public frmbugun()
        {
            InitializeComponent();
        }

        private void frmbugun_Load(object sender, EventArgs e)
        {
            baglanti bgl = new baglanti();
            
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            dateTimePicker1.Value = bugün;
            dateTimePicker2.Value = bugün;

            SqlConnection baglan = new SqlConnection(bgl.adres);
            
            DataTable dt = new DataTable();
            string sql = "SELECT adivesoyadi,telefon,saat FROM seansekleme1 WHERE tarih BETWEEN @tarih1 and @tarih2";
            SqlDataAdapter da = new SqlDataAdapter(sql,baglan);
            da.SelectCommand.Parameters.AddWithValue("@tarih1", dateTimePicker1.Value.ToString());
            da.SelectCommand.Parameters.AddWithValue("@tarih2", dateTimePicker1.Value.ToString());
            baglan.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
