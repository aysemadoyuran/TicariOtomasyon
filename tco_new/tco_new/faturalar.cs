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
    public partial class faturalar : Form
    {
        sql_baglanti bgl = new sql_baglanti();
        public faturalar()
        {
            InitializeComponent();
        }
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select ıd as 'ID',seri as 'Seri No',sırano as 'Sıra No',tarih as 'Tarih',saat as 'Saat',vergidaire as 'Vergi Dairesi',alıcı as 'Alıcı',teslimeden as 'Teslim Eden',teslimalan as 'Teslim Alan' from faturalar", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }
        void temizle()
        {
            txt_alıcı.Text = "";
            txt_saat.Text = "";
            txt_tarih.Text = "";
           
        }

        private void faturalar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_alıcı.Text == "" || txt_faturano.Text == "" || txt_fiyat.Text == "" || txt_miktar.Text == "" || txt_saat.Text == "" || txt_serino.Text == "" || txt_sırano.Text == "" || txt_tarih.Text == "" || txt_teslima.Text == "" || txt_teslime.Text == "" || txt_tutar.Text == "" || txt_urunad.Text == "" || txt_vergidaire.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurun!!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into faturalar (seri,sırano,tarih,saat,vergidaire,alıcı,teslimeden,teslimalan) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_serino.Text);
                komut.Parameters.AddWithValue("@p2", txt_sırano.Text);
                komut.Parameters.AddWithValue("@p3", txt_tarih.Text);
                komut.Parameters.AddWithValue("@p4", txt_saat.Text);
                komut.Parameters.AddWithValue("@p5", txt_vergidaire.Text);
                komut.Parameters.AddWithValue("@p6", txt_alıcı.Text);
                komut.Parameters.AddWithValue("@p7", txt_teslime.Text);
                komut.Parameters.AddWithValue("@p8", txt_teslima.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SqlCommand komut2 = new SqlCommand("insert into fatura_detay (urunad,miktar,fiyat,tutar,faturaid) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txt_urunad.Text);
                komut2.Parameters.AddWithValue("@p2", txt_miktar.Text);
                komut2.Parameters.AddWithValue("@p3", decimal.Parse(txt_fiyat.Text));
                komut2.Parameters.AddWithValue("@p4", decimal.Parse(txt_tutar.Text));
                komut2.Parameters.AddWithValue("@p5", txt_faturano.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();

                listele();
                //temizle();
                MessageBox.Show("Müşteri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                lbl_ıd.Text = dr["ID"].ToString();
                txt_serino.Text = dr["Seri No"].ToString();
                txt_sırano.Text = dr["Sıra No"].ToString();
                txt_teslime.Text = dr["Teslim Eden"].ToString();
                txt_teslima.Text = dr["Teslim Alan"].ToString();
                txt_tarih.Text = dr["Tarih"].ToString();
                txt_saat.Text = dr["Saat"].ToString();
                txt_vergidaire.Text = dr["Vergi Dairesi"].ToString();
                txt_alıcı.Text = dr["Alıcı"].ToString();
            }
        }
    }
}
