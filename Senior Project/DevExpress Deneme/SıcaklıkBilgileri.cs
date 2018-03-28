using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Sıcaklık;
using Newtonsoft.Json;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi;

namespace DevExpress_Deneme
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        List<HavuzJSON> urlListesi = new List<HavuzJSON>();
        public Form3()
        {
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            btnKapat.Text = Localization.btnKapat;
        }

        private void urlGetir()
        {
            //bu fonksiyon veritabanından tüm havuz isimlerini ve json urllerini çekecektir
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader Dr;
            cmd.CommandText = "select * from Havuzlar where gorunur=1";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            connection.Open();
            Dr = cmd.ExecuteReader();
            string havuzadi = "";
            string url = "";
            while (Dr.Read())
            {
                havuzadi = Dr["havuzAdi"].ToString();
                url = Dr["url"].ToString();
                urlListesi.Add(new HavuzJSON(havuzadi,url));
                havuzadi = "";
                url = "";
            }
            connection.Close();
            SicaklikBilgisiAl();
        }

        private void SicaklikBilgisiAl()
        {
            foreach (HavuzJSON item in urlListesi)
            {
                string geciciSicaklik="";
                string geciciTarih="";
                if (!string.IsNullOrEmpty(item.url))
                {
                    using (var webClient = new System.Net.WebClient())
                    {
                        var json = webClient.DownloadString(item.url);
                        // Now parse with JSON.Net
                        var welcome = Welcome.FromJson(json);
                        for (int i = 0; i < welcome.Feeds.Count; i++)
                        {
                            try
                            {
                                geciciSicaklik = welcome.Feeds[i].Field1.ToString();
                                geciciTarih = welcome.Feeds[i].CreatedAt.ToString();
                            }
                            catch (Exception)
                            {
                                geciciSicaklik = Localization.Olculemedi;
                                geciciTarih = Localization.Guncellenemedi;
                            }
                        }
                    }
                    if (string.Equals(geciciSicaklik, Localization.Olculemedi))
                    {
                        item.sicaklik = geciciSicaklik;
                        item.GuncellenmeTarihi = DateTime.Now;
                    }
                    else
                    {
                        item.sicaklik = Convert.ToInt32(geciciSicaklik).ToString();
                        item.GuncellenmeTarihi = Convert.ToDateTime(geciciTarih);
                    }
                }
                else
                {
                    geciciSicaklik = Localization.Olculemedi;
                    geciciTarih = Localization.Guncellenemedi;
                }

                if (item.GuncellenmeTarihi == Convert.ToDateTime("01.01.0001 00:00:00"))
                {
                    item.GuncellenmeTarihi = DateTime.Now;
                    item.sicaklik = Localization.Olculemedi;
                }
                
            }
            
        }

        private void GridGuncelleListeden()
        {
            urlGetir();
            metroGrid1.DataSource = null;

            var source = new BindingSource();
            source.DataSource = urlListesi;
            metroGrid1.DataSource = source;

            metroGrid1.Columns[0].HeaderText = Localization.HavuzAdi;
            metroGrid1.Columns[3].HeaderText = Localization.lblGuncellemeTarihi;
            metroGrid1.Columns[2].HeaderText = Localization.Sicaklik;
            metroGrid1.Columns[1].Visible = false;
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            GridGuncelleListeden();
            this.WindowState = FormWindowState.Maximized;
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
         
           
        }

        private void GridGuncelle()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            string sorgu = "select * from Havuzlar";
           
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = sorgu;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            metroGrid1.DataSource = dtRecord;
            
            if (dtRecord.Rows.Count >= 0)
            {
                metroGrid1.Columns[0].HeaderText = "Havuz Adı";
                metroGrid1.Columns[1].HeaderText = "Havuz Sıcaklığı";
                metroGrid1.Columns[2].HeaderText = "Son Güncellenme Tarihi";
                metroGrid1.Columns[3].Visible = false;
            }

            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
