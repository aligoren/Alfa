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

namespace Alfa
{
    public partial class KullaniciEkle : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        public void KEkle(string kullanici_adi, string sifre)
        {
            Alfa.AlfaDBEntities dbContext = new AlfaDBEntities();
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi = kullanici_adi;
            kullanici.KullaniciSifre = sifre;
            dbContext.Kullanicis.Add(kullanici);
            dbContext.SaveChanges();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kul_adi = txtKullaniciAdi.Text;
            var kul_parola = txtParola.Text;
            var kul_par_tekrar = txtParolaTekrar.Text;
            if (kul_adi != string.Empty && kul_parola != string.Empty && kul_par_tekrar != string.Empty)
            {
                if (kul_parola == kul_par_tekrar)
                {
                    KEkle(kul_adi, kul_parola);
                    XtraMessageBox.Show("Kullanıcı Ekleme İşlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Parolalar Eşleşmelidir", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Tüm Alanlar Doldurulmalıdır!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}