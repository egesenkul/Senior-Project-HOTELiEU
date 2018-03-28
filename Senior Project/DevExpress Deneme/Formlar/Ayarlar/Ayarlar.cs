using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Otel_Uygulamasi.Formlar;
using Otel_Uygulamasi.Formlar.Ayarlar;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Ardunio;
using Otel_Uygulamasi;

namespace DevExpress_Deneme
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void darkTema()
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Style = MetroFramework.MetroColorStyle.Black;

        }

        private void lightTema()
        {
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Style = MetroFramework.MetroColorStyle.White;
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") || !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileBlokEkle.Visible = false;
                tileHavuzEkle.Visible = false;
                tileItemSıcaklıkArdunio.Visible = false;
                tileKategoriTanimlamari.Visible = false;
                tileKatEkle.Visible = false;
                tileLisansIslemleri.Visible = false;
                tileOtelTanimlamalari.Visible = false;
                tileSalonTanimlamalari.Visible = false;
                tileYetki.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            tileKullaniciTercihleri.Text = Localization.tileKullaniciTercihleri;
            tileLisansIslemleri.Text = Localization.tileLisans;
            tileYetki.Text = Localization.tileYetki;
            tileKapat.Text = Localization.btnKapat;
            tileOtelTanimlamalari.Text = Localization.tileOtelTanimlamalari;
            tileKategoriTanimlamari.Text = Localization.tileKategoriTanimlamalari;
            tileKatEkle.Text = Localization.tileKatEkle;
            tileSalonTanimlamalari.Text = Localization.tileSalonTanimlamalari;
            tileBlokEkle.Text = Localization.tileBlokEkle;
            tileHavuzEkle.Text = Localization.tileHavuzEkle;
            tileItemSıcaklıkArdunio.Text = Localization.ArdunioSicaklinBaglanti;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                darkTema();
            }
            else
            {
                lightTema();
            }
            ortakFormIslemleri.tileRenkDegistir(tileBlokEkle, tileKategoriTanimlamari, tileKullaniciTercihleri, tileLisansIslemleri, tileOtelTanimlamalari,
                tileSalonTanimlamalari,tileHavuzEkle,tileItemSıcaklıkArdunio,tileYetki,tileKatEkle);
   //         Yetki();
            }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            OtelTanımlamaları otelTanimlamaları = new OtelTanımlamaları();
            otelTanimlamaları.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            SalonTanimlamalari salontanimlamalari = new SalonTanimlamalari();
            salontanimlamalari.Show();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            KategoriTanimlamalari kategoritanimlamalari = new KategoriTanimlamalari();
            kategoritanimlamalari.Show();
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            LisansIslemleri lisans = new LisansIslemleri();
            lisans.Show();
        }

        //private void tileItem1_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        //{
        //    if (temadark)
        //    {
        //        lightTema();
        //    }
        //    else { darkTema(); }
        //}

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            blokEkle blokekle = new blokEkle();
            blokekle.Show();
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            KullaniciTercihleri kullaniciTercihleri = new KullaniciTercihleri();
            kullaniciTercihleri.Show();
        }

        private void tileHavuzEkle_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            HavuzEkle havuzEkle = new HavuzEkle();
            havuzEkle.Show();
        }

        private void tileItemSıcaklıkArdunio_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            ArdunioBaglantiSicaklik ayarlarArdunioSicaklik = new ArdunioBaglantiSicaklik();
            ayarlarArdunioSicaklik.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            KatEkle katEkle = new KatEkle();
            katEkle.Show();
        }

        private void tileYetki_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            AyarlarYetki yetki = new AyarlarYetki();
            yetki.Show();
        }
    }
}
