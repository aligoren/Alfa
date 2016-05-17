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
using DevExpress.XtraSplashScreen;
using System.Threading;

namespace Alfa
{
    public partial class YeniTelefonKisi : DevExpress.XtraEditors.XtraForm
    {
        

        public YeniTelefonKisi()
        {
            InitializeComponent();
        }

        public void RehbereEkle(string kisi, string tel)
        {
            AlfaDBEntities dbContext = new AlfaDBEntities();
            TelefonRehberi tr = new TelefonRehberi();
            tr.KisiAdiSoyadi = kisi;
            tr.TelefonNumarasi = tel;
            dbContext.TelefonRehberis.Add(tr);
            dbContext.SaveChanges();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kisi = txtKisi.Text;
            var telefon = txtTelefon.Text;
            if (kisi != string.Empty && telefon != string.Empty)
            {
                try
                {
                    RehbereEkle(kisi, telefon);
                    XtraMessageBox.Show(kisi + " rehbere eklendi", "BİLGİ");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("HATA: " + ex.Message, "BİLGİ");
                }
            }
        }

        private void YeniTelefonKisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            var kisi = txtKisi.Text;
            var telefon = txtTelefon.Text;
            TelRehber telr = (TelRehber)Application.OpenForms["TelRehber"];
            if (kisi != string.Empty && telefon != string.Empty)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                SplashScreenManager.Default.SetWaitFormCaption("Ekleniyor..");
                SplashScreenManager.Default.SetWaitFormDescription("Kişi Ekleniyor..");
                Thread.Sleep(600);
                SplashScreenManager.CloseForm();
                telr.Text = "Telefon Rehberi";
                telr.RehberGuncelle();
            }
        }
    }
}