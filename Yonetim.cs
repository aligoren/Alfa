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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using System.Threading;
using DevExpress.Skins;

namespace Alfa
{
    public partial class Yonetim : DevExpress.XtraEditors.XtraForm
    {
        public static int by_id;

        Alfa.AlfaDBEntities dbContext;

        public Yonetim()
        {
            InitializeComponent();
            NotlariGetir();
        }
        
        public void NotlariGetir()
        {

            dbContext = new Alfa.AlfaDBEntities();
            dbContext.Notlars.Load();

            bindingSource1.DataSource = dbContext.Notlars.Local.ToBindingList().Reverse().Take(4);
            
        }


        private void Yonetim_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        
        private void grpYeniNot_Click(object sender, EventArgs e)
        {
            this.Text = "Yeni Not Ekle..";
            YeniNot yeni = new YeniNot();
            yeni.ShowDialog();
        }

        private void pceYeniNot_Click(object sender, EventArgs e)
        {
            this.Text = "Yeni Not Ekle..";
            YeniNot yeni = new YeniNot();
            yeni.ShowDialog();
        }

        private void lblYeniNot_Click(object sender, EventArgs e)
        {
            this.Text = "Yeni Not Ekle..";
            YeniNot yeni = new YeniNot();
            yeni.ShowDialog();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void grpGuncelle_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Thread.Sleep(800);
            SplashScreenManager.CloseForm();
            NotlariGetir();
        }

        private void lblGuncelle_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Thread.Sleep(800);
            SplashScreenManager.CloseForm();
            NotlariGetir();
            
        }

        private void pcrGuncelle_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Thread.Sleep(800);
            SplashScreenManager.CloseForm();
            NotlariGetir();
        }

        private void brNotEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Text = "Yeni Not Ekle..";
            YeniNot yeni = new YeniNot();
            yeni.ShowDialog();
        }
        
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "Not Düzenleniyor..";
            NotDuzenle nd = new NotDuzenle();
            int row_select = int.Parse(gridView1.GetRowCellDisplayText(gridView1.FocusedRowHandle, "NotID"));
            var not = dbContext.Notlars.Where(c => c.NotID == row_select).FirstOrDefault();
            by_id = row_select;
            nd.txtNotBaslik.Text = not.NotBaslik;
            nd.txtNot.Text = not.NotIcerik;
            nd.ShowDialog();
            
        }

        private void brTemaSec_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TemaSec ts = new TemaSec();
            ts.ShowDialog();
            
        }

        private void brKullaniciEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KullaniciEkle kullanici_ekle = new KullaniciEkle();
            kullanici_ekle.ShowDialog();
        }
    }
}