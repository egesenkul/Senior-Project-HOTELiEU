using DevExpress.XtraEditors;
using MetroFramework;
using Otel_Uygulamasi;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar;
using Otel_Uygulamasi.Formlar.Ardunio;
using Otel_Uygulamasi.Formlar.Duyuru_Islemleri;
using Otel_Uygulamasi.Formlar.EtkinlikIslemleri;
using Otel_Uygulamasi.Formlar.Genel;
using Otel_Uygulamasi.Formlar.OdaIslemleri;
using Otel_Uygulamasi.Formlar.Personel_Islemleri;
using Otel_Uygulamasi.Formlar.TemizlikIslemleri;
using Otel_Uygulamasi.Formlar.Toplantı_Islemleri;
using Otel_Uygulamasi.Formlar.YemekIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DevExpress_Deneme
{
    public partial class AnaEkran : MetroFramework.Forms.MetroForm
    {

        public AnaEkran()
        {
            if (string.IsNullOrEmpty(Kullanici.KullaniciAdi))
            {
                frmLogin Login = new frmLogin();
                Login.ShowDialog();
            }
            InitializeComponent();
        }

        private void ArdunioKontrol()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from Ardunio where ArdunioCinsi='SıcaklıkHavuz1'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    Ardunio.ArdunioAktif = Convert.ToBoolean(Dr["Aktif"]);
                    Ardunio.Port = Dr["Port"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void AnaEkranYetki()
        {
            try
            {
                if (!string.Equals(Kullanici.yetki, "admin"))
                {
                    tilePersonelIslemleri.Visible = false;
                    tileMusteriIslemleri.Visible = false;
                    tileOdaIslemleri.Visible = false;
                    tilePersonelIslemleri.Visible = false;
                    tileTemizlikIslemleri.Visible = false;
                    tileYemekIslemleri.ItemSize = TileItemSize.Wide;
                    tileDuyuruIslemleri.ItemSize = TileItemSize.Large;
                    tileYemekIslemleri.ItemSize = TileItemSize.Large;
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
                tileAyarlar.Text = Localization.tileAyarlar;
                tileItemSicaklik.Text = Localization.tileSicaklik;
                tileMusteriIslemleri.Text = Localization.tileMusteri;
                tileYemekIslemleri.Text = Localization.tileYemek;
                tileEtkinlikIslemleri.Text = Localization.tileEtkinlik;
                tilePersonelIslemleri.Text = Localization.tilePersonel;
                tileOdaIslemleri.Text = Localization.tileOda;
                tileTemizlikIslemleri.Text = Localization.tileTemizlik;
                tileDuyuruIslemleri.Text = Localization.tileDuyuru;
                tileToplantiIslemleri.Text = Localization.tileToplanti;
                btnKlavye.Text = Localization.btnKlavyeAc;
                tileKapat.Text = Localization.btnKapat;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Ardunio.Sicaklik1 = 0; // İlk değer işlemleri için
                                       //ArdunioKontrol();
                
                metroLabel1.Text = Localization.Hoşgeldiniz + " " + Kullanici.isim;
                tileKullaniciAdi.Text = Kullanici.isim;
                tileKapat.ItemSize = TileItemSize.Large;
                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else { btnKlavye.Visible = false; }
                timer1.Start();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    metroLabel1.ForeColor = Color.White;
                }
                else
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    metroLabel1.BackColor = Color.White;
                    metroLabel1.ForeColor = Color.Black;
                }
                ortakFormIslemleri.tileRenkDegistir(tileKullaniciAdi, tileAyarlar, tileTarih, tileMusteriIslemleri, tileYemekIslemleri, tileEtkinlikIslemleri, tilePersonelIslemleri,
                    tileOdaIslemleri, tileTemizlikIslemleri, tileDuyuruIslemleri, tileToplantiIslemleri, tileSaat, tileGuncelleme, tileDestek, tileItemSicaklik);
                AnaEkranYetki();
                MultiLanguage();
                this.Text = "HOTELiEU";
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
                Form2 ayarlar = new Form2();
                ayarlar.ShowDialog();
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
                Form3 havadurumu = new Form3();
                havadurumu.Show();
                //Login login = new Login();
                //login.Show();
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
                HotelWarningForm.Show(Localization.programaGirisYapanKullanici + " " + Kullanici.isim + " " + Kullanici.soyisim, Localization.Tamam, 2);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem11_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("osk.exe");
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                tileSaat.Text = DateTime.Now.ToShortTimeString();
                tileTarih.Text = DateTime.Now.Date.ToString().Substring(0, 8);
                //TileItem'de kullanıcı adı ve otel adının yazması için
                tileKullaniciAdi.Text = Kullanici.isim + " " + Kullanici.soyisim;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem19_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                string tarih = Localization.Saat + " : " + DateTime.Now.ToShortTimeString(); ;
                HotelWarningForm.Show(tarih, Localization.Tamam, 2);
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
                string tarih = Localization.lblTarih + " : " + DateTime.Now.Date.ToString().Substring(0, 8);
                HotelWarningForm.Show(tarih, Localization.Tamam, 2);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem14_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                if (Kullanici.OnayFormlari.Equals("True"))
                {
                    DialogResult sonuc;
                    sonuc = HotelMessageBox.Show(Localization.ProgramCikisOnay, Localization.Evet, Localization.Hayır);
                    if (sonuc == DialogResult.No)
                    {
                        //MessageBox.Show("");// hiçbir işlem yaptırmıyorum
                    }
                    if (sonuc == DialogResult.Yes)
                    {
                        this.Close();
                        Application.Exit();
                    }
                }
                else { Application.Exit(); }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                Form4 musteriislemleri = new Form4();
                musteriislemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem13_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                OdaIslemleri odaislemleri = new OdaIslemleri();
                odaislemleri.Show();
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
                EtkinlikIslemleri etkinlikIslemleri = new EtkinlikIslemleri();
                etkinlikIslemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem15_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                DuyuruIslemleri duyuruislemleri = new DuyuruIslemleri();
                duyuruislemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem16_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                TemizlikIslemleri temizlikismleri = new TemizlikIslemleri();
                temizlikismleri.Show();
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
                YemekIslemleri yemekislemleri = new YemekIslemleri();
                yemekislemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem12_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                PersonelIslemleri personelislemleri = new PersonelIslemleri();
                personelislemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem17_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                PersonelIslemleri persislemleri = new PersonelIslemleri();
                persislemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem18_ItemClick_1(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            try
            {
                ToplantiIslemleri toplantiIslemleri = new ToplantiIslemleri();
                toplantiIslemleri.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tileItem1_ItemClick_1(object sender, TileItemEventArgs e)
        {
            try
            {
                ArdunioBaglantiSicaklik ArdunioAyarlar = new ArdunioBaglantiSicaklik();
                ArdunioAyarlar.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
