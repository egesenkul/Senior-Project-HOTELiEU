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
    public partial class PersonelOlusturma : MetroFramework.Forms.MetroForm
    {
        string MevcutPersonelKadi = "";
        int mod=0;

        public PersonelOlusturma()
        {
            InitializeComponent();
        }

        public PersonelOlusturma(string personelKullaniciAdi,int m)
        { //Personel Listesinden Tüm Bilgileri Göster Dediği Zaman Form Bu Şekilde Açılsın
            InitializeComponent();
            MevcutPersonelKadi = personelKullaniciAdi;
            mod = m;
        }

        public string TurkceIngilizceCevir(string data)
        {
            foreach (char c in data)
            {
                switch (c)
                {
                    case 'ş':
                    case 'Ş':
                        data = data.Replace(c, 's');
                        break;
                    case 'ç':
                    case 'Ç':
                        data = data.Replace(c, 'c');
                        break;
                    case 'ı':
                    case 'İ':
                        data = data.Replace(c, 'i');
                        break;
                    case 'ğ':
                    case 'Ğ':
                        data = data.Replace(c, 'g');
                        break;
                    case 'ü':
                    case 'Ü':
                        data = data.Replace(c, 'u');
                        break;
                    case 'ö':
                    case 'Ö':
                        data = data.Replace(c, 'o');
                        break;
                }
            }
            return data;
        } // Türkçe karakterleri İngilizce karaktere çevirebilmek için
        
        private void KullaniciAdiOlustur()
        {
            if (!String.IsNullOrWhiteSpace(txtsoyisim.Text) && !String.IsNullOrWhiteSpace(txtisim.Text))
            {
                txtKullaniciAdi.Text = txtisim.Text.ToLower() + "." + txtsoyisim.Text.ToLower();
                txtKullaniciAdi.Text = TurkceIngilizceCevir(txtKullaniciAdi.Text);
            }
            else { txtKullaniciAdi.Text = ""; }
        }

        private void KullaniciSifreOlustur()
        {
            if (!String.IsNullOrEmpty(txtisim.Text) && !String.IsNullOrEmpty(txtsoyisim.Text) && !String.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                txtSifre.Text = txtKullaniciAdi.Text.Substring(0, 2) + DateTime.Now.Second.ToString() + txtKullaniciAdi.Text.Substring(2, txtKullaniciAdi.Text.Length - 2) + DateTime.Now.Minute.ToString();
            }
            else { txtSifre.Text = ""; }
        } //Kullanıcı için ilk şifre oluşturucu

        public void FiilComboBoxYetkiler()
        {
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
                    cmbYetki.Items.Add(Dr["yetkiAdı"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbYetki);
        }

        private void MultiLanguage()
        {
            lblAd.Text = Localization.lblMusteriAdi;
            lblSoyad.Text = Localization.lblMusteriSoyadi;
            lblAdres.Text = Localization.lblAdres;
            lblKullaniciAdi.Text = Localization.lblKullaniciAdi;
            lblMail.Text = Localization.lblMail;
            lblPersonelGrubu.Text = Localization.lblPersonelGrubu;
            lblPersonelYetkisi.Text = Localization.lblPersonelYetkisi;
            lblSifre.Text = Localization.lblSifre;
            lblTelefon.Text = Localization.lblTelefon;
            btnKlavye.Text = Localization.btnKlavyeAc;
            metroButton1.Text = Localization.btnKaydet;
            metroButton2.Text = Localization.btnKapat;
            metroButton4.Text = Localization.btnTemizle;
        }

        private void PersonelOlusturma_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            FiilCombobox();
            BilgiDoldur();
            EnableFalse();
            FiilComboBoxYetkiler();

            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblAd, lblSoyad, lblTelefon, lblAdres, lblMail, lblKullaniciAdi, lblSifre, lblPersonelGrubu, lblPersonelYetkisi);
                ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtadres, txtisim, txtKullaniciAdi, txtmail, txtSifre, txtsoyisim, txttelefon);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbPersonelGrubu, cmbYetki);
            }
            

            if (Kullanici.klavye.Equals("True"))
            {
                btnKlavye.Visible = true;
            }
            else btnKlavye.Visible = false;
        }

        private void EnableFalse()
        { // Eğer bu form personel bilgilerini görüntüle denilerek açıldıysa değişiklik yapamasın
            if (mod==1)
            {
                txtadres.Enabled = false;
                txtisim.Enabled = false;
                txtKullaniciAdi.Enabled = false;
                txtmail.Enabled = false;
                txtSifre.Enabled = false;
                txtsoyisim.Enabled = false;
                txttelefon.Enabled = false;
                cmbPersonelGrubu.Enabled = false;
            }
        }

        public void FiilCombobox()
        {
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
                cmbPersonelGrubu.Items.Add(Dr["KategoriAciklama"]);
            }
            connection.Close();
            cmbPersonelGrubu.SelectedIndex = 0; 
        }

        private void txtisim_TextChanged(object sender, EventArgs e)
        {
            KullaniciAdiOlustur();
        }

        public bool eMailKontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                HotelWarningForm.Show(Localization.eMailHata,Localization.Tamam);
                return false;
            }
        } // Girilen email adresinin geçerliliğini kontrol ediyor

        private bool PersonelOlusturKontrol()
        { // müşteri oluşturmak için gerekli kontrol işlemlerini yap
            if (!String.IsNullOrEmpty(txtKullaniciAdi.Text) && !String.IsNullOrEmpty(txtSifre.Text))
            {
                return eMailKontrol(txtmail.Text);

            }
            HotelWarningForm.Show(Localization.KullaniciAdiHata, Localization.Tamam);
            return false;
        }

        private bool personelEkliMi()
        { //Personel daha önceden veri tabanına eklenmiş mi


            return  false ;
        }


        private void txtsoyisim_TextChanged(object sender, EventArgs e)
        {
            KullaniciAdiOlustur();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnPersonelGrupEkle_Click(object sender, EventArgs e)
        {
            KategoriTanimlamalari PersonelGrup = new KategoriTanimlamalari(0);
            PersonelGrup.Show();
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            KullaniciSifreOlustur();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (PersonelOlusturKontrol())
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                if (string.IsNullOrWhiteSpace(MevcutPersonelKadi))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "Insert into Personel values ('" + txtisim.Text + "','" + txtsoyisim.Text + "' , '" + txttelefon.Text + "' , '" + cmbPersonelGrubu.SelectedItem.ToString() + "' , '" + txtmail.Text + "' , '" + txtKullaniciAdi.Text + "' , '" + txtSifre.Text + "','"+txtadres.Text+"',1,1,1,1,'Green',0,'"+cmbYetki.SelectedItem.ToString()+"') ";
                    // Personel türünü Rıza'ya sor.
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        MetroMessageBox.Show(this, "Başarılı bir şekilde personel eklenmiştir. ", "Personel Tanımlanmıştır", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } }
                else
                {
                    //güncelleme işlemi olacak 
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Personel set personelAdi='" + txtisim.Text + "',personelSoyadi='" + txtsoyisim.Text + "',personelTelefon='" + txttelefon.Text + "',personelDepartman='" + cmbPersonelGrubu.SelectedItem.ToString() + "',personelMail='" + txtmail.Text + "',personelSifre='" + txtSifre.Text + "',personelAdresi='" + txtadres.Text + "' where personelKullaniciAdi='" + txtKullaniciAdi.Text + "' and personelSifre='"+txtSifre.Text+"'";
                    // Personel türünü Rıza'ya sor.
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        MetroMessageBox.Show(this, "Başarılı bir şekilde personel güncellenmiştir. ", "Personel Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } }
                ortakFormIslemleri.comboBoxTemizle(cmbYetki, cmbPersonelGrubu);
                ortakFormIslemleri.textBoxTemizle(txtadres, txtisim, txtKullaniciAdi, txtmail, txtSifre, txtsoyisim, txttelefon);
            }
        }

        private void BilgiDoldur()
        { // Form mevcut kullanıcı ile ilgili açıldı ise bu kullanıcıya ait bilgileri ilgili yerlere yazar
            if (!String.IsNullOrEmpty(MevcutPersonelKadi))
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from Personel where personelKullaniciAdi ='"+MevcutPersonelKadi+"'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    txtisim.Text = Dr["personelAdi"].ToString();
                    txtsoyisim.Text = Dr["personelSoyadi"].ToString();
                    txttelefon.Text = Dr["personelTelefon"].ToString();
                    cmbPersonelGrubu.SelectedItem = Dr["personelDepartman"].ToString();
                    txtmail.Text = Dr["personelMail"].ToString();
                    txtKullaniciAdi.Text = Dr["personelKullaniciAdi"].ToString();
                    txtSifre.Text = Dr["personelSifre"].ToString();
                    txtadres.Text = Dr["personelAdresi"].ToString();
                }
                connection.Close();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.textBoxTemizle(txtadres, txtisim, txtKullaniciAdi, txtmail, txtSifre, txtsoyisim, txttelefon);
            ortakFormIslemleri.comboBoxTemizle(cmbPersonelGrubu,cmbYetki);
        }
    }
}
