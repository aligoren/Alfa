using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;

namespace Alfa
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            TemaGetir();
        }
        
        public void TemaGetir()
        {
            Alfa.AlfaDBEntities dbContext = new AlfaDBEntities();
            Tema tema = dbContext.Temas.Where(c => c.id == 1).FirstOrDefault();
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(tema.TemaAdi);
        }
        private void ParolaDogrula(string kullanici, string sifre)
        {
            AlfaDBEntities ade = new AlfaDBEntities();

            var kullanici_islemi = ade.Kullanicis
                .FirstOrDefault(u => u.KullaniciAdi == kullanici
                             && u.KullaniciSifre == sifre);

            var kullanici_adi = txtKullaniciAdi.Text;
            var kullanici_sifre = txtParola.Text;

            if (kullanici_adi != string.Empty && kullanici_sifre != string.Empty)
            {
                if (kullanici_islemi != null)
                {
                    Yonetim yonetim = new Yonetim();
                    yonetim.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı Adı Ya da Parola Yanlış", "HATA");
                }
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı Ya da Parola Alanı Boş Bırakılamaz!", "HATA");
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullanici = txtKullaniciAdi.Text;
            var sifre = txtParola.Text;
            ParolaDogrula(kullanici, sifre);
        }

        private void txtParola_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.Sleep(2000);
        }
    }
}
