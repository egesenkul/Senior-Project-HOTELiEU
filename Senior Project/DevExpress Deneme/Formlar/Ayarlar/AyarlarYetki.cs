using MetroFramework;
using Otel_Uygulamasi.Classlar;
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

        public void FiilComboBoxYetkiler()
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

        private void AyarlarYetki_Load(object sender, EventArgs e)
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
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKullaniciDepartman, lblTanımlıYetki, lblYetkiler,lblKullanıcıListesi,lblYetki);
                ortakFormIslemleri.ListViewRenkDegistir(Color.Black, ListeKullanicilar);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKullaniciDepartman, cmbYetki);
            }
            MultiLanguage();
        }

        private void MultiLanguage()
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

        private void KullaniciListesiGuncelleme()
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand cmd = new SqlCommand();
            ListeKullanicilar.Items.Clear();
            SqlDataReader Dr;

            cmd.CommandText = "select * from Personel where Sil = 0 and personelDepartman='" + cmbKullaniciDepartman.SelectedItem.ToString()+"'" ;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                ListeKullanicilar.Items.Add(Dr["personelAdi"].ToString()+" "+Dr["personelSoyadi"].ToString());
            }
            connection.Close();
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
            if (ListeKullanicilar.SelectedItems.Count != 0)
            {
                
                string kisiAdi = ListeKullanicilar.SelectedItems[0].Text;
                parcalar = kisiAdi.Split(' ');
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                ListeKullanicilar.Items.Clear();
                SqlDataReader Dr;
               
                cmd.CommandText = "select Yetki from Personel where personelAdi='"+parcalar[0]+"' and personelSoyadi='"+parcalar[1]+"'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                        lblYetki.Text=Dr["Yetki"].ToString();
                }
                connection.Close();
            }
            FiilComboBoxYetkiler();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.comboBoxTemizle(cmbYetki, cmbKullaniciDepartman);
        }

        private void btnKlavye_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Personel set Yetki='"+cmbYetki.SelectedItem.ToString()+"' where personelAdi='"+parcalar[0]+"' and personelSoyadi='"+parcalar[1]+"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            if (Kullanici.BilgilendirmeFormlari.Equals("True"))
            {
                MetroMessageBox.Show(this, ". ", Localization.YetkiGuncellemeBasarili, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
