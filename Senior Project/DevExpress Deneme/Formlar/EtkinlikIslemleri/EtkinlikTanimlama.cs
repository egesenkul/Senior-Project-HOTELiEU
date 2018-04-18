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

namespace Otel_Uygulamasi.Formlar.EtkinlikIslemleri
{ // Etkinlik tarihine saat seçimini eklemeyi unutma 
    public partial class EtkinlikTanimlama : MetroFramework.Forms.MetroForm
    {
        string EtkinlikID = "";
        public EtkinlikTanimlama()
        {
            InitializeComponent();
        }

        public EtkinlikTanimlama(string id)
        {
            EtkinlikID = id;
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            btnIptal.Text = Localization.btnIptal;
            btnKaydet.Text = Localization.btnKaydet;
            btnKlavye.Text = Localization.btnKlavyeAc;
            btnTemizle.Text = Localization.btnTemizle;
            lblAciklama.Text = Localization.lblAciklama;
            lblEtkinlikismi.Text = Localization.lblEtkinlikismi;
            lblKisiLimit.Text = Localization.lblKisiLimiti;
            lblTarih.Text = Localization.lblTarih;
            CheckBoxKisiLimiti.Text = Localization.KisiLimitiVar;
        }

        private void EtkinlikTanimlama_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            if (Kullanici.klavye.Equals("True"))
            {
                btnKlavye.Visible = true;
            }
            else btnKlavye.Visible = false;
            dtEtkinlik.EditValue = DateTime.Now;
            dtEtkinlik.Properties.VistaDisplayMode = DefaultBoolean.True;
            dtEtkinlik.Properties.VistaEditTime = DefaultBoolean.True;
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblEtkinlikismi, lblAciklama, lblKisiLimit,lblTarih);
                ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtEtkinlikAciklama, txtEtkinlikAdı,txtKisiLimiti);
                ortakFormIslemleri.CheckBoxRenkDegistir(Color.White, CheckBoxKisiLimiti);
                ortakFormIslemleri.DateEditRenkDegistir(Color.Gray, dtEtkinlik);
            }
            if (!string.IsNullOrEmpty(EtkinlikID))
            {
                BilgiDoldur();
            }
        }

        private void BilgiDoldur()
        { // Form mevcut kullanıcı ile ilgili açıldı ise bu kullanıcıya ait bilgileri ilgili yerlere yazar
            if (!String.IsNullOrEmpty(EtkinlikID))
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select * from Etkinlik where Etkinlikno ='" + EtkinlikID + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    txtEtkinlikAdı.Text = Dr["EtkinlikAdi"].ToString();
                    txtEtkinlikAciklama.Text = Dr["EtkinlikAciklama"].ToString();
                    dtEtkinlik.EditValue = Convert.ToDateTime(Dr["EtkinlikTarihi"]);
                    int limit = Convert.ToInt32(Dr["EtkinlikLimit"]);
                    if (limit != 0)
                    {
                        CheckBoxKisiLimiti.Checked = true;
                        txtKisiLimiti.Text = limit.ToString();
                    }
                    else
                    {
                        CheckBoxKisiLimiti.Checked = false;
                    }
                }
                connection.Close();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.checkboxTemizle(CheckBoxKisiLimiti);
            ortakFormIslemleri.textBoxTemizle(txtEtkinlikAciklama, txtEtkinlikAdı, txtKisiLimiti);
        }

        private bool EtkinlikEkleKontrol()
        {
            if(!String.IsNullOrEmpty(txtEtkinlikAdı.Text)&& !String.IsNullOrEmpty(txtEtkinlikAciklama.Text) && Convert.ToDateTime(dtEtkinlik.EditValue)>DateTime.Now.AddMilliseconds(-1))
            {
                return true;
            }
            HotelWarningForm.Show(Localization.EksikEtkinlikBilgileri,Localization.Tamam,2);
            return false;
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (EtkinlikEkleKontrol())
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                int limit = 0;
                if (CheckBoxKisiLimiti.Checked==true) {
                    limit = Convert.ToInt32(txtKisiLimiti.Text);
                }
                else
                {
                    txtKisiLimiti.Text = "-1";
                }
                if (string.IsNullOrEmpty(EtkinlikID))
                {
                    cmd.CommandText = "Insert into Etkinlik values ('" + txtEtkinlikAdı.Text + "','" + txtEtkinlikAciklama.Text + "' , '" + Convert.ToDateTime(dtEtkinlik.EditValue).ToString("yyyy-MM-dd") + "'," + Convert.ToInt32(txtKisiLimiti.Text) + ",1) ";
                }
                else {
                    cmd.CommandText = "update Etkinlik set EtkinlikAdi='" + txtEtkinlikAdı.Text + "' ,EtkinlikAciklama='" + txtEtkinlikAciklama.Text + "',EtkinlikTarihi='" + Convert.ToDateTime(dtEtkinlik.EditValue).ToString("yyyy-MM-dd") + "' ,EtkinlikLimit=" + Convert.ToInt32(txtKisiLimiti.Text) + " where Etkinlikno="+EtkinlikID;
                        }
                cmd.ExecuteNonQuery();
                connection.Close();
                if (string.IsNullOrEmpty(EtkinlikID) && Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.EtkinlikEklemeBasarili, Localization.Tamam,0);
                }
                else if (!string.IsNullOrEmpty(EtkinlikID) && Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.EtkinlikGuncellemeBasarili, Localization.Tamam,0);
                }
                    dtEtkinlik.EditValue = DateTime.Now;
                ortakFormIslemleri.textBoxTemizle(txtEtkinlikAciklama, txtEtkinlikAdı, txtKisiLimiti);
                ortakFormIslemleri.checkboxTemizle(CheckBoxKisiLimiti);
            }
        }

        private void CheckBoxOzelGonderim_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxKisiLimiti.Checked == true)
            {
                lblKisiLimit.Enabled = true;
                lblKisiLimit.Visible = true;
                txtKisiLimiti.Enabled = true;
                txtKisiLimiti.Visible = true;
            }
            else
            {
                lblKisiLimit.Enabled = false;
                lblKisiLimit.Visible = false;
                txtKisiLimiti.Enabled = false;
                txtKisiLimiti.Visible = false;
            }
        }
    }
}
