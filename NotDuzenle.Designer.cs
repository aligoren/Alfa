namespace Alfa
{
    partial class NotDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotDuzenle));
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.txtNotBaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtNot = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblNotKalan = new DevExpress.XtraEditors.LabelControl();
            this.lblBaslikKalan = new DevExpress.XtraEditors.LabelControl();
            this.lblNot = new DevExpress.XtraEditors.LabelControl();
            this.lblNotBaslik = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(318, 297);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(118, 40);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Not Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtNotBaslik
            // 
            this.txtNotBaslik.EditValue = "";
            this.txtNotBaslik.Location = new System.Drawing.Point(14, 40);
            this.txtNotBaslik.Name = "txtNotBaslik";
            this.txtNotBaslik.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("txtNotBaslik.Properties.ContextImage")));
            this.txtNotBaslik.Properties.MaxLength = 50;
            this.txtNotBaslik.Properties.NullText = "Not Başlığı";
            this.txtNotBaslik.Size = new System.Drawing.Size(422, 20);
            this.txtNotBaslik.TabIndex = 0;
            this.txtNotBaslik.TextChanged += new System.EventHandler(this.txtNotBaslik_TextChanged);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(14, 99);
            this.txtNot.Name = "txtNot";
            this.txtNot.Properties.MaxLength = 100;
            this.txtNot.Size = new System.Drawing.Size(422, 184);
            this.txtNot.TabIndex = 1;
            this.txtNot.TextChanged += new System.EventHandler(this.txtNot_TextChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblNotKalan);
            this.panelControl1.Controls.Add(this.lblBaslikKalan);
            this.panelControl1.Controls.Add(this.lblNot);
            this.panelControl1.Controls.Add(this.lblNotBaslik);
            this.panelControl1.Controls.Add(this.btnGuncelle);
            this.panelControl1.Controls.Add(this.txtNotBaslik);
            this.panelControl1.Controls.Add(this.txtNot);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(451, 353);
            this.panelControl1.TabIndex = 4;
            // 
            // lblNotKalan
            // 
            this.lblNotKalan.Location = new System.Drawing.Point(14, 332);
            this.lblNotKalan.Name = "lblNotKalan";
            this.lblNotKalan.Size = new System.Drawing.Size(0, 13);
            this.lblNotKalan.TabIndex = 6;
            // 
            // lblBaslikKalan
            // 
            this.lblBaslikKalan.Location = new System.Drawing.Point(14, 304);
            this.lblBaslikKalan.Name = "lblBaslikKalan";
            this.lblBaslikKalan.Size = new System.Drawing.Size(0, 13);
            this.lblBaslikKalan.TabIndex = 5;
            // 
            // lblNot
            // 
            this.lblNot.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(14, 71);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(25, 22);
            this.lblNot.TabIndex = 4;
            this.lblNot.Text = "Not";
            // 
            // lblNotBaslik
            // 
            this.lblNotBaslik.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotBaslik.Location = new System.Drawing.Point(14, 10);
            this.lblNotBaslik.Name = "lblNotBaslik";
            this.lblNotBaslik.Size = new System.Drawing.Size(75, 22);
            this.lblNotBaslik.TabIndex = 3;
            this.lblNotBaslik.Text = "Not Başlığı";
            // 
            // NotDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 380);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NotDuzenle";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Not Düzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NotDuzenle_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNotKalan;
        private DevExpress.XtraEditors.LabelControl lblBaslikKalan;
        private DevExpress.XtraEditors.LabelControl lblNot;
        private DevExpress.XtraEditors.LabelControl lblNotBaslik;
        public DevExpress.XtraEditors.TextEdit txtNotBaslik;
        public DevExpress.XtraEditors.MemoEdit txtNot;
    }
}