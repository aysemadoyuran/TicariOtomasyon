namespace tco_new
{
    partial class bankalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankalar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txt_hesapno = new System.Windows.Forms.MaskedTextBox();
            this.txt_ıban = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.ıd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_hesaptur = new System.Windows.Forms.MaskedTextBox();
            this.txt_yetkili = new DevExpress.XtraEditors.TextEdit();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_sube = new DevExpress.XtraEditors.TextEdit();
            this.btn_temizle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_ıd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ad = new DevExpress.XtraEditors.TextEdit();
            this.cmb_il = new System.Windows.Forms.ComboBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ilce = new System.Windows.Forms.ComboBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(405, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1506, 824);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "KAYITLAR";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl1.Location = new System.Drawing.Point(2, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1502, 789);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 538;
            this.gridView1.FixedLineWidth = 3;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.txt_hesapno);
            this.groupControl2.Controls.Add(this.txt_ıban);
            this.groupControl2.Controls.Add(this.comboBox1);
            this.groupControl2.Controls.Add(this.labelControl16);
            this.groupControl2.Controls.Add(this.ıd);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txt_tarih);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.txt_hesaptur);
            this.groupControl2.Controls.Add(this.txt_yetkili);
            this.groupControl2.Controls.Add(this.btn_kaydet);
            this.groupControl2.Controls.Add(this.txt_sube);
            this.groupControl2.Controls.Add(this.btn_temizle);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.btn_sil);
            this.groupControl2.Controls.Add(this.btn_guncelle);
            this.groupControl2.Controls.Add(this.lbl_ıd);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.txt_ad);
            this.groupControl2.Controls.Add(this.cmb_il);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.cmb_ilce);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Location = new System.Drawing.Point(9, 7);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(389, 824);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "İŞLEMLER";
            // 
            // txt_hesapno
            // 
            this.txt_hesapno.Location = new System.Drawing.Point(113, 323);
            this.txt_hesapno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hesapno.Mask = "0000000000000000";
            this.txt_hesapno.Name = "txt_hesapno";
            this.txt_hesapno.Size = new System.Drawing.Size(219, 21);
            this.txt_hesapno.TabIndex = 51;
            // 
            // txt_ıban
            // 
            this.txt_ıban.Location = new System.Drawing.Point(113, 288);
            this.txt_ıban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ıban.Mask = "TR00 0000 0000 0000 0000 0000 00";
            this.txt_ıban.Name = "txt_ıban";
            this.txt_ıban.Size = new System.Drawing.Size(219, 21);
            this.txt_ıban.TabIndex = 50;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 49;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Location = new System.Drawing.Point(31, 324);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(64, 16);
            this.labelControl16.TabIndex = 48;
            this.labelControl16.Text = "HESAP NO:";
            // 
            // ıd
            // 
            this.ıd.Location = new System.Drawing.Point(360, 792);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(24, 13);
            this.ıd.TabIndex = 39;
            this.ıd.Text = "NULL";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(30, 150);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(66, 16);
            this.labelControl15.TabIndex = 43;
            this.labelControl15.Text = "FİRMA ADI:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(339, 792);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(15, 13);
            this.labelControl13.TabIndex = 38;
            this.labelControl13.Text = "ID:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(47, 360);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 16);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "YETKİLİ:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(109, 597);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(223, 40);
            this.simpleButton1.TabIndex = 31;
            this.simpleButton1.Text = "TEMİZLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(109, 551);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(223, 40);
            this.simpleButton2.TabIndex = 30;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 390);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 16);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "TARİH:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(63, 289);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(32, 16);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "IBAN:";
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(113, 389);
            this.txt_tarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tarih.Mask = "00/00/0000";
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(219, 21);
            this.txt_tarih.TabIndex = 30;
            this.txt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(16, 421);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 16);
            this.labelControl9.TabIndex = 35;
            this.labelControl9.Text = "HESAP TÜRÜ:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(109, 505);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(223, 40);
            this.simpleButton3.TabIndex = 29;
            this.simpleButton3.Text = "GÜNCELLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txt_hesaptur
            // 
            this.txt_hesaptur.Location = new System.Drawing.Point(113, 420);
            this.txt_hesaptur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hesaptur.Name = "txt_hesaptur";
            this.txt_hesaptur.Size = new System.Drawing.Size(219, 21);
            this.txt_hesaptur.TabIndex = 36;
            // 
            // txt_yetkili
            // 
            this.txt_yetkili.Location = new System.Drawing.Point(113, 357);
            this.txt_yetkili.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_yetkili.Name = "txt_yetkili";
            this.txt_yetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_yetkili.Properties.Appearance.Options.UseFont = true;
            this.txt_yetkili.Size = new System.Drawing.Size(219, 22);
            this.txt_yetkili.TabIndex = 40;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.ImageOptions.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(109, 459);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(223, 40);
            this.btn_kaydet.TabIndex = 28;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_sube
            // 
            this.txt_sube.Location = new System.Drawing.Point(111, 251);
            this.txt_sube.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sube.Name = "txt_sube";
            this.txt_sube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sube.Properties.Appearance.Options.UseFont = true;
            this.txt_sube.Size = new System.Drawing.Size(221, 22);
            this.txt_sube.TabIndex = 2;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.Appearance.Options.UseFont = true;
            this.btn_temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_temizle.ImageOptions.Image")));
            this.btn_temizle.Location = new System.Drawing.Point(140, 974);
            this.btn_temizle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(351, 62);
            this.btn_temizle.TabIndex = 27;
            this.btn_temizle.Text = "TEMİZLE";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(60, 254);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ŞUBE:";
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_sil.ImageOptions.Image")));
            this.btn_sil.Location = new System.Drawing.Point(140, 903);
            this.btn_sil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(351, 62);
            this.btn_sil.TabIndex = 26;
            this.btn_sil.Text = "SİL";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.ImageOptions.Image")));
            this.btn_guncelle.Location = new System.Drawing.Point(140, 832);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(351, 62);
            this.btn_guncelle.TabIndex = 25;
            this.btn_guncelle.Text = "GÜNCELLE";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.Location = new System.Drawing.Point(480, 1246);
            this.lbl_ıd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(24, 13);
            this.lbl_ıd.TabIndex = 24;
            this.lbl_ıd.Text = "NULL";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(448, 1246);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(15, 13);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "ID:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(31, 117);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "BANKA ADI:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(111, 114);
            this.txt_ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ad.Properties.Appearance.Options.UseFont = true;
            this.txt_ad.Size = new System.Drawing.Size(221, 22);
            this.txt_ad.TabIndex = 0;
            // 
            // cmb_il
            // 
            this.cmb_il.FormattingEnabled = true;
            this.cmb_il.Location = new System.Drawing.Point(111, 180);
            this.cmb_il.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Size = new System.Drawing.Size(221, 21);
            this.cmb_il.TabIndex = 32;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(83, 180);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(15, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "İL:";
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.FormattingEnabled = true;
            this.cmb_ilce.Location = new System.Drawing.Point(111, 216);
            this.cmb_ilce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Size = new System.Drawing.Size(221, 21);
            this.cmb_ilce.TabIndex = 34;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(67, 216);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 16);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "İLÇE:";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Location = new System.Drawing.Point(528, 286);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(0, 16);
            this.labelControl14.TabIndex = 41;
            // 
            // bankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 838);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.labelControl14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "bankalar";
            this.Text = "BANKALAR";
            this.Load += new System.EventHandler(this.bankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit txt_yetkili;
        private DevExpress.XtraEditors.LabelControl ıd;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.MaskedTextBox txt_hesaptur;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.ComboBox cmb_ilce;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cmb_il;
        private System.Windows.Forms.MaskedTextBox txt_tarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_temizle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.LabelControl lbl_ıd;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_sube;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_ad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox txt_hesapno;
        private System.Windows.Forms.MaskedTextBox txt_ıban;
    }
}