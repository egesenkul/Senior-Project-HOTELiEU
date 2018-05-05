using MetroFramework;
using Otel_Uygulamasi;
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

namespace DevExpress_Deneme
{
    public partial class MusteriTanimlamaForm : MetroFramework.Forms.MetroForm
    {
        string MevcutMailAdresi = "";
        int mod = 0;
        bool guncellemeYap = true;
        string tablo = "";
        public MusteriTanimlamaForm()
        {
            InitializeComponent();
        }

        public MusteriTanimlamaForm(string mailAdresi, int m, string Tablo)
        { //Personel Listesinden Tüm Bilgileri Göster Dediği Zaman Form Bu Şekilde Açılsın
            InitializeComponent();
            MevcutMailAdresi = mailAdresi;
            mod = m;
            tablo = Tablo;
        }

        private void EnableFalse()
        { // Eğer bu form personel bilgilerini görüntüle denilerek açıldıysa değişiklik yapamasın
            try
            {
                if (mod == 1)
                {
                    txtadres.Enabled = false;
                    txtisim.Enabled = false;
                    txtKullaniciAdi.Enabled = false;
                    txtmail.Enabled = false;
                    txtSifre.Enabled = false;
                    txtsoyisim.Enabled = false;
                    txttelefon.Enabled = false;
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
                lblAdres.Text = Localization.lblAdres;
                lblKullaniciAdi.Text = Localization.lblKullaniciAdi;
                lblMail.Text = Localization.lblMail;
                lblMusteriAdi.Text = Localization.lblMusteriAdi;
                lblMusteriSoyadi.Text = Localization.lblMusteriSoyadi;
                lblSifre.Text = Localization.lblSifre;
                lblTelefon.Text = Localization.lblTelefon;
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

        private void MusteriTanimlamaForm_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.musteriTanimlama;
                this.WindowState = FormWindowState.Maximized;
                float x = (Convert.ToInt32(this.Width) - Convert.ToInt32(metroPanel1.Width)) / 2;
                float y = (Convert.ToInt32(this.Height) - Convert.ToInt32(metroPanel1.Height)) / 2;

                metroPanel1.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
                btnTemizle.PerformClick();
                BilgiDoldur();
                EnableFalse();

                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKullaniciAdi, lblSifre, lblMusteriAdi, lblMusteriSoyadi, lblTelefon, lblAdres, lblMail);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtadres, txtisim, txtKullaniciAdi, txtmail, txtSifre, txtsoyisim, txttelefon);
                }
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

        private void BilgiDoldur()
        { // Form mevcut kullanıcı ile ilgili açıldı ise bu kullanıcıya ait bilgileri ilgili yerlere yazar
            try
            {
                if (!String.IsNullOrEmpty(MevcutMailAdresi))
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd = new SqlCommand();
                    //cmd text rızanın ve egenin tablosuna göre değişecektir 
                    if (string.Equals(tablo, "ege"))
                    {
                        cmd.CommandText = "select * from Musteriler where musteriMail ='" + MevcutMailAdresi + "'";
                    }
                    else
                    {
                        cmd.CommandText = "select * from DenemeMusteriler where musteriMail ='" + MevcutMailAdresi + "'";
                    }
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader Dr;
                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        txtisim.Text = Dr["musteriAdi"].ToString();
                        txtsoyisim.Text = Dr["musteriSoyadi"].ToString();
                        txttelefon.Text = Dr["musteriTelefon"].ToString();
                        txtadres.Text = Dr["musteriAdres"].ToString();
                        txtmail.Text = Dr["musteriMail"].ToString();
                        if (string.Equals(tablo, "ege"))
                        {
                            txtKullaniciAdi.Text = Dr["musteriKullaniciAdi"].ToString();
                            txtSifre.Text = Dr["musteriSifre"].ToString();
                        }
                        else
                        {
                            txtKullaniciAdi.Visible = false;
                            txtSifre.Visible = false;
                            lblKullaniciAdi.Visible = false;
                            lblSifre.Visible = false;
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void KullaniciSifreOlustur()
        {
            try
            {
                if (!String.IsNullOrEmpty(txtisim.Text) && !String.IsNullOrEmpty(txtsoyisim.Text) && !String.IsNullOrEmpty(txtKullaniciAdi.Text))
                {
                    txtSifre.Text = txtKullaniciAdi.Text.Substring(0, 2) + DateTime.Now.Second.ToString() + txtKullaniciAdi.Text.Substring(2, txtKullaniciAdi.Text.Length - 2) + DateTime.Now.Minute.ToString();
                }
                else { txtSifre.Text = ""; }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        } //Kullanıcı için ilk şifre oluşturucu

        private void metroButton3_Click(object sender, EventArgs e)
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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.textBoxTemizle(txtadres, txtisim, txtKullaniciAdi, txtmail, txtSifre, txtsoyisim, txttelefon);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public string TurkceIngilizceCevir(string data)
        {
            try
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
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return "";
        } // Türkçe karakterleri İngilizce karaktere çevirebilmek için

        private void KullaniciAdiOlustur()
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(txtsoyisim.Text) && !String.IsNullOrWhiteSpace(txtisim.Text))
                {
                    txtKullaniciAdi.Text = txtisim.Text.ToLower() + "." + txtsoyisim.Text.ToLower();
                    txtKullaniciAdi.Text = TurkceIngilizceCevir(txtKullaniciAdi.Text);
                }
                else { txtKullaniciAdi.Text = ""; }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        } // Kullanıcı adı oluşturucu

        private void txtisim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                KullaniciAdiOlustur();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtsoyisim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                KullaniciAdiOlustur();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool MusteriOlusturKontrol()
        { // müşteri oluşturmak için gerekli kontrol işlemlerini yap
            try
            {
                if (!String.IsNullOrEmpty(txtKullaniciAdi.Text) && !String.IsNullOrEmpty(txtSifre.Text))
                {
                    return eMailKontrol(txtmail.Text);

                }
                HotelWarningForm.Show(Localization.HataliKullaniciAdiSifre, Localization.Tamam, 2);
                return false;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private bool musteriRizaninTablodami(string musteriMail)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from DenemeMusteriler where MusteriMail ='" + musteriMail + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                if (!Dr.HasRows)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    guncellemeYap = false;
                    HotelWarningForm.Show(Localization.MusterFaceVarHata, Localization.Tamam, 1);
                    return false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private bool musteriVarmi(string musteriMail)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from Musteriler where musteriMail ='" + musteriMail + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                if (!Dr.HasRows)
                {
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    guncellemeYap = false;
                    HotelWarningForm.Show(Localization.MusteriSistemeKayitliHata, Localization.Tamam, 1);
                    return false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MusteriOlusturKontrol())
                {//gerekli kontroller sağlandıktan sonra müşteri tablosunda yeni kişi oluştur insert et

                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    if (string.IsNullOrWhiteSpace(MevcutMailAdresi) && musteriVarmi(txtmail.Text) && musteriRizaninTablodami(txtmail.Text))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "Insert into Musteriler values ('" + txtisim.Text + "','" + txtsoyisim.Text + "' , '" + txttelefon.Text + "' , '" + txtadres.Text + "' , '" + txtmail.Text + "' , '" + txtKullaniciAdi.Text + "' , '" + txtSifre.Text + "',0,0)";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.MusteriTanimlamaBasarili, Localization.Tamam, 0);
                        }
                    }

                    else
                    {
                        if (guncellemeYap)
                        {
                            //güncelleme işlemi olacak 
                            //rızanın tablosunu da göz önüne alarak güncelle
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = connection;
                            connection.Open();
                            if (string.Equals(tablo, "ege"))
                            {
                                cmd.CommandText = "update Musteriler set musteriAdi='" + txtisim.Text + "',musteriSoyadi='" + txtsoyisim.Text + "',musteriTelefon='" + txttelefon.Text + "',musteriAdres='" + txtadres.Text + "',musteriMail='" + txtmail.Text + "',musteriSifre='" + txtSifre.Text + "' where musteriMail='" + MevcutMailAdresi + "'";
                            }
                            else
                            {
                                cmd.CommandText = "update DenemeMusteriler set MusteriAdi = '" + txtisim.Text + "',MusteriSoyadi='" + txtsoyisim.Text + "',MusteriTelefon = '" + txttelefon.Text + "',MusteriAdres = '" + txtadres.Text + "',MusteriMail = '" + txtmail.Text + "' where MusteriMail = '" + MevcutMailAdresi + "'";
                            }
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                            {
                                HotelWarningForm.Show(Localization.MusteriGuncellemeBasarili, Localization.Tamam, 0);
                            }
                        }
                    }
                    btnTemizle.PerformClick();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                KullaniciSifreOlustur();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        } // Kullanıcı adı değiştiği zaman otomatik şifre de değişsin

        public bool eMailKontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                HotelWarningForm.Show(Localization.eMailHata, Localization.Tamam, 1);
                return false;
            }
        } // Girilen email adresinin geçerliliğini kontrol ediyor
    }
}
