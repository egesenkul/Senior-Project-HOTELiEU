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
    public partial class KategoriTanimlamalari : MetroFramework.Forms.MetroForm
    {
        private SqlDataReader Dr;

        int KategoriMod = 0;
        public KategoriTanimlamalari()
        {
            InitializeComponent();
        }
        public KategoriTanimlamalari(int mod)
        {
            InitializeComponent();
            KategoriMod = mod;
        }

        private void MultiLanguage()
        {
            try
            {
                lblBolumeAitKategori.Text = Localization.lblKatAdi;
                lblKategoriAdi.Text = Localization.lblKategoriAdi;
                btnKlavye.Text = Localization.btnKlavyeAc;
                lblKategoriAitBolum.Text = Localization.lblKategoriAitBolum;
                btnTemizle.Text = Localization.btnTemizle;
                btnIptal.Text = Localization.btnIptal;
                btnKaydet.Text = Localization.btnKaydet;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void KategoriTanimlamalari_Load(object sender, EventArgs e)
        {
            try
            {
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKategoriAdi, lblKategoriAitBolum, lblBolumeAitKategori);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtisim);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKategoriBolum);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, metroListView1);
                }

                cmbKategoriBolum.Items.Add(Localization.Personel);
                cmbKategoriBolum.Items.Add(Localization.yemekTuru);
                cmbKategoriBolum.Items.Add(Localization.OdaGrubu);
                cmbKategoriBolum.Items.Add(Localization.lblDuyuruGrubu.Substring(0,Localization.lblDuyuruGrubu.Length-1));
                if (KategoriMod == 0)
                {
                    cmbKategoriBolum.SelectedIndex = 0;
                }
                else if (KategoriMod == 1) { cmbKategoriBolum.SelectedIndex = 1; }
                else if (KategoriMod == 2) { cmbKategoriBolum.SelectedIndex = 2; }
                else if (KategoriMod == 3) { cmbKategoriBolum.SelectedIndex = 3; }
                ListViewGuncelleme();
                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
                MultiLanguage();
                this.Text = Localization.tileKategoriTanimlamalari;
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
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();

                if (txtisim.Text == "")
                {
                    HotelWarningForm.Show(Localization.KategoriIsmiBosGecilemez, Localization.Tamam, 1);
                    txtisim.Focus();
                    connection.Close();
                }
                else
                {
                    if (cmbKategoriBolum.SelectedIndex == 0)
                    {
                        cmd.CommandText = "Insert into PeronelKategori values('" + txtisim.Text + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        txtisim.Clear();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KategoriEklemeBasarili, Localization.Tamam, 0);
                        }
                        ListViewGuncelleme();
                    }
                    else if (cmbKategoriBolum.SelectedIndex == 1)
                    {
                        cmd.CommandText = "Insert into YemekTuru values('" + txtisim.Text + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        txtisim.Clear();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KategoriEklemeBasarili, Localization.Tamam, 0);
                        }
                        ListViewGuncelleme();
                    }
                    else if (cmbKategoriBolum.SelectedIndex == 2)
                    {
                        cmd.CommandText = "Insert into OdaKategori values('" + txtisim.Text + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        txtisim.Clear();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KategoriEklemeBasarili, Localization.Tamam, 0);
                        }
                        ListViewGuncelleme();
                    }
                    else if (cmbKategoriBolum.SelectedIndex == 3)
                    {
                        cmd.CommandText = "Insert into DuyuruKategori values('" + txtisim.Text + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        txtisim.Clear();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KategoriEklemeBasarili, Localization.Tamam, 0);
                        }
                        ListViewGuncelleme();
                    }
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ListViewGuncelleme()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();

                string tablename = "";
                string tablecolumnname = "";

                metroListView1.Items.Clear();

                if (cmbKategoriBolum.SelectedIndex == 0)
                {
                    metroListView1.Items.Clear();
                    tablename = "PeronelKategori";
                    tablecolumnname = "KategoriAciklama";
                    cmd.CommandText = "Select * from " + tablename + "";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        metroListView1.Items.Add(Dr[tablecolumnname].ToString());
                    }
                    connection.Close();
                }
                else if (cmbKategoriBolum.SelectedIndex == 1)
                {
                    metroListView1.Items.Clear();
                    tablename = "YemekTuru";
                    tablecolumnname = "TurAciklama";
                    cmd.CommandText = "Select * from " + tablename + "";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        metroListView1.Items.Add(Dr[tablecolumnname].ToString());
                    }
                    connection.Close();
                }
                else if (cmbKategoriBolum.SelectedIndex == 2)
                {
                    metroListView1.Items.Clear();
                    tablename = "OdaKategori";
                    tablecolumnname = "OdaKategoriAciklama";
                    cmd.CommandText = "Select * from " + tablename + "";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        metroListView1.Items.Add(Dr[tablecolumnname].ToString());
                    }
                    connection.Close();
                }
                else if (cmbKategoriBolum.SelectedIndex == 3)
                {
                    metroListView1.Items.Clear();
                    tablename = "DuyuruKategori";
                    tablecolumnname = "DuyuruKategoriAciklama";
                    cmd.CommandText = "Select * from " + tablename + "";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        metroListView1.Items.Add(Dr[tablecolumnname].ToString());
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbKategoriBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewGuncelleme();
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
                ortakFormIslemleri.textBoxTemizle(txtisim);
                ortakFormIslemleri.comboBoxTemizle(cmbKategoriBolum);
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
    }
}
