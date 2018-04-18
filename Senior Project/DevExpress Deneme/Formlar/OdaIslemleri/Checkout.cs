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

namespace Otel_Uygulamasi.Formlar.OdaIslemleri
{
    public partial class Checkout : MetroFramework.Forms.MetroForm
    {
        public Checkout()
        {
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            btnKapat.Text = Localization.btnKapat;
        }

        private void AutoDarkMode()
        {
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblAdveSoyad,lblOdaNumarasi);
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            AutoDarkMode();
            FillDataGridView("select * from OdaHareket where Onay=0 and islemTipi='Check-in'");
        }

        public void FillDataGridView(string sorgu)
        {
            metroGrid1.DataSource = null; // Listeyi boşaltmak için
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = sorgu;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            metroGrid1.DataSource = dtRecord;

            //GridView Column isimlerini değiştirmek için
            //datatable boş değilse bunları yapsın 
            if (dtRecord.Rows.Count > 0)
            {
                metroGrid1.Columns[0].Visible = false; 
                metroGrid1.Columns[1].HeaderText = Localization.OdaNumarasi;
                metroGrid1.Columns[2].HeaderText = Localization.GirisTarihi;
                metroGrid1.Columns[3].HeaderText = Localization.CikisTarihi;
                metroGrid1.Columns[4].HeaderText = Localization.MusteriAdi;
                metroGrid1.Columns[5].Visible = false;
                metroGrid1.Columns[6].Visible = false;
                metroGrid1.Columns[7].Visible = false;
                metroGrid1.Columns[8].Visible = false;
            }
            //GridView yayılsın
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView("select * from OdaHareket where Onay=0 and islemTipi='Check-in' and musteriPersonel LIKE '%" + txtAd.Text + "%' and OdaNo LIKE '%"+txtOdaNumarasi.Text+"%'");
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView("select * from OdaHareket where Onay=0 and islemTipi='Check-in' and musteriPersonel LIKE '%" + txtAd.Text + "%' and OdaNo LIKE '%" + txtOdaNumarasi.Text + "%'");
        }

        private void musteriActiveGuncelle(string musteriMail,string Tablo)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            if (string.Equals(Tablo, "ege"))
            {
                connection.Open(); cmd.CommandText = "update Musteriler set musteriActive=0" + " where musteriMail='" + musteriMail + "'";
            }
            else
            {
                connection.Open(); cmd.CommandText = "update DenemeMusteriler set MusteriActive=0" + "where MusteriMail='" + musteriMail + "'";
            }
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private string TabloKontrol(string mailAdresi)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from Musteriler where musteriMail='"+mailAdresi+"'";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);

            //GridView Column isimlerini değiştirmek için
            //datatable boş değilse bunları yapsın 
            if (dtRecord.Rows.Count > 0)
            {
                connection.Close();
                return "ege";
            }
            else
            {
                connection.Close();
                return "rıza";
            }
            return "";
            }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            connection.Open();
            //            cmd.CommandText = "update OdaHareket set islemTipi='Check-out', Onay=1, islemTarihii2='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'  where OdaNo='" + metroGrid1.SelectedCells[1].Value.ToString()+"' and musteriPersonel='"+metroGrid1.SelectedCells[4].Value.ToString()+"' and islemTipi='Check-in' and islemTarihi1='"+Convert.ToDateTime(metroGrid1.SelectedCells[2].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "'";
            musteriActiveGuncelle(metroGrid1.SelectedCells[7].Value.ToString(), TabloKontrol(metroGrid1.SelectedCells[7].Value.ToString()));
            cmd.CommandText = "update OdaHareket set islemTipi='Check-out', Onay=1, islemTarihii2='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'  where OdaNo='" + metroGrid1.SelectedCells[1].Value.ToString()+"' and musteriPersonel='"+metroGrid1.SelectedCells[4].Value.ToString()+"' and islemTipi='Check-in' and islemTarihi1='"+Convert.ToDateTime(metroGrid1.SelectedCells[2].Value.ToString()).ToString("yyyy-MM-dd HH:mm:ss") + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            if (Kullanici.BilgilendirmeFormlari.Equals("True"))
            {
                HotelWarningForm.Show(Localization.CheckoutBasarili, Localization.Tamam,0);
            }
            ortakFormIslemleri.textBoxTemizle(txtOdaNumarasi, txtAd);
            FillDataGridView("select * from OdaHareket where Onay=0 and islemTipi='Check-in'");
        }
    }
}
