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
using DevExpress.Skins;

namespace Alfa
{
    public partial class TemaSec : DevExpress.XtraEditors.XtraForm
    {
        public TemaSec()
        {
            InitializeComponent();
        }

        private void TSec(string tema_adi)
        {
            Alfa.AlfaDBEntities dbContext = new AlfaDBEntities();
            Tema tema = dbContext.Temas.Where(c => c.id == 1).FirstOrDefault();
            tema.TemaAdi = tema_adi;
            dbContext.SaveChanges();
        }

        private void btnTemaSec_Click(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(lstTemalar.Text);
            TSec(lstTemalar.Text);
        }

        private void TemaSec_Load(object sender, EventArgs e)
        {
            string[] temalar = { "DevExpress Style","DevExpress Dark Style","VS2010","Seven Classic","Office 2010 Blue","Office 2010 Black","Office 2010 Silver",
                    "Office 2013","Office 2013 Dark Gray","Office 2013 Light Gray","Visual Studio 2013 Blue","Visual Studio 2013 Light","Visual Studio 2013 Dark",
                    "Office 2016 Colorful","Office 2016 Dark","Coffee","Liquid Sky","London Liquid Sky","Glass Oceans","Stardust","Xmas 2008 Blue","Valentine","McSkin",
                    "Summer 2008","Pumpkin","Dark Side","Springtime","Foggy","High Contrast","Seven","Sharp","Sharp Plus",
                    "The Asphalt World","Whiteprint","Caramel","Money Twins","Lilian","iMaginary","Black","Office 2007 Blue",
                    "Office 2007 Black","Office 2007 Silver","Office 2007 Green","Office 2007 Pink",
                    "Blue","Darkroom","Blueprint","Metropolis Dark","Metropolis"};

            foreach (var tema in temalar)
            {
                lstTemalar.Items.Add(tema);
            }
        }
    }
}