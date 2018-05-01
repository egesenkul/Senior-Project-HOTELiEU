using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Otel_Uygulamasi.Formlar.Ayarlar;
using DevExpress.Utils;
using System.Data.SqlClient;
using Otel_Uygulamasi.Classlar;
using MetroFramework;
using Otel_Uygulamasi.Formlar.Genel;

namespace Otel_Uygulamasi.Formlar.YemekIslemleri
{
    public partial class OgunTanimlama : MetroFramework.Forms.MetroForm
    {
        public OgunTanimlama()
        {
            InitializeComponent();
        }

        public void FiilComboboxPersonelKategori()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxYemekTuru()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void MultiLanguage()
        {
            try
            {
                lblAciklama.Text = Localization.lblAciklama;
                lblBitisZamani.Text = Localization.lblBitisZamani;
                lblGorevliPersoneller.Text = Localization.lblGorevliPersoneller;
                lblOgunAdi.Text = Localization.yemekAdi;
                lblOgunSonGunu.Text = Localization.sonGun;
                lblPersonelGorevlendir.Text = Localization.personelGorevlendir;
                lblPersonelKategorisi.Text = Localization.lblPersonelGrubu;
                lblPersonelSecimi.Text = Localization.personelSecimi;
                lblYemekSalonu.Text = Localization.yemekSalonu;
                lblYemekTuru.Text = Localization.yemekTuru;
                lbBaslangicZamani.Text = Localization.baslangicZamani;
                btnGorevlendir.Text = Localization.btnGorevlendir;
                btnGorevlendirme.Text = Localization.btnGorevlendirme;
                btnTemizle.Text = Localization.btnTemizle;
                btnKlavyeAc.Text = Localization.btnKlavyeAc;
                btnKaydet.Text = Localization.btnKaydet;
                btnKapat.Text = Localization.btnKapat;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void OgunTanimlama_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                btnGorevlendirme.Visible = false;
                dtOgunBas.EditValue = DateTime.Now;
                dtOgunBas.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtOgunBas.Properties.VistaEditTime = DefaultBoolean.True;
                dtSonGun.EditValue = DateTime.Now;
                dtSonGun.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtSonGun.Properties.VistaEditTime = DefaultBoolean.True;
                dtOgunBit.EditValue = DateTime.Now;
                dtOgunBit.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtOgunBit.Properties.VistaEditTime = DefaultBoolean.True;
                FiilYemekSalonu();
                FiilComboboxPersonelKategori();
                FiilComboboxYemekTuru();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblOgunAdi, lblOgunSonGunu, lblYemekSalonu, lblBitisZamani, lbBaslangicZamani, lblPersonelGorevlendir, lblYemekTuru, lblPersonelKategorisi, lblPersonelSecimi, lblGorevliPersoneller);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtAciklama, txtOgunAdi);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbPersonelKategorisi, cmbYemekSalonu, cmbYemekTürü);
                    ortakFormIslemleri.DateEditRenkDegistir(Color.Gray, dtOgunBas, dtOgunBit, dtSonGun);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, listeGorevliler, listePersonel);
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

        private void listeGorevliler_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void listePersonel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                listeGorevliler.Items.Add(listePersonel.SelectedItems[0].Text);
                listePersonel.Items.Remove(listePersonel.SelectedItems[0]);
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
                listeGorevliler.Items.Remove(listeGorevliler.SelectedItems[0]);
                PersonelListesiGuncelleme();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void listeGorevliler_ItemsRemoved(MetroFramework.Controls.MetroListView obj)
        {
            try
            {
                if (listeGorevliler.Items.Count - 1 == 0)
                {
                    btnGorevlendirme.Visible = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void listeGorevliler_ItemAdded(MetroFramework.Controls.MetroListView obj)
        {
            try
            {
                if (listeGorevliler.Items.Count != 0)
                {
                    btnGorevlendirme.Visible = true;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool OgunKontrol()
        {
            try
            {
                if (string.IsNullOrEmpty(txtOgunAdi.Text))
                {
                    HotelWarningForm.Show(Localization.yemekAdiBosGecilemez, Localization.Tamam, 1);
                    txtOgunAdi.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtAciklama.Text))
                {
                    HotelWarningForm.Show(Localization.aciklamaBosGecilemez, Localization.Tamam, 1);
                    txtAciklama.Focus();
                    return false;
                }
                if (dtOgunBas.EditValue.ToString() == dtOgunBit.EditValue.ToString())
                {
                    HotelWarningForm.Show(Localization.TarihKontrol, Localization.Tamam, 1);
                    dtOgunBit.Focus();
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

                if (OgunKontrol())
                {
                    //PersonelYemekGorevli ve Yemek tablosune veri eklenecek

                    DateTime GeciciTarihBaslangic = (DateTime)dtOgunBas.EditValue;
                    DateTime GeciciTarihBitis = (DateTime)dtOgunBit.EditValue;
                    while (GeciciTarihBaslangic < (DateTime)dtSonGun.EditValue)
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "Insert into Yemek values ('" + txtOgunAdi.Text + "','" + txtAciklama.Text + "' , '" + Convert.ToDateTime(GeciciTarihBaslangic) + "' , '" + Convert.ToDateTime(GeciciTarihBitis) + "' , '" + 0 + "' , '" + cmbYemekSalonu.SelectedItem.ToString() + "' , '" + cmbYemekTürü.SelectedItem.ToString() + "' , '" + "YOK" + "' , '" + "Herkes" + "','" + 1 + ") ";
                        cmd.ExecuteNonQuery();
                        //tüm personeller için döngü yap 
                        for (int i = 0; i < listeGorevliler.Items.Count; i++)
                        {
                            cmd.CommandText = "Insert into PersonelYemekGorevli values ('" + txtOgunAdi.Text + "','" + Convert.ToDateTime(GeciciTarihBaslangic) + "' , '" + listeGorevliler.Items[i].Text + "') ";
                            cmd.ExecuteNonQuery();

                        }
                        connection.Close();

                        GeciciTarihBaslangic = GeciciTarihBaslangic.AddDays(1);
                        GeciciTarihBitis = GeciciTarihBitis.AddDays(1);
                    }
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
    }
}
