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
    public partial class NotDuzenle : DevExpress.XtraEditors.XtraForm
    {
        public NotDuzenle()
        {
            InitializeComponent();
            
        }
        private void NotGuncelle(int not_id, string baslik, string icerik)
        {
            Alfa.AlfaDBEntities dbContext = new AlfaDBEntities();
            Notlar not = dbContext.Notlars.Where(c => c.NotID == not_id).FirstOrDefault();
            not.NotBaslik = baslik;
            not.NotIcerik = icerik;
            dbContext.SaveChanges();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var baslik = txtNotBaslik.Text;
            var icerik = txtNot.Text;
            

            if (baslik != string.Empty && icerik != string.Empty)
            {
                try
                {
                    NotGuncelle(Yonetim.by_id, baslik, icerik);
                    XtraMessageBox.Show("Not Güncellendi", "BİLGİ");

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

        private void NotDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Yonetim ynt = (Yonetim)Application.OpenForms["Yonetim"];
            ynt.Text = "Yönetim";
            ynt.NotlariGetir();
        }
    }
}