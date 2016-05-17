namespace Alfa
{
    partial class TelRehber
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
            this.pnlRehber = new DevExpress.XtraEditors.PanelControl();
            this.btnYeniEkle = new DevExpress.XtraEditors.SimpleButton();
            this.grdRehber = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRehberID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKisiAdiSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonNumarasi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRehber)).BeginInit();
            this.pnlRehber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRehber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRehber
            // 
            this.pnlRehber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRehber.Controls.Add(this.btnYeniEkle);
            this.pnlRehber.Controls.Add(this.grdRehber);
            this.pnlRehber.Location = new System.Drawing.Point(13, 12);
            this.pnlRehber.Name = "pnlRehber";
            this.pnlRehber.Size = new System.Drawing.Size(877, 539);
            this.pnlRehber.TabIndex = 0;
            // 
            // btnYeniEkle
            // 
            this.btnYeniEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYeniEkle.Location = new System.Drawing.Point(797, 511);
            this.btnYeniEkle.Name = "btnYeniEkle";
            this.btnYeniEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYeniEkle.TabIndex = 1;
            this.btnYeniEkle.Text = "Yeni Kişi Ekle";
            this.btnYeniEkle.Click += new System.EventHandler(this.btnYeniEkle_Click);
            // 
            // grdRehber
            // 
            this.grdRehber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdRehber.DataSource = this.bindingSource1;
            this.grdRehber.Location = new System.Drawing.Point(5, 5);
            this.grdRehber.MainView = this.gridView1;
            this.grdRehber.Name = "grdRehber";
            this.grdRehber.Size = new System.Drawing.Size(867, 500);
            this.grdRehber.TabIndex = 0;
            this.grdRehber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Alfa.TelefonRehberi);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRehberID,
            this.colKisiAdiSoyadi,
            this.colTelefonNumarasi});
            this.gridView1.GridControl = this.grdRehber;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colKisiAdiSoyadi, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colRehberID
            // 
            this.colRehberID.FieldName = "RehberID";
            this.colRehberID.Name = "colRehberID";
            // 
            // colKisiAdiSoyadi
            // 
            this.colKisiAdiSoyadi.Caption = "Kayıtlı Kişi";
            this.colKisiAdiSoyadi.FieldName = "KisiAdiSoyadi";
            this.colKisiAdiSoyadi.Name = "colKisiAdiSoyadi";
            this.colKisiAdiSoyadi.Visible = true;
            this.colKisiAdiSoyadi.VisibleIndex = 0;
            this.colKisiAdiSoyadi.Width = 157;
            // 
            // colTelefonNumarasi
            // 
            this.colTelefonNumarasi.Caption = "Telefon Numarası";
            this.colTelefonNumarasi.FieldName = "TelefonNumarasi";
            this.colTelefonNumarasi.Name = "colTelefonNumarasi";
            this.colTelefonNumarasi.Visible = true;
            this.colTelefonNumarasi.VisibleIndex = 1;
            this.colTelefonNumarasi.Width = 338;
            // 
            // TelRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 563);
            this.Controls.Add(this.pnlRehber);
            this.Name = "TelRehber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Telefon Rehberi";
            ((System.ComponentModel.ISupportInitialize)(this.pnlRehber)).EndInit();
            this.pnlRehber.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdRehber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlRehber;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.GridControl grdRehber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colRehberID;
        private DevExpress.XtraGrid.Columns.GridColumn colKisiAdiSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonNumarasi;
        private DevExpress.XtraEditors.SimpleButton btnYeniEkle;
    }
}