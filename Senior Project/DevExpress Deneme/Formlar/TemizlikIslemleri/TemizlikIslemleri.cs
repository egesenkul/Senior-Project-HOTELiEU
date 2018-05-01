using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Genel;
using Otel_Uygulamasi.Formlar.OdaIslemleri;
using Otel_Uygulamasi.Formlar.TemizlikIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.TemizlikIslemleri
{
    public partial class TemizlikIslemleri : MetroFramework.Forms.MetroForm
    {
        public TemizlikIslemleri()
        {
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            try
            {
                tileItemOdaKontrol.Text = Localization.odaKontrol;
                tileItemPersonelKontrol.Text = Localization.personelKontrol;
                tileItemKapat.Text = Localization.btnKapat;
                tileItem1.Text = Localization.temizlikYap;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void TemizlikIslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                }
                ortakFormIslemleri.tileRenkDegistir(tileItemOdaKontrol, tileItemPersonelKontrol);
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
                Form34 odakontrol = new Form34();
                odakontrol.Show();
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
                PersonelKontrol personelkontrol = new PersonelKontrol();
                personelkontrol.Show();
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

        private void tileItem1_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                TemizlikYap temizlikYap = new TemizlikYap();
                temizlikYap.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
