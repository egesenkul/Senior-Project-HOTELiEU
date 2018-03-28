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
    public partial class KullaniciTercihleri : MetroFramework.Forms.MetroForm
    {
        bool formOnayi = false;
        bool bilgilendirmeFormlari = false;
        string geceModu = "";
        string klavye = "";
        public KullaniciTercihleri()
        {
            InitializeComponent();
        }

        private void OnayKontrol()
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select onayFormlari, bilgilendirmeFormlari,otoGeceModu,klavyeButonu from Personel where personelKullaniciAdi = '"+Kullanici.KullaniciAdi+"'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            string formlarIcin;
            string bilgilendirmeIcin;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                formlarIcin = Dr["onayFormlari"].ToString();
                bilgilendirmeIcin = Dr["bilgilendirmeFormlari"].ToString();
                geceModu = Dr["otoGeceModu"].ToString();
                klavye = Dr["klavyeButonu"].ToString();

                if (formlarIcin.Equals("True"))
                {
                    formOnayi = true;
                    tileOnayForm.Checked = true;
                }
                else { formOnayi = false; tileOnayForm.Checked = false; }
                if (bilgilendirmeIcin.Equals("True"))
                {
                    bilgilendirmeFormlari = true;
                    tileBilgilendirmeFormu.Checked = true;
                }
                else { bilgilendirmeFormlari = false; tileBilgilendirmeFormu.Checked = false; }
                if(geceModu.Equals("True"))
                {
                    tileGeceModu.Checked = true;
                }
                else { tileGeceModu.Checked = false; }
                if (klavye.Equals("True"))
                {
                    tileKlavye.Checked = true;
                }
                else { tileKlavye.Checked = false; }
            }
            connection.Close();
        }

        private void MultiLanguage()
        {
            tileBilgilendirmeFormu.Text = Localization.tileBilgilendirmeFormu;
            tileGeceModu.Text = Localization.tileGeceModu;
            tileKapat.Text = Localization.btnKapat;
            tileKlavye.Text = Localization.btnKlavyeAc;
            tileOnayForm.Text = Localization.tileOnayForm;
            tileRenkDeğistir.Text = Localization.tileRenkDegistir;
            tileYardim.Text = Localization.Yardim;
        }

        private void KullaniciTercihleri_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            OnayKontrol();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            ortakFormIslemleri.tileRenkDegistir(tileBilgilendirmeFormu, tileGeceModu, tileKlavye, tileOnayForm,
                tileRenkDeğistir, tileYardim);
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            this.Close();
        }

        private void tileOnayForm_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (tileOnayForm.Checked == true)
            {
                tileOnayForm.Checked = false;
            }
            else { tileOnayForm.Checked = true; }
        }

        private void tileBilgilendirmeFormu_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (tileBilgilendirmeFormu.Checked == true)
            {
                tileBilgilendirmeFormu.Checked = false;
            }
            else { tileBilgilendirmeFormu.Checked = true; }
        }

        private void tileOnayForm_CheckedChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (tileOnayForm.Checked == true)
            {
                formOnayi = true;

            }
            else { formOnayi = false; }
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Personel set onayFormlari='"+formOnayi+"' where personelKullaniciAdi='"+Kullanici.KullaniciAdi+"'";
            // Personel türünü Rıza'ya sor.
            cmd.ExecuteNonQuery();
            connection.Close();
            Kullanici.BilgiGuncelle();
        }
        //veri tabanına yaz 
        private void tileBilgilendirmeFormu_CheckedChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (tileBilgilendirmeFormu.Checked == true)
            {
                bilgilendirmeFormlari = true;
                //veritabanına yaz

            }
            else { bilgilendirmeFormlari = false; }
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Personel set bilgilendirmeFormlari='" + bilgilendirmeFormlari + "' where personelKullaniciAdi='" + Kullanici.KullaniciAdi + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            Kullanici.BilgiGuncelle();

        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (tileGeceModu.Checked == true)
            {
                tileGeceModu.Checked = false;
            }
            else { tileGeceModu.Checked = true; }
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Personel set otoGeceModu='" + tileGeceModu.Checked + "' where personelKullaniciAdi='" + Kullanici.KullaniciAdi + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void tileGeceModu_CheckedChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Kullanici.BilgiGuncelle();
        }

        private void tileKlavye_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            if (tileKlavye.Checked == true)
            {
                tileKlavye.Checked = false;
            }
            else { tileKlavye.Checked = true; }
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Personel set klavyeButonu ='" + tileKlavye.Checked + "' where personelKullaniciAdi='" + Kullanici.KullaniciAdi + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void tileKlavye_CheckedChanged(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            Kullanici.BilgiGuncelle();
        }

        private void tileRenkDeğistir_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                tileRenkDeğistir.AppearanceItem.Normal.BackColor = colorDialog1.Color;
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Personel set tileItemColor ='" + System.Drawing.ColorTranslator.ToHtml(colorDialog1.Color) + "' where personelKullaniciAdi='" + Kullanici.KullaniciAdi + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                Kullanici.BilgiGuncelle();
            }
        }
    }
}
