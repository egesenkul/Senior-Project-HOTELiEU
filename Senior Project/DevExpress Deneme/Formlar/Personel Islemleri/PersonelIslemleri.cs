using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Personel_Islemleri
{
    public partial class PersonelIslemleri : MetroFramework.Forms.MetroForm
    {
        public PersonelIslemleri()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileItemPersonelOlusturma.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            tileItemPersonelOlusturma.Text = Localization.tilePersonelOlustur;
            tileItemPersonelListesi.Text = Localization.tilePersonelListesi;
            tileItemKapat.Text = Localization.btnKapat;
        }

        private void PersonelIslemleri_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileItemPersonelListesi, tileItemPersonelOlusturma);
            Yetki();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            PersonelOlusturma persolustur = new PersonelOlusturma();
            persolustur.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            PersonelListesi personelListesi = new PersonelListesi();
            personelListesi.Show();
        }
    }
}
