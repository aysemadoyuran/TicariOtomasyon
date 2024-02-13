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
    public partial class bankalar : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public bankalar()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("banka_bilgi",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firma()
        {
            SqlCommand komut = new SqlCommand("select ıd,ad from firmalar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader dr = komut.ExecuteReader();
            comboBox1.ValueMember = "ıd";
            comboBox1.DisplayMember = "ad";
            comboBox1.DataSource = dt;
            
        }
        void il_getir()
        {
            SqlCommand komut = new SqlCommand("select sehir from iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmb_il.Items.Add(dr[0]);
            }
        }

        private void bankalar_Load(object sender, EventArgs e)
        {
            listele();
            firma();
            il_getir();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into bankalar(bankaadi,sube,ıban,hesapno,yetkılı,tarih,hesapturu,fırmaıd,il,ilce) values(@p1,@p2,@p3,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_sube.Text);
            komut.Parameters.AddWithValue("@p3", txt_ıban.Text);
            komut.Parameters.AddWithValue("@p5", txt_hesapno.Text);
            komut.Parameters.AddWithValue("@p6", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@p7", txt_tarih.Text);
            komut.Parameters.AddWithValue("@p8", txt_hesaptur.Text);
            komut.Parameters.AddWithValue("@p9", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p10", cmb_il.Text);
            komut.Parameters.AddWithValue("@p11", cmb_ilce.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgileri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ilce.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select ilce from ilceler where sehir=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmb_il.SelectedIndex + 1);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmb_ilce.Items.Add(dr3[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                ıd.Text = dr["ıd"].ToString();
                txt_ad.Text = dr["Banka Adı"].ToString();
                comboBox1.Text = dr["Firma Adı"].ToString();
                cmb_il.Text = dr["İl"].ToString();
                cmb_ilce.Text = dr["İlçe"].ToString();
                txt_sube.Text = dr["Şube"].ToString();
                txt_ıban.Text = dr["IBAN"].ToString();
                txt_hesapno.Text = dr["Hesap No"].ToString();
                txt_yetkili.Text = dr["Yetkili"].ToString();
                txt_tarih.Text = dr["Tarih"].ToString();
                txt_hesaptur.Text = dr["Tarih"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update bankalar set bankaadi=@p1,sube=@p2,ıban=@p3,hesapno=@p5,yetkılı=@p6,tarih=@p7,hesapturu=@p8,fırmaıd=@p9,il=@p10,ilce=@p11 where ıd=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_sube.Text);
            komut.Parameters.AddWithValue("@p3", txt_ıban.Text);
            komut.Parameters.AddWithValue("@p5", txt_hesapno.Text);
            komut.Parameters.AddWithValue("@p6", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@p7", txt_tarih.Text);
            komut.Parameters.AddWithValue("@p8", txt_hesaptur.Text);
            komut.Parameters.AddWithValue("@p9", comboBox1.SelectedValue);
            komut.Parameters.AddWithValue("@p10", cmb_il.Text);
            komut.Parameters.AddWithValue("@p11", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p12", ıd.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("delete from bankalar where bankalar.ıd=@p1",bgl.baglanti());
            //komut.Parameters.AddWithValue("@p1", ıd.Text);
            //komut.ExecuteNonQuery();
            //listele();
        }
        void temizle()
        {
            txt_ad.Text = "";
            comboBox1.Text = "";
            txt_hesapno.Text = "";
            txt_hesaptur.Text = "";
            txt_sube.Text = "";
            txt_tarih.Text = "";
            txt_yetkili.Text = "";
            txt_ıban.Text = "";
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            ıd.Text = "";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
