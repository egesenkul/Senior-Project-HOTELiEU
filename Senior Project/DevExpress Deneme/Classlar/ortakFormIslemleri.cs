using DevExpress.XtraEditors;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Classlar
{
    public class ortakFormIslemleri
    {
        public static void tileRenkDegistir(params TileItem[] item) //tileların rengini değiştirmek için
    {
            foreach (TileItem i in item)  
            {
                i.AppearanceItem.Normal.BackColor = System.Drawing.ColorTranslator.FromHtml(Kullanici.tileItemRenk);
            }
        }

        public static void LabelRenkDegistir(Color renk, params MetroLabel[] item)
        {
            foreach (MetroLabel i in item)  //labelların rengini istenilen renge çevirmek için
            {
                i.ForeColor = renk;
            }
        }

        public static void GridRenkDegistir(Color renk, params MetroGrid[] item)
        {
            foreach (MetroGrid i in item)  //labelların rengini istenilen renge çevirmek için
            {
                i.ForeColor = renk;
            }
        }

        public static void CheckBoxRenkDegistir(Color renk, params MetroCheckBox[] item)
        {
            foreach (MetroCheckBox i in item)  //checkbox rengini istenilen renge çevirmek için
            {
                i.ForeColor = renk;
            }
        }

        public static void DateEditRenkDegistir(Color renk, params DateEdit[] item)
        {
            foreach (DateEdit i in item)  //labelların rengini istenilen renge çevirmek için
            {
                i.BackColor = renk;
            }
        }

        public static void TextBoxRenkDegistir(Color renk, params MetroTextBox[] item)
        {
            foreach (MetroTextBox i in item)  //textboxların rengini istenilen renge çevirmek için
            {
                i.ForeColor = renk;
            }
        }

        public static void ListViewRenkDegistir(Color renk, params MetroListView[] item)
        {
            foreach (MetroListView i in item)  //listviewlerin rengini istenilen renge çevirmek için
            {
                i.BackColor = renk;
            }
        }

        public static void ComboBoxRenkDegistir(Color renk, params MetroComboBox[] item)
        {
            foreach (MetroComboBox i in item)  //comboboxların rengini istenilen renge çevirmek için
            {
                i.BackColor = renk;
            }
        }

        public static void textBoxTemizle(params MetroTextBox[] item) //textboxları temizlemek için
        {
            foreach (MetroTextBox i in item)  
            {
                i.Text = "";
            }
        }

        public static void metroGridTemizle(params MetroGrid[] item) //textboxları temizlemek için
        {
            foreach (MetroGrid i in item)
            {
                i.DataSource = null;
            }
        }

        public static void comboBoxTemizle(params MetroComboBox[] item)  //comboboxları temizlemek için
        {
            foreach (MetroComboBox i in item)  
            {
                cmbIlkDegerGetir(i);
            }
        }

        public static void checkboxTemizle(params MetroCheckBox[] item)  //checkboxları temizlemek için
        {
            foreach (MetroCheckBox i in item)   
            {
                i.Checked = false;
            }
        }

        public static void textBoxEnableFalse(params MetroTextBox[] item)  //textboxı enable false yapar
        {
            foreach (MetroTextBox i in item)  
            {
                i.Enabled = false;
            }
        }

        public static void comboBoxEnableFalse(params MetroComboBox[] item)  //int tipinde dizi bekleyen fonksiyonumuz
        {
            foreach (MetroComboBox i in item)  //diziyi okuyoruz
            {
                i.Enabled = false;
            }
        }

        public static void checkboxEnableFalse(params MetroCheckBox[] item)  //int tipinde dizi bekleyen fonksiyonumuz
        {
            foreach (MetroCheckBox i in item)  //diziyi okuyoruz
            {
                i.Enabled = false;
            }
        }

        public static void checkboxEnableFalse(params TextBox[] item)  //int tipinde dizi bekleyen fonksiyonumuz
        {
            foreach (TextBox i in item)  //diziyi okuyoruz
            {
                i.Enabled = false;
            }
        }

        public static void cmbIlkDegerGetir(params MetroComboBox[] item)
        {
            foreach (MetroComboBox i in item)  //diziyi okuyoruz
            {
                if (i.Items.Count > 0)
                {
                    i.SelectedIndex = 0;
                }
            }
        } //comboboxın ilk değerinin eğer varsa gelmesi 

        public static void txtNumaraArttir(MetroTextBox item)
        {
            if (string.IsNullOrWhiteSpace(item.Text))
            {
                item.Text = "1";
            }
            else
            {
                item.Text = (Convert.ToInt32(item.Text) + 1).ToString();
            }
        }

        public static void txtNumaraAzalt(MetroTextBox item)
        {
            if (!string.IsNullOrWhiteSpace(item.Text) && Convert.ToInt32(item.Text) != 0)
            {
               item.Text = (Convert.ToInt32(item.Text) - 1).ToString();
            }
        }

        public static void KlavyeAc()
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        public static void dateTimeTemizle(params MetroDateTime[] item)
        {
            foreach (MetroDateTime i in item)  
            {
                i.Value = DateTime.Now;
            }
        }

        public static void LogoGetir(PictureBox pictureBox1)
        {
            if (File.Exists((Application.StartupPath + "\\logo.jpg")))
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\logo.jpg");
            }
            else
            {
                pictureBox1.Image = Properties.Resources.HoteliEU;
            }
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        public static string PersonelMailGetir(string PersonelAdi,string PersonelSoyadi,string Personeldepartman)
        {
            //Seçili personelin mail adresini döndürür
            string mail = "";
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select personelMail from Personel where personelAdi='"+PersonelAdi+"' and personelSoyadi='"+PersonelSoyadi+"' and personelDepartman='"+Personeldepartman+"'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                mail=(Dr["personelMail"].ToString());
            }
            connection.Close();
            return mail;
        }

        public static string odaTipGetir(string odaAdi)
        {
            string odaTip = "";
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select odaTip from Oda where OdaNo='" + odaAdi+"'"; 
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                odaTip = (Dr["odaTip"].ToString());
            }
            connection.Close();
            return odaTip;
        }

        public static string odaKatGetir(string odaAdi)
        {
            string kat = "";
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select katAdi from Oda where OdaNo='" + odaAdi + "'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                kat = (Dr["katAdi"].ToString());
            }
            connection.Close();
            return kat;
        }

        public static string odaBlokGetir(string odaAdi)
        {
            string blok = "";
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select blok from Oda where OdaNo='" + odaAdi + "'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                blok = (Dr["blok"].ToString());
            }
            connection.Close();
            return blok;
        }
    }
}