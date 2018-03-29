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

namespace Otel_Uygulamasi.Formlar.TemizlikIslemleri
{
    public partial class TemizlikYap : MetroFramework.Forms.MetroForm
    {
        public TemizlikYap()
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
                cmbTemizlikci.Items.Add(Dr["personelAdi"]+" "+Dr["personelSoyadi"]);
            }
            connection.Close();
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

        private void TemizlikYap_Load(object sender, EventArgs e)
        {
            TemizlikciListesiDoldur();
            cmbKat.Items.Add(Localization.Tümü);;
            cmbOdaBlok.Items.Add(Localization.Tümü);
            FiilComboboxBlok();
            FiilComboboxKat();
            ortakFormIslemleri.comboBoxTemizle(cmbTemizlikci,cmbOdaBlok,cmbKat);
        }

        private void btnKlavye_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.KlavyeAc();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.comboBoxTemizle(cmbTemizlikci);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOdaBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void metroButton3_Click(object sender, EventArgs e)
        {
            OdaListesiGuncelle();
        }

        private void OdaListesiGuncelle()
        {
            SqlDataReader Dr;
            ListeOdalar.BackColor = Color.White;
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();
            ListeOdalar.Items.Clear();
            if(string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select * from Oda where gorunur = 1";
            }
            else if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select * from Oda where gorunur =1 and katAdı='" + cmbKat.SelectedItem.ToString() + "'";
            }
            else if (!string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select * from Oda where gorunur =1 and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'";
            }
            else if (!string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && !string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü))
            {
                cmd.CommandText = "Select * from Oda where gorunur =1 and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'and where katAdi='"+cmbKat.SelectedValue.ToString()+"'";
            }


            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                ListeOdalar.Items.Add(Dr["OdaNo"].ToString());
            }
            connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            //Oda tablosunda son temizlenmeyi güncelleyecek ve temizlik hareket tablosuna kayıt atacak
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            // Convert.ToDateTime(dtCikisTarihi.EditValue).ToString("yyyy-MM-dd HH:mm:ss")
            connection.Open();
            cmd.CommandText = "update Oda set temizlikTarihi='"+DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where OdaNo='"+ListeOdalar.SelectedItems[0].Text+"'";
            cmd.ExecuteNonQuery();
            connection.Close();
            // isim ve soyisime göre kullanıcı adı bulmak
            string[] parcalar;
            string kullaniciadiPersonel = "" ;
            parcalar = cmbTemizlikci.SelectedItem.ToString().Split(' ');

            SqlCommand cmd3 = new SqlCommand();

            cmd3.CommandText = "select personelKullaniciAdi from Personel where personelAdi ='" + parcalar[0] + "' and personelSoyadi='" + parcalar[1] + "'";
            cmd3.Connection = connection;
            cmd3.CommandType = CommandType.Text;
            SqlDataReader Dr;
            connection.Open();
            Dr = cmd3.ExecuteReader();
            while (Dr.Read())
            {
                kullaniciadiPersonel=(Dr["personelKullaniciAdi"]).ToString();
            }
            connection.Close();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = connection;
            connection.Open();
            cmd2.CommandText = "insert into OdaHareket values('" + ListeOdalar.SelectedItems[0].Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + cmbTemizlikci.SelectedItem.ToString() + "', 'Temizlik', 0, '" + ortakFormIslemleri.PersonelMailGetir(parcalar[0], parcalar[1], "Temizlikçi") + "')";
            cmd2.ExecuteNonQuery();
            connection.Close();


            if (Kullanici.BilgilendirmeFormlari.Equals("True"))
            {
                MetroMessageBox.Show(this, "", "Başarılı bir şekilde oda temizlenmiştir.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListeOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
