using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Genel;
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
            try { 
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileOgunTanimla.Visible = false;
                tileOzelYemekTanimla.Visible = false;
            }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void MultiLanguage()
        {
            try { 
            tileYemekListesi.Text = Localization.tileYemekListesi;
            tileItem2.Text = Localization.ozelYemekEkle;
            tileItem3.Text = Localization.btnKapat;
            tileItem4.Text = Localization.tileYemekListesi;
            tileOgunTanimla.Text = Localization.ogunTanimlama;
            tileOzelYemekTanimla.Text = Localization.ozelYemekEkle;
            tileKapat.Text = Localization.btnKapat;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void YemekIslemleri_Load(object sender, EventArgs e)
        {
            try { 
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileOgunTanimla,tileYemekListesi, tileOzelYemekTanimla);
            Yetki();
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

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try { 
            OgunTanimlama ogun = new OgunTanimlama();
            ogun.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try { 
            OzelYemek ozelyemek = new OzelYemek();
            ozelyemek.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem1_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try { 
            YemekListesi yemekListesi = new YemekListesi();
            yemekListesi.Show();
        }
            catch(Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
}
    }
}
