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
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void KatEkle_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.katAyarlari;
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblBlok, lblKatAdi, lblBloktakiKatlar);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbBlok);
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
                    cmbBlok.Items.Add(Dr["blokAdı"]);
                }
                cmbBlok.SelectedIndex = 0;
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
                if (mod == 0)
                {
                    if (!String.IsNullOrEmpty(txtKatAdi.Text))
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "Insert into Kat values('" + cmbBlok.SelectedItem.ToString() + "','" + txtKatAdi.Text + "',1)";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KatEklemeBasarili, Localization.Tamam, 0);
                        }
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(txtKatAdi.Text))
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "update Kat set KatNo = '" + txtKatAdi.Text + "', blokAdı = '" + cmbBlok.SelectedItem.ToString() + "' where KatNo ='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        // oda tablosunu güncelle 
                        SqlConnection connection2 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = connection2;
                        connection2.Open();
                        cmd2.CommandText = "update Oda set katAdi='" + txtKatAdi.Text + "' where katAdi='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd2.ExecuteNonQuery();
                        connection2.Close();

                        // odaHareket tablosunu güncelle 
                        SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd3 = new SqlCommand();
                        cmd3.Connection = connection3;
                        connection3.Open();
                        cmd3.CommandText = "update OdaHareket set Katno='" + txtKatAdi.Text + "' where Katno='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd3.ExecuteNonQuery();
                        connection3.Close();

                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KatDuzenlemeBasarili, Localization.Tamam, 0);
                        }

                    }
                }
                btnTemizle.PerformClick();
                ListeGuncelle();
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
                ortakFormIslemleri.textBoxTemizle(txtKatAdi);
                ortakFormIslemleri.comboBoxTemizle(cmbBlok);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ListeGuncelle()
        {
            try
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
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbBlok_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListeGuncelle();
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

        private void silinmişPersoneliGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroListView1.SelectedItems.Count > 0)
                {
                    txtKatAdi.Text = (metroListView1.SelectedItems[0]).Text;
                    mod = 1;
                }
                else
                {
                    HotelWarningForm.Show(Localization.DuzenlenecekKatSec, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool katBosKontrolOda()
        {
            try
            {
                SqlDataReader Dr3;
                SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select * from Oda where katAdi = '" + metroListView1.SelectedItems[0].Text + "'";
                cmd3.Connection = connection3;
                cmd3.CommandType = CommandType.Text;

                connection3.Open();
                Dr3 = cmd3.ExecuteReader();
                if (Dr3.HasRows)
                {
                    HotelWarningForm.Show(Localization.kattaBulunanOdalariSilin, Localization.Tamam, 1);
                    return false;
                }
                connection3.Close();
                return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
                return true;
            }
        }

        private bool katBosKontrolSalon()
        {
            try
            {
                SqlDataReader Dr3;
                SqlConnection connection3 = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd3 = new SqlCommand();
                cmd3.CommandText = "select * from Salon where katAdi = '" + metroListView1.SelectedItems[0].Text + "'";
                cmd3.Connection = connection3;
                cmd3.CommandType = CommandType.Text;

                connection3.Open();
                Dr3 = cmd3.ExecuteReader();
                if (Dr3.HasRows)
                {
                    HotelWarningForm.Show(Localization.kattaBulunanSalonlariSilin, Localization.Tamam, 1);
                    return false;
                }
                connection3.Close();
                return true;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
                return true;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroListView1.SelectedItems.Count > 0)
                {
                    if (katBosKontrolOda() && katBosKontrolSalon())
                    {
                        SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection;
                        connection.Open();
                        cmd.CommandText = "update Kat set Gorunur=0 where KatNo='" + metroListView1.SelectedItems[0].Text + "'";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.KatSilmeBasarili, Localization.Tamam, 0);
                        }
                        ListeGuncelle();
                    }
                }
                else
                {
                    HotelWarningForm.Show(Localization.SilinecekKatSec, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnSecenekler_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void silinmişKayıtlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (silinmişKayıtlarıGösterToolStripMenuItem.Text.Equals(Localization.SilinmisKayitlariGoster))
                {
                    metroListView1.Clear();
                    metroListView1.BackColor = Color.YellowGreen;
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
                    silinmişKaydıGeriAlToolStripMenuItem.Visible = true;
                }
                else
                {
                    ListeGuncelle();
                }
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

        private void silinmişKaydıGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroListView1.SelectedItems.Count > 0)
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Kat set Gorunur=1 where KatNo='" + metroListView1.SelectedItems[0].Text + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.katGeriAlmaIslemiBasarili, Localization.Tamam, 0);
                    }
                    ListeGuncelle();
                }
                else
                {
                    HotelWarningForm.Show(Localization.geriAlinacakKatiSecin, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
