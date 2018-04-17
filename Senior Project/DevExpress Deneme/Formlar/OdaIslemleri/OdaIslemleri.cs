using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Musteri_Islemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.OdaIslemleri
{
    public partial class OdaIslemleri : MetroFramework.Forms.MetroForm
    {
        public OdaIslemleri()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileItemOdaMusteriIliskilendir.Visible = false;
                tileItemOdaRezerveEt.Visible = false;
                tileItemOdaTanimlama.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            tileItemOdaTanimlama.Text = Localization.tileOdaTanimlama;
            tileItemOdaMusteriIliskilendir.Text = Localization.tileOdaCheckin;
            tileItemOdaListesi.Text = Localization.tileOdaListesi;
            tileItemOdaRezerveEt.Text = Localization.tileOdaRezerveEt;
            tileItem7.Text = Localization.btnKapat;
            tileSureUzat.Text = Localization.tileSureUzat;
        }

        private void OdaIslemleri_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileItemKatPlani, tileItemOdaListesi, tileItemOdaMusteriIliskilendir, tileItemOdaRezerveEt, tileItemOdaTanimlama,tileItem1,tileSureUzat);
            Yetki();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OdaRezerveEt odaRezerve = new OdaRezerveEt();
            odaRezerve.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OdaListesi odaListesi = new OdaListesi();
            odaListesi.Show();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OdaTanimlama odatanimlama = new OdaTanimlama();
            odatanimlama.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OdaCheckin iliskilendir = new OdaCheckin();
            iliskilendir.Show();
        }

        private void tileItem1_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Checkout chout = new Checkout();
            chout.Show();
        }

        private void tileSureUzat_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            SureUzat sureUzat = new SureUzat();
            sureUzat.Show();
        }
    }
}
