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
    public partial class notlar : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public notlar()
        {
            InitializeComponent();
        }
        void temizle()
        {
            txt_hitap.Text = "";
            txt_tarih.Text = "";
            txt_ad.Text = "";
            txt_baslik.Text = "";
            txt_detay.Text = "";
            txt_saat.Text = "";
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select notid as 'ID',tarih as 'Tarih',saat as 'Saat',baslik as 'Başlık',detay as 'Detay',olusturan_ad as 'Oluşturan Kişi',hitap as 'Hitap' from notlar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        private void notlar_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into notlar(tarih,saat,baslik,detay,olusturan_ad,hitap) values(@p1,@p2,@p3,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_tarih.Text);
            komut.Parameters.AddWithValue("@p2", txt_saat.Text);
            komut.Parameters.AddWithValue("@p3", txt_baslik.Text);
            komut.Parameters.AddWithValue("@p5", txt_detay.Text);
            komut.Parameters.AddWithValue("@p6", txt_ad.Text);
            komut.Parameters.AddWithValue("@p7", txt_hitap.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Not Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update notlar set tarih=@p1,saat=@p2,baslik=@p3,detay=@p4,olusturan_ad=@p5,hitap=@p6 where notid=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_tarih.Text);
            komut.Parameters.AddWithValue("@p2", txt_saat.Text);
            komut.Parameters.AddWithValue("@p3", txt_baslik.Text);
            komut.Parameters.AddWithValue("@p4", txt_detay.Text);
            komut.Parameters.AddWithValue("@p5", txt_ad.Text);
            komut.Parameters.AddWithValue("@p6", txt_hitap.Text);
            komut.Parameters.AddWithValue("@p7", lbl_ıd.Text);
            komut.ExecuteNonQuery();
            listele();
            temizle();
            bgl.baglanti().Close();
            MessageBox.Show("Not Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lbl_ıd.Text = dr["ID"].ToString();
                txt_tarih.Text = dr["Tarih"].ToString();
                txt_saat.Text = dr["Saat"].ToString();
                txt_baslik.Text = dr["Başlık"].ToString();
                txt_detay.Text = dr["Detay"].ToString();
                txt_ad.Text = dr["Oluşturan Kişi"].ToString();
                txt_hitap.Text = dr["Hitap"].ToString();

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            not_detay fr = new not_detay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                fr.metin = dr["Detay"].ToString();
            }
            fr.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("delete from notlar where notid=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p9", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Not Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Silinecek Notu Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void notlar_Load_1(object sender, EventArgs e)
        {
            listele();
        }
    }
}
