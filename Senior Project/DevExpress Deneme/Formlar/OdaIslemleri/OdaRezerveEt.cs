using DevExpress.Utils;
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
    public partial class OdaRezerveEt : MetroFramework.Forms.MetroForm
    {
        public List<string> tumOdalar = new List<string>();
        public List<int> rezerveOdalar = new List<int>();
        public List<int> checkinOdalar = new List<int>();
        List<Musteri> musteriListesi = new List<Musteri>();

        public OdaRezerveEt()
        {
            InitializeComponent();
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
            while (Dr.Read())
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

        public void FiilComboboxKat()
        {
            cmbKat.Items.Clear();
            cmbKat.Items.Add("Tümü");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), "Tümü"))
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

        public void FiilComboboxMusteriAdi()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from Musteriler where Aktif = 1";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                musteriListesi.Add(new Musteri(Dr["musteriAdi"].ToString(), Dr["musteriSoyadi"].ToString(), Dr["musteriMail"].ToString(), "Ege"));
            }
            connection.Close();
        }

        private void MusteriListesiGetir()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select musteriAdi,musteriSoyadi,musteriMail from Musteriler ";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                musteriListesi.Add(new Musteri(Dr["musteriAdi"].ToString(), Dr["musteriSoyadi"].ToString(), Dr["musteriMail"].ToString(), "ege"));
            }
            connection.Close();

            cmd.CommandText = "select * from DenemeMusteriler ";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                musteriListesi.Add(new Musteri(Dr["MusteriAdi"].ToString(), Dr["MusteriSoyadi"].ToString(), Dr["MusteriMail"].ToString(), "riza"));
            }
            connection.Close();

            //cmbMusteriAdi.DataSource = musteriListesi;

            foreach(Musteri item in musteriListesi)
            {
                cmbMusteriAdi.Items.Add(item.Isim + " " + item.soyIsim);
            }
        }

        private void MultiLanguage()
        {
            lblBlok.Text = Localization.lblBlokAdi;
            lblBosOdalar.Text = Localization.BosOdalar;
            lblCikisTarihi.Text = Localization.CikisTarihi;
            lblGirisTarihi.Text = Localization.GirisTarihi;
            lblKat.Text = Localization.lblKatAdi;
            lblOdaTipi.Text = Localization.OdaGrubu;
            lblRezerveEdilmisOdalar.Text = Localization.RezerveEdilmisOdalar;
            btnKapat.Text = Localization.btnKapat;
            btnKaydet.Text = Localization.btnKaydet;
            btnKlavye.Text = Localization.btnKlavyeAc;
            btnListeGuncelle.Text = Localization.ListeGuncelle;
            btnRezervasyonIptali.Text = Localization.RezervasyoniptalEt;
            btnTemizle.Text = Localization.btnTemizle;
        }

        private void OdaRezerveEt_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            cmbOdaTipi.Items.Add(Localization.Tümü);
            FiilCombobox();
            cmbOdaBlok.Items.Add(Localization.Tümü);
            FiilComboboxBlok();
            //FiilComboboxMusteriAdi();
            MusteriListesiGetir();
            dtGirisTarihi.EditValue = DateTime.Now;
            dtGirisTarihi.Properties.VistaDisplayMode = DefaultBoolean.True;
            dtGirisTarihi.Properties.VistaEditTime = DefaultBoolean.True;
            dtCikisTarihi.EditValue = DateTime.Now;
            dtCikisTarihi.Properties.VistaDisplayMode = DefaultBoolean.True;
            dtCikisTarihi.Properties.VistaEditTime = DefaultBoolean.True;
            ortakFormIslemleri.cmbIlkDegerGetir(cmbKat, cmbMusteriAdi, cmbOdaBlok, cmbOdaTipi);
            btnRezervasyonIptali.Visible = false;
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblCikisTarihi, lblRezerveEdilmisOdalar, lblBlok,lblBosOdalar,lblKat,lblOdaTipi,lblGirisTarihi,MusteriAdLabel);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbKat, cmbOdaBlok, cmbOdaTipi,cmbMusteriAdi,cmbOdaBlok);
                ortakFormIslemleri.DateEditRenkDegistir(Color.Black, dtCikisTarihi, dtGirisTarihi);
                ortakFormIslemleri.ListViewRenkDegistir(Color.Black, ListeOdalar, ListeRezerveOdalar);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOdaBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiilComboboxKat();
        }

        private bool TarihKontrol()
        {
            if((Convert.ToDateTime(dtCikisTarihi.EditValue) > Convert.ToDateTime(dtGirisTarihi.EditValue)))
            {
                return true;
            }
            MessageBox.Show(Localization.TarihKontrol);
            return false;
        }

        private void OdaListesiGuncelle(string sorgu)
        {
            if (TarihKontrol())
            {
                SqlDataReader Dr;
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                ListeOdalar.Items.Clear();

                cmd.CommandText = sorgu;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    //ListeOdalar.Items.Add(Dr["OdaNo"].ToString());
                    tumOdalar.Add(Dr["OdaNo"].ToString());
                }
                connection.Close();
                // Tepedeki filtrelere göre oda listesini aldık 
                SqlDataReader Dr2;
                SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "select * from OdaHareket where islemTarihi1 <= '" + Convert.ToDateTime(dtCikisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTarihii2 >= '" + Convert.ToDateTime(dtGirisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTipi='Rezervasyon'";
                cmd2.Connection = connection2;
                cmd2.CommandType = CommandType.Text;

                connection2.Open();
                Dr2 = cmd2.ExecuteReader();
                while (Dr2.Read())
                {
                    //Tüm odalar listesinden bu odaları çıkar. Bu odalar müsait değil.
                    tumOdalar.Remove(Dr2["OdaNo"].ToString());
                    rezerveOdalar.Add(Convert.ToInt32(Dr2["OdaHareketID"]));
                }
                connection2.Close();

                foreach (string item in tumOdalar)
                {
                    ListeOdalar.Items.Add(item);
                }
                ListeRezerveOdalar.Items.Clear();

                //Rezerve odaları sildiğimiz gibi checkinli odaları da sileceğiz
                SqlDataReader Dr4;
                SqlConnection connection4 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd4 = new SqlCommand();
                cmd4.CommandText = "select * from OdaHareket where islemTarihi1 <= '" + Convert.ToDateTime(dtCikisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTarihii2 >= '" + Convert.ToDateTime(dtGirisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTipi='Check-in'";
                cmd4.Connection = connection4;
                cmd4.CommandType = CommandType.Text;

                connection4.Open();
                Dr4 = cmd4.ExecuteReader();
                while (Dr4.Read())
                {
                    //Tüm odalar listesinden bu odaları çıkar. Bu odalar müsait değil.
                    tumOdalar.Remove(Dr4["OdaNo"].ToString());
                    checkinOdalar.Add(Convert.ToInt32(Dr4["OdaHareketID"]));
                }
                connection4.Close();

                //Rezerve odaları kırmızı olacak şekilde ekle
                foreach (int item in rezerveOdalar)
                {
                    SqlDataReader Dr3;
                    SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd3 = new SqlCommand();
                    cmd3.CommandText = "select * from OdaHareket where OdaHareketID=" + item;
                    cmd3.Connection = connection3;
                    cmd3.CommandType = CommandType.Text;

                    connection3.Open();
                    Dr3 = cmd3.ExecuteReader();
                    while (Dr3.Read())
                    {
                        ListeRezerveOdalar.Items.Add(Dr3["OdaNo"].ToString() + "    " + Dr3["musteriPersonel"].ToString());
                    }
                    connection3.Close();
                }
                tumOdalar.Clear();
                rezerveOdalar.Clear();
                checkinOdalar.Clear();
            }
        }

        private void ListeOdaGuncelle()
        {

            if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda");
            }
            else if ((!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü)) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'");
            }
            else if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where blok ='" + cmbOdaBlok.SelectedItem.ToString() + "'");
            }
            else if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where odaTip ='" + cmbOdaTipi.SelectedItem.ToString() + "'");
            }
            else if (!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'");
            }
            else if (!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'");
            }
            else if (string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where blok ='" + cmbOdaBlok.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "'");
            }
            else if (!string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbOdaBlok.SelectedItem.ToString(), (Localization.Tümü)) && !string.Equals(cmbOdaTipi.SelectedItem.ToString(), (Localization.Tümü)))
            {
                OdaListesiGuncelle("select * from Oda where katAdi ='" + cmbKat.SelectedItem.ToString() + "'and odaTip='" + cmbOdaTipi.SelectedItem.ToString() + "' and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'");
            }
        }

        private void cmbKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListeOdaGuncelle();
        }

        private void cmbOdaTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListeOdaGuncelle();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ListeOdaGuncelle();
        }

        private void ListeOdalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(ListeOdalar.SelectedItems[0].Text);
        }

        private bool RezerveKontrol()
        {
            if (Convert.ToDateTime(dtGirisTarihi.EditValue) >Convert.ToDateTime(dtCikisTarihi.EditValue) || ListeOdalar.SelectedItems.Count!=1)
            {
                MetroMessageBox.Show(this, "", Localization.EksikRezervasyonBilgisi, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (RezerveKontrol() && TarihKontrol())
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                string tempdatetime = DateTime.Now.ToString();

                cmd.Connection = connection;
                connection.Open();
                // müşteri mail adresini ekle
                cmd.CommandText = "insert into OdaHareket values('" + ListeOdalar.SelectedItems[0].Text + "','" + Convert.ToDateTime(dtGirisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "','" + Convert.ToDateTime(dtCikisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbMusteriAdi.SelectedItem.ToString() + "','Rezervasyon',0,'" + musteriListesi[cmbMusteriAdi.SelectedIndex].email + "')";

                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    MetroMessageBox.Show(this, "", Localization.RezervasyonBasarili, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ListeOdaGuncelle();
            }
        }

        private void ListeRezerveOdalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ListeRezerveOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListeRezerveOdalar.Items.Count > 0)
            {
                btnRezervasyonIptali.Visible = true;
            }
            else
            {
                btnRezervasyonIptali.Visible = false;
            }
        }

        private void btnRezervasyonIptali_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            string tempdatetime = DateTime.Now.ToString();

            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "delete from OdaHareket where islemTarihi1 <= '"+ Convert.ToDateTime(dtGirisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTipi = 'Rezervasyon' and musteriPersonel = '"+cmbMusteriAdi.SelectedItem.ToString()+"'";

            cmd.ExecuteNonQuery();
            connection.Close();
            if (Kullanici.BilgilendirmeFormlari.Equals("True"))
            {
                MetroMessageBox.Show(this, "", Localization.RezervasyonIptal, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ListeOdaGuncelle();
        }
    }
}
