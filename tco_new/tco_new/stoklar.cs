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
    public partial class stoklar : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public stoklar()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select urunad as 'Ürün Adı',sum(adet) as 'Adet' from urunler group by urunad",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void stoklar_Load(object sender, EventArgs e)
        {
            listele();
            SqlCommand komut = new SqlCommand("select urunad as 'Ürün Adı',sum(adet) as 'Adet' from urunler group by urunad", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
        }
    }
}
