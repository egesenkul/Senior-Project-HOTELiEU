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
using Otel_Uygulamasi.Formlar.Genel;

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
            try
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                this.Style = MetroFramework.MetroColorStyle.Black;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }

        }

        private void lightTema()
        {
            try
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                this.Style = MetroFramework.MetroColorStyle.White;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void Yetki()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void MultiLanguage()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
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
                    tileSalonTanimlamalari, tileHavuzEkle, tileItemSıcaklıkArdunio, tileYetki, tileKatEkle);
                //         Yetki();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                OtelTanımlamaları otelTanimlamaları = new OtelTanımlamaları();
                otelTanimlamaları.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                SalonTanimlamalari salontanimlamalari = new SalonTanimlamalari();
                salontanimlamalari.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                KategoriTanimlamalari kategoritanimlamalari = new KategoriTanimlamalari();
                kategoritanimlamalari.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                LisansIslemleri lisans = new LisansIslemleri();
                lisans.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
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
            try
            {
                blokEkle blokekle = new blokEkle();
                blokekle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                KullaniciTercihleri kullaniciTercihleri = new KullaniciTercihleri();
                kullaniciTercihleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileHavuzEkle_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                HavuzEkle havuzEkle = new HavuzEkle();
                havuzEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItemSıcaklıkArdunio_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                ArdunioBaglantiSicaklik ayarlarArdunioSicaklik = new ArdunioBaglantiSicaklik();
                ayarlarArdunioSicaklik.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                KatEkle katEkle = new KatEkle();
                katEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileYetki_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                AyarlarYetki yetki = new AyarlarYetki();
                yetki.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
