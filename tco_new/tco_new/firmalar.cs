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
    public partial class firmalar : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public firmalar()
        {
            InitializeComponent();
        }
        void listele()
        {
            //SqlDataAdapter da = new SqlDataAdapter("select ıd as 'ID',ad as 'Ad',mail as 'Mail',yetkılı_unvan as 'Yetkili Kişinin Unvanı',yetkili_tc as 'Yetkilinin TC Nosu',sektor as 'Sektör',telefon1 as '1.Telefon',telefon2 as '2. Telefon',telefon3 as '3. Telefon',mail as 'Mail',fax as 'Fax',il as 'İl',ilce as 'İlçe',vergi_dairesi as 'Vergi Dairesi',adres as 'Adres',ozelkod1 as 'Kod 1',ozelkod2 as 'Kod 2',ozelkod3 as 'Kod 3' from firmalar ", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter("select ıd as 'ID',ad as 'Firmanın Adı',yetkılı_unvan as 'Yetkilinin Görevi',yetkili_ad_soyad as 'Yetkili Kişinin Adı ve Soyadı',sektor as 'Firmanın Sektörü', telefon1 as '1. Telefon',telefon2 as '2. Telefon',telefon3 as '3. Telefon',fax as 'Fax',mail as 'Mail',il as 'İl',ilce as 'İlçe',vergi_dairesi as 'Vergi Dairesi',adres as 'Adres' from firmalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
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
        void temizle()
        {
            txt_ad.Text = "";
            txt_sektor.Text = "";
            txt_tel1.Text = "";
            txt_tel2.Text = "";
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            txt_gorev.Text = "";
            txt_fax.Text = "";
            txt_vergi.Text = "";
            txt_adres.Text = "";
            lbl_ıd.Text = "";
            txt_tel3.Text = "";
            txt_mail.Text = "";

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into firmalar(ad,yetkılı_unvan,yetkili_ad_soyad,sektor,telefon1,telefon2,telefon3,mail,fax,il,ilce,vergi_dairesi,adres) values(@p1,@p2,@p3,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_gorev.Text);
            komut.Parameters.AddWithValue("@p3", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@p5", txt_sektor.Text);
            komut.Parameters.AddWithValue("@p6", txt_tel1.Text);
            komut.Parameters.AddWithValue("@p7", txt_tel2.Text);
            komut.Parameters.AddWithValue("@p8", txt_tel3.Text);
            komut.Parameters.AddWithValue("@p9", txt_mail.Text);
            komut.Parameters.AddWithValue("@p10", txt_fax.Text);
            komut.Parameters.AddWithValue("@p11", cmb_il.Text);
            komut.Parameters.AddWithValue("@p12", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p13", txt_vergi.Text);
            komut.Parameters.AddWithValue("@p14", txt_adres.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void firmalar_Load(object sender, EventArgs e)
        {
            listele();
            il_getir();
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update firmalar set ad=@p1,yetkılı_unvan=@p2,yetkili_ad_soyad=@p3,sektor=@p5,telefon1=@p6,telefon2=@p7,telefon3=@p8,mail=@p9,fax=@p10,il=@p11,ilce=@p12,vergi_dairesi=@p13,adres=@p14 where ıd=@p15", bgl.baglanti()); komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_gorev.Text);
            komut.Parameters.AddWithValue("@p3", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@p5", txt_sektor.Text);
            komut.Parameters.AddWithValue("@p6", txt_tel1.Text);
            komut.Parameters.AddWithValue("@p7", txt_tel2.Text);
            komut.Parameters.AddWithValue("@p8", txt_tel3.Text);
            komut.Parameters.AddWithValue("@p9", txt_mail.Text);
            komut.Parameters.AddWithValue("@p10", txt_fax.Text);
            komut.Parameters.AddWithValue("@p11", cmb_il.Text);
            komut.Parameters.AddWithValue("@p12", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@p13", txt_vergi.Text);
            komut.Parameters.AddWithValue("@p14", txt_adres.Text);
            komut.Parameters.AddWithValue("@p15", lbl_ıd.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lbl_ıd.Text = dr["ID"].ToString();
                txt_ad.Text = dr["Firmanın Adı"].ToString();
                txt_sektor.Text = dr["Firmanın Sektörü"].ToString();
                txt_yetkili.Text = dr["Yetkili Kişinin Adı ve Soyadı"].ToString();
                txt_gorev.Text = dr["Yetkilinin Görevi"].ToString();
                txt_mail.Text = dr["Mail"].ToString();
                txt_gorev.Text = dr["Yetkilinin Görevi"].ToString();
                txt_tel1.Text = dr["1. Telefon"].ToString();
                txt_tel2.Text = dr["2. Telefon"].ToString();
                txt_tel3.Text = dr["3. Telefon"].ToString();
                txt_fax.Text = dr["fax"].ToString();
                cmb_il.Text = dr["İl"].ToString();
                cmb_ilce.Text = dr["İlçe"].ToString();
                txt_vergi.Text = dr["Vergi Dairesi"].ToString();
                txt_adres.Text = dr["Adres"].ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from firmalar where ıd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_ıd.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Bilgileri Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
