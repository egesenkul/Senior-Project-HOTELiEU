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

namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    public partial class KatEkle : MetroFramework.Forms.MetroForm
    {
        int mod = 0;
        public KatEkle()
        {
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            lblBloktakiKatlar.Text = Localization.lblBloktakiKatlar;
            lblKatAdi.Text = Localization.lblKatAdi;
            btnKatEkle.Text = Localization.btnKatEkle;
            btnKlavye.Text = Localization.btnKlavyeAc;
            btnSecenekler.Text = Localization.btnSecenekler;
            btnTemizle.Text = Localization.btnTemizle;
            silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
            silToolStripMenuItem.Text = Localization.Sil;
            düzenlePersoneliGeriAlToolStripMenuItem.Text = Localization.Duzenle;
            silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
        }

        private void KatEkle_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblBlok,lblKatAdi,lblBloktakiKatlar);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray,cmbBlok);
                ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtKatAdi);
                ortakFormIslemleri.ListViewRenkDegistir(Color.Black, metroListView1);

            }
            FiilComboboxBlok();
            if (Kullanici.klavye.Equals("True"))
            {
                btnKlavye.Visible = true;
            }
            else btnKlavye.Visible = false;
        }

        public void FiilComboboxBlok()
        {
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
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
                cmbBlok.Items.Add(Dr["blokAdı"]);
            }
            cmbBlok.SelectedIndex = 0;
            connection.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (mod == 0)
            {
                if (!String.IsNullOrEmpty(txtKatAdi.Text))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "Insert into Kat values('" + cmbBlok.SelectedItem.ToString() + "','" + txtKatAdi.Text + "',1)";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.KatEklemeBasarili, Localization.Tamam,0);
                    }
                }
            }
            else
            {
                //
                if (!String.IsNullOrEmpty(txtKatAdi.Text))
                {
                    //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Kat set KatNo = '" + txtKatAdi.Text + "', blokAdı = '" + cmbBlok.SelectedItem.ToString() + "' where KatNo ='" + metroListView1.SelectedItems[0].Text+"'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.KatDuzenlemeBasarili, Localization.Tamam,0);
                    }
                }
            }
            btnTemizle.PerformClick();
            ListeGuncelle();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ortakFormIslemleri.textBoxTemizle(txtKatAdi);
            ortakFormIslemleri.comboBoxTemizle(cmbBlok);
        }

        private void ListeGuncelle()
        {
            metroListView1.Clear();
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroListView1.BackColor = Color.Black;
            }
            else
            {
                metroListView1.BackColor = Color.White;
            }
            //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand cmd = new SqlCommand();
            metroListView1.Items.Clear();

            cmd.CommandText = "select * from Kat where blokAdı='" + cmbBlok.SelectedItem.ToString() + "'and Gorunur=1";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            SqlDataReader Dr;

            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                metroListView1.Items.Add(Dr["KatNo"].ToString());
            }
            connection.Close();
            silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
            silinmişKayıtlarıGösterToolStripMenuItem.BackColor = Color.White;
        }

        private void cmbBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroListView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void silinmişPersoneliGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroListView1.SelectedItems.Count > 0)
            {
                txtKatAdi.Text = (metroListView1.SelectedItems[0]).Text;
                mod = 1;
            }
            else
            {
                HotelWarningForm.Show(Localization.DuzenlenecekKatSec, Localization.Tamam,1);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroListView1.SelectedItems.Count > 0)
            {
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Kat set Gorunur=0";
                //where ekle
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.KatSilmeBasarili, Localization.Tamam,0);
                }
                ListeGuncelle();
            }
            else
            {
                HotelWarningForm.Show(Localization.SilinecekKatSec,Localization.Tamam,1);
            }
        }

        private void btnSecenekler_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void silinmişKayıtlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(silinmişKayıtlarıGösterToolStripMenuItem.Text.Equals(Localization.SilinmisKayitlariGoster))
            {
                metroListView1.Clear();
                metroListView1.BackColor = Color.YellowGreen;
                //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                metroListView1.Items.Clear();

                cmd.CommandText = "select * from Kat where blokAdı='" + cmbBlok.SelectedItem.ToString() + "'and Gorunur=0";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                SqlDataReader Dr;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    metroListView1.Items.Add(Dr["KatNo"].ToString());
                }
                connection.Close();
                silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGosterme;
                silinmişKayıtlarıGösterToolStripMenuItem.BackColor = Color.YellowGreen;
            }
           else
            {
                ListeGuncelle();
            }
        }
    }
}
