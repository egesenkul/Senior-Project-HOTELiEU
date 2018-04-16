using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Otel_Uygulamasi.Formlar.Musteri_Islemleri;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.OdaIslemleri;
using Otel_Uygulamasi;

namespace DevExpress_Deneme
{
    public partial class Form4 : MetroFramework.Forms.MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileItemMusteriTanimlama.Visible = false;
                tileItemMusteriOdaIliskilendir.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            tileItemKapat.Text = Localization.btnKapat;
            tileItemMusteriOdaIliskilendir.Text = Localization.musteriCheckin;
            tileItemMusteriListesi.Text = Localization.musteriListesi;
            tileItemKapat.Text = Localization.btnKapat;
            tileSureUzat.Text = Localization.tileSureUzat;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileItemMusteriListesi, tileItemMusteriOdaIliskilendir, tileItemMusteriTanimlama);
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MusteriTanimlamaForm musteritanimlama = new MusteriTanimlamaForm();
            musteritanimlama.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OdaCheckin iliskilendir = new OdaCheckin();
            iliskilendir.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            MusteriListesi musteriListesi = new MusteriListesi();
            musteriListesi.Show();
        }

        private void tileSureUzat_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {

        }
    }
}
