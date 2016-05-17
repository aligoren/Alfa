namespace Alfa
{
    partial class YeniTelefonKisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniTelefonKisi));
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem2 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.txtKisi = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefon = new DevExpress.XtraEditors.LabelControl();
            this.lblAdiSoyadi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKisi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Controls.Add(this.txtTelefon);
            this.panelControl1.Controls.Add(this.txtKisi);
            this.panelControl1.Controls.Add(this.lblTelefon);
            this.panelControl1.Controls.Add(this.lblAdiSoyadi);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(241, 226);
            this.panelControl1.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(101, 163);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 40);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Kullanıcı Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTelefon
            // 
            this.txtTelefon.EnterMoveNextControl = true;
            this.txtTelefon.Location = new System.Drawing.Point(15, 120);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImage")));
            this.txtTelefon.Properties.Mask.EditMask = "(\\(\\d\\d\\d\\) )?\\d{1,3}-\\d\\d\\d-\\d\\d-\\d\\d";
            this.txtTelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtTelefon.Properties.NullText = "Örnek: 543 876 94 29";
            this.txtTelefon.Size = new System.Drawing.Size(204, 20);
            toolTipTitleItem3.Text = "Uyarı";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "Numara girişi başında sıfır olmayacak şekilde olmalı";
            toolTipTitleItem4.LeftIndent = 6;
            toolTipTitleItem4.Text = "Örnek: 543 876 94 29";
            superToolTip2.Items.Add(toolTipTitleItem3);
            superToolTip2.Items.Add(toolTipItem2);
            superToolTip2.Items.Add(toolTipSeparatorItem2);
            superToolTip2.Items.Add(toolTipTitleItem4);
            this.txtTelefon.SuperTip = superToolTip2;
            this.txtTelefon.TabIndex = 5;
            // 
            // txtKisi
            // 
            this.txtKisi.EnterMoveNextControl = true;
            this.txtKisi.Location = new System.Drawing.Point(15, 61);
            this.txtKisi.Name = "txtKisi";
            this.txtKisi.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImage")));
            this.txtKisi.Size = new System.Drawing.Size(204, 20);
            this.txtKisi.TabIndex = 4;
            // 
            // lblTelefon
            // 
            this.lblTelefon.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(15, 87);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(71, 24);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdiSoyadi
            // 
            this.lblAdiSoyadi.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdiSoyadi.Location = new System.Drawing.Point(15, 21);
            this.lblAdiSoyadi.Name = "lblAdiSoyadi";
            this.lblAdiSoyadi.Size = new System.Drawing.Size(88, 24);
            this.lblAdiSoyadi.TabIndex = 2;
            this.lblAdiSoyadi.Text = "Adı Soyadı";
            // 
            // YeniTelefonKisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 255);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "YeniTelefonKisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rehbere Yeni Kişi Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeniTelefonKisi_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKisi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.TextEdit txtKisi;
        private DevExpress.XtraEditors.LabelControl lblTelefon;
        private DevExpress.XtraEditors.LabelControl lblAdiSoyadi;
    }
}