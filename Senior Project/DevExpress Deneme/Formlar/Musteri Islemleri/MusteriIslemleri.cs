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
using Otel_Uygulamasi.Formlar.Genel;

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
            try
            {
                if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
                {
                    tileItemMusteriTanimlama.Visible = false;
                    tileItemMusteriOdaIliskilendir.Visible = false;
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
                tileItemKapat.Text = Localization.btnKapat;
                tileItemMusteriOdaIliskilendir.Text = Localization.musteriCheckin;
                tileItemMusteriListesi.Text = Localization.musteriListesi;
                tileItemKapat.Text = Localization.btnKapat;
                tileSureUzat.Text = Localization.tileSureUzat;
                tileItemMusteriTanimlama.Text = Localization.tileItemMusteriTanimlama;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                }
                ortakFormIslemleri.tileRenkDegistir(tileItemMusteriListesi, tileItemMusteriOdaIliskilendir, tileItemMusteriTanimlama, tileSureUzat);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                MusteriTanimlamaForm musteritanimlama = new MusteriTanimlamaForm();
                musteritanimlama.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                OdaCheckin iliskilendir = new OdaCheckin();
                iliskilendir.Show();
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
                MusteriListesi musteriListesi = new MusteriListesi();
                musteriListesi.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileSureUzat_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                SureUzat sureUzat = new SureUzat();
                sureUzat.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
