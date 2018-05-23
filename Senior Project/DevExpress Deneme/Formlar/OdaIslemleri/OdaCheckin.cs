using DevExpress.Utils;
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
    public partial class OdaCheckin : MetroFramework.Forms.MetroForm
    {
        public List<string> tumOdalar = new List<string>();
        public List<int> rezerveOdalar = new List<int>();
        public List<int> checkinOdalar = new List<int>();
        List<Musteri> musteriListesi = new List<Musteri>();
        public string mail;


        public OdaCheckin()
        {
            InitializeComponent();
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


            foreach (Musteri item in musteriListesi)
            {
                cmbMusteriAdi.Items.Add(item.Isim + " " + item.soyIsim);
            }
            ortakFormIslemleri.cmbIlkDegerGetir(cmbMusteriAdi);
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

        private void MusteriActiveGuncelle()
        {
            //Rıza'nn mobil programda giriş kontrolü yapabilmesi için müşteri tablolarında bulunan müşteriactive column update et 

            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            string tempdatetime = DateTime.Now.ToString();

            cmd.Connection = connection;
            connection.Open();

            //DenemeMusteriler tablosunda update işlemi yap
            cmd.CommandText = "update DenemeMusteriler set musteriActive='1' where MusteriMail= " + "'" + musteriListesi[cmbMusteriAdi.SelectedIndex].email + "'";

            cmd.ExecuteNonQuery();
            connection.Close();


            SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd2 = new SqlCommand();

            string tempdatetime2 = DateTime.Now.ToString();

            cmd2.Connection = connection2;
            connection2.Open();

            //DenemeMusteriler tablosunda update işlemi yap

            cmd2.CommandText = "update Musteriler set musteriActive='1' where musteriMail='" + musteriListesi[cmbMusteriAdi.SelectedIndex].email + "'";

            cmd2.ExecuteNonQuery();
            connection2.Close();
        }

        private void OdaListesiGuncelle(string sorgu)
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
                tumOdalar.Add(Dr["OdaNo"].ToString());
            }
            connection.Close();
            // Tepedeki filtrelere göre oda listesini aldık 
            SqlDataReader Dr2;
            SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd2 = new SqlCommand();
            string tarih = Convert.ToDateTime(dtCikisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss");
            string tarih2 = Convert.ToDateTime(dtGirisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss");

            cmd2.CommandText = "select * from OdaHareket where islemTarihi1 < '" + tarih + "' and islemTarihii2 > '" + tarih2 + "' and islemTipi='Rezervasyon'";
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




            foreach (string item in tumOdalar)
            {
                ListeOdalar.Items.Add(item);
            }
            ListeRezerveOdalar.Items.Clear();
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
                    ListeRezerveOdalar.Items.Add(Dr3["OdaNo"].ToString() + " " + Dr3["musteriPersonel"].ToString());
                }
                connection3.Close();
            }
            tumOdalar.Clear();
            rezerveOdalar.Clear();
            checkinOdalar.Clear();
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

        private bool HareketKontrol(string musteriAdi, DateTime girisTarihi, DateTime cikisTarihi)
        {
            try
            {
                SqlDataReader Dr3;
                SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select * from OdaHareket where musteriPersonel = '" + musteriAdi + "' and islemTarihi1 > '" + girisTarihi.ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTarihii2 < '" + cikisTarihi.ToString("yyyy-MM-dd HH:mm:ss") + "' and islemTipi = 'Check-in'";
                cmd3.Connection = connection3;
                cmd3.CommandType = CommandType.Text;

                connection3.Open();
                Dr3 = cmd3.ExecuteReader();
                if (Dr3.HasRows)
                {
                    return false;
                }

                connection3.Close();
                return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
                return false;
            }
        }

        private void MultiLanguage()
        {
            lblGirisTarihi.Text = Localization.GirisTarihi + ":";
            lblCikisTarihi.Text = Localization.CikisTarihi + ":";
            lblBlok.Text = Localization.lblBlokAdi + ":";
            lblKat.Text = Localization.lblKatAdi + ":";
            lblOdaTipi.Text = Localization.OdaGrubu + ":";
            btnListeGuncelle.Text = Localization.ListeGuncelle;
            lblBosOdalar.Text = Localization.BosOdalar + ":";
            lblRezerveEdilmisOdalar.Text = Localization.RezerveEdilmisOdalar + ":";
            MusteriAdLabel.Text = Localization.MusteriAdLabel;
            metroButton1.Text = Localization.checkinYap;
            metroButton5.Text = Localization.checkinYap;
            btnTemizle.Text = Localization.btnTemizle;
            btnKlavye.Text = Localization.btnKlavyeAc;
            btnKapat.Text = Localization.btnKapat;
        }


        private void OdaCheckin_Load(object sender, EventArgs e)
        {
            try
            {
                dtGirisTarihi.EditValue = DateTime.Now;
                dtGirisTarihi.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtGirisTarihi.Properties.VistaEditTime = DefaultBoolean.True;
                dtGirisTarihi.Properties.Mask.EditMask = "yyyy-MM-dd hh-mm-ss";
                dtCikisTarihi.EditValue = DateTime.Now.AddDays(1);
                dtCikisTarihi.Properties.VistaDisplayMode = DefaultBoolean.True;
                dtCikisTarihi.Properties.VistaEditTime = DefaultBoolean.True;
                dtCikisTarihi.Properties.Mask.EditMask = "yyyy-MM-dd hh-mm-ss";
                cmbOdaTipi.Items.Add(Localization.Tümü);
                cmbKat.Items.Add(Localization.Tümü);
                cmbOdaBlok.Items.Add(Localization.Tümü);
                FiilCombobox();
                MusteriListesiGetir();
                FiilComboboxBlok();
                FiilComboboxKat();
                this.Text = "Check-in";
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblCikisTarihi, lblRezerveEdilmisOdalar, lblKat, lblOdaTipi, lblGirisTarihi, lblBosOdalar);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbMusteriAdi, cmbKat, cmbOdaBlok, cmbOdaTipi);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, ListeOdalar, ListeRezerveOdalar);
                    ortakFormIslemleri.DateEditRenkDegistir(Color.Black, dtCikisTarihi, dtGirisTarihi);
                }
                if (Kullanici.klavye.Equals("True"))
                {
                    btnKlavye.Visible = true;
                }
                else btnKlavye.Visible = false;
                MultiLanguage();
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

        private bool TarihKontrol()
        {
            try
            {
                if ((Convert.ToDateTime(dtCikisTarihi.EditValue) > Convert.ToDateTime(dtGirisTarihi.EditValue)) && (Convert.ToDateTime(dtCikisTarihi.EditValue) > DateTime.Now))
                {
                    return true;
                }
                HotelWarningForm.Show(Localization.TarihKontrol, Localization.Tamam, 1);
                return false;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TarihKontrol())
                {
                    ListeOdaGuncelle();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool CheckinKontrol()
        {
            try
            {
                if (Convert.ToDateTime(dtGirisTarihi.EditValue) > Convert.ToDateTime(dtCikisTarihi.EditValue) || ListeOdalar.SelectedItems.Count != 1)
                {
                    HotelWarningForm.Show(Localization.EksikCheckinBilgisi, Localization.Tamam, 1);
                    return false;
                }
                else return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckinKontrol() && TarihKontrol())
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd = new SqlCommand();

                    string tempdatetime = DateTime.Now.ToString();

                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "insert into OdaHareket values('" + ListeOdalar.SelectedItems[0].Text + "','" + Convert.ToDateTime(dtGirisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "','" + Convert.ToDateTime(dtCikisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss") + "','" + cmbMusteriAdi.SelectedItem.ToString() + "','Check-in',0,'" + musteriListesi[cmbMusteriAdi.SelectedIndex].email + "','" + ortakFormIslemleri.odaTipGetir(ListeOdalar.SelectedItems[0].Text) + "','" + ortakFormIslemleri.odaBlokGetir(ListeOdalar.SelectedItems[0].Text) + "','" + ortakFormIslemleri.odaKatGetir(ListeOdalar.SelectedItems[0].Text) + "')";

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MusteriActiveGuncelle();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.BasariliCheckin, Localization.Tamam, 0);
                    }
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListeRezerveOdalar.Items.Count > 0 && TarihKontrol() && HareketKontrol(cmbMusteriAdi.SelectedItem.ToString(), Convert.ToDateTime(dtGirisTarihi.EditValue), Convert.ToDateTime(dtCikisTarihi.EditValue)))
                {
                    SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd2 = new SqlCommand();

                    string[] parcalar;
                    parcalar = ListeRezerveOdalar.SelectedItems[0].Text.Split(' ');
                    //parcalar[0]=oda bilgisi
                    //parcalar[1]=müşteri adı
                    //parcalar[2]=müşteri soyadı
                    cmd2.CommandText = "select mail from OdaHareket where musteriPersonel='" + parcalar[1] + " " + parcalar[2] + "'";
                    cmd2.Connection = connection2;
                    cmd2.CommandType = CommandType.Text;

                    //isim isim soyisim oda oda için
                    SqlDataReader Dr;

                    connection2.Open();
                    Dr = cmd2.ExecuteReader();
                    while (Dr.Read())
                    {
                        mail = Dr["mail"].ToString();
                    }

                    connection2.Close();

                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand cmd = new SqlCommand();

                    string tempdatetime = DateTime.Now.ToString();

                    cmd.Connection = connection;
                    connection.Open();
                    //isim soyisim oda oda için
                    cmd.CommandText = "update OdaHareket set islemTipi='Check-in' where OdaNo='" + parcalar[0] + "'and mail='" + mail + "'";


                    cmd.ExecuteNonQuery();
                    connection.Close();

                    //SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    //SqlCommand cmd2 = new SqlCommand();

                    //cmd2.Connection = connection2;
                    //connection2.Open();
                    ////isim isim soyisim oda oda için
                    //cmd2.CommandText = "update OdaHareket set islemTipi='Check-in' where OdaNo='" + parcalar[0]  + "'and musteriPersonel='"  + parcalar[1]+" "+parcalar[2] + " " + parcalar[3] + " " + parcalar[4] + "' ";

                    //cmd2.ExecuteNonQuery();
                    //connection2.Close();

                    //SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    //SqlCommand cmd3 = new SqlCommand();

                    //cmd3.Connection = connection3;
                    //connection3.Open();
                    ////isim soyisim oda için
                    //cmd3.CommandText = "update OdaHareket set islemTipi='Check-in' where OdaNo='" + parcalar[0] + "'and musteriPersonel='" + parcalar[2] + " " + parcalar[3] + " " + parcalar[4] + "' ";

                    //cmd3.ExecuteNonQuery();
                    //connection3.Close();

                    //SqlConnection connection4 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    //SqlCommand cmd4 = new SqlCommand();

                    //cmd4.Connection = connection4;
                    //connection4.Open();
                    ////isim isim soyisim oda için
                    //cmd4.CommandText = "update OdaHareket set islemTipi='Check-in' where OdaNo='" + parcalar[0] + " " + parcalar[1] + "'and musteriPersonel='" + parcalar[2] + " " + parcalar[3] + " " + parcalar[4] + "' ";

                    //cmd4.ExecuteNonQuery();
                    //connection4.Close();
                    MusteriActiveGuncelle();

                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.BasariliCheckin, Localization.Tamam, 0);
                    }
                    ListeOdaGuncelle();
                }
                else
                {
                    HotelWarningForm.Show(Localization.rezerveOdalarBos, Localization.Tamam, 2);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKlavye_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.KlavyeAc();
        }
    }
}
