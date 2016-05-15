namespace Alfa
{
    partial class YeniNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniNot));
            this.txtNotBaslik = new DevExpress.XtraEditors.TextEdit();
            this.txtNot = new DevExpress.XtraEditors.MemoEdit();
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
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
            // txtNotBaslik
            // 
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
            // btnEkle
            // 
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(318, 297);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(118, 40);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Not Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblNotKalan);
            this.panelControl1.Controls.Add(this.lblBaslikKalan);
            this.panelControl1.Controls.Add(this.lblNot);
            this.panelControl1.Controls.Add(this.lblNotBaslik);
            this.panelControl1.Controls.Add(this.btnEkle);
            this.panelControl1.Controls.Add(this.txtNotBaslik);
            this.panelControl1.Controls.Add(this.txtNot);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(451, 353);
            this.panelControl1.TabIndex = 3;
            // 
            // lblNotKalan
            // 
            this.lblNotKalan.Location = new System.Drawing.Point(14, 337);
            this.lblNotKalan.Name = "lblNotKalan";
            this.lblNotKalan.Size = new System.Drawing.Size(0, 13);
            this.lblNotKalan.TabIndex = 6;
            // 
            // lblBaslikKalan
            // 
            this.lblBaslikKalan.Location = new System.Drawing.Point(14, 310);
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
            // YeniNot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 378);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YeniNot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Not Ekle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YeniNot_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtNotBaslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNotBaslik;
        private DevExpress.XtraEditors.MemoEdit txtNot;
        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblNot;
        private DevExpress.XtraEditors.LabelControl lblNotBaslik;
        private DevExpress.XtraEditors.LabelControl lblNotKalan;
        private DevExpress.XtraEditors.LabelControl lblBaslikKalan;
    }
}