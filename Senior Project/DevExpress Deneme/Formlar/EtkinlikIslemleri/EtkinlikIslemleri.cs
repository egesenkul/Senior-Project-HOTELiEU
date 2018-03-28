using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.EtkinlikIslemleri
{
    public partial class EtkinlikIslemleri : MetroFramework.Forms.MetroForm
    {
        public EtkinlikIslemleri()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki,"Resepsiyon'"))
            {
                tileItemEtkinlikOlustur.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            tileItemKapat.Text = Localization.btnKapat;
            tileItemEtkinlikListesi.Text = Localization.etkinlikListesi;
            tileItemEtkinlikOlustur.Text = Localization.etkinlikEkle;
        }

        private void EtkinlikIslemleri_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileItemEtkinlikListesi, tileItemEtkinlikOlustur);
            //Yetki();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EtkinlikListesi EtkinlikListesi = new EtkinlikListesi();
            EtkinlikListesi.Show();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            EtkinlikTanimlama EtkinlikTanimlama = new EtkinlikTanimlama();
            EtkinlikTanimlama.Show();
        }
    }
}
