using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tco_new
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        bankalar fr11;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            if (fr11==null)
            {
                fr11 = new bankalar();
                fr11.MdiParent = this;
                fr11.Show();
            }

        }
        urun fr2;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(fr2==null)
            {
                fr2 = new urun();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }

        musteriler fr4;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr4 == null)
            {
                fr4 = new musteriler();
                fr4.MdiParent = this;
                fr4.Show();
            }
        }

        firmalar fr5;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr5 == null)
            {
                fr5 = new firmalar();
                fr5.MdiParent = this;
                fr5.Show();
            }
        }

        personeller fr6;
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr6 == null)
            {
                fr6 = new personeller();
                fr6.MdiParent = this;
                fr6.Show();
            }
        }

        giderler fr8;
        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr8 == null)
            {
                fr8 = new giderler();
                fr8.MdiParent = this;
                fr8.Show();
            }
        }

        notlar fr10;
        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr10 == null)
            {
                fr10 = new notlar();
                fr10.MdiParent = this;
                fr10.Show();
            }
        }

        r_ehber fr12;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr12 == null)
            {
                fr12 = new r_ehber();
                fr12.MdiParent = this;
                fr12.Show();
            }
        }
        faturalar fr13;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr13 == null)
            {
                fr13 = new faturalar();
                fr13.MdiParent = this;
                fr13.Show();
            }
        }
        stoklar fr3;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new stoklar();
                fr3.MdiParent = this;
                fr3.Show();
            }
        }
        hareketler fr16;
        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(fr16==null)
            {
                fr16 = new hareketler();
                fr16.MdiParent = this;
                fr16.Show();
            }


        }
    }
}
