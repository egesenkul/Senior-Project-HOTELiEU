using DevExpress_Deneme;
using MetroFramework;
using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Musteri_Islemleri
{
    public partial class MusteriListesi : MetroFramework.Forms.MetroForm
    {
        List<Musteri> musteriListesi = new List<Musteri>();
        public MusteriListesi()
        {
            InitializeComponent();
        }
        
        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin"))
            {
                düzenleToolStripMenuItem.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            lblAdveSoyad.Text = Localization.lblAdveSoyad;
            btnKapat.Text = Localization.btnKapat;
            btnSecenekler.Text = Localization.btnSecenekler;
            düzenleToolStripMenuItem.Text = Localization.Duzenle;
            tümBilgileriGösterToolStripMenuItem.Text = Localization.tumBilgileriGoster;
        }

        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            //GridGuncelle();
            EgeTablosu("");
            RizaTablosu("");
            GridGuncelleListeden();
            Yetki();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblAdveSoyad);
                ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtAd);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EgeTablosu(string kosul)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select musteriAdi,musteriSoyadi,musteriMail from Musteriler "+kosul;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                musteriListesi.Add(new Musteri(Dr["musteriAdi"].ToString(), Dr["musteriSoyadi"].ToString(), Dr["musteriMail"].ToString(),"ege"));
            }
            connection.Close();
        }

        private void RizaTablosu(string kosul)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from DenemeMusteriler "+kosul;
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                musteriListesi.Add(new Musteri(Dr["MusteriAdi"].ToString(),Dr["MusteriSoyadi"].ToString(), Dr["MusteriMail"].ToString(),"riza"));
            }
            connection.Close();
        }

        private void GridGuncelle()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select musteriAdi,musteriSoyadi,musteriTelefon,Aktif,musteriKullaniciAdi from Musteriler";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            metroGrid1.DataSource = dtRecord;

            //GridView Column isimlerini değiştirmek için
            //datatable boş değilse bunları yapsın 
            if (dtRecord.Rows.Count >= 0)
            {
                metroGrid1.Columns[0].HeaderText = Localization.MusteriAdi;
                metroGrid1.Columns[1].HeaderText = Localization.MusteriSoyadi;
                metroGrid1.Columns[2].HeaderText = Localization.MusteriTelefonNumarasi;
                metroGrid1.Columns[4].HeaderText = "Müşteri Kullanıcı Adı";
                metroGrid1.Columns[4].Visible = false;
                metroGrid1.Columns[3].HeaderText = "Müşteri Otelde mi ?";
                metroGrid1.Columns[3].Visible = false;
            }
            //GridView yayılsın
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GridGuncelleListeden()
        {
            metroGrid1.DataSource = null;
            
            var source = new BindingSource();
            source.DataSource = musteriListesi; 
            metroGrid1.DataSource = source;

            metroGrid1.Columns[0].HeaderText = Localization.MusteriAdi;
            metroGrid1.Columns[1].HeaderText = Localization.MusteriSoyadi;
            metroGrid1.Columns[2].HeaderText = Localization.lblMail;
            metroGrid1.Columns[3].Visible = false;
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        private void Filtrele()
        {
            metroGrid1.DataSource = null;
            musteriListesi.Clear();
            EgeTablosu("where musteriAdi LIKE '%" + txtAd.Text + "%'" + "or musteriSoyadi LIKE '%" + txtAd.Text + "%'");
            RizaTablosu("where MusteriAdi LIKE '%" + txtAd.Text + "%'");
            GridGuncelleListeden();
        }
        

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                MusteriTanimlamaForm bilgileriGoster = new MusteriTanimlamaForm(metroGrid1.SelectedCells[2].Value.ToString(), 0,metroGrid1.SelectedCells[3].Value.ToString());
                bilgileriGoster.Show();
            }
        }

        private void tümBilgileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                //mail adresi ve tablo bilgileri ile işle yap
                MusteriTanimlamaForm bilgileriGoster = new MusteriTanimlamaForm(metroGrid1.SelectedCells[2].Value.ToString(), 1, metroGrid1.SelectedCells[3].Value.ToString());
                bilgileriGoster.Show();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
        
    }
}
