using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Alfa
{
    public partial class YeniNot : DevExpress.XtraEditors.XtraForm
    {
        
        public YeniNot()
        {
            InitializeComponent();
            
        }

        public void NotEkle(string baslik, string icerik)
        {
            Alfa.AlfaDBEntities dbContext = new AlfaDBEntities();
            Notlar not = new Notlar();
            not.NotBaslik = baslik;
            not.NotIcerik = icerik;
            dbContext.Notlars.Add(not);
            dbContext.SaveChanges();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var baslik = txtNotBaslik.Text;
            var not = txtNot.Text;
            if (baslik != string.Empty && not != string.Empty)
            {
                try
                {
                    NotEkle(baslik, not);
                    XtraMessageBox.Show("Not Eklendi", "BİLGİ");

                }
                catch (Exception ex)
                {

                    XtraMessageBox.Show("HATA: " + ex.Message, "BİLGİ");
                }
            }
            else
            {
                XtraMessageBox.Show("Başlık ve Not Bilgisi Boş Olamaz", "HATA");
            }
        }

        private void txtNotBaslik_TextChanged(object sender, EventArgs e)
        {
            if (txtNotBaslik.Text.Length <= 50)
            {
                lblBaslikKalan.ForeColor = Color.Red;
                lblBaslikKalan.Font = new Font("Trebuchet MS", 8, FontStyle.Bold);
                lblBaslikKalan.Text = "Başlık Kalan Karakter Sayısı: " + Convert.ToString(50 - txtNotBaslik.Text.Length);

            }
        }

        private void txtNot_TextChanged(object sender, EventArgs e)
        {
            if (txtNot.Text.Length <= 100)
            {
                lblNotKalan.ForeColor = Color.Red;
                lblNotKalan.Font = new Font("Trebuchet MS", 8, FontStyle.Bold);
                lblNotKalan.Text = "Not Kalan Karakter Sayısı: " + Convert.ToString(100 - txtNot.Text.Length);
            }
        }
        private void YeniNot_FormClosing(object sender, FormClosingEventArgs e)
        {
            Yonetim ynt = (Yonetim)Application.OpenForms["Yonetim"];
            var baslik = txtNotBaslik.Text;
            var icerik = txtNot.Text;
            if (baslik != string.Empty && icerik != string.Empty)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                SplashScreenManager.Default.SetWaitFormCaption("Ekleniyor..");
                SplashScreenManager.Default.SetWaitFormDescription("Not Ekleniyor..");
                Thread.Sleep(600);
                SplashScreenManager.CloseForm();
                ynt.Text = "Yönetim";
                ynt.NotlariGetir(); 
            }
        }
    }
}