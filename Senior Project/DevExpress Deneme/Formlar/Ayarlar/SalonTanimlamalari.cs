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
    public partial class SalonTanimlamalari : MetroFramework.Forms.MetroForm
    {
        int SalonKategoriMod = 0;

        public SalonTanimlamalari()
        {
            InitializeComponent();
        }

        public SalonTanimlamalari(int mod)
        {
            InitializeComponent();
            SalonKategoriMod = mod;
        }

        public void FiilComboboxSorumlu()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select personelAdi,personelSoyadi from Personel";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbSalonSorumlu.Items.Add(Dr["personelAdi"] + " " + Dr["personelSoyadi"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxBlok()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select blokAdı from Blok";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbSalonBlok.Items.Add(Dr["blokAdı"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxKat()
        {
            try
            {
                cmbKat.Items.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select KatNo from Kat where blokAdı='" + cmbSalonBlok.SelectedItem.ToString() + "'";

                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbKat.Items.Add(Dr["KatNo"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbKat);
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
                lblSalonAdi.Text = Localization.lblSalonAdi;
                lblSalonAdresi.Text = Localization.lblSalonAdresi;
                lblSalonBulunduguBlok.Text = Localization.lblSalonBulunduguBlok+":";
                btnKlavye.Text = Localization.btnKlavyeAc;
                btnTemizle.Text = Localization.btnTemizle;
                btnIptal.Text = Localization.btnIptal;
                btnKaydet.Text = Localization.btnKaydet;
                lblSalonBulunduguKat.Text = Localization.lblSalonBulunduguKat;
                lblSalonKategori.Text = Localization.lblSalonKategori;
                lblSalonSorumlusu.Text = Localization.lblSalonSorumlusu;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void SalonTanimlamalari_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.tileSalonTanimlamalari;
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblSalonAdi, lblSalonKategori, lblSalonSorumlusu, lblSalonAdresi, lblSalonBulunduguBlok, lblSalonBulunduguKat);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtadres, txtisim);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKat, cmbSalonBlok, cmbSalonKategori, cmbSalonSorumlu);
                }
                FiilComboboxBlok();
                FiilComboboxSorumlu();
                cmbSalonKategori.Items.Add("Yemek Salonu");
                cmbSalonKategori.Items.Add("Toplantı Salonu");
                ortakFormIslemleri.comboBoxTemizle(cmbSalonBlok, cmbSalonKategori, cmbSalonSorumlu);
                if (SalonKategoriMod == 0)
                {
                    cmbSalonKategori.SelectedIndex = 0;
                }
                else { cmbSalonKategori.SelectedIndex = 1; }
                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BilgiKontrol())
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    string[] parcalar;
                    string kullaniciadiPersonel = "";
                    parcalar = cmbSalonSorumlu.SelectedItem.ToString().Split(' ');
                    SqlCommand cmd3 = new SqlCommand();

                    cmd3.CommandText = "select personelKullaniciAdi from Personel where personelAdi ='" + parcalar[0] + "' and personelSoyadi='" + parcalar[1] + "'";
                    cmd3.Connection = connection;
                    cmd3.CommandType = CommandType.Text;
                    SqlDataReader Dr;
                    connection.Open();
                    Dr = cmd3.ExecuteReader();
                    while (Dr.Read())
                    {
                        kullaniciadiPersonel = (Dr["personelKullaniciAdi"]).ToString();
                    }
                    connection.Close();


                    if (!String.IsNullOrEmpty(txtisim.Text))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();

                        cmd.CommandText = "Insert into Salon values('" + txtisim.Text + "','" + cmbSalonKategori.SelectedItem.ToString() + "','" + kullaniciadiPersonel + "','" + cmbSalonBlok.SelectedItem.ToString() + "','" + txtadres.Text + "','" + cmbKat.SelectedItem.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        txtisim.Clear();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.SalonEklemeBasarili, Localization.Tamam, 0);
                        }
                        ortakFormIslemleri.textBoxTemizle(txtadres, txtisim);
                        ortakFormIslemleri.comboBoxTemizle(cmbSalonSorumlu, cmbSalonKategori, cmbSalonBlok, cmbKat);
                    }
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKlavye_Click(object sender, EventArgs e)
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.textBoxTemizle(txtadres, txtisim);
                ortakFormIslemleri.comboBoxTemizle(cmbSalonBlok, cmbSalonKategori, cmbKat, cmbSalonSorumlu);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool BilgiKontrol()
        {
            try
            {
                if ((cmbKat.SelectedItem == null))
                {
                    HotelWarningForm.Show(Localization.onceKatEkleyiniz, Localization.Tamam, 1);
                    return false;
                }
                if (string.IsNullOrEmpty(txtisim.Text))
                {
                    HotelWarningForm.Show(Localization.salonIsmiBosGecilemez, Localization.Tamam, 1);
                    return false;
                }
                if ((cmbSalonSorumlu.SelectedItem == null))
                {
                    HotelWarningForm.Show(Localization.salonSorumlusuSeciniz, Localization.Tamam, 1);
                    return false;
                }
                if ((cmbSalonBlok.SelectedItem == null))
                {
                    HotelWarningForm.Show(Localization.blokIsmiBosGecilmez, Localization.Tamam, 1);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private void cmbSalonBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FiilComboboxKat();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
