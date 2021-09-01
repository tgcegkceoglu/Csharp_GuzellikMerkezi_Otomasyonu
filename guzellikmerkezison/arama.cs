using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guzellikmerkezison
{
    class arama
    {
        DataTable tablo;
        baglanti bgl = new baglanti();
       
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu, baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;

        }


    }
}
