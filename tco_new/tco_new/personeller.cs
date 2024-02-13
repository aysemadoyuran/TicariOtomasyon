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
    public partial class personeller : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public personeller()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ıd as 'ID', ad as 'Ad',soyad as 'Soyad',telefon as 'Telefon',tc as 'TC',mail as 'Mail',il as 'İl',ilce as 'İlçe',adres as'Adres',gorev as 'Görev' from personel", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txt_ad.Text = "";
            txt_soyad.Text = "";
            txt_tel.Text = "";
            txt_tc.Text = "";
            txt_mail.Text = "";
            cmb_il.Text = "";
            cmb_ilce.Text = "";
            txt_gorev.Text = "";
            txt_adres.Text = "";
            lbl_ıd.Text = "";
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
        private void personeller_Load(object sender, EventArgs e)
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

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text == "" || txt_adres.Text == "" || txt_mail.Text == "" || txt_soyad.Text == "" || txt_tc.Text == "" || txt_tel.Text == "" || txt_gorev.Text == "" || cmb_il.Text == "" || cmb_ilce.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into personel (ad,soyad,telefon,tc,mail,il,ilce,adres,gorev) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                komut.Parameters.AddWithValue("@p3", txt_tel.Text);
                komut.Parameters.AddWithValue("@p4", txt_tc.Text);
                komut.Parameters.AddWithValue("@p5", txt_mail.Text);
                komut.Parameters.AddWithValue("@p6", cmb_il.Text);
                komut.Parameters.AddWithValue("@p7", cmb_ilce.Text);
                komut.Parameters.AddWithValue("@p8", txt_adres.Text);
                komut.Parameters.AddWithValue("@p9", txt_gorev.Text);
                komut.ExecuteNonQuery();
                listele();
                temizle();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("update personel set ad=@p1,soyad=@p2,telefon=@p3,tc=@p5,mail=@p6,il=@p7,ilce=@p8,adres=@p9,gorev=@p10 where ıd=@p11", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
                komut.Parameters.AddWithValue("@p3", txt_tel.Text);
                komut.Parameters.AddWithValue("@p5", txt_tc.Text);
                komut.Parameters.AddWithValue("@p6", txt_mail.Text);
                komut.Parameters.AddWithValue("@p7", cmb_il.Text);
                komut.Parameters.AddWithValue("@p8", cmb_ilce.Text);
                komut.Parameters.AddWithValue("@p9", txt_adres.Text);
                komut.Parameters.AddWithValue("@p10", txt_gorev.Text);
                komut.Parameters.AddWithValue("@p11", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Müşteri Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Güncellenecek Ürünü Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lbl_ıd.Text = dr["ID"].ToString();
                txt_ad.Text = dr["Ad"].ToString();
                txt_soyad.Text = dr["Soyad"].ToString();
                txt_tel.Text = dr["Telefon"].ToString();
                txt_tc.Text = dr["TC"].ToString();
                txt_mail.Text = dr["Mail"].ToString();
                cmb_il.Text = dr["İl"].ToString();
                cmb_ilce.Text = dr["İlçe"].ToString();
                txt_gorev.Text = dr["Görev"].ToString();
                txt_adres.Text = dr["Adres"].ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("delete from personel where ıd=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p9", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Personel Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Silinecek Ürünü Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
