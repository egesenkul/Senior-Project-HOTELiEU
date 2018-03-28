using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.YemekIslemleri
{
    public partial class YemekIslemleri : MetroFramework.Forms.MetroForm
    {
        public YemekIslemleri()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileOgunTanimla.Visible = false;
                tileOzelYemekTanimla.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            tileYemekListesi.Text = Localization.tileYemekListesi;
            tileItem2.Text = Localization.ozelYemekEkle;
            tileItem3.Text = Localization.btnKapat;
            tileItem4.Text = Localization.tileYemekListesi;
        }

        private void YemekIslemleri_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileOgunTanimla,tileYemekListesi, tileOzelYemekTanimla);
            Yetki();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OgunTanimlama ogun = new OgunTanimlama();
            ogun.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OzelYemek ozelyemek = new OzelYemek();
            ozelyemek.Show();
        }

        private void tileItem1_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            YemekListesi yemekListesi = new YemekListesi();
            yemekListesi.Show();
        }
    }
}
