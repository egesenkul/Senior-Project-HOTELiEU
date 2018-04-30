using MetroFramework;
using Otel_Uygulamasi.Classlar;
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

namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    public partial class AyarlarYetki : MetroFramework.Forms.MetroForm
    {
        public string[] parcalar;
        public AyarlarYetki()
        {
            InitializeComponent();
        }

        public void FiilComboboxDepartmanlar()
        {
            try
            {
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select KategoriAciklama from PeronelKategori";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbKullaniciDepartman.Items.Add(Dr["KategoriAciklama"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboBoxYetkiler()
        {
            try
            {
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select yetkiAdı from Yetki";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    if (!string.Equals(lblYetki.Text, Dr["yetkiAdı"]))
                    {
                        cmbYetki.Items.Add(Dr["yetkiAdı"]);
                    }
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbYetki);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void AyarlarYetki_Load(object sender, EventArgs e)
        {
            try
            {
                FiilComboboxDepartmanlar();
                FiilComboBoxYetkiler();
                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
                ortakFormIslemleri.cmbIlkDegerGetir(cmbKullaniciDepartman);

                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKullaniciDepartman, lblTanımlıYetki, lblYetkiler, lblKullanıcıListesi, lblYetki);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, ListeKullanicilar);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKullaniciDepartman, cmbYetki);
                }
                MultiLanguage();
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
                lblKullaniciDepartman.Text = Localization.lblKullaniciDepartman;
                lblKullanıcıListesi.Text = Localization.lblKullanıcıListesi;
                lblTanımlıYetki.Text = Localization.lblTanımlıYetki;
                lblYetkiler.Text = Localization.lblYetkiler;
                lblYetki.Text = Localization.lblYetki;
                btnIptal.Text = Localization.btnIptal;
                btnKaydet.Text = Localization.btnKaydet;
                btnKlavye.Text = Localization.btnKlavyeAc;
                btnTemizle.Text = Localization.btnTemizle;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void KullaniciListesiGuncelleme()
        {
            try
            {
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                ListeKullanicilar.Items.Clear();
                SqlDataReader Dr;

                cmd.CommandText = "select * from Personel where Sil = 0 and personelDepartman='" + cmbKullaniciDepartman.SelectedItem.ToString() + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    ListeKullanicilar.Items.Add(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbKullaniciDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            KullaniciListesiGuncelleme();
        }

        private void ListeKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListeKullanicilar.SelectedItems.Count != 0)
                {

                    string kisiAdi = ListeKullanicilar.SelectedItems[0].Text;
                    parcalar = kisiAdi.Split(' ');
                    //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    ListeKullanicilar.Items.Clear();
                    SqlDataReader Dr;

                    cmd.CommandText = "select Yetki from Personel where personelAdi='" + parcalar[0] + "' and personelSoyadi='" + parcalar[1] + "'";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        lblYetki.Text = Dr["Yetki"].ToString();
                    }
                    connection.Close();
                }
                FiilComboBoxYetkiler();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.comboBoxTemizle(cmbYetki, cmbKullaniciDepartman);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKlavye_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Personel set Yetki='" + cmbYetki.SelectedItem.ToString() + "' where personelAdi='" + parcalar[0] + "' and personelSoyadi='" + parcalar[1] + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.YetkiGuncellemeBasarili, Localization.Tamam, 0);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

    }
}
