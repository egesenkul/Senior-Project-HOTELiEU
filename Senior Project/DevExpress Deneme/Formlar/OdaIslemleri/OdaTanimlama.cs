using MetroFramework;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Ayarlar;
using Otel_Uygulamasi.Formlar.Genel;
using Otel_Uygulamasi.Formlar.Personel_Islemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.OdaIslemleri
{
    public partial class OdaTanimlama : MetroFramework.Forms.MetroForm
    {
        string mevcutOdaNo = "";
        public OdaTanimlama()
        {
            InitializeComponent();
        }
        public OdaTanimlama(string odano)
        {
            mevcutOdaNo = odano;
            InitializeComponent();
        }

        public void FiilComboboxPersonel()
        {
            try
            {
                cmbSorumluPersonel.Items.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select personelAdi,personelSoyadi from Personel where personelDepartman='Temizlikçi'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbSorumluPersonel.Items.Add(Dr["personelAdi"] + " " + Dr["personelSoyadi"]);
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
                cmbBlok.Items.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select BlokAdı from Blok";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbBlok.Items.Add(Dr["BlokAdı"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxOdaGrubu()
        {
            try
            {
                cmbOdaTürü.Items.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select OdaKategoriAciklama from OdaKategori";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbOdaTürü.Items.Add(Dr["OdaKategoriAciklama"]);
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

                cmd.CommandText = "Select KatNo from Kat where blokAdı='" + cmbBlok.SelectedItem.ToString() + "'";
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

        private void BilgiDoldur()
        {
            try
            {
                // Form spesifik bir oda numarası için aldığı zaman bu oda numarasına ait bilgileri doldurur
                if (!String.IsNullOrEmpty(mevcutOdaNo))
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "select * from Oda where OdaNo ='" + mevcutOdaNo + "'";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    SqlDataReader Dr;
                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        txtOdaNo.Text = Dr["OdaNo"].ToString();
                        txtCiftKisiYatakSayisi.Text = Dr["ikiKisilikYatak"].ToString();
                        txtTekKisilikYatakSayisi.Text = Dr["tekKisilikYatak"].ToString();
                        cmbOdaTürü.SelectedItem = Dr["odaTip"].ToString();
                        cmbBlok.Text = Dr["blok"].ToString();
                        cmbKat.Text = Dr["katAdi"].ToString();
                    }
                    connection.Close();

                    //Odadan sorumlu personeli al 

                    SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "select Id from KatSorumluPersoneller where Blok='" + ortakFormIslemleri.odaBlokGetir(mevcutOdaNo) + "' and KatNo='" + ortakFormIslemleri.odaKatGetir(mevcutOdaNo) + "'";
                    cmd2.Connection = connection2;
                    cmd2.CommandType = CommandType.Text;
                    SqlDataReader Dr2;
                    connection2.Open();
                    Dr2 = cmd2.ExecuteReader();
                    while (Dr2.Read())
                    {
                        cmbSorumluPersonel.SelectedIndex = Convert.ToInt32(Dr2["Id"]) - 1;
                    }
                    connection.Close();
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
                lblBlok.Text = Localization.lblBlokAdi + ":";
                lblCiftKisilikYatak.Text = Localization.CiftKisilikYatakSayisi + ":";
                lblKat.Text = Localization.lblKatAdi + ":";
                lblOdadanSorumluPersonel.Text = Localization.OdadanSorumluPersonel + ":";
                lblOdaGrup.Text = Localization.OdaGrubu + ":";
                lblOdaNumarasi.Text = Localization.OdaNumarasi + ":";
                lblTekKisilikYatak.Text = Localization.tekKisilikYatakSayisi + ":";
                btnIptal.Text = Localization.btnIptal;
                btnKaydet.Text = Localization.btnKaydet;
                btnKlavye.Text = Localization.btnKlavyeAc;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void OdaTanimlama_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.tileOdaTanimlama;
                FiilComboboxOdaGrubu();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbOdaTürü);
                FiilComboboxBlok();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbBlok);
                FiilComboboxKat();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbKat);
                FiilComboboxPersonel();
                cmbSorumluPersonel.SelectedIndex = 0;

                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
                if (!string.IsNullOrWhiteSpace(mevcutOdaNo))
                {
                    //düzenleme işlemi
                    BilgiDoldur();
                }
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblOdaNumarasi, lblBlok, lblTekKisilikYatak, lblKat, lblOdaGrup, lblOdadanSorumluPersonel, lblCiftKisilikYatak);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbBlok, cmbKat, cmbOdaTürü, cmbSorumluPersonel);
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

        private void btnOdaTuruEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriTanimlamalari OdaTuruEkle = new KategoriTanimlamalari(2);
                OdaTuruEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelOlusturma PersonelEkle = new PersonelOlusturma();
                PersonelEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnBlokEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KatEkle blokekle = new KatEkle();
                blokekle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool OdaOlusturKontrol()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtOdaNo.Text) && !string.IsNullOrEmpty(txtCiftKisiYatakSayisi.Text) && !string.IsNullOrEmpty(txtTekKisilikYatakSayisi.Text) && !string.IsNullOrEmpty(cmbBlok.SelectedItem.ToString()))
                {
                    return true;
                }
                return false;
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
                if (OdaOlusturKontrol())
                {//gerekli kontroller sağlandıktan sonra oda tablosunda yeni kişi oluştur insert et
                    if (string.IsNullOrWhiteSpace(mevcutOdaNo))
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "insert into Oda values ('" + txtOdaNo.Text + "'," + txtCiftKisiYatakSayisi.Text + "," + txtTekKisilikYatakSayisi.Text + ",'" + cmbOdaTürü.SelectedItem.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbBlok.SelectedItem.ToString() + "','" + cmbKat.SelectedItem.ToString() + "',1,'Boş')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        // Oda sorumlusu oluşturma işlemi

                        string[] parcalar;
                        parcalar = cmbSorumluPersonel.SelectedItem.ToString().Split(' ');

                        SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = connection2;
                        connection2.Open();
                        cmd2.CommandText = "insert into KatSorumluPersoneller values ('" + parcalar[0] + "','" + parcalar[1] + "','" + cmbBlok.SelectedItem.ToString() + "','" + cmbKat.SelectedItem.ToString() + "')";
                        cmd2.ExecuteNonQuery();
                        connection2.Close();


                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.OdaEklemeBasarili, Localization.Tamam, 0);
                        }
                        btnTemizle.PerformClick();
                    }
                    else
                    {
                        //update işlemi olacak
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open(); //BLOK ID EKLE
                        cmd.CommandText = "Update Oda set OdaNo='" + txtOdaNo.Text + "',ikiKisilikYatak=" + txtCiftKisiYatakSayisi.Text + ",tekKisilikYatak=" + txtTekKisilikYatakSayisi.Text + ",odaTip='" + cmbOdaTürü.SelectedItem.ToString() + "',blok='" + cmbBlok.SelectedItem.ToString() + "',katAdi='" + cmbKat.SelectedItem.ToString() + "'where OdaNo='" + mevcutOdaNo + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();


                        string[] parcalar;
                        parcalar = cmbSorumluPersonel.SelectedItem.ToString().Split(' ');

                        SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = connection2;
                        connection2.Open();
                        cmd2.CommandText = "update KatSorumluPersoneller set PersonelAdi='" + parcalar[0] + "',PersonelSoyadi='" + parcalar[1] + "' where Blok='" + cmbBlok.SelectedItem.ToString() + "' and KatNo='" + cmbKat.SelectedItem.ToString() + "'";
                        cmd2.ExecuteNonQuery();
                        connection2.Close();

                        //oda hareket tablosuna update at 
                        SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.Connection = connection3;
                        connection3.Open(); //BLOK ID EKLE
                        cmd3.CommandText = "Update OdaHareket set OdaNo='" + txtOdaNo.Text +  "'where OdaNo='" + mevcutOdaNo + "'";
                        cmd3.ExecuteNonQuery();
                        connection3.Close();


                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.OdaDuzenlemeBasarili, Localization.Tamam, 0);
                        }
                        this.Close();
                    }
                }
                else
                {
                    HotelWarningForm.Show(Localization.OdaBilgisiEksik, Localization.Tamam, 1);
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
                ortakFormIslemleri.textBoxTemizle(txtCiftKisiYatakSayisi, txtOdaNo, txtTekKisilikYatakSayisi);
                ortakFormIslemleri.comboBoxTemizle(cmbKat, cmbBlok, cmbOdaTürü, cmbSorumluPersonel);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiilComboboxKat();
        }

        private void txtTekKisilikYatakSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    HotelWarningForm.Show(Localization.tekKisilikRakamGir, Localization.Tamam, 1);
                    txtTekKisilikYatakSayisi.Focus();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtCiftKisiYatakSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    HotelWarningForm.Show(Localization.ikiKisilikRakamGir, Localization.Tamam, 1);
                    txtCiftKisiYatakSayisi.Focus();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnTekKisilikYatakArttır_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.txtNumaraArttir(txtTekKisilikYatakSayisi);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnCiftKisilikYatakArttır_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.txtNumaraArttir(txtCiftKisiYatakSayisi);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnTekKisiYatakAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.txtNumaraAzalt(txtTekKisilikYatakSayisi);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnCiftKisilikYatakAzalt_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.txtNumaraAzalt(txtCiftKisiYatakSayisi);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKatEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KatEkle ke = new KatEkle();
                ke.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbBlok_Click(object sender, EventArgs e)
        {
            FiilComboboxBlok();
        }

        private void cmbKat_Click(object sender, EventArgs e)
        {
            FiilComboboxKat();
        }

        private void cmbOdaTürü_Click(object sender, EventArgs e)
        {
            FiilComboboxOdaGrubu();
        }

        private void cmbSorumluPersonel_Click(object sender, EventArgs e)
        {
            FiilComboboxPersonel();
        }
    }
}
