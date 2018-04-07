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

namespace Otel_Uygulamasi.Formlar.OdaIslemleri
{
    public partial class Form34 : MetroFramework.Forms.MetroForm
    {
        public bool ListeBos = false;

        public List<String> odalar = new List<string>();
        public Form34()
        {
            InitializeComponent();
        }

        public void FiilComboboxOdaGrubu()
        {
            cmbOdaTipi.Items.Add(Localization.Tümü);
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
                cmbOdaTipi.Items.Add(Dr["OdaKategoriAciklama"]);
            }
            connection.Close();
            cmbOdaTipi.SelectedIndex = 0;
        }

        public void FiilComboboxBlok()
        {
            cmbOdaBlok.Items.Add(Localization.Tümü);
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

        public void FillDataGridView(string sorgu)
        {
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
            ListeBos = true;
            if (dtRecord.Rows.Count > 0)
            {
                
                    metroGrid1.Columns[0].Visible = false;
                    metroGrid1.Columns[1].HeaderText = Localization.OdaNumarasi;
                    metroGrid1.Columns[2].HeaderText = Localization.GirisTarihi;
                    metroGrid1.Columns[3].HeaderText = Localization.CikisTarihi;
                    metroGrid1.Columns[4].HeaderText = Localization.personelAdi;
                    metroGrid1.Columns[5].Visible = false;
                    metroGrid1.Columns[6].Visible = false;
                    metroGrid1.Columns[7].Visible = false;
                
            }
            
            //GridView yayılsın
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MultiLanguage()
        {
            lblBlok.Text = Localization.lblBlokAdi;
            lblKat.Text = Localization.lblKatAdi;
            lblOdaTipi.Text = Localization.OdaGrupLabel;
            btnFiltrele.Text = Localization.btnFiltrele;
            btnKapat.Text = Localization.btnKapat;
            btnTemizle.Text = Localization.btnTemizle;
        }

        private void OdaKontrol_Load(object sender, EventArgs e)
        {
            //Oda Kontrol
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblKat, lblOdaTipi);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKat, cmbOdaBlok, cmbOdaTipi);
            }
            FiilComboboxOdaGrubu();
            FiilComboboxBlok();
            FiilComboboxKat();

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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.comboBoxTemizle(cmbOdaTipi, cmbKat,cmbOdaBlok);
        }

        private void cmbOdaBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiilComboboxKat();
        }

        private void OdalarıGetir()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaTipi.SelectedItem.ToString(),Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1";
            }
            else if (!string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and blok='" + cmbOdaBlok.SelectedItem.ToString()+"'";
            }
            else if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and katAdi='" + cmbKat.SelectedItem.ToString() + "'";
            }
            else if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'";
            }
            else if (!string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and katAdi='" + cmbKat.SelectedItem.ToString() + "'and blok='"+cmbOdaBlok.SelectedItem.ToString()+"'";
            }
            else if (!string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'";
            }
            else if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and katAdi='" + cmbKat.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'";
            }
            else if (!string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select OdaNo from Oda where gorunur = 1 and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'and katAdi='"+cmbKat.SelectedItem.ToString()+"'";
            }

            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            bool ListeBos = true;
            while (Dr.Read())
            {
                odalar.Add((Dr["OdaNo"].ToString()));
            }
            if (ListeBos)
            {
                //MetroMessageBox.Show(this, "", "İstenilen kriterlerde herhangi bir kayıt bulunamamıştır.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            connection.Close();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            OdalarıGetir();
            foreach (string item in odalar) {
                FillDataGridView("SELECT * FROM OdaHareket  WHERE OdaNo ='" + item + "'and islemTarihi1>='" + Convert.ToDateTime(metroDateTime1.Value).ToString("yyyy-MM-dd HH:mm:ss") + "'and islemTarihii2<='" + Convert.ToDateTime(metroDateTime2.Value).ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTipi='Temizlik'");
            }
            if (metroGrid1.DataSource == null)
            {
                MetroMessageBox.Show(this, "", "İstenilen kriterlerde herhangi bir kayıt bulunamamıştır.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
