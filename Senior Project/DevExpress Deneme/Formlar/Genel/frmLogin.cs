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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void KullaniciAdiSifreOku()
        {
            txtKullaniciAdi.Text = Otel_Uygulamasi.Properties.Settings.Default.KullaniciAdi;
            txtSifre.Text = Otel_Uygulamasi.Properties.Settings.Default.KullaniciSifre;
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                chHatirla.Checked = false;
            }
        }

        private void KullaniciAdiSifreKaydet()
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

        private void MultiLanguage()
        {
            lblKullaniciAdi.Text = Localization.lblKullaniciAdi;
            lblSifre.Text = Localization.lblSifre;
            lblDil.Text = Localization.lblDil;
            //frmLogin.Text = Localization.LoginFormText;
            btnDestek.Text = Localization.btnDestek;
            btnGiris.Text = Localization.btnGiris;
            btnKapat.Text = Localization.btnKapat;
            btnKlavyeAc.Text = Localization.btnKlavyeAc;
            chHatirla.Text = Localization.chHatirla;
            
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

                   

                    label1.Text = (string.Format("USD: "+USD));
                    label2.Text = (string.Format("EURO: "+EURO));
                    label3.Text = (string.Format("POUND: "+POUND));
                    //webBrowser1.Navigate("http://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=169&cad=rja&uact=8&ved=0ahUKEwiZzKSIxZ_UAhWDVhoKHVxrDnA4oAEQFghKMAg&url=http%3A%2F%2Fwww.zentekyazilim.net%2F&usg=AFQjCNHc2Df9xQjv-O16X96EJPC9xH4gUw&sig2=ovl3PoVp-vgX913SQBeYTw");
                }
                else
                {

                }
            }
            catch (Exception)
            {

                MessageBox.Show(".", "İnternet Bağlantısı Sağlanamadı. Döviz Kurları Gücellenemedi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (CheckForInternetConnection())
            {
                DovizKuruGetir();
                KullaniciAdiSifreOku();
                this.StyleManager = metroStyleManager1;
                ortakFormIslemleri.LogoGetir(pictureBox1);
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7)
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKullaniciAdi, lblSifre);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtKullaniciAdi, txtSifre);
                    ortakFormIslemleri.CheckBoxRenkDegistir(Color.White, chHatirla);
                    btnDestek.BackColor = Color.Black;
                    btnDestek.ForeColor = Color.Red;
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
                MessageBox.Show("İnternet bağlantısı olmadığından programı kullanamazsınız.");
                Environment.Exit(1);
            }
        }
        

        private void GirisKontrol()
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MetroMessageBox.Show(this, "", Localization.KullaniciAdiHata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAdi.Focus();
            }
            if (string.IsNullOrEmpty(txtSifre.Text))
            {
                MetroMessageBox.Show(this, "", Localization.KullaniciSifreHata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Focus();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection= new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select personelAdi,personelKullaniciAdi,personelSoyadi,onayFormlari,bilgilendirmeFormlari,otoGeceModu,klavyeButonu,tileItemColor,Yetki from Personel where personelKullaniciAdi = '" + txtKullaniciAdi.Text + "' and personelSifre='"+txtSifre.Text+"'";
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
                girisDogru = true;
            }
            connection.Close();
            if (!girisDogru)
            {
                MetroMessageBox.Show(this, "", Localization.HataliKullaniciAdiSifre, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MetroMessageBox.Show(this, " ", Localization.ProgramCikisOnay, MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Destek destek = new Destek();
            destek.Show();
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnGiris.PerformClick();
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnGiris.PerformClick();
            }
        }

        private void cmbDil_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
