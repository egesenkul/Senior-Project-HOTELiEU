﻿using MetroFramework;
using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    public partial class OtelTanımlamaları : MetroFramework.Forms.MetroForm
    {
        string imgLoc = "";
        bool resimDegisti = false;
        public OtelTanımlamaları()
        {
            InitializeComponent();
        }

        private void BilgiDoldur()
        { //Kontrol yaz 
          //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from otelBilgileri";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    txtOtelAdi.Text = Dr["OtelAdı"].ToString();
                    txttelefon.Text = Dr["otelTelefonu"].ToString();
                    txtmail.Text = Dr["otelMail"].ToString();
                txtadres.Text = Dr["otelAdres"].ToString();
                    }
                connection.Close();
            ortakFormIslemleri.LogoGetir(pictureBox1);
        }

        private void MultiLanguage()
        {
            lblAdres.Text = Localization.lblAdres;
            lblMail.Text = Localization.lblMail;
            lblTelefon.Text = Localization.lblTelefon;
            lblOtelAdı.Text = Localization.lblOtelAdi;
            btnKlavye.Text = Localization.btnKlavyeAc;
            btnTemizle.Text = Localization.btnTemizle;
            btnGozat.Text = Localization.btnGozat;
            btnKapat.Text = Localization.btnKapat;
            btnKaydet.Text = Localization.btnKaydet;
            lblYetkiliKisiDegistirebilir.Text = Localization.lblYetkiliKisiDegistirebilir;
            lblAciklama.Text = Localization.lblAciklama;
        }

        private void OtelTanımlamaları_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            if (Kullanici.klavye.Equals("True"))
            {
                btnKlavye.Visible = true;
            }
            else btnKlavye.Visible = false;

            if (!string.Equals(Kullanici.yetki, "admin"))
            {
                txtmail.BackColor = Color.Orange;
                txtadres.BackColor = Color.Orange;
                txtOtelAdi.BackColor = Color.Orange;
                txttelefon.BackColor = Color.Orange;
                btnTemizle.Visible = false;
            }
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblAciklama, lblAdres,lblImageSize,lblMail,lblOtelAdı,lblTelefon,lblYetkiliKisiDegistirebilir);
                ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtAciklama,txtadres,txtmail,txtOtelAdi,txttelefon);
            }
            BilgiDoldur();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelect = new OpenFileDialog();
            imageSelect.Title = "Otel Logosu Seçiniz";
            imageSelect.Filter = "Image Files (*.png *.jpg *.bmp) |*.png; *.jpg; *.bmp|All Files(*.*) |*.*";
            if(imageSelect.ShowDialog() == DialogResult.OK)
            {
                imgLoc = imageSelect.FileName.ToString();
            }

            pictureBox1.Image = Image.FromFile(imgLoc);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            pictureBox1.Image.Save(Application.StartupPath + "\\logo.jpg");
            resimDegisti = true;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool eMailKontrol(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                MetroMessageBox.Show(this, "", Localization.eMailHata, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        } // Girilen email adresinin geçerliliğini kontrol ediyor


        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (eMailKontrol(txtmail.Text)){
                if (resimDegisti) {
                    byte[] img = null;
                    FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    img = br.ReadBytes((int)fs.Length);
                    resimDegisti = false;
                }
                string sql = "insert into otelBilgileri values ('" + txtOtelAdi.Text +"','" + txttelefon.Text + "','" + txtmail.Text + "','" + txtadres.Text + "','"+txtAciklama.Text+"')";
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    MetroMessageBox.Show(this, "", Localization.otelBilgileriEklemeBasarili, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void btnKlavye_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }


        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.textBoxTemizle(txtAciklama, txtadres, txtmail, txtOtelAdi, txttelefon);
            pictureBox1.Image = null;
        }
    }
}
