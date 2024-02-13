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
    public partial class hareketler : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public hareketler()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("hareket2",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
            SqlDataAdapter da2 = new SqlDataAdapter("hareket1", bgl.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

        }

        private void hareketler_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
