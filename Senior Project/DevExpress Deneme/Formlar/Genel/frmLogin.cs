using MetroFramework;
using Otel_Uygulamasi;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Genel;
using Otel_Uygulamasi.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DevExpress_Deneme
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {

        bool girisDogru = false;
        bool personelSilinmis = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void KullaniciAdiSifreOku()
        {
            try
            {
                txtKullaniciAdi.Text = Otel_Uygulamasi.Properties.Settings.Default.KullaniciAdi;
                txtSifre.Text = Otel_Uygulamasi.Properties.Settings.Default.KullaniciSifre;
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                {
                    chHatirla.Checked = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void KullaniciAdiSifreKaydet()
        {
            try
            {
                Otel_Uygulamasi.Properties.Settings.Default.CheckDurum = chHatirla.Checked;
                Otel_Uygulamasi.Properties.Settings.Default.Save();
                if (chHatirla.Checked)
                {
                    Otel_Uygulamasi.Properties.Settings.Default.KullaniciAdi = txtKullaniciAdi.Text;
                    Otel_Uygulamasi.Properties.Settings.Default.Save();
                    Otel_Uygulamasi.Properties.Settings.Default.KullaniciSifre = txtSifre.Text;
                    Otel_Uygulamasi.Properties.Settings.Default.Save();
                }
                else
                {
                    Otel_Uygulamasi.Properties.Settings.Default.KullaniciAdi = "";
                    Otel_Uygulamasi.Properties.Settings.Default.Save();
                    Otel_Uygulamasi.Properties.Settings.Default.KullaniciSifre = "";
                    Otel_Uygulamasi.Properties.Settings.Default.Save();
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
                lblKullaniciAdi.Text = Localization.lblKullaniciAdi;
                lblSifre.Text = Localization.lblSifre;
                lblDil.Text = Localization.lblDil;
                btnGiris.Text = Localization.btnGiris;
                btnKapat.Text = Localization.btnKapat;
                btnKlavyeAc.Text = Localization.btnKlavyeAc;
                chHatirla.Text = Localization.chHatirla;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void DovizKuruGetir()
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    string Bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(Bugun);

                    // Xml içinden tarihi alma - gerekli olabilir
                    DateTime exchangeDate = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                    lblGuncellemeTarihi.Text = exchangeDate.ToShortDateString();
                    string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                    string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                    string POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;



                    label1.Text = (string.Format("USD: " + USD));
                    label2.Text = (string.Format("EURO: " + EURO));
                    label3.Text = (string.Format("POUND: " + POUND));
                    //webBrowser1.Navigate("http://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=169&cad=rja&uact=8&ved=0ahUKEwiZzKSIxZ_UAhWDVhoKHVxrDnA4oAEQFghKMAg&url=http%3A%2F%2Fwww.zentekyazilim.net%2F&usg=AFQjCNHc2Df9xQjv-O16X96EJPC9xH4gUw&sig2=ovl3PoVp-vgX913SQBeYTw");
                }
                else
                {

                }
            }
            catch (Exception)
            {
                HotelWarningForm.Show(Localization.internetYok, Localization.Tamam, 1);
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://clients3.google.com/generate_204"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (CheckForInternetConnection())
                {
                    DovizKuruGetir();
                    KullaniciAdiSifreOku();
                    this.StyleManager = metroStyleManager1;
                    ortakFormIslemleri.LogoGetir(pictureBox1);
                    if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7)
                    {
                        metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                        metroPanel1.BackColor = Color.Black;
                        panel1.BackColor = Color.Black;
                        panel2.BackColor = Color.Black;
                        ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKullaniciAdi, lblSifre);
                        ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtKullaniciAdi, txtSifre);
                        ortakFormIslemleri.CheckBoxRenkDegistir(Color.White, chHatirla);
                    }
                    else
                    {
                        metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    }
                    cmbDil.Items.Add("Türkçe");
                    cmbDil.Items.Add("English");
                    if (string.Equals(Settings.Default.dil, "İngilizce"))
                    {
                        cmbDil.SelectedIndex = 1;
                    }
                    else
                    {
                        cmbDil.SelectedIndex = 0;
                    }
                    MultiLanguage();
                    this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                  (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
                }
                else
                {
                    HotelWarningForm.Show(Localization.internetYok, Localization.Tamam, 1);
                    Environment.Exit(1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }


        private void GirisKontrol()
        {
            try
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                {
                    HotelWarningForm.Show(Localization.KullaniciAdiHata, Localization.Tamam, 1);
                    txtKullaniciAdi.Focus();
                }
                if (string.IsNullOrEmpty(txtSifre.Text))
                {
                    HotelWarningForm.Show(Localization.KullaniciSifreHata, Localization.Tamam, 1);
                    txtSifre.Focus();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select personelAdi,personelKullaniciAdi,personelSoyadi,onayFormlari,bilgilendirmeFormlari,otoGeceModu,Sil,klavyeButonu,tileItemColor,Yetki from Personel where personelKullaniciAdi = '" + txtKullaniciAdi.Text + "' and personelSifre='" + txtSifre.Text + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    Kullanici.isim = Dr["personelAdi"].ToString();
                    Kullanici.KullaniciAdi = Dr["personelKullaniciAdi"].ToString();
                    Kullanici.soyisim = Dr["personelSoyadi"].ToString();
                    Kullanici.OnayFormlari = Dr["onayFormlari"].ToString();
                    Kullanici.BilgilendirmeFormlari = Dr["bilgilendirmeFormlari"].ToString();
                    Kullanici.otoGeceModu = Dr["otoGeceModu"].ToString(); // Form içerisinde değerlendirilecek
                    Kullanici.klavye = Dr["klavyeButonu"].ToString();
                    Kullanici.tileItemRenk = Dr["tileItemColor"].ToString();
                    Kullanici.yetki = Dr["Yetki"].ToString();
                    if (Dr["Sil"].ToString()== "True")
                    {
                        girisDogru = true;
                    }
                    else
                    {
                        personelSilinmis = true;
                        girisDogru = false;
                    }
                }
                connection.Close();
                if (!girisDogru)
                {
                    if (personelSilinmis == true)
                    {
                        HotelWarningForm.Show(Localization.personelSilinmis, Localization.Tamam, 1);
                    }
                    else HotelWarningForm.Show(Localization.HataliKullaniciAdiSifre, Localization.Tamam, 1);
                }
                else
                {
                    if (String.IsNullOrEmpty(Kullanici.KullaniciAdi))
                    {
                        Application.Exit();
                    }
                    this.Hide();
                    KullaniciAdiSifreKaydet();
                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.Show();

                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.KlavyeAc();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar.Equals(Convert.ToChar(13)))
                {
                    btnGiris.PerformClick();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar.Equals(Convert.ToChar(13)))
                {
                    btnGiris.PerformClick();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDil.SelectedIndex == 0)
                {
                    Localization.Culture = new CultureInfo("");
                    Settings.Default.dil = "Türkçe";
                    Settings.Default.Save();
                }
                else if (cmbDil.SelectedIndex == 1)
                {
                    Localization.Culture = new CultureInfo("en-US");
                    Settings.Default.dil = "İngilizce";
                    Settings.Default.Save();
                }
                MultiLanguage();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
