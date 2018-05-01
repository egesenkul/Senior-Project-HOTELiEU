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
    public partial class HavuzEkle : MetroFramework.Forms.MetroForm
    {
        int mod = 0;
        string havuzEskiAdi = "";
        private SqlDataReader Dr;

        public HavuzEkle()
        {
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            try
            {
                lblHavuzAdı.Text = Localization.lblHavuzAdi;
                lblHavuzlar.Text = Localization.lblHavuzlar;
                btnKlavye.Text = Localization.btnKlavyeAc;
                btnSecenekler.Text = Localization.btnSecenekler;
                btnTemizle.Text = Localization.btnTemizle;
                btnIptal.Text = Localization.btnIptal;
                btnKaydet.Text = Localization.btnKaydet;
                düzenlePersoneliGeriAlToolStripMenuItem.Text = Localization.Duzenle;
                silinmişKaydıGeriAlToolStripMenuItem.Text = Localization.SilinmisKayitlariGeriAl;
                silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
                silToolStripMenuItem.Text = Localization.Sil;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void HavuzEkle_Load(object sender, EventArgs e)
        {
            try
            {
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblHavuzAdı, lblHavuzlar);
                    ortakFormIslemleri.TextBoxRenkDegistir(Color.White, txtisim);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, ListeHavuzlar);
                }
                HavuzListesiGuncelleme();
                MultiLanguage();
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

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.textBoxTemizle(txtisim);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void jsonBilgisiniAl()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                ListeHavuzlar.Items.Clear();

                cmd.CommandText = "select url from Havuzlar where havuzAdi ='" + txtisim.Text + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    jsonUrl.Text = (Dr["url"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void HavuzListesiGuncelleme()
        {
            try
            {
                silinmişKayıtlarıGösterToolStripMenuItem.Text = Localization.SilinmisKayitlariGoster;
                silinmişKayıtlarıGösterToolStripMenuItem.BackColor = Color.White;
                silinmişKaydıGeriAlToolStripMenuItem.Visible = false;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    ListeHavuzlar.BackColor = Color.Black;
                }
                else
                {
                    ListeHavuzlar.BackColor = Color.White;
                }
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                ListeHavuzlar.Items.Clear();

                cmd.CommandText = "Select * from Havuzlar where gorunur = 1";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    ListeHavuzlar.Items.Add(Dr["havuzAdi"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                if (mod == 0)
                {
                    if (txtisim.Text == "")
                    {
                        HotelWarningForm.Show(Localization.HavuzAdiBosOlamaz, Localization.Tamam, 1);
                        txtisim.Focus();
                        connection.Close();
                    }
                    else
                    {
                        cmd.CommandText = "Insert into Havuzlar values('" + txtisim.Text + "''" + DateTime.Now + "',1,'" + jsonUrl.Text + "')";
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        txtisim.Clear();
                        if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                        {
                            HotelWarningForm.Show(Localization.HavuzEklendi, Localization.Tamam, 0);
                        }
                        HavuzListesiGuncelleme();
                    }
                }
                else
                {
                    cmd.CommandText = "update Havuzlar set havuzAdi ='" + txtisim.Text + "',url='" + jsonUrl.Text + "' where havuzAdi='" + havuzEskiAdi + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    txtisim.Clear();
                    jsonUrl.Clear();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.HavuzDuzenlendi, Localization.Tamam, 0);
                    }
                    HavuzListesiGuncelleme();
                    mod = 0;
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
                if (ListeHavuzlar.SelectedItems.Count > 0)
                {
                    mod = 1;
                    txtisim.Text = ListeHavuzlar.SelectedItems[0].Text;
                    havuzEskiAdi = txtisim.Text;
                    jsonBilgisiniAl();
                }
                else
                {
                    HotelWarningForm.Show(Localization.DuzenlenecekHavuzSec, Localization.Tamam, 1);
                }
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

        private void ListeHavuzlar_MouseClick(object sender, MouseEventArgs e)
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

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListeHavuzlar.SelectedItems.Count > 0)
                {
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Havuzlar set gorunur=0 where havuzAdi='" + ListeHavuzlar.SelectedItems[0].Text + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.HavuzSilmeBasarili, Localization.Tamam, 0);
                    }
                    HavuzListesiGuncelleme();
                }
                else
                {
                    HotelWarningForm.Show(Localization.SilinecekHavuzSeciniz, Localization.Tamam, 1);
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
                if (silinmişKayıtlarıGösterToolStripMenuItem.Text == "Silinmiş Kayıtları Göster")
                {
                    silinmişKaydıGeriAlToolStripMenuItem.Visible = true;
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                    SqlCommand cmd = new SqlCommand();
                    ListeHavuzlar.Items.Clear();

                    cmd.CommandText = "Select * from Havuzlar where gorunur = 0";
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    Dr = cmd.ExecuteReader();
                    while (Dr.Read())
                    {
                        ListeHavuzlar.Items.Add(Dr["havuzAdi"].ToString());
                    }
                    connection.Close();
                    silinmişKayıtlarıGösterToolStripMenuItem.Text = "Silinmiş Kayıtları Gösterme";
                    silinmişKayıtlarıGösterToolStripMenuItem.BackColor = Color.YellowGreen;
                    ListeHavuzlar.BackColor = Color.YellowGreen;
                }
                else
                {
                    HavuzListesiGuncelleme();
                }
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
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Havuzlar set gorunur=1 where havuzAdi='" + ListeHavuzlar.SelectedItems[0].Text + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.HavuzGeriAlmaBasarili, Localization.Tamam, 0);
                }
                HavuzListesiGuncelleme();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

    }
}
