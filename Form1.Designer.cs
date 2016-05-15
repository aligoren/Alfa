namespace Alfa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraSplashScreen.SplashScreenManager splAcilis = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Alfa.SplashScreen1), true, false, true);
            this.pnlGiris = new DevExpress.XtraEditors.PanelControl();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblParola = new DevExpress.XtraEditors.LabelControl();
            this.lblKullaniciAdi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGiris)).BeginInit();
            this.pnlGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGiris
            // 
            this.pnlGiris.Controls.Add(this.btnGiris);
            this.pnlGiris.Controls.Add(this.txtParola);
            this.pnlGiris.Controls.Add(this.txtKullaniciAdi);
            this.pnlGiris.Controls.Add(this.lblParola);
            this.pnlGiris.Controls.Add(this.lblKullaniciAdi);
            this.pnlGiris.Location = new System.Drawing.Point(13, 13);
            this.pnlGiris.Name = "pnlGiris";
            this.pnlGiris.Size = new System.Drawing.Size(371, 181);
            this.pnlGiris.TabIndex = 0;
            // 
            // btnGiris
            // 
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(216, 123);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(139, 35);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtParola
            // 
            this.txtParola.EnterMoveNextControl = true;
            this.txtParola.Location = new System.Drawing.Point(151, 82);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtParola.Properties.ContextImage")));
            this.txtParola.Properties.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(204, 20);
            this.txtParola.TabIndex = 3;
            this.txtParola.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtParola_KeyDown);
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.EnterMoveNextControl = true;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(151, 23);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImage")));
            this.txtKullaniciAdi.Size = new System.Drawing.Size(204, 20);
            this.txtKullaniciAdi.TabIndex = 2;
            // 
            // lblParola
            // 
            this.lblParola.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.Location = new System.Drawing.Point(17, 77);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(61, 24);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(17, 18);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(112, 24);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 206);
            this.Controls.Add(this.pnlGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALFA Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGiris)).EndInit();
            this.pnlGiris.ResumeLayout(false);
            this.pnlGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlGiris;
        private DevExpress.XtraEditors.LabelControl lblKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl lblParola;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
    }
}

