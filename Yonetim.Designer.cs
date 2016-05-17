namespace Alfa
{
    partial class Yonetim
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yonetim));
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Alfa.WaitForm1), true, false);
            this.pnlGenel = new DevExpress.XtraEditors.PanelControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.brMenu = new DevExpress.XtraBars.Bar();
            this.brDosya = new DevExpress.XtraBars.BarSubItem();
            this.brKullaniciEkle = new DevExpress.XtraBars.BarSubItem();
            this.brSistemBilgisi = new DevExpress.XtraBars.BarSubItem();
            this.brTemaSec = new DevExpress.XtraBars.BarSubItem();
            this.brNotEkle = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.grdVeriler = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNotID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotBaslik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotIcerik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlHatirlatici = new DevExpress.XtraEditors.PanelControl();
            this.grpGuncelle = new DevExpress.XtraEditors.GroupControl();
            this.lblGuncelle = new DevExpress.XtraEditors.LabelControl();
            this.pcrGuncelle = new DevExpress.XtraEditors.PictureEdit();
            this.grpYeniNot = new DevExpress.XtraEditors.GroupControl();
            this.lblYeniNot = new DevExpress.XtraEditors.LabelControl();
            this.pceYeniNot = new DevExpress.XtraEditors.PictureEdit();
            this.brTelRehber = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGenel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeriler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHatirlatici)).BeginInit();
            this.pnlHatirlatici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpGuncelle)).BeginInit();
            this.grpGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGuncelle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpYeniNot)).BeginInit();
            this.grpYeniNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceYeniNot.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // pnlGenel
            // 
            this.pnlGenel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGenel.Location = new System.Drawing.Point(12, 41);
            this.pnlGenel.Name = "pnlGenel";
            this.pnlGenel.Size = new System.Drawing.Size(1072, 436);
            this.pnlGenel.TabIndex = 0;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.brMenu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.brDosya,
            this.brKullaniciEkle,
            this.brSistemBilgisi,
            this.brTemaSec,
            this.brNotEkle,
            this.brTelRehber});
            this.barManager1.MainMenu = this.brMenu;
            this.barManager1.MaxItemId = 14;
            // 
            // brMenu
            // 
            this.brMenu.BarName = "Main menu";
            this.brMenu.DockCol = 0;
            this.brMenu.DockRow = 0;
            this.brMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.brMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.brDosya),
            new DevExpress.XtraBars.LinkPersistInfo(this.brNotEkle),
            new DevExpress.XtraBars.LinkPersistInfo(this.brTelRehber)});
            this.brMenu.OptionsBar.AllowQuickCustomization = false;
            this.brMenu.OptionsBar.DrawBorder = false;
            this.brMenu.OptionsBar.MultiLine = true;
            this.brMenu.OptionsBar.UseWholeRow = true;
            this.brMenu.Text = "Main menu";
            // 
            // brDosya
            // 
            this.brDosya.AllowRightClickInMenu = false;
            this.brDosya.Caption = "Dosya";
            this.brDosya.Id = 1;
            this.brDosya.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.brKullaniciEkle, DevExpress.XtraBars.BarItemPaintStyle.Standard),
            new DevExpress.XtraBars.LinkPersistInfo(this.brSistemBilgisi),
            new DevExpress.XtraBars.LinkPersistInfo(this.brTemaSec)});
            this.brDosya.Name = "brDosya";
            // 
            // brKullaniciEkle
            // 
            this.brKullaniciEkle.AllowRightClickInMenu = false;
            this.brKullaniciEkle.Caption = "Kullanıcı Ekle";
            this.brKullaniciEkle.Id = 2;
            this.brKullaniciEkle.Name = "brKullaniciEkle";
            this.brKullaniciEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brKullaniciEkle_ItemClick);
            // 
            // brSistemBilgisi
            // 
            this.brSistemBilgisi.AllowRightClickInMenu = false;
            this.brSistemBilgisi.Caption = "Sistem Bilgisi";
            this.brSistemBilgisi.Id = 3;
            this.brSistemBilgisi.Name = "brSistemBilgisi";
            // 
            // brTemaSec
            // 
            this.brTemaSec.AllowRightClickInMenu = false;
            this.brTemaSec.Caption = "Tema Seç";
            this.brTemaSec.Id = 4;
            this.brTemaSec.Name = "brTemaSec";
            this.brTemaSec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brTemaSec_ItemClick);
            // 
            // brNotEkle
            // 
            this.brNotEkle.AllowRightClickInMenu = false;
            this.brNotEkle.Caption = "Not Ekle";
            this.brNotEkle.Id = 5;
            this.brNotEkle.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N), (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.brNotEkle.Name = "brNotEkle";
            this.brNotEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brNotEkle_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1098, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 631);
            this.barDockControlBottom.Size = new System.Drawing.Size(1098, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 611);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1098, 20);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 611);
            // 
            // grdVeriler
            // 
            this.grdVeriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdVeriler.DataSource = this.bindingSource1;
            this.grdVeriler.Location = new System.Drawing.Point(5, 25);
            this.grdVeriler.MainView = this.gridView1;
            this.grdVeriler.Name = "grdVeriler";
            this.grdVeriler.Size = new System.Drawing.Size(1064, 106);
            this.grdVeriler.TabIndex = 0;
            this.grdVeriler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Alfa.Notlar);
            this.bindingSource1.Sort = "";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNotID,
            this.colNotBaslik,
            this.colNotIcerik});
            this.gridView1.GridControl = this.grdVeriler;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colNotID
            // 
            this.colNotID.FieldName = "NotID";
            this.colNotID.Name = "colNotID";
            // 
            // colNotBaslik
            // 
            this.colNotBaslik.FieldName = "NotBaslik";
            this.colNotBaslik.Name = "colNotBaslik";
            this.colNotBaslik.Visible = true;
            this.colNotBaslik.VisibleIndex = 0;
            // 
            // colNotIcerik
            // 
            this.colNotIcerik.FieldName = "NotIcerik";
            this.colNotIcerik.Name = "colNotIcerik";
            this.colNotIcerik.Visible = true;
            this.colNotIcerik.VisibleIndex = 1;
            // 
            // pnlHatirlatici
            // 
            this.pnlHatirlatici.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHatirlatici.Controls.Add(this.grpGuncelle);
            this.pnlHatirlatici.Controls.Add(this.grdVeriler);
            this.pnlHatirlatici.Controls.Add(this.grpYeniNot);
            this.pnlHatirlatici.Location = new System.Drawing.Point(12, 483);
            this.pnlHatirlatici.Name = "pnlHatirlatici";
            this.pnlHatirlatici.Size = new System.Drawing.Size(1074, 136);
            this.pnlHatirlatici.TabIndex = 1;
            // 
            // grpGuncelle
            // 
            this.grpGuncelle.Controls.Add(this.lblGuncelle);
            this.grpGuncelle.Controls.Add(this.pcrGuncelle);
            this.grpGuncelle.Location = new System.Drawing.Point(5, 1);
            this.grpGuncelle.Name = "grpGuncelle";
            this.grpGuncelle.ShowCaption = false;
            this.grpGuncelle.Size = new System.Drawing.Size(77, 23);
            this.grpGuncelle.TabIndex = 3;
            this.grpGuncelle.Text = "groupControl1";
            this.grpGuncelle.Click += new System.EventHandler(this.grpGuncelle_Click);
            // 
            // lblGuncelle
            // 
            this.lblGuncelle.Location = new System.Drawing.Point(26, 5);
            this.lblGuncelle.Name = "lblGuncelle";
            this.lblGuncelle.Size = new System.Drawing.Size(40, 13);
            this.lblGuncelle.TabIndex = 2;
            this.lblGuncelle.Text = "Güncelle";
            this.lblGuncelle.Click += new System.EventHandler(this.lblGuncelle_Click);
            // 
            // pcrGuncelle
            // 
            this.pcrGuncelle.EditValue = ((object)(resources.GetObject("pcrGuncelle.EditValue")));
            this.pcrGuncelle.Location = new System.Drawing.Point(3, 5);
            this.pcrGuncelle.Name = "pcrGuncelle";
            this.pcrGuncelle.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pcrGuncelle.Size = new System.Drawing.Size(16, 16);
            this.pcrGuncelle.TabIndex = 1;
            this.pcrGuncelle.Click += new System.EventHandler(this.pcrGuncelle_Click);
            // 
            // grpYeniNot
            // 
            this.grpYeniNot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpYeniNot.Controls.Add(this.lblYeniNot);
            this.grpYeniNot.Controls.Add(this.pceYeniNot);
            this.grpYeniNot.Location = new System.Drawing.Point(977, 0);
            this.grpYeniNot.Name = "grpYeniNot";
            this.grpYeniNot.ShowCaption = false;
            this.grpYeniNot.Size = new System.Drawing.Size(92, 23);
            this.grpYeniNot.TabIndex = 0;
            this.grpYeniNot.Text = "groupControl1";
            this.grpYeniNot.Click += new System.EventHandler(this.grpYeniNot_Click);
            // 
            // lblYeniNot
            // 
            this.lblYeniNot.Location = new System.Drawing.Point(25, 5);
            this.lblYeniNot.Name = "lblYeniNot";
            this.lblYeniNot.Size = new System.Drawing.Size(62, 13);
            this.lblYeniNot.TabIndex = 3;
            this.lblYeniNot.Text = "Yeni Not ekle";
            this.lblYeniNot.Click += new System.EventHandler(this.lblYeniNot_Click);
            // 
            // pceYeniNot
            // 
            this.pceYeniNot.EditValue = ((object)(resources.GetObject("pceYeniNot.EditValue")));
            this.pceYeniNot.Location = new System.Drawing.Point(3, 3);
            this.pceYeniNot.Name = "pceYeniNot";
            this.pceYeniNot.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pceYeniNot.Size = new System.Drawing.Size(16, 16);
            this.pceYeniNot.TabIndex = 4;
            this.pceYeniNot.Click += new System.EventHandler(this.pceYeniNot_Click);
            // 
            // brTelRehber
            // 
            this.brTelRehber.Caption = "Telefon Rehberi";
            this.brTelRehber.Id = 13;
            this.brTelRehber.Name = "brTelRehber";
            this.brTelRehber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.brTelRehber_ItemClick);
            // 
            // Yonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 631);
            this.Controls.Add(this.pnlHatirlatici);
            this.Controls.Add(this.pnlGenel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Yonetim";
            this.Text = "Yönetim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Yonetim_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGenel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVeriler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlHatirlatici)).EndInit();
            this.pnlHatirlatici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpGuncelle)).EndInit();
            this.grpGuncelle.ResumeLayout(false);
            this.grpGuncelle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcrGuncelle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpYeniNot)).EndInit();
            this.grpYeniNot.ResumeLayout(false);
            this.grpYeniNot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pceYeniNot.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlGenel;
        private DevExpress.XtraEditors.PanelControl pnlHatirlatici;
        private DevExpress.XtraEditors.LabelControl lblYeniNot;
        private DevExpress.XtraEditors.PictureEdit pceYeniNot;
        private DevExpress.XtraEditors.GroupControl grpYeniNot;
        private DevExpress.XtraGrid.Columns.GridColumn colNotID;
        private DevExpress.XtraGrid.Columns.GridColumn colNotBaslik;
        private DevExpress.XtraGrid.Columns.GridColumn colNotIcerik;
        public System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraEditors.GroupControl grpGuncelle;
        private DevExpress.XtraEditors.LabelControl lblGuncelle;
        private DevExpress.XtraEditors.PictureEdit pcrGuncelle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl grdVeriler;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar brMenu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem brDosya;
        private DevExpress.XtraBars.BarSubItem brKullaniciEkle;
        private DevExpress.XtraBars.BarSubItem brSistemBilgisi;
        private DevExpress.XtraBars.BarSubItem brTemaSec;
        private DevExpress.XtraBars.BarSubItem brNotEkle;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraBars.BarSubItem brTelRehber;
    }
}