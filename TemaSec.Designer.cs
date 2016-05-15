namespace Alfa
{
    partial class TemaSec
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
            this.btnTemaSec = new DevExpress.XtraEditors.SimpleButton();
            this.grpTemalar = new DevExpress.XtraEditors.GroupControl();
            this.lstTemalar = new DevExpress.XtraEditors.ListBoxControl();
            this.grpBtnTemaSec = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpTemalar)).BeginInit();
            this.grpTemalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTemalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBtnTemaSec)).BeginInit();
            this.grpBtnTemaSec.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemaSec
            // 
            this.btnTemaSec.Location = new System.Drawing.Point(203, 14);
            this.btnTemaSec.Name = "btnTemaSec";
            this.btnTemaSec.Size = new System.Drawing.Size(202, 23);
            this.btnTemaSec.TabIndex = 1;
            this.btnTemaSec.Text = "Tema\'yı Uygula";
            this.btnTemaSec.Click += new System.EventHandler(this.btnTemaSec_Click);
            // 
            // grpTemalar
            // 
            this.grpTemalar.Controls.Add(this.lstTemalar);
            this.grpTemalar.Location = new System.Drawing.Point(12, 12);
            this.grpTemalar.Name = "grpTemalar";
            this.grpTemalar.Size = new System.Drawing.Size(620, 374);
            this.grpTemalar.TabIndex = 1;
            this.grpTemalar.Text = "Tema Listesi";
            // 
            // lstTemalar
            // 
            this.lstTemalar.Location = new System.Drawing.Point(6, 24);
            this.lstTemalar.Name = "lstTemalar";
            this.lstTemalar.Size = new System.Drawing.Size(609, 345);
            this.lstTemalar.TabIndex = 0;
            // 
            // grpBtnTemaSec
            // 
            this.grpBtnTemaSec.Controls.Add(this.btnTemaSec);
            this.grpBtnTemaSec.Location = new System.Drawing.Point(12, 392);
            this.grpBtnTemaSec.Name = "grpBtnTemaSec";
            this.grpBtnTemaSec.ShowCaption = false;
            this.grpBtnTemaSec.Size = new System.Drawing.Size(615, 52);
            this.grpBtnTemaSec.TabIndex = 2;
            // 
            // TemaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(644, 455);
            this.Controls.Add(this.grpBtnTemaSec);
            this.Controls.Add(this.grpTemalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TemaSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tema Seçimi";
            this.Load += new System.EventHandler(this.TemaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpTemalar)).EndInit();
            this.grpTemalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTemalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpBtnTemaSec)).EndInit();
            this.grpBtnTemaSec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnTemaSec;
        private DevExpress.XtraEditors.GroupControl grpTemalar;
        private DevExpress.XtraEditors.ListBoxControl lstTemalar;
        private DevExpress.XtraEditors.GroupControl grpBtnTemaSec;
    }
}