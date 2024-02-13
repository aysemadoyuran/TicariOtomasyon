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
    public partial class giderler : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public giderler()
        {
            InitializeComponent();
        }
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select id,bas_tarih as'Dönem Başlangıç Tarihi',bit_tarih as 'Dönem Bitiş Tarihi',elektrik as 'Elektrik',su as 'Su',dogalgaz as'Doğalgaz',internet as 'İnternet',maaslar as 'Maaşlar',ekstra as 'Ekstralar', notlar as 'Notlar' from giderler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            lbl_ıd.Text = "";
            txt_elektrik.Text = "";
            txt_internet.Text = "";
            txt_maaslar.Text = "";
            txt_notlar.Text = "Bu ay toplamda .....TL harcama yapılmıştır.";
            txt_su.Text = "";
            txt_dogalgaz.Text = "";
            txt_ekstra.Text = "";
            txt_baslangic.Text = "";
            maskedTextBox2.Text = "";

        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void giderler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into giderler (elektrik,su,dogalgaz,internet,maaslar,ekstra,notlar,bas_tarih,bit_tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", decimal.Parse(txt_elektrik.Text));
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txt_su.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txt_dogalgaz.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txt_internet.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txt_maaslar.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_ekstra.Text));
            komut.Parameters.AddWithValue("@p7", txt_notlar.Text);
            komut.Parameters.AddWithValue("@p8", txt_baslangic.Text);
            komut.Parameters.AddWithValue("@p9", maskedTextBox2.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Giderler Kaydı Gerçekleştirildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("update giderler set elektrik=@p1,su=@p2,dogalgaz=@p3,internet=@p4,maaslar=@p5,ekstra=@p6,notlar=@p7,bas_tarih=@p8,bit_tarih=@p9 where id=@p10", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", decimal.Parse(txt_elektrik.Text));
                komut.Parameters.AddWithValue("@p2", decimal.Parse(txt_su.Text));
                komut.Parameters.AddWithValue("@p3", decimal.Parse(txt_dogalgaz.Text));
                komut.Parameters.AddWithValue("@p4", decimal.Parse(txt_internet.Text));
                komut.Parameters.AddWithValue("@p5", decimal.Parse(txt_maaslar.Text));
                komut.Parameters.AddWithValue("@p6", decimal.Parse(txt_ekstra.Text));
                komut.Parameters.AddWithValue("@p7", txt_notlar.Text);
                komut.Parameters.AddWithValue("@p8", txt_baslangic.Text);
                komut.Parameters.AddWithValue("@p9", maskedTextBox2.Text);
                komut.Parameters.AddWithValue("@p10", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Giderler Kaydı Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Güncellenecek Gider Kaydını Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            {
                DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
                if (dr != null)
                {
                    lbl_ıd.Text = dr["id"].ToString();
                    txt_elektrik.Text = dr["Elektrik"].ToString();
                    txt_su.Text = dr["Su"].ToString();
                    txt_dogalgaz.Text = dr["Doğalgaz"].ToString();
                    txt_internet.Text = dr["İnternet"].ToString();
                    txt_maaslar.Text = dr["Maaşlar"].ToString();
                    txt_ekstra.Text = dr["Ekstralar"].ToString();
                    txt_notlar.Text = dr["Notlar"].ToString();
                    txt_baslangic.Text = dr["Dönem Başlangıç Tarihi"].ToString();
                    maskedTextBox2.Text = dr["Dönem Bitiş Tarihi"].ToString();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (lbl_ıd.Text != "")
            {
                SqlCommand komut = new SqlCommand("delete from giderler where id=@p9", bgl.baglanti());
                komut.Parameters.AddWithValue("@p9", lbl_ıd.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                listele();
                MessageBox.Show("Gider Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Silinecek Gider Kaydını Seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
