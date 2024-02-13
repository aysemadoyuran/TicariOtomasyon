namespace tco_new
{
    partial class faturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(faturalar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_ıd = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_fiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txt_urunad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txt_faturano = new DevExpress.XtraEditors.TextEdit();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txt_miktar = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txt_saat = new System.Windows.Forms.MaskedTextBox();
            this.txt_tarih = new System.Windows.Forms.MaskedTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_alıcı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_teslime = new DevExpress.XtraEditors.TextEdit();
            this.txt_vergidaire = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_teslima = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_serino = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sırano = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_faturano.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_teslime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vergidaire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_teslima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sırano.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(383, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1535, 834);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "KAYITLAR";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 33);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1531, 799);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImageOptions.Image")));
            this.groupControl2.Controls.Add(this.lbl_ıd);
            this.groupControl2.Controls.Add(this.labelControl15);
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.simpleButton2);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.btn_kaydet);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Controls.Add(this.groupControl3);
            this.groupControl2.Location = new System.Drawing.Point(5, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(373, 834);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "İŞLEMLER";
            // 
            // lbl_ıd
            // 
            this.lbl_ıd.Location = new System.Drawing.Point(340, 799);
            this.lbl_ıd.Name = "lbl_ıd";
            this.lbl_ıd.Size = new System.Drawing.Size(24, 13);
            this.lbl_ıd.TabIndex = 41;
            this.lbl_ıd.Text = "NULL";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(319, 799);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(15, 13);
            this.labelControl15.TabIndex = 40;
            this.labelControl15.Text = "ID:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(192, 698);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(176, 40);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Text = "TEMİZLE";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(7, 698);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(176, 40);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "SİL";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(192, 652);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(176, 40);
            this.simpleButton3.TabIndex = 15;
            this.simpleButton3.Text = "GÜNCELLE";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaydet.ImageOptions.Image")));
            this.btn_kaydet.Location = new System.Drawing.Point(7, 652);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(176, 40);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImageOptions.Image")));
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Controls.Add(this.txt_fiyat);
            this.groupControl4.Controls.Add(this.labelControl13);
            this.groupControl4.Controls.Add(this.txt_urunad);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Controls.Add(this.txt_faturano);
            this.groupControl4.Controls.Add(this.txt_tutar);
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Controls.Add(this.txt_miktar);
            this.groupControl4.Location = new System.Drawing.Point(5, 402);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(363, 232);
            this.groupControl4.TabIndex = 10;
            this.groupControl4.Text = "FATURA DETAYLARI";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(22, 189);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(86, 18);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "FATURA NO:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(114, 116);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_fiyat.Properties.Appearance.Options.UseFont = true;
            this.txt_fiyat.Size = new System.Drawing.Size(215, 24);
            this.txt_fiyat.TabIndex = 10;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(48, 81);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(60, 18);
            this.labelControl13.TabIndex = 16;
            this.labelControl13.Text = "MİKTAR:";
            // 
            // txt_urunad
            // 
            this.txt_urunad.Location = new System.Drawing.Point(114, 43);
            this.txt_urunad.Name = "txt_urunad";
            this.txt_urunad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urunad.Properties.Appearance.Options.UseFont = true;
            this.txt_urunad.Size = new System.Drawing.Size(213, 24);
            this.txt_urunad.TabIndex = 11;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(40, 46);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(68, 18);
            this.labelControl12.TabIndex = 15;
            this.labelControl12.Text = "ÜRÜN AD:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(55, 154);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(53, 18);
            this.labelControl10.TabIndex = 18;
            this.labelControl10.Text = "TUTAR:";
            // 
            // txt_faturano
            // 
            this.txt_faturano.Location = new System.Drawing.Point(115, 186);
            this.txt_faturano.Name = "txt_faturano";
            this.txt_faturano.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_faturano.Properties.Appearance.Options.UseFont = true;
            this.txt_faturano.Size = new System.Drawing.Size(214, 24);
            this.txt_faturano.TabIndex = 14;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(115, 151);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Size = new System.Drawing.Size(213, 24);
            this.txt_tutar.TabIndex = 12;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(60, 119);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 18);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "FİYAT:";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(114, 78);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_miktar.Properties.Appearance.Options.UseFont = true;
            this.txt_miktar.Size = new System.Drawing.Size(213, 24);
            this.txt_miktar.TabIndex = 13;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImageOptions.Image")));
            this.groupControl3.Controls.Add(this.txt_saat);
            this.groupControl3.Controls.Add(this.txt_tarih);
            this.groupControl3.Controls.Add(this.labelControl8);
            this.groupControl3.Controls.Add(this.txt_alıcı);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.txt_teslime);
            this.groupControl3.Controls.Add(this.txt_vergidaire);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.txt_teslima);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txt_serino);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txt_sırano);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(5, 40);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(363, 352);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "FATURA BİLGİLERİ";
            // 
            // txt_saat
            // 
            this.txt_saat.Location = new System.Drawing.Point(120, 166);
            this.txt_saat.Mask = "00:00";
            this.txt_saat.Name = "txt_saat";
            this.txt_saat.Size = new System.Drawing.Size(209, 21);
            this.txt_saat.TabIndex = 11;
            this.txt_saat.ValidatingType = typeof(System.DateTime);
            // 
            // txt_tarih
            // 
            this.txt_tarih.Location = new System.Drawing.Point(120, 131);
            this.txt_tarih.Mask = "00/00/0000";
            this.txt_tarih.Name = "txt_tarih";
            this.txt_tarih.Size = new System.Drawing.Size(209, 21);
            this.txt_tarih.TabIndex = 10;
            this.txt_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(17, 312);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(96, 18);
            this.labelControl8.TabIndex = 9;
            this.labelControl8.Text = "TESLİM ALAN:";
            // 
            // txt_alıcı
            // 
            this.txt_alıcı.Location = new System.Drawing.Point(119, 239);
            this.txt_alıcı.Name = "txt_alıcı";
            this.txt_alıcı.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alıcı.Properties.Appearance.Options.UseFont = true;
            this.txt_alıcı.Size = new System.Drawing.Size(208, 24);
            this.txt_alıcı.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(15, 277);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(97, 18);
            this.labelControl7.TabIndex = 8;
            this.labelControl7.Text = "TESLİM EDEN:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "SIRA NO:";
            // 
            // txt_teslime
            // 
            this.txt_teslime.Location = new System.Drawing.Point(120, 274);
            this.txt_teslime.Name = "txt_teslime";
            this.txt_teslime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_teslime.Properties.Appearance.Options.UseFont = true;
            this.txt_teslime.Size = new System.Drawing.Size(208, 24);
            this.txt_teslime.TabIndex = 1;
            // 
            // txt_vergidaire
            // 
            this.txt_vergidaire.Location = new System.Drawing.Point(119, 201);
            this.txt_vergidaire.Name = "txt_vergidaire";
            this.txt_vergidaire.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_vergidaire.Properties.Appearance.Options.UseFont = true;
            this.txt_vergidaire.Size = new System.Drawing.Size(208, 24);
            this.txt_vergidaire.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(70, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 18);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "ALICI:";
            // 
            // txt_teslima
            // 
            this.txt_teslima.Location = new System.Drawing.Point(120, 309);
            this.txt_teslima.Name = "txt_teslima";
            this.txt_teslima.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_teslima.Properties.Appearance.Options.UseFont = true;
            this.txt_teslima.Size = new System.Drawing.Size(208, 24);
            this.txt_teslima.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(51, 55);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "SERİ NO:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(71, 169);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "SAAT:";
            // 
            // txt_serino
            // 
            this.txt_serino.Location = new System.Drawing.Point(118, 52);
            this.txt_serino.Name = "txt_serino";
            this.txt_serino.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_serino.Properties.Appearance.Options.UseFont = true;
            this.txt_serino.Size = new System.Drawing.Size(211, 24);
            this.txt_serino.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(18, 204);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(94, 18);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "VERGİ DAİRE:";
            // 
            // txt_sırano
            // 
            this.txt_sırano.Location = new System.Drawing.Point(120, 92);
            this.txt_sırano.Name = "txt_sırano";
            this.txt_sırano.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sırano.Properties.Appearance.Options.UseFont = true;
            this.txt_sırano.Size = new System.Drawing.Size(208, 24);
            this.txt_sırano.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(63, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(49, 18);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "TARİH:";
            // 
            // faturalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 838);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "faturalar";
            this.Text = "FATURALAR";
            this.Load += new System.EventHandler(this.faturalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_faturano.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_teslime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vergidaire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_teslima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sırano.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_alıcı;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_teslime;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_teslima;
        private DevExpress.XtraEditors.TextEdit txt_vergidaire;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_serino;
        private DevExpress.XtraEditors.TextEdit txt_sırano;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_fiyat;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txt_urunad;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txt_faturano;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txt_miktar;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl lbl_ıd;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.MaskedTextBox txt_saat;
        private System.Windows.Forms.MaskedTextBox txt_tarih;
    }
}