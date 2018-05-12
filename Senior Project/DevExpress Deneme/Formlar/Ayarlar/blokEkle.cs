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
    public partial class blokEkle : MetroFramework.Forms.MetroForm
    {
        int mod = 0;
        public blokEkle()
        {
            InitializeComponent();
        }

        private void BlokListesiGuncelle()
        {
            try
            {
                silinmişKayıtlarıGeriAlToolStripMenuItem.Visible = false;
                metroListView1.Clear();
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroListView1.BackColor = Color.Black;
                }
                else
                {
                    metroListView1.BackColor = Color.White;
                }
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                metroListView1.Items.Clear();

                cmd.CommandText = "select * from Blok where Gorunur=1";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;
                SqlDataReader Dr;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    metroListView1.Items.Add(Dr["blokAdı"].ToString());
                }
                connection.Close();
                silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
                silinmişKayıtlarıGösterToolStripMenuItem.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool blokBosKontrol()
        {
            try
            {
                SqlDataReader Dr3;
                SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select * from Kat where blokAdı = '" + metroListView1.SelectedItems[0].Text + "'";
                cmd3.Connection = connection3;
                cmd3.CommandType = CommandType.Text;

                connection3.Open();
                Dr3 = cmd3.ExecuteReader();
                if (Dr3.HasRows)
                {
                    HotelWarningForm.Show(Localization.bloktaBulunanKatlarıSilin, Localization.Tamam, 1);
                    return false;
                }
                connection3.Close();
                return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private void MultiLanguage()
        {
            try
            {
                lblBlokAdı.Text = Localization.lblBlokAdi;
                lblBlokListesi.Text = Localization.lblBlokListesi;
                btnKlavye.Text = Localization.btnKlavyeAc;
                btnSecenekler.Text = Localization.btnSecenekler;
                btnTemizle.Text = Localization.btnTemizle;
                btnKapat.Text = Localization.btnIptal;
                btnKaydet.Text = Localization.btnKaydet;
                düzenlePersoneliGeriAlToolStripMenuItem.Text = Localization.Duzenle;
                silinmişKayıtlarıGeriAlToolStripMenuItem.Text = Localization.SilinmisKayitlariGeriAl;
                silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
                silToolStripMenuItem.Text = Localization.Sil;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void blokEkle_Load(object sender, EventArgs e)
        {
            try
            {
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblBlokAdı, lblBlokListesi);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, metroListView1);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtBlokAdi);
                }
                BlokListesiGuncelle();
                MultiLanguage();
                this.Text = Localization.blokAyarlari;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnSecenekler_Click(object sender, EventArgs e)
        {
            try
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroListView1.SelectedItems.Count > 0)
                {
                    if (blokBosKontrol())
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "update Blok set Gorunur=0 where blokAdı='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.BlokSilmeBasarili, Localization.Tamam, 0);
                        }
                        BlokListesiGuncelle();
                    }
                }
                else
                {
                    HotelWarningForm.Show(Localization.SilinecekBlokSec, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroListView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void düzenlePersoneliGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mod = 1;
                if (metroListView1.SelectedItems.Count > 0)
                {
                    txtBlokAdi.Text = metroListView1.SelectedItems[0].Text;
                }
                else
                {
                    HotelWarningForm.Show(Localization.DuzenlemekIcınBlokSec, Localization.Tamam, 1);
                    mod = 0;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void silinmişKayıtlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (silinmişKayıtlarıGösterToolStripMenuItem.Text == Localization.SilinmisKayitlariGoster)
                {
                    silinmişKayıtlarıGeriAlToolStripMenuItem.Visible = true;
                    //SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    metroListView1.Items.Clear();

                    cmd.CommandText = "Select * from Blok where gorunur = 0";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader Dr;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        metroListView1.Items.Add(Dr["blokAdı"].ToString());
                    }
                    connection.Close();
                    silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGosterme;
                    silinmişKayıtlarıGösterToolStripMenuItem.BackColor = Color.YellowGreen;
                    metroListView1.BackColor = Color.YellowGreen;
                }
                else
                {
                    BlokListesiGuncelle();
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void silinmişKayıtlarıGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Blok set Gorunur=1 where blokAdı='" + metroListView1.SelectedItems[0].Text + "'";
                //where ekle
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.SilinenHavuzGeriAlindi, Localization.Tamam, 0);
                }
                BlokListesiGuncelle();
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

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.textBoxTemizle(txtBlokAdi);
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
                if (!String.IsNullOrEmpty(txtBlokAdi.Text))
                {
                    if (mod == 0)
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "Insert into Blok values('" + txtBlokAdi.Text + "', 1)";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.Blokeklendi, Localization.Tamam, 0);
                        }
                    }
                    else
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "update Blok set blokAdı = '" + txtBlokAdi.Text + "' where blokAdı ='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        // oda tablosunu güncelle 
                        SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = connection2;
                        connection2.Open();
                        cmd2.CommandText = "update Oda set blok='" + txtBlokAdi.Text+"' where blok='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd2.ExecuteNonQuery();
                        connection2.Close();

                        // odaHareket tablosunu güncelle 
                        SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.Connection = connection3;
                        connection3.Open();
                        cmd3.CommandText = "update OdaHareket set Blok='" + txtBlokAdi.Text + "' where Blok='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd3.ExecuteNonQuery();
                        connection3.Close();

                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.BlokDuzenlendi, Localization.Tamam, 0);
                        }
                        mod = 0;
                    }
                }
                else
                {
                    HotelWarningForm.Show(Localization.BlokismiBosOlamaz, Localization.Tamam, 1);
                    txtBlokAdi.Focus();
                }
                BlokListesiGuncelle();
                txtBlokAdi.Text = "";
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

    }
}
