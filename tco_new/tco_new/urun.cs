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
    public partial class urun : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public urun()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ıd, urunad as 'Ürün Adı',marka as 'Ürünün Markası',model as'Ürünün Modeli',yıl as 'Çıkış Yılı',adet as 'Ürün Adeti',alıs_fiyat as 'Alış Fiyatı', satis_fiyat as 'Satış Fiyatı', detay as 'Ürün Detayı' from urunler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }
        void temizle()
        {
            lbl_ıd.Text = "";
            txt_adet.Text = "";
            txt_a_fiyat.Text = "";
            txt_detay.Text = "";
            txt_marka.Text = "";
            txt_model.Text = "";
            txt_s_fiyat.Text = "";
            txt_yil.Text = "";
            txt_ad.Text = "";

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into urunler (urunad,marka,model,yıl,adet,alıs_fiyat,satis_fiyat,detay) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_marka.Text);
            komut.Parameters.AddWithValue("@p3", txt_model.Text);
            komut.Parameters.AddWithValue("@p4", txt_yil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse(txt_adet.Text).ToString());
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_a_fiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txt_s_fiyat.Text));
            komut.Parameters.AddWithValue("@p8", txt_detay.Text);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("insert into kategori(kategori) values(@k1)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txt_ad.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Ürün Kaydı Gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void urun_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lbl_ıd.Text = dr["ıd"].ToString();
                txt_ad.Text = dr["Ürün Adı"].ToString();
                txt_marka.Text = dr["Ürünün Markası"].ToString();
                txt_model.Text = dr["Ürünün Modeli"].ToString();
                txt_yil.Text = dr["Çıkış Yılı"].ToString();
                txt_adet.Text = dr["Ürün Adeti"].ToString();
                txt_a_fiyat.Text = dr["Alış Fiyatı"].ToString();
                txt_s_fiyat.Text = dr["Satış Fiyatı"].ToString();
                txt_detay.Text = dr["Ürün Detayı"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("update urunler set urunad=@p1,marka=@p2,model=@p3,yıl=@p4,adet=@p5,alıs_fiyat=@p6,satis_fiyat=@p7,detay=@p8 where ıd=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_ad.Text);
                komut.Parameters.AddWithValue("@p2", txt_marka.Text);
                komut.Parameters.AddWithValue("@p3", txt_model.Text);
                komut.Parameters.AddWithValue("@p4", txt_yil.Text);
                komut.Parameters.AddWithValue("@p5", int.Parse(txt_adet.Text).ToString());
                komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_a_fiyat.Text));
                komut.Parameters.AddWithValue("@p7", decimal.Parse(txt_s_fiyat.Text));
                komut.Parameters.AddWithValue("@p8", txt_detay.Text);
                komut.Parameters.AddWithValue("@p9", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Ürün Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Güncellenecek Ürünü Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("delete from urunler where ıd=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p9", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Ürün Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
