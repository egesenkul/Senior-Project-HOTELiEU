using DevExpress.Utils;
using MetroFramework;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Ayarlar;
using Otel_Uygulamasi.Formlar.Genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Personel_Islemleri
{
    public partial class ToplantiOlustur : MetroFramework.Forms.MetroForm
    {
        public ToplantiOlustur()
        {
            InitializeComponent();
        }

        public void FiilComboboxPersonelKategorisi()
        {
            try
            {
                cmbPersonelKategori.Items.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select KategoriAciklama from PeronelKategori";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbPersonelKategori.Items.Add(Dr["KategoriAciklama"]);
                }
                connection.Close();
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
                lblPersonelKategori.Text = Localization.lblPersonelGrubu;
                lblToplantiKonusu.Text = Localization.lblToplantiKonusu;
                lblToplantiTarihi.Text = Localization.lblToplantiTarihi;
                chechBoxTümPersoneller.Text = Localization.chechBoxTümPersoneller;
                lblToplantiSalonu.Text = Localization.lblToplantiSalonu;
                lblAciklama.Text = Localization.lblAciklama;
                btnKapat.Text = Localization.btnKapat;
                btnKaydet.Text = Localization.btnKaydet;
                btnKlavye.Text = Localization.btnKlavyeAc;
                btnTemizle.Text = Localization.btnTemizle;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ToplantiOlustur_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.tileToplantiOlustur;
                FiilComboboxPersonelKategorisi();
                cmbPersonelKategori.SelectedIndex = 0;
                dtToplantiTarihSaat.EditValue = DateTime.Now;
                dtToplantiTarihSaat.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtToplantiTarihSaat.Properties.VistaEditTime = DefaultBoolean.True;
                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
                FiilToplantiSalonu();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblToplantiKonusu, lblToplantiSalonu, lblToplantiTarihi, lblPersonelKategori, lblAciklama);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtAciklama, txtisim);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbPersonelKategori, cmbSalon);
                    ortakFormIslemleri.CheckBoxRenkDegistir(Color.White, chechBoxTümPersoneller);
                    ortakFormIslemleri.DateEditRenkDegistir(Color.Gray, dtToplantiTarihSaat);
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
                ortakFormIslemleri.KlavyeAc();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelKategoriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriTanimlamalari PersonelKategoriEkle = new KategoriTanimlamalari(0);
                PersonelKategoriEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnToplantıSalonuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SalonTanimlamalari ToplantıSalonuEkle = new SalonTanimlamalari(1);
                ToplantıSalonuEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void chechBoxTümPersoneller_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chechBoxTümPersoneller.Checked == true)
                {
                    lblPersonelKategori.Enabled = false;
                    cmbPersonelKategori.Enabled = false;
                    btnPersonelKategoriEkle.Enabled = false;
                    lblPersonelKategori.Visible = false;
                    cmbPersonelKategori.Visible = false;
                    btnPersonelKategoriEkle.Visible = false;
                }
                else
                {
                    lblPersonelKategori.Enabled = true;
                    cmbPersonelKategori.Enabled = true;
                    btnPersonelKategoriEkle.Enabled = true;
                    lblPersonelKategori.Visible = true;
                    cmbPersonelKategori.Visible = true;
                    btnPersonelKategoriEkle.Visible = true;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.textBoxTemizle(txtisim, txtAciklama);
                ortakFormIslemleri.checkboxTemizle(chechBoxTümPersoneller);
                ortakFormIslemleri.comboBoxTemizle(cmbPersonelKategori, cmbSalon);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilToplantiSalonu()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select* from Salon where kategori='Toplantı Salonu'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbSalon.Items.Add(Dr["salonAdı"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbSalon);
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
                string personelKategorisi = "";
                if (chechBoxTümPersoneller.Checked)
                {
                    personelKategorisi = "Tüm Personeller";
                }
                else
                {
                    personelKategorisi = cmbPersonelKategori.SelectedItem.ToString();
                }
                string tarih = Convert.ToDateTime(dtToplantiTarihSaat.EditValue).ToString("yyyy-MM-dd hh:mm:ss");

                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "insert into Toplanti values ('" + txtisim.Text + "','" + cmbSalon.SelectedItem.ToString() + "','" + tarih + "','" + personelKategorisi + "','" + txtAciklama.Text + "','" + Kullanici.KullaniciAdi + "')";
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.ToplantiEklemeBasarili, Localization.Tamam, 0);
                }
                btnTemizle.PerformClick();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbSalon_Click(object sender, EventArgs e)
        {
            FiilToplantiSalonu();
        }

        private void cmbPersonelKategori_Click(object sender, EventArgs e)
        {
            FiilComboboxPersonelKategorisi();
        }
    }
}
