using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Duyuru_Islemleri
{
    public partial class DuyuruIslemleri : MetroFramework.Forms.MetroForm
    {
        public DuyuruIslemleri()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                tileDuyuruEkle.Visible = false;
            }
        }
        
        private void MultiLanguage()
        {
            tileDuyuruEkle.Text = Localization.duyuruEkle;
            tileDuyuruListesi.Text = Localization.duyuruListesi;
            tileKapat.Text = Localization.btnKapat;
        }

        private void DuyuruIslemleri_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileDuyuruEkle, tileDuyuruListesi);
            Yetki();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DuyuruEkle duyuruekle = new DuyuruEkle();
            duyuruekle.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DuyuruListesi duyuruListesi = new DuyuruListesi();
            duyuruListesi.Show();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }
    }
}
