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

namespace Alfa
{
    public partial class TelRehber : DevExpress.XtraEditors.XtraForm
    {
        AlfaDBEntities dbContext;
        public TelRehber()
        {
            InitializeComponent();
            
            dbContext = new AlfaDBEntities();
            dbContext.TelefonRehberis.Load();
            bindingSource1.DataSource = dbContext.TelefonRehberis.Local.ToBindingList().Reverse();

        }

        public void RehberGuncelle()
        {

            dbContext = new AlfaDBEntities();
            dbContext.TelefonRehberis.Load();
            bindingSource1.DataSource = dbContext.TelefonRehberis.Local.ToBindingList().Reverse();

        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            YeniTelefonKisi ytk = new YeniTelefonKisi();
            this.Text = "Kişi Ekleniyor..";
            ytk.ShowDialog();
        }
    }
}