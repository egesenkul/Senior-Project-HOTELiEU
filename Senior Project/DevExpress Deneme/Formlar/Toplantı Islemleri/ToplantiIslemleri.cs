using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Genel;
using Otel_Uygulamasi.Formlar.Personel_Islemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Toplantı_Islemleri
{
    public partial class ToplantiIslemleri : MetroFramework.Forms.MetroForm
    {
        public ToplantiIslemleri()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            try { 
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileItemToplantiOlustur.Visible = false;
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
            tileItemToplantiOlustur.Text = Localization.tileToplantiOlustur;
            tileItemToplantiListesi.Text = Localization.tileToplantiListesi;
            tileItemKapat.Text = Localization.btnKapat;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ToplantiIslemleri_Load(object sender, EventArgs e)
        {
            try { 
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileItemToplantiListesi, tileItemToplantiOlustur);
            Yetki();
            MultiLanguage();
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
            ToplantiOlustur toplantiOlustur = new ToplantiOlustur();
            toplantiOlustur.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItemToplantiListesi_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try { 
            ToplantiListesi toplantiListesi = new ToplantiListesi();
            toplantiListesi.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
