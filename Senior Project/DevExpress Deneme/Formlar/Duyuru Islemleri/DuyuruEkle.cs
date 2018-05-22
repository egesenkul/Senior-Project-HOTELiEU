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

namespace Otel_Uygulamasi.Formlar.Duyuru_Islemleri
{
    public partial class DuyuruEkle : MetroFramework.Forms.MetroForm
    {
        public int mod = 0;
        public DateTime duyuruTarihi;
        public string duyuruBaslik = "";
        public DuyuruEkle()
        {
            InitializeComponent();
        }

        public DuyuruEkle(DateTime dt,string baslik,int m)
        {
            mod = m;
            duyuruBaslik = baslik;
            duyuruTarihi = dt;
            InitializeComponent();
        }

        public void FiilComboboxDuyuruKategori()
        {
            try
            {
                cmbDuyuruGrubu.Items.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "Select DuyuruKategoriAciklama from DuyuruKategori";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbDuyuruGrubu.Items.Add(Dr["DuyuruKategoriAciklama"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbDuyuruGrubu);
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
                    ComboBoxOdaGrubu.Items.Add(Dr["OdaKategoriAciklama"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(ComboBoxOdaGrubu);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxPersonelGrubu()
        {
            try
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
                    ComboBoxPersonelGrubu.Items.Add(Dr["KategoriAciklama"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(ComboBoxPersonelGrubu);
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
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from Duyuru where Baslik = '" + duyuruBaslik + "' and DuyuruTarihi='" + duyuruTarihi + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    txtBaslik.Text = Dr["Baslik"].ToString();
                    cmbDuyuruGrubu.SelectedItem = Dr["DuyuruGrubu"].ToString();
                    txtIcerik.Text = Dr["Icerik"].ToString();
                    string kriter = "";
                    kriter = Dr["Kriter"].ToString();
                    if (kriter.Equals("Belirtilmedi"))
                    {
                        CheckBoxOzelGonderim.Checked = false;
                    }
                    else { CheckBoxOzelGonderim.Checked = true; }
                    if (kriter.Equals("Oda Grubu"))
                    {
                        ComboBoxKriter.SelectedItem = Localization.OdaGrubu;
                        OdaGrupLabel.Visible = true;
                        ComboBoxOdaGrubu.Visible = true;
                        MusteriAdLabel.Visible = false;
                        cmbMusteriAdi.Visible = false;
                        CheckBoxTumPersoneller.Visible = false;
                        ComboBoxPersonelGrubu.Visible = false;
                        LabelPersonelGrup.Visible = false;
                        CheckBoxTumPersoneller.Visible = false;
                        ComboBoxOdaGrubu.SelectedItem = Dr["OdaGrubu"].ToString();
                    }
                    else if (kriter.Equals("Personeller"))
                    {
                        ComboBoxKriter.SelectedItem = Localization.Personel;
                        string personelGrubu = Dr["PersonelGrubu"].ToString();
                        if (personelGrubu.Equals("Tüm Personel"))
                        {
                            CheckBoxTumPersoneller.Checked = true;
                        }
                        else
                        {
                            ComboBoxKriter.SelectedItem = "Personeller";
                            CheckBoxTumPersoneller.Checked = false;
                            ComboBoxPersonelGrubu.SelectedItem = Dr["PersonelGrubu"].ToString();
                        }
                    }
                    else if (kriter.Equals("Özel Müşteri"))
                    {
                        ComboBoxKriter.SelectedItem = Localization.OzelMusteri;
                        cmbMusteriAdi.SelectedItem = Dr["MusteriAdi"].ToString();
                    }
                }
                connection.Close();
                txtBaslik.Text = duyuruBaslik;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void MusteriListesiGetir()
        {
            try
            {
                List<Musteri> musteriListesi = new List<Musteri>();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select musteriAdi,musteriSoyadi,musteriMail from Musteriler ";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    musteriListesi.Add(new Musteri(Dr["musteriAdi"].ToString(), Dr["musteriSoyadi"].ToString(), Dr["musteriMail"].ToString(), "ege"));
                }
                connection.Close();

                cmd.CommandText = "select * from DenemeMusteriler ";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    musteriListesi.Add(new Musteri(Dr["MusteriAdi"].ToString(), Dr["MusteriSoyadi"].ToString(), Dr["MusteriMail"].ToString(), "riza"));
                }
                connection.Close();

                foreach (Musteri item in musteriListesi)
                {
                    cmbMusteriAdi.Items.Add(item.Isim + " " + item.soyIsim);
                }
                ortakFormIslemleri.cmbIlkDegerGetir(cmbMusteriAdi);
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
                lblBaslik.Text = Localization.lblBaslik;
                lblDuyuruGrubu.Text = Localization.lblDuyuruGrubu;
                lblIcerik.Text = Localization.lbliCerik;
                KriterLabel.Text = Localization.KriterLabel;
                LabelPersonelGrup.Text = Localization.lblPersonelGrubu;
                MusteriAdLabel.Text = Localization.MusteriAdLabel;
                CheckBoxTumPersoneller.Text = Localization.chechBoxTümPersoneller;
                btnGonder.Text = Localization.btnGonder;
                btnKapat.Text = Localization.btnKapat;
                btnKlavye.Text = Localization.btnKlavyeAc;
                btnTemizle.Text = Localization.btnTemizle;
                CheckBoxOzelGonderim.Text = Localization.CheckBoxOzelGonderim;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void DuyuruEkle_Load(object sender, EventArgs e)
        {
            try
            {
                FiilComboboxDuyuruKategori();
                MusteriListesiGetir();
                FiilComboboxOdaGrubu();
                CheckBoxOzelGonderim.Checked = true;
                ComboBoxKriter.Items.Add(Localization.OdaGrubu);
                ComboBoxKriter.Items.Add(Localization.OzelMusteri);
                ComboBoxKriter.Items.Add(Localization.Personel);
                ComboBoxKriter.SelectedIndex = 0;
                MultiLanguage();
                this.Text = Localization.duyuruEkle;

                FiilComboboxPersonelGrubu();
                ComboBoxPersonelGrubu.SelectedIndex = 0;

                CheckBoxTumPersoneller.Checked = true;

                //Duyuru duzenleme için 2 ise duyuru detay göster için 
                if (mod == 1)
                {
                    BilgiDoldur();
                }
                else if (mod == 2)
                {
                    BilgiDoldur();
                    //Editlemeyi engelle
                    ortakFormIslemleri.textBoxEnableFalse(txtIcerik, txtBaslik);
                    ortakFormIslemleri.comboBoxEnableFalse(cmbMusteriAdi, cmbDuyuruGrubu, ComboBoxKriter, ComboBoxOdaGrubu, ComboBoxPersonelGrubu);
                    ortakFormIslemleri.checkboxEnableFalse(CheckBoxOzelGonderim, CheckBoxTumPersoneller);
                }

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

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBoxOzelGonderim_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CheckBoxOzelGonderim.Checked)
                {
                    ComboBoxKriter.Visible = true;
                    KriterLabel.Visible = true;
                    OdaGrupLabel.Visible = true;
                    ComboBoxOdaGrubu.Visible = true;
                }
                else
                {
                    ComboBoxKriter.Visible = false;
                    KriterLabel.Visible = false;
                    OdaGrupLabel.Visible = false;
                    ComboBoxOdaGrubu.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                    CheckBoxTumPersoneller.Enabled = false;
                    LabelPersonelGrup.Enabled = false;
                    LabelPersonelGrup.Visible = false;
                    ComboBoxPersonelGrubu.Visible = false;
                    ComboBoxPersonelGrubu.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ComboBoxKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxKriter.SelectedIndex == 0)
                {
                    OdaGrupLabel.Visible = true;
                    ComboBoxOdaGrubu.Visible = true;
                    MusteriAdLabel.Visible = false;
                    cmbMusteriAdi.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                }
                else if (ComboBoxKriter.SelectedIndex == 1)
                {
                    OdaGrupLabel.Visible = false;
                    ComboBoxOdaGrubu.Visible = false;
                    MusteriAdLabel.Visible = true;
                    cmbMusteriAdi.Visible = true;
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                }
                else if (ComboBoxKriter.SelectedIndex == 2)
                {
                    OdaGrupLabel.Visible = false;
                    ComboBoxOdaGrubu.Visible = false;
                    MusteriAdLabel.Visible = false;
                    cmbMusteriAdi.Visible = false;
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                    CheckBoxTumPersoneller.Visible = true;
                    CheckBoxTumPersoneller.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void CheckBoxTumPersoneller_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CheckBoxTumPersoneller.Checked)
                {
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                }
                else
                {
                    ComboBoxPersonelGrubu.Visible = true;
                    LabelPersonelGrup.Visible = true;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
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

        private void btnDuyuruGrubuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriTanimlamalari DuyuruGrup = new KategoriTanimlamalari(3);
                DuyuruGrup.Show();
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
                //mod int değer 0 değilse bu sorgu çalışacak eğer bu değer 1 ve 2 ise update sorgusu çalışacak
                if (mod == 1)
                {
                    SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = connection2;
                    connection2.Open();
                    cmd2.CommandText = "delete from Duyuru where Baslik='" + duyuruBaslik + "' and DuyuruTarihi='" + duyuruTarihi + "'";
                    cmd2.ExecuteNonQuery();
                    connection2.Close();
                }
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                string tempdatetime = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss");

                cmd.Connection = connection;
                connection.Open();

                if (CheckBoxOzelGonderim.Checked == false)
                {
                    cmd.CommandText = "Insert into Duyuru (Baslik,DuyuruGrubu,Icerik,DuyuruTarihi,Gorunur) values ('" + txtBaslik.Text + "','" + cmbDuyuruGrubu.SelectedItem.ToString() + "','" + txtIcerik.Text + "','" + tempdatetime + "',1)";
                }
                else if (CheckBoxOzelGonderim.Checked == true && ComboBoxKriter.SelectedIndex == 0)
                {
                    cmd.CommandText = "Insert into Duyuru (Baslik,DuyuruGrubu,Icerik,Kriter,OdaGrubu,DuyuruTarihi,Gorunur) values ('" + txtBaslik.Text + "','" + cmbDuyuruGrubu.SelectedItem.ToString() + "','" + txtIcerik.Text + "','" + "Oda Grubu"+ "','" + ComboBoxOdaGrubu.SelectedItem.ToString() + "','" + tempdatetime + "',1)";
                }
                else if (CheckBoxOzelGonderim.Checked == true && ComboBoxKriter.SelectedIndex == 1)
                {
                    cmd.CommandText = "Insert into Duyuru (Baslik,DuyuruGrubu,Icerik,Kriter,MusteriAdi,DuyuruTarihi,Gorunur) values ('" + txtBaslik.Text + "','" + cmbDuyuruGrubu.SelectedItem.ToString() + "','" + txtIcerik.Text + "','" + "Musteri" + "','" + cmbMusteriAdi.SelectedItem.ToString() + "','" + tempdatetime + "',1)";
                }
                else if (CheckBoxOzelGonderim.Checked == true && ComboBoxKriter.SelectedIndex == 2 && CheckBoxTumPersoneller.Checked == true)
                {
                    cmd.CommandText = "Insert into Duyuru (Baslik,DuyuruGrubu,Icerik,Kriter,PersonelGrubu,DuyuruTarihi,Gorunur) values ('" + txtBaslik.Text + "','" + cmbDuyuruGrubu.SelectedItem.ToString() + "','" + txtIcerik.Text + "','" + "Personel" + "','Tüm Personel','" + tempdatetime + "',1)";
                }
                else if (CheckBoxOzelGonderim.Checked == true && ComboBoxKriter.SelectedIndex == 2 && CheckBoxTumPersoneller.Checked == false)
                {
                    cmd.CommandText = "Insert into Duyuru (Baslik,DuyuruGrubu,Icerik,Kriter,PersonelGrubu,DuyuruTarihi,Gorunur) values ('" + txtBaslik.Text + "','" + cmbDuyuruGrubu.SelectedItem.ToString() + "','" + txtIcerik.Text + "','" + "Personel" + "','" + ComboBoxPersonelGrubu.SelectedItem.ToString() + "','" + tempdatetime + "',1)";
                }
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    if (mod == 0)
                    {
                        HotelWarningForm.Show(Localization.DuyuruEklemeBasarili, Localization.Tamam, 0);
                    }
                    else
                    {
                        HotelWarningForm.Show(Localization.DuyuruGuncellemeBasarili, Localization.Tamam, 0);
                    }
                }
                btnTemizle.PerformClick();
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
                ortakFormIslemleri.textBoxTemizle(txtBaslik, txtIcerik);
                ortakFormIslemleri.comboBoxTemizle(ComboBoxKriter, ComboBoxOdaGrubu, ComboBoxPersonelGrubu, cmbDuyuruGrubu, cmbMusteriAdi);
                ortakFormIslemleri.checkboxTemizle(CheckBoxTumPersoneller, CheckBoxOzelGonderim);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbDuyuruGrubu_Click(object sender, EventArgs e)
        {
            FiilComboboxDuyuruKategori();
        }
    }
}
