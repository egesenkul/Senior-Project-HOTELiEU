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

namespace Otel_Uygulamasi.Formlar.YemekIslemleri
{
    public partial class OzelYemek : MetroFramework.Forms.MetroForm
    {
        string yemekAdi = "";
        string yemekAciklama = "";
        public OzelYemek()
        {
            InitializeComponent();
        }
        public OzelYemek(string ad, string aciklama)
        {
            yemekAdi = ad;
            yemekAciklama = aciklama;
            InitializeComponent();
        }

        public void FiilComboboxYemekTuru()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from YemekTuru";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmbYemekTürü.Items.Add(Dr["TurAciklama"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbYemekTürü);
        }

        private void BilgiDoldur()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Yemek where YemekAdı='" + yemekAdi + "'and Aciklama='" + yemekAciklama + "'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            string Katilimcilar = "";
            string Gorevlilier = "";
            while (Dr.Read())
            {
                txtYemekIsmi.Text = (Dr["YemekAdı"].ToString());
                txtAciklama.Text = (Dr["Aciklama"].ToString());
                cmbKatilimKriter.SelectedItem = (Dr["KatılımKriter"].ToString());
                cmbYemekSalonu.SelectedItem = Dr["YemekSalonu"].ToString();
                cmbYemekTürü.SelectedItem = Dr["YemekTuru"].ToString();
                Katilimcilar = Dr["KatılımcıGrup"].ToString();
                dtYemekTarihi.EditValue = Convert.ToDateTime(Dr["BaslangicTarihi"]);
                dtYemekBitis.EditValue = Convert.ToDateTime(Dr["BitisTarihi"]);
            }
            string[] parcalar = Katilimcilar.Split('+');
            foreach (string i in parcalar)
            {
                listeKatilacaklar.Items.Add(i);
            }
            connection.Close();

            SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd2 = new SqlCommand();

            cmd2.CommandText = "select * from PersonelYemekGorevli where YemekAdı='" + yemekAdi + "'and YemekTarihi='" + dtYemekTarihi.EditValue + "'";
            cmd2.Connection = connection2;
            cmd2.CommandType = CommandType.Text;

            SqlDataReader Dr2;
            connection2.Open();
            Dr2 = cmd2.ExecuteReader();
            while (Dr2.Read())
            {
                Gorevlilier = (Dr2["personel"].ToString());
            }
            string[] parcalar2 = Gorevlilier.Split('+');
            foreach (string i in parcalar2)
            {
                listeGorevliler.Items.Add(i);
            }
            connection.Close();
        }

        public void FiilComboboxPersonelKategori()
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
                cmbPersonelKategorisi.Items.Add(Dr["KategoriAciklama"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbPersonelKategorisi);
        }

        private void MultiLanguage()
        {
            btnEkle.Text = Localization.btnEkle;
            btnGorevlendir.Text = Localization.btnGorevlendir;
            btnGorevlendirme.Text = Localization.btnGorevlendirme;
            btnKapat.Text = Localization.btnKapat;
            btnKaydet.Text = Localization.btnKaydet;
            btnKlavyeAc.Text = Localization.btnKlavyeAc;
            btnTemizle.Text = Localization.btnTemizle;
            btnVazgec.Text = Localization.btnKapat;
            lblAciklama.Text = Localization.lblAciklama;
            lblGorevliPersoneller.Text = Localization.lblGorevliPersoneller;
            lblGruplar.Text = Localization.lblPersonelGrubu;
            lblKatilacaklar.Text = Localization.lblKatilacaklar;
            lblPersoenlKategori.Text = Localization.lblPersonelGrubu;
            lblPersoenlSecimi.Text = Localization.personelSecimi;
            lblPersonelGorevlendir.Text = Localization.personelGorevlendir;
            lblYemekAdi.Text = Localization.yemekAdi;
            lblYemekSalonu.Text = Localization.yemekSalonu;
            lblYemekTuru.Text = Localization.yemekTuru;
            lblKatilimKriter.Text = Localization.lblKatilimKriter;
            lblYemekTarihi.Text = Localization.lblTarih;
            lblBitisTarihi.Text = Localization.lblBitisZamani;
        }

        private void OzelYemek_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.ozelYemekEkle;
                cmbKatilimKriter.Items.Add(Localization.Personel);
                cmbKatilimKriter.Items.Add(Localization.OdaGrubu);
                cmbKatilimKriter.SelectedIndex = 0;
                dtYemekTarihi.EditValue = DateTime.Now;
                dtYemekTarihi.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtYemekTarihi.Properties.VistaEditTime = DefaultBoolean.True;
                dtYemekBitis.EditValue = DateTime.Now;
                dtYemekBitis.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtYemekBitis.Properties.VistaEditTime = DefaultBoolean.True;
                FiilComboboxYemekTuru();
                FiilYemekSalonu();
                FiilComboboxPersonelKategori();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblYemekAdi, lblGruplar, lblKatilimKriter, lblKatilacaklar, lblYemekTarihi, lblPersonelGorevlendir, lblYemekTuru, lblPersoenlKategori, lblPersoenlSecimi, lblGorevliPersoneller, lblBitisTarihi, lblYemekSalonu);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtAciklama, txtYemekIsmi);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbPersonelKategorisi, cmbYemekSalonu, cmbYemekTürü, cmbKatilimKriter);
                    ortakFormIslemleri.DateEditRenkDegistir(Color.Gray, dtYemekBitis, dtYemekTarihi);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, ListeGrupUyeleri, listeKatilacaklar, listeGorevliler, listePersonel);
                }
                if (!string.IsNullOrEmpty(yemekAdi))
                {
                    BilgiDoldur();
                    for (int i = 0; i < listeKatilacaklar.Items.Count; i++)
                    {
                        //ListeGrupUyeleri.ControlRemoved()
                    }
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

        private void btnYemekTuruEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KategoriTanimlamalari YemekTuruEkle = new KategoriTanimlamalari(1);
                YemekTuruEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void PersonelListesiGuncelleme()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                listePersonel.Items.Clear();
                SqlDataReader Dr;
                cmd.CommandText = "select * from Personel where personelDepartman='" + cmbPersonelKategorisi.SelectedItem.ToString() + "' and Sil=0";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                listePersonel.Items.Clear();
                while (Dr.Read())
                {
                    bool listedevar = false;
                    if (listeGorevliler.Items.Count != 0)
                    {
                        for (int i = 0; i < listeGorevliler.Items.Count; i++)
                        {
                            if (string.Equals(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString(), listeGorevliler.Items[i].Text))
                            {
                                listedevar = true;
                            }
                            if (!listedevar)
                            {
                                listePersonel.Items.Add(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString());
                            }
                        }
                    }
                    else
                    {
                        listePersonel.Items.Add(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString());
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void GruplarıGuncelle(string sorgu, string kriter)
        {
            try
            {
                ListeGrupUyeleri.Clear();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                ListeGrupUyeleri.Items.Clear();
                SqlDataReader Dr;

                cmd.CommandText = sorgu;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                if (string.Equals(kriter, "personel"))
                {
                    while (Dr.Read())
                    {
                        ListeGrupUyeleri.Items.Add(Dr["KategoriAciklama"].ToString());
                    }
                }
                else
                {
                    while (Dr.Read())
                    {
                        ListeGrupUyeleri.Items.Add(Dr["OdaKategoriAciklama"].ToString());
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void Guncelle()
        {
            try
            {
                if (string.Equals(cmbKatilimKriter.SelectedItem.ToString(), "Personel"))
                {
                    //Personel gruplarını ekle
                    GruplarıGuncelle("select * from PeronelKategori", "personel");
                }
                else
                {
                    GruplarıGuncelle("select * from OdaKategori", "oda");
                    //Oda gruplarını ekle
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }


        private void cmbKatilimKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Guncelle();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ListeGrupUyeleri.SelectedItems.Count; i++)
                {
                    listeKatilacaklar.Items.Add(ListeGrupUyeleri.SelectedItems[i].Text);
                    ListeGrupUyeleri.Items.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            try
            {
                listeKatilacaklar.Items.Remove(listeKatilacaklar.SelectedItems[0]);
                Guncelle();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool YemekKontrol()
        {
            try
            {
                //içeriğini doldur
                if (string.IsNullOrEmpty(txtYemekIsmi.Text))
                {
                    HotelWarningForm.Show(Localization.yemekAdiBosGecilemez, Localization.Tamam, 1);
                    txtYemekIsmi.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (YemekKontrol())
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    string KatilimciGrup = "";
                    for (int i = 0; i < listeKatilacaklar.Items.Count; i++)
                    {
                        KatilimciGrup += listeKatilacaklar.Items[i].Text + "+";
                    }
                    string tarih = Convert.ToDateTime(dtYemekTarihi.EditValue).ToString("yyyy-MM-dd");
                    string tarih2 = Convert.ToDateTime(dtYemekBitis.EditValue).ToString("yyyy-MM-dd");
                    cmd.CommandText = "Insert into Yemek (YemekAdi,Aciklama,BaslangicTarihi,BitisTarihi,Sil,YemekSalonu,YemekTurID,KatilimKriter,KatilimciGrup,OgunMu) values ('" + txtYemekIsmi.Text + "','" + txtAciklama.Text + "' , '" + tarih + "' , '" + tarih2 + "' , '" + 0 + "' , '" + cmbYemekSalonu.SelectedItem.ToString() + "' , '" + (cmbYemekTürü.SelectedIndex++).ToString() + "','" + cmbKatilimKriter.SelectedItem.ToString() + "' , '" + KatilimciGrup + "','" + 0 + "') ";
                    cmd.ExecuteNonQuery();
                    //tüm personeller için döngü yap
                    string Gorevliler = "";
                    for (int i = 0; i < listeGorevliler.Items.Count; i++)
                    {
                        Gorevliler += listeGorevliler.Items[i].Text + "+";
                    }
                    cmd.CommandText = "Insert into PersonelYemekGorevli values ('" + txtYemekIsmi.Text + "','" + tarih + "' , '" + Gorevliler + "') ";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.yemekEklemeBasarili, Localization.Tamam, 0);
                    }
                    btnTemizle.PerformClick();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilYemekSalonu()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select* from Salon where kategori='Yemek Salonu'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbYemekSalonu.Items.Add(Dr["salonAdı"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbYemekSalonu);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnYemekSalonuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SalonTanimlamalari YemekSalonuEkle = new SalonTanimlamalari(1);
                YemekSalonuEkle.Show();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbPersonelKategorisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonelListesiGuncelleme();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnGorevlendir_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listePersonel.SelectedItems.Count; i++)
                {
                    listeGorevliler.Items.Add(listePersonel.SelectedItems[i].Text);
                    listePersonel.Items.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnGorevlendirme_Click(object sender, EventArgs e)
        {
            try
            {
                listeGorevliler.Items.Remove(listeGorevliler.SelectedItems[0]);
                PersonelListesiGuncelleme();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
