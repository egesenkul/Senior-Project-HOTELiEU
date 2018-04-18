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
    public partial class OdaListesi : MetroFramework.Forms.MetroForm
    {
        string mod = "";
        public OdaListesi()
        {
            InitializeComponent();
        }
        public OdaListesi(string rez)
        {
            InitializeComponent();
            mod = rez;
        }

        public void FiilComboboxKat()
        {
            cmbKat.Items.Clear();
            cmbKat.Items.Add(Localization.Tümü);
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select KatNo from Kat";
            }
            else
            {
                cmd.CommandText = "Select KatNo from Kat where blokAdı='" + cmbOdaBlok.SelectedItem.ToString() + "'";
            }
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

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin"))
            {
                düzenleToolStripMenuItem.Visible = false;
                silToolStripMenuItem.Visible = false;
                rezerveEtToolStripMenuItem.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            lblBlok.Text = Localization.lblBlokAdi;
            lblKat.Text = Localization.lblKatAdi;
            lblOdaGrup.Text = Localization.OdaGrupLabel;
            btnFiltrele.Text = Localization.btnFiltrele;
            btnKapat.Text = Localization.btnKapat;
            btnSecenekler.Text = Localization.btnSecenekler;
            btnTemizle.Text = Localization.btnTemizle;
            silinmişOdalarıGösterToolStripMenuItem.Text = Localization.silinmisOdalariGoster;
            silinmişOdayıGeriAlToolStripMenuItem.Text = Localization.silinmisOdalariGoster;
            düzenleToolStripMenuItem.Text = Localization.Duzenle;
        }

        private void OdaListesi_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            cmbOdaTipi.Items.Add(Localization.Tümü);
            FiilCombobox();
            cmbOdaBlok.Items.Add(Localization.Tümü);
            FiilComboboxBlok();
            this.WindowState = FormWindowState.Maximized;
            float x = (Convert.ToInt32(this.Width) - Convert.ToInt32(metroPanel1.Width)) / 2;
            float y = (Convert.ToInt32(this.Height) - Convert.ToInt32(metroPanel1.Height)) / 2;

            metroPanel1.Location = new Point(x: Convert.ToInt32(x), y: Convert.ToInt32(y));
            btnFiltrele.PerformClick();
            silinmişOdayıGeriAlToolStripMenuItem.Visible = false;
            if (string.Equals(mod, "rez"))
            {
                rezerveEtToolStripMenuItem.Enabled = true;
                rezerveEtToolStripMenuItem.Visible = true;
            }
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKat, lblOdaGrup,lblBlok);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKat, cmbOdaBlok, cmbOdaTipi);
            }
            Yetki();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FiilCombobox()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select OdaKategoriAciklama from OdaKategori";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while(Dr.Read())
            {
                cmbOdaTipi.Items.Add(Dr["OdaKategoriAciklama"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbOdaTipi);
        }

        public void FiilComboboxBlok()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select blokAdı from Blok";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmbOdaBlok.Items.Add(Dr["blokAdı"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbOdaBlok);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.comboBoxTemizle(cmbOdaBlok,cmbKat, cmbOdaTipi);
            ortakFormIslemleri.metroGridTemizle(metroGrid1);
        }

        private void cmbOdaBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiilComboboxKat();
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
                metroGrid1.Columns[0].HeaderText = Localization.OdaNumarasi;
                metroGrid1.Columns[1].HeaderText = Localization.ikiKisilikYatakSayisi;
                metroGrid1.Columns[2].HeaderText = Localization.tekKisilikYatakSayisi;
                metroGrid1.Columns[3].HeaderText = Localization.OdaGrupLabel;
                metroGrid1.Columns[4].HeaderText = Localization.temizlenmeTarihi;
                metroGrid1.Columns[4].Visible = false;
                metroGrid1.Columns[5].HeaderText = Localization.lblBlokAdi;
                metroGrid1.Columns[6].HeaderText = Localization.lblKatAdi;
                metroGrid1.Columns[7].HeaderText = "Görünürlük";
                metroGrid1.Columns[7].Visible = false;
                metroGrid1.Columns[7].HeaderText = "Oda Durumu";
                metroGrid1.Columns[7].Visible = false;
                metroGrid1.Columns[8].Visible = false;
            }
            //GridView yayılsın
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaBlok.SelectedItem.ToString(),(Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(),(Localization.Tümü))){
                //normal select procedure çalışacak
                FillDataGridView("select * from Oda");
            }
            else if ((!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü)) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where katAdi ='"+cmbKat.SelectedItem.ToString()+"'");
            }
            else if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where blok ='" + cmbOdaBlok.SelectedItem.ToString() + "'");
            }
            else if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where odaTip ='" + cmbOdaTipi.SelectedItem.ToString() + "'");
            }
            else if (!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'and blok='"+cmbOdaBlok.SelectedItem.ToString()+"'");
            }
            else if (!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'");
            }
            else if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where blok ='" + cmbOdaBlok.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'");
            }
            else if (!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                FillDataGridView("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "' and blok='"+cmbOdaBlok.SelectedItem.ToString()+"'");
            }
        }

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                OdaTanimlama bilgiDuzenle = new OdaTanimlama(metroGrid1.SelectedCells[0].Value.ToString());
                bilgiDuzenle.Show();
            }
            else
            {
                HotelWarningForm.Show(Localization.duzenlemekIcınOdaSec, Localization.Tamam,1);
            }
        }

        private void silinmişOdalarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!string.Equals(silinmişOdalarıGösterToolStripMenuItem.Text,Localization.silinmisOdalariGoster))
            {
                silinmişOdayıGeriAlToolStripMenuItem.Visible = false;
                FillDataGridView("Select * from Oda where Gorunur =1");
                silinmişOdalarıGösterToolStripMenuItem.Text = Localization.silinmisOdalariGoster;
                silinmişOdayıGeriAlToolStripMenuItem.BackColor = Color.YellowGreen;
                metroGrid1.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                silinmişOdalarıGösterToolStripMenuItem.Text = Localization.silinmisOdalariGosterme;
                silinmişOdayıGeriAlToolStripMenuItem.Visible = true;
                FillDataGridView("Select * from Oda where Gorunur =0");
                metroGrid1.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void silinmişOdayıGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Veri tabanına göster bölümü ekle
            SqlCommand cmd = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Oda set Gorunur=1 where OdaNo='" + metroGrid1.SelectedCells[0].Value.ToString() + "'";
            // Personel türünü Rıza'ya sor.
            cmd.ExecuteNonQuery();
            connection.Close();
            HotelWarningForm.Show(Localization.odaGeriAlmaBasarili, Localization.Tamam,0);
            btnFiltrele.PerformClick();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Oda set Gorunur=0 where OdaNo='" + metroGrid1.SelectedCells[0].Value.ToString() + "'";
                // Personel türünü Rıza'ya sor.
                cmd.ExecuteNonQuery();
                connection.Close();
                HotelWarningForm.Show(Localization.odaSilmeBasarili,Localization.Tamam,0);
                btnFiltrele.PerformClick();
            }
            else
            {
                HotelWarningForm.Show(Localization.silmekIcınOdaSec, Localization.Tamam,1);
            }
        }

     
    }
}
