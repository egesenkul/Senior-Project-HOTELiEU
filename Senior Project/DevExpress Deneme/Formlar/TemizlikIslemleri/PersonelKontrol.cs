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

namespace Otel_Uygulamasi.Formlar.TemizlikIslemleri
{
    public partial class PersonelKontrol : MetroFramework.Forms.MetroForm
    {
        public bool ListeBos = true;

        public PersonelKontrol()
        {
            InitializeComponent();
        }

        private void TemizlikciListesiDoldur()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select * from Personel where personelDepartman='Temizlikçi'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmbPersonel.Items.Add(Dr["personelAdi"] + " " + Dr["personelSoyadi"]);
            }
            connection.Close();
        }

        private void MultiLanguage()
        {
            btnFiltrele.Text = Localization.btnFiltrele;
            btnKapat.Text = Localization.btnKapat;
            btnTemizle.Text = Localization.btnTemizle;
            lblPersonel.Text = Localization.Personel;
        }

        private void PersonelKontrol_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            //personel kontrol
            TemizlikciListesiDoldur();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbPersonel);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.comboBoxTemizle(cmbPersonel);
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
            if (dtRecord.Rows.Count > 0)
            {
                ListeBos = false;
                if (!ListeBos)
                {
                    metroGrid1.Columns[0].Visible = false;
                    metroGrid1.Columns[1].HeaderText = Localization.OdaNumarasi;
                    metroGrid1.Columns[2].HeaderText = Localization.GirisTarihi;
                    metroGrid1.Columns[3].HeaderText = Localization.CikisTarihi;
                    metroGrid1.Columns[4].HeaderText = Localization.personelAdi;
                    metroGrid1.Columns[5].Visible = false;
                    metroGrid1.Columns[6].Visible = false;
                    metroGrid1.Columns[7].Visible = false;
                    metroGrid1.Columns[8].HeaderText = Localization.OdaGrubu;
                }
            }
            else
            {
                metroGrid1.DataSource = null;
                HotelWarningForm.Show(Localization.IstenilenKriterdeKayitYok, Localization.Tamam,1);
            }
            //GridView yayılsın
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            string[] parcalar;
            string kullaniciadiPersonel = "";
            parcalar = cmbPersonel.SelectedItem.ToString().Split(' ');

            SqlCommand cmd3 = new SqlCommand();
            cmd3.CommandText = "select personelKullaniciAdi from Personel where personelAdi ='" + parcalar[0] + "' and personelSoyadi='" + parcalar[1] + "'";
            cmd3.Connection = connection;
            cmd3.CommandType = CommandType.Text;
            //kullanıcı adı boş geliyor
            SqlDataReader Dr;
            connection.Open();
            Dr = cmd3.ExecuteReader();
            while (Dr.Read())
            {
                kullaniciadiPersonel = (Dr["personelKullaniciAdi"]).ToString();
            }
            connection.Close();
            FillDataGridView("SELECT * FROM OdaHareket  WHERE musteriPersonel ='" + cmbPersonel.SelectedItem.ToString() + "'and islemTarihi1>='" + Convert.ToDateTime(metroDateTime1.Value).ToString("yyyy-MM-dd HH:mm:ss") + "'and islemTarihii2<='" + Convert.ToDateTime(metroDateTime2.Value).ToString("yyyy-MM-dd HH:mm:ss") + "'");


        }
    }
}
