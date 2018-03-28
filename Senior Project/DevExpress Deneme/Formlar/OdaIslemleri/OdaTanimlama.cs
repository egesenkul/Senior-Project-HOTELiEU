using MetroFramework;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Ayarlar;
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
                cmbSorumluPersonel.Items.Add(Dr["personelAdi"]+" "+ Dr["personelSoyadi"]);
            }
            connection.Close();
        }

        public void FiilComboboxBlok()
        {
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

        public void FiilComboboxOdaGrubu()
        {
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

        public void FiilComboboxKat()
        {
            cmbKat.Items.Clear();
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select KatNo from Kat where blokAdı='"+cmbBlok.SelectedItem.ToString() + "'";
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

        private void BilgiDoldur()
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
            }
        }

        private void MultiLanguage()
        {
            lblBlok.Text = Localization.lblBlokAdi;
            lblCiftKisilikYatak.Text = Localization.CiftKisilikYatakSayisi;
            lblKat.Text = Localization.lblKatAdi;
            lblOdadanSorumluPersonel.Text = Localization.OdadanSorumluPersonel;
            lblOdaGrup.Text = Localization.OdaGrubu;
            lblOdaNumarasi.Text = Localization.OdaNumarasi;
            lblTekKisilikYatak.Text = Localization.tekKisilikYatakSayisi;
            btnIptal.Text = Localization.btnIptal;
            btnKaydet.Text = Localization.btnKaydet;
            btnKlavye.Text = Localization.btnKlavyeAc;
        }

        private void OdaTanimlama_Load(object sender, EventArgs e)
        {
            MultiLanguage();
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
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblOdaNumarasi, lblBlok,lblTekKisilikYatak,lblKat,lblOdaGrup,lblOdadanSorumluPersonel,lblCiftKisilikYatak);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbBlok,cmbKat,cmbOdaTürü,cmbSorumluPersonel);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnOdaTuruEkle_Click(object sender, EventArgs e)
        {
            KategoriTanimlamalari OdaTuruEkle = new KategoriTanimlamalari(2);
            OdaTuruEkle.Show();
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelOlusturma PersonelEkle = new PersonelOlusturma();
            PersonelEkle.Show();
        }

        private void btnBlokEkle_Click(object sender, EventArgs e)
        {
            KatEkle blokekle = new KatEkle();
            blokekle.Show();
        }

        private bool OdaOlusturKontrol()
        {
            if (!string.IsNullOrEmpty(txtOdaNo.Text) && !string.IsNullOrEmpty(txtCiftKisiYatakSayisi.Text) && !string.IsNullOrEmpty(txtTekKisilikYatakSayisi.Text))
            {
                return true;
            }
            return false;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (OdaOlusturKontrol())
            {//gerekli kontroller sağlandıktan sonra oda tablosunda yeni kişi oluştur insert et
                if (string.IsNullOrWhiteSpace(mevcutOdaNo))
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open(); //BLOK ID EKLE
                    cmd.CommandText = "insert into Oda values ('" + txtOdaNo.Text + "'," + txtCiftKisiYatakSayisi.Text + "," + txtTekKisilikYatakSayisi.Text + ",'" + cmbOdaTürü.SelectedItem.ToString() + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbBlok.SelectedItem.ToString() + "','" + cmbKat.SelectedItem.ToString() + "',1,'Boş')";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        MetroMessageBox.Show(this, "", Localization.OdaEklemeBasarili, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    cmd.CommandText = "Update Oda set OdaNo='" + txtOdaNo.Text + "',ikiKisilikYatak=" + txtCiftKisiYatakSayisi.Text + ",tekKisilikYatak=" + txtTekKisilikYatakSayisi.Text + ",odaTip='" + cmbOdaTürü.SelectedItem.ToString() + "',blok='"  + cmbBlok.SelectedItem.ToString() + "',katAdi='" + cmbKat.SelectedItem.ToString() + "'where OdaNo='"+mevcutOdaNo+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        MetroMessageBox.Show(this, "", Localization.OdaDuzenlemeBasarili, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "", Localization.OdaBilgisiEksik, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.textBoxTemizle(txtCiftKisiYatakSayisi, txtOdaNo, txtTekKisilikYatakSayisi);
            ortakFormIslemleri.comboBoxTemizle(cmbKat,cmbBlok, cmbOdaTürü, cmbSorumluPersonel);
        }

        private void cmbBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiilComboboxKat();
        }

        private void txtTekKisilikYatakSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&  (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this, "", Localization.tekKisilikRakamGir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTekKisilikYatakSayisi.Focus();
            }
        }

        private void txtCiftKisiYatakSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroMessageBox.Show(this, "", Localization.ikiKisilikRakamGir, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCiftKisiYatakSayisi.Focus();
            }
        }

        private void btnTekKisilikYatakArttır_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.txtNumaraArttir(txtTekKisilikYatakSayisi);
        }

        private void btnCiftKisilikYatakArttır_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.txtNumaraArttir(txtCiftKisiYatakSayisi);
        }

        private void btnTekKisiYatakAzalt_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.txtNumaraAzalt(txtTekKisilikYatakSayisi);
        }

        private void btnCiftKisilikYatakAzalt_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.txtNumaraAzalt(txtCiftKisiYatakSayisi);
        }
    }
}
