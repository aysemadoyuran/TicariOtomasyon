using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tco_new
{
    public partial class r_ehber : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public r_ehber()
        {
            InitializeComponent();
        }
        void bilgi_getir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ad+' '+soyad as 'Ad Soyad',telefon as '1. Telefon',telefon2 as '2. Telefon',mail as 'Mail',adres as 'Adres' from musteri", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            SqlDataAdapter da2 = new SqlDataAdapter("select ad as 'Firma Adı',yetkili_ad_soyad 'Yetkili Kişinin Adı ve Soyadı',telefon1 as '1. Telefon',telefon2 as '2. Telefon',telefon3 as '3. Telefon',mail as 'Mail',fax as 'Fax',adres as 'Adres' from firmalar", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

        }

        private void r_ehber_Load(object sender, EventArgs e)
        {
            bilgi_getir();
        }
    }
}
