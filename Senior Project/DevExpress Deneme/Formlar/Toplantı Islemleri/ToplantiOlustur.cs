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

        private void MultiLanguage()
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

        private void ToplantiOlustur_Load(object sender, EventArgs e)
        {
            MultiLanguage();
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.KlavyeAc();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPersonelKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriTanimlamalari PersonelKategoriEkle = new KategoriTanimlamalari(0);
            PersonelKategoriEkle.Show();
        }

        private void btnToplantıSalonuEkle_Click(object sender, EventArgs e)
        {
            SalonTanimlamalari ToplantıSalonuEkle = new SalonTanimlamalari(1);
            ToplantıSalonuEkle.Show();
        }

        private void chechBoxTümPersoneller_CheckedChanged(object sender, EventArgs e)
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.textBoxTemizle(txtisim, txtAciklama);
            ortakFormIslemleri.checkboxTemizle(chechBoxTümPersoneller);
            ortakFormIslemleri.comboBoxTemizle(cmbPersonelKategori, cmbSalon);
        }

        public void FiilToplantiSalonu()
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


        private void metroButton1_Click(object sender, EventArgs e)
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
            cmd.CommandText = "insert into Toplanti values ('"+txtisim.Text+"','"+cmbSalon.SelectedItem.ToString()+"','"+tarih+"','"+personelKategorisi+"','"+txtAciklama.Text+"','"+Kullanici.KullaniciAdi+ "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            if (Kullanici.BilgilendirmeFormlari.Equals("True"))
            {
                HotelWarningForm.Show(Localization.ToplantiEklemeBasarili, Localization.Tamam);
            }
            btnTemizle.PerformClick();
        }
    }
}
