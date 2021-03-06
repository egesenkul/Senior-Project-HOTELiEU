﻿using MetroFramework;
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
    public partial class TemizlikYap : MetroFramework.Forms.MetroForm
    {
        public TemizlikYap()
        {
            InitializeComponent();
        }

        private void TemizlikciListesiDoldur()
        {
            try
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
                    cmbTemizlikci.Items.Add(Dr["personelAdi"] + " " + Dr["personelSoyadi"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxBlok()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void TemizlikYap_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Localization.temizlikYap;
                TemizlikciListesiDoldur();
                cmbKat.Items.Add(Localization.Tümü); ;
                cmbOdaBlok.Items.Add(Localization.Tümü);
                FiilComboboxBlok();
                FiilComboboxKat();
                ortakFormIslemleri.comboBoxTemizle(cmbTemizlikci, cmbOdaBlok, cmbKat);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKlavye_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.KlavyeAc();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.comboBoxTemizle(cmbTemizlikci);
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

        private void cmbOdaBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FiilComboboxKat();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxKat()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                OdaListesiGuncelle();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void OdaListesiGuncelle()
        {
            try
            {
                SqlDataReader Dr;
                ListeOdalar.BackColor = Color.White;
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                ListeOdalar.Items.Clear();
                if (string.Equals(cmbOdaBlok.SelectedItem.ToString(), Localization.Tümü) && string.Equals(cmbKat.SelectedItem.ToString(), Localization.Tümü))
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
                    cmd.CommandText = "Select * from Oda where gorunur =1 and blok='" + cmbOdaBlok.SelectedItem.ToString() + "'and where katAdi='" + cmbKat.SelectedValue.ToString() + "'";
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                //Oda tablosunda son temizlenmeyi güncelleyecek ve temizlik hareket tablosuna kayıt atacak
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Oda set temizlikTarihi='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where OdaNo='" + ListeOdalar.SelectedItems[0].Text + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                // isim ve soyisime göre kullanıcı adı bulmak
                string[] parcalar;
                string kullaniciadiPersonel = "";
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
                    kullaniciadiPersonel = (Dr["personelKullaniciAdi"]).ToString();
                }
                connection.Close();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = connection;
                connection.Open();
                cmd2.CommandText = "insert into OdaHareket values('" + ListeOdalar.SelectedItems[0].Text + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + cmbTemizlikci.SelectedItem.ToString() + "', 'Temizlik', 0, '" + ortakFormIslemleri.PersonelMailGetir(parcalar[0], parcalar[1], "Temizlikçi") + "','" + ortakFormIslemleri.odaTipGetir(ListeOdalar.SelectedItems[0].Text) + "','" + ortakFormIslemleri.odaBlokGetir(ListeOdalar.SelectedItems[0].Text) + "','" + ortakFormIslemleri.odaKatGetir(ListeOdalar.SelectedItems[0].Text) + "')";
                cmd2.ExecuteNonQuery();
                connection.Close();

                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.temizlikBasarili, Localization.Tamam, 0);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ListeOdalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçili odanın kat ve blok bilgisini al
            //KatSorumluPersoneller tablosunda eğer bu 2 bilgiye ait kişi varsa onu getir
            //yoksa direk 0ı getir
            try
            {
                string kat = ortakFormIslemleri.odaKatGetir(ListeOdalar.SelectedItems[0].Text);
                string blok = ortakFormIslemleri.odaBlokGetir(ListeOdalar.SelectedItems[0].Text);
                string kisi = "";

                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd3 = new SqlCommand();

                cmd3.CommandText = "select PersonelAdi,PersonelSoyadi from KatSorumluPersoneller where Blok ='" + blok + "' and KatNo='" + kat + "'";
                cmd3.Connection = connection;
                cmd3.CommandType = CommandType.Text;
                SqlDataReader Dr;
                connection.Open();
                Dr = cmd3.ExecuteReader();
                while (Dr.Read())
                {
                    kisi = (Dr["PersonelAdi"]).ToString() + " " + (Dr["PersonelSoyadi"]).ToString();
                }
                connection.Close();

                cmbTemizlikci.SelectedItem = kisi;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
