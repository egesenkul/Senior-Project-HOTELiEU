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

namespace Otel_Uygulamasi.Formlar.OdaIslemleri
{
    public partial class SureUzat : MetroFramework.Forms.MetroForm
    {
        private void MultiLanguage()
        {
            try
            {
                lblAdveSoyad.Text = Localization.lblAdveSoyad;
                btnKapat.Text = Localization.btnKapat;
                lblGunSayisi.Text = Localization.GunSayisi;
                btnSureUzat.Text = Localization.gunEkle;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public SureUzat()
        {
            InitializeComponent();
        }

        private void GridGuncelle(string kosul)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                string tarih = Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                sqlCmd.CommandText = "select * from OdaHareket where islemTipi='Check-in' and islemTarihii2>'" + tarih + "'" + kosul;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                metroGrid1.DataSource = dtRecord;

                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[1].HeaderText = Localization.OdaNumarasi;
                metroGrid1.Columns[2].HeaderText = Localization.GirisTarihi;
                metroGrid1.Columns[3].HeaderText = Localization.GirisTarihi;
                metroGrid1.Columns[4].HeaderText = Localization.MusteriAdi;
                metroGrid1.Columns[5].Visible = false;
                metroGrid1.Columns[6].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                metroGrid1.Columns[8].Visible = false;

                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void SureUzat_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblAdveSoyad);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtAd);
                }
                lblGunSayisi.Visible = false;
                btnSureUzat.Visible = false;
                txtGunSayisi.Visible = false;
                GridGuncelle("");
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroGrid1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    lblGunSayisi.Visible = true;
                    btnSureUzat.Visible = true;
                    txtGunSayisi.Visible = true;
                }
                else
                {
                    lblGunSayisi.Visible = false;
                    btnSureUzat.Visible = false;
                    txtGunSayisi.Visible = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filtrele()
        {
            try
            {
                if (string.IsNullOrEmpty(txtAd.Text))
                {
                    GridGuncelle("");
                }
                else
                {
                    GridGuncelle("and musteriPersonel='" + txtAd.Text + "'");
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }

        private DateTime TarihAl()
        {
            try
            {
                DateTime value = DateTime.Now;

                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select islemTarihii2 from OdaHareket where OdaHareketID='" + metroGrid1.SelectedCells[0].Value.ToString() + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    value = Convert.ToDateTime(Dr["islemTarihii2"].ToString());
                }
                connection.Close();
                return value;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return DateTime.Now;
        }

        private void btnSureUzat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtGunSayisi.Text) > 0)
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    string tarih = Convert.ToDateTime(TarihAl().AddDays(Convert.ToDouble(txtGunSayisi.Text))).ToString("yyyy-MM-dd");
                    cmd.CommandText = "update OdaHareket set islemTarihii2='" + tarih + "'where OdaHareketID=" + metroGrid1.SelectedCells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.cikisTarihiUzatıldı, Localization.Tamam, 0);
                    }
                    Filtrele();
                    txtGunSayisi.Text = "";
                }
                else
                {
                    HotelWarningForm.Show(Localization.eklenecekGunSayisiPozitifHata, Localization.Tamam, 1);
                    txtGunSayisi.Focus();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void txtGunSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    btnSureUzat.PerformClick();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
