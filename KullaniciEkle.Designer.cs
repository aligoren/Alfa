namespace Alfa
{
    partial class KullaniciEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkle));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblParola = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.lblParolaTekrar = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Controls.Add(this.txtParolaTekrar);
            this.panelControl1.Controls.Add(this.lblParolaTekrar);
            this.panelControl1.Controls.Add(this.txtParola);
            this.panelControl1.Controls.Add(this.txtKullaniciAdi);
            this.panelControl1.Controls.Add(this.lblParola);
            this.panelControl1.Controls.Add(this.lblKullaniciAdi);
            this.panelControl1.Location = new System.Drawing.Point(13, 13);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(241, 290);
            this.panelControl1.TabIndex = 0;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(15, 21);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(112, 24);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // lblParola
            // 
            this.lblParola.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.Location = new System.Drawing.Point(15, 87);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(61, 24);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EnterMoveNextControl = true;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(15, 61);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImage")));
            this.txtKullaniciAdi.Size = new System.Drawing.Size(204, 20);
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // txtParola
            // 
            this.txtParola.EnterMoveNextControl = true;
            this.txtParola.Location = new System.Drawing.Point(15, 120);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImage")));
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(204, 20);
            this.txtParola.TabIndex = 5;
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.EnterMoveNextControl = true;
            this.txtParolaTekrar.Location = new System.Drawing.Point(15, 187);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("textEdit1.Properties.ContextImage")));
            this.txtParolaTekrar.Properties.UseSystemPasswordChar = true;
            this.txtParolaTekrar.Size = new System.Drawing.Size(204, 20);
            this.txtParolaTekrar.TabIndex = 7;
            // 
            // lblParolaTekrar
            // 
            this.lblParolaTekrar.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParolaTekrar.Location = new System.Drawing.Point(15, 152);
            this.lblParolaTekrar.Name = "lblParolaTekrar";
            this.lblParolaTekrar.Size = new System.Drawing.Size(122, 24);
            this.lblParolaTekrar.TabIndex = 6;
            this.lblParolaTekrar.Text = "Parola Tekrar:";
            // 
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(101, 227);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 40);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Kullanıcı Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 315);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KullaniciEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
        private DevExpress.XtraEditors.LabelControl lblParolaTekrar;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
    }
}