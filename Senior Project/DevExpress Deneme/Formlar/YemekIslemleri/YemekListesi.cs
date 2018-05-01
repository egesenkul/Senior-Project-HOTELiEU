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

namespace Otel_Uygulamasi.Formlar.YemekIslemleri
{
    public partial class YemekListesi : MetroFramework.Forms.MetroForm
    {
        public bool ilkAcilis = true;

        public YemekListesi()
        {
            InitializeComponent();
        }

        public void FiilYemekTuru()
        {
            cmbYemekTur.Items.Clear();
            cmbYemekTur.Items.Add(Localization.Tümü);
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select* from YemekTuru";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmbYemekTur.Items.Add(Dr["TurAciklama"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbYemekTur);
        }

        public void FiilYemekSalonu()
        {
            try
            {
                cmbYemekSalonu.Items.Clear();
                cmbYemekSalonu.Items.Add(Localization.Tümü);
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select* from Salon where kategori='Yemek Salonu'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbYemekSalonu.Items.Add(Dr["salonAdı"]);
                }
                connection.Close();
                ortakFormIslemleri.cmbIlkDegerGetir(cmbYemekSalonu);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void Yetki()
        {
            try
            {
                if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
                {
                    düzenleToolStripMenuItem.Visible = false;
                    silToolStripMenuItem.Visible = false;
                    gorevliEkle.Visible = false;
                    gorevliIptal.Visible = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void MultiLanguage()
        {
            try
            {
                lblGorevliPersoneller.Text = Localization.lblGorevliPersoneller;
                lblPersonelGorevlendir.Text = Localization.personelGorevlendir;
                lblPersonelKategorisi.Text = Localization.lblPersonelGrubu;
                lblPersonelSecimi.Text = Localization.personelSecimi;
                lblYemekSalonu.Text = Localization.yemekSalonu;
                lblYemekTuru.Text = Localization.yemekTuru;
                btnFiltrele.Text = Localization.btnFiltrele;
                btnGorevlendir.Text = Localization.btnGorevlendir;
                btnGorevlendirme.Text = Localization.btnGorevlendirme;
                btnTemizle.Text = Localization.btnTemizle;
                btnKapat.Text = Localization.btnKapat;
                btnSecenekler.Text = Localization.btnSecenekler;
                btnOnayla.Text = Localization.btnOnayla;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void YemekListesi_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                FiilYemekSalonu();
                FiilYemekTuru();
                silinmişPersoneliGeriAlToolStripMenuItem.Visible = false;
                ListeGörevliler.Visible = false;
                lblGorevliPersoneller.Visible = false;
                lblGorevliPersoneller.Enabled = false;
                lblPersonelGorevlendir.Visible = false;
                lblPersonelGorevlendir.Enabled = false;
                lblPersonelKategorisi.Visible = false;
                lblPersonelKategorisi.Enabled = false;
                lblPersonelSecimi.Visible = false;
                lblPersonelSecimi.Enabled = false;
                cmbPersonelKategorisi.Visible = false;
                cmbPersonelKategorisi.Enabled = false;
                btnGorevlendir.Visible = false;
                btnGorevlendir.Enabled = false;
                btnGorevlendirme.Visible = false;
                btnGorevlendirme.Enabled = false;
                listeGorevlenecekler.Visible = false;
                listeGorevlenecekler.Enabled = false;
                listePersonel.Visible = false;
                listePersonel.Enabled = false;
                btnOnayla.Enabled = false;
                btnOnayla.Visible = false;
                Yetki();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblYemekTuru, lblYemekSalonu, lblGorevliPersoneller, lblPersonelGorevlendir, lblPersonelKategorisi, lblPersonelSecimi);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbPersonelKategorisi, cmbYemekSalonu, cmbYemekTur);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black, listeGorevlenecekler, ListeGörevliler, listePersonel);
                }
                btnFiltrele.PerformClick();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void GorevliListeGuncelle()
        {
            try
            {
                string tarih = Convert.ToDateTime(metroGrid1.SelectedCells[2].Value).ToString("yyyy-MM-dd");

                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                ListeGörevliler.Items.Clear();
                SqlDataReader Dr;
                cmd.CommandText = "select * from PersonelYemekGorevli where YemekAdı = '" + metroGrid1.SelectedCells[0].Value.ToString() + "' and YemekTarihi='" + tarih + " '";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    ListeGörevliler.Items.Add(Dr["personel"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.dateTimeTemizle(metroDateTime1, metroDateTime2);
                ortakFormIslemleri.cmbIlkDegerGetir(cmbYemekSalonu);
                ortakFormIslemleri.metroGridTemizle(metroGrid1);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FillDataGridView(string sorgu)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sorgu;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                metroGrid1.DataSource = null;
                metroGrid1.DataSource = dtRecord;

                metroGrid1.Columns[0].HeaderText = "Yemek Adı";
                metroGrid1.Columns[1].HeaderText = "Yemek Açıklaması";
                metroGrid1.Columns[2].HeaderText = "Yemek Tarihi";
                metroGrid1.Columns[3].HeaderText = "Yemek Tarihi2";
                metroGrid1.Columns[3].Visible = false;
                metroGrid1.Columns[4].HeaderText = "Sil";
                metroGrid1.Columns[4].Visible = false;
                metroGrid1.Columns[5].HeaderText = "Yemek Salonu";
                metroGrid1.Columns[6].HeaderText = "Yemek Türü";
                metroGrid1.Columns[7].Visible = false;
                metroGrid1.Columns[8].Visible = false;
                metroGrid1.Columns[9].Visible = false;
                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dtRecord.Rows.Count == 0)
                {
                    if (!ilkAcilis)
                    {
                        HotelWarningForm.Show(Localization.IstenilenKriterdeKayitYok, Localization.Tamam, 1);
                    }
                    ilkAcilis = false;
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
                string tarih = Convert.ToDateTime(metroDateTime1.Value).ToString("yyyy-MM-dd");
                string tarih2 = Convert.ToDateTime(metroDateTime2.Value).ToString("yyyy-MM-dd");

                if (cmbYemekSalonu.SelectedIndex != 0 && cmbYemekTur.SelectedIndex != 0)
                {
                    FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and YemekSalonu='" + cmbYemekSalonu.SelectedItem.ToString() + "' and YemekTuru='" + cmbYemekTur.SelectedItem.ToString() + "'and Sil=0");
                }
                else if (cmbYemekSalonu.SelectedIndex == 0 && cmbYemekTur.SelectedIndex != 0)
                {
                    FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and YemekTuru='" + cmbYemekTur.SelectedItem.ToString() + "'and Sil=0");
                }
                else if (cmbYemekSalonu.SelectedIndex != 0 && cmbYemekTur.SelectedIndex == 0)
                {
                    FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and YemekSalonu='" + cmbYemekSalonu.SelectedItem.ToString() + "'and Sil=0");
                }
                else if (cmbYemekSalonu.SelectedIndex == 0 && cmbYemekTur.SelectedIndex == 0)
                {
                    FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and Sil=0");
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxPersonelKategori()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select KategoriAciklama from PeronelKategori";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbPersonelKategorisi.Items.Add(Dr["KategoriAciklama"]);
                }
                connection.Close();
                cmbPersonelKategorisi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private bool OgunKontrol(string yemekAdı, string yemekAciklama)
        {
            try
            {
                bool ogunMu = false;
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select OgunMu from Yemek where YemekAdi='" + yemekAdı + "' and Aciklama='" + yemekAciklama + "'";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    ogunMu = (Convert.ToBoolean(Dr["OgunMu"]));
                }
                connection.Close();
                if (ogunMu)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
            return false;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Eğer öğün değilse bunu yapacak
                if (!OgunKontrol(metroGrid1.SelectedCells[0].Value.ToString(), metroGrid1.SelectedCells[1].Value.ToString()))
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Yemek set Sil=1 where YemekAdı='" + metroGrid1.SelectedCells[0].Value.ToString() + "' and BaslangicTarihi='" + metroGrid1.SelectedCells[2].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Yemek set Sil=1 where YemekAdı='" + metroGrid1.SelectedCells[0].Value.ToString() + "' and Aciklama='" + metroGrid1.SelectedCells[1].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                //Eğer öğün ise bu yemek adı ve açıklamasına ait tüm yemekleri silecektir 


                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.yemekSilmeBasarili, Localization.Tamam, 0);
                }
                btnFiltrele.PerformClick();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.Visible == true)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
                else
                {
                    contextMenuStrip2.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
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

        private void silinmişPersonelleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Equals(silinmişPersonelleriGösterToolStripMenuItem.Text, "Silinmiş Yemekleri Gösterme"))
                {
                    string tarih = Convert.ToDateTime(metroDateTime1.Value).ToString("yyyy-MM-dd");
                    string tarih2 = Convert.ToDateTime(metroDateTime2.Value).ToString("yyyy-MM-dd");
                    silinmişPersoneliGeriAlToolStripMenuItem.Visible = false;
                    silinmişPersonelleriGösterToolStripMenuItem.Text = "Silinmiş Yemekleri Göster";
                    if (cmbYemekSalonu.SelectedIndex != 0 && cmbYemekTur.SelectedIndex != 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and YemekSalonu='" + cmbYemekSalonu.SelectedItem.ToString() + "' and YemekTuru='" + cmbYemekTur.SelectedItem.ToString() + "'and Sil=0");
                    }
                    else if (cmbYemekSalonu.SelectedIndex == 0 && cmbYemekTur.SelectedIndex != 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and YemekTuru='" + cmbYemekTur.SelectedItem.ToString() + "'and Sil=0");
                    }
                    else if (cmbYemekSalonu.SelectedIndex != 0 && cmbYemekTur.SelectedIndex == 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and YemekSalonu='" + cmbYemekSalonu.SelectedItem.ToString() + "'and Sil=0");
                    }
                    else if (cmbYemekSalonu.SelectedIndex == 0 && cmbYemekTur.SelectedIndex == 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + tarih + "' and BitisTarihi <= '" + tarih2 + "' and Sil=0");
                    }
                }
                else
                {
                    silinmişPersoneliGeriAlToolStripMenuItem.Visible = true;
                    silinmişPersonelleriGösterToolStripMenuItem.Text = "Silinmiş Yemekleri Gösterme";
                    if (cmbYemekSalonu.SelectedIndex != 0 && cmbYemekTur.SelectedIndex != 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + metroDateTime1.Value.ToString() + "' and BitisTarihi <= '" + metroDateTime2.Value.ToString() + "' and YemekSalonu='" + cmbYemekSalonu.SelectedItem.ToString() + "' and YemekTuru='" + cmbYemekTur.SelectedItem.ToString() + "'and Sil=1");
                    }
                    else if (cmbYemekSalonu.SelectedIndex == 0 && cmbYemekTur.SelectedIndex != 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + metroDateTime1.Value.ToString() + "' and BitisTarihi <= '" + metroDateTime2.Value.ToString() + "' and YemekTuru='" + cmbYemekTur.SelectedItem.ToString() + "'and Sil=1");
                    }
                    else if (cmbYemekSalonu.SelectedIndex != 0 && cmbYemekTur.SelectedIndex == 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + metroDateTime1.Value.ToString() + "' and BitisTarihi <= '" + metroDateTime2.Value.ToString() + "' and YemekSalonu='" + cmbYemekSalonu.SelectedItem.ToString() + "'and Sil=1");
                    }
                    else if (cmbYemekSalonu.SelectedIndex == 0 && cmbYemekTur.SelectedIndex == 0)
                    {
                        FillDataGridView("select * from Yemek where BaslangicTarihi >= '" + metroDateTime1.Value.ToString() + "' and BitisTarihi <= '" + metroDateTime2.Value.ToString() + "' and Sil=1");
                    }
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
                SqlCommand cmd = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Yemek set Sil=0 where YemekAdı='" + metroGrid1.SelectedCells[0].Value.ToString() + "' and BaslangicTarihi='" + metroGrid1.SelectedCells[2].Value.ToString() + "'";
                // Personel türünü Rıza'ya sor.
                cmd.ExecuteNonQuery();
                connection.Close();
                if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                {
                    HotelWarningForm.Show(Localization.PersonelGeriAlindi, Localization.Tamam, 0);
                }
                btnFiltrele.PerformClick();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void tümBilgileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.Equals(tümBilgileriGösterToolStripMenuItem.Text, "Görevlileri Gösterme"))
                {
                    tümBilgileriGösterToolStripMenuItem.Text = "Görevlileri Göster";
                    ListeGörevliler.Visible = false;
                    metroGrid1.Visible = true;
                }
                else
                {
                    tümBilgileriGösterToolStripMenuItem.Text = "Görevlileri Gösterme";
                    GorevliListeGuncelle();
                    ListeGörevliler.Visible = true;
                    metroGrid1.Visible = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ListeGörevliler_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    contextMenuStrip2.Show(Cursor.Position);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void gorevliIptal_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "delete from PersonelYemekGorevli where YemekAdı='" + metroGrid1.SelectedCells[0].Value.ToString() + "' and YemekTarihi='" + metroGrid1.SelectedCells[2].Value.ToString() + "' and personel='" + ListeGörevliler.SelectedItems[0].Text + "'";
                cmd.ExecuteNonQuery();
                connection.Close();
                HotelWarningForm.Show(Localization.personelSilmeBasarili, Localization.Tamam, 0);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void gorevliEkle_Click(object sender, EventArgs e)
        {
            try
            {
                lblGorevliPersoneller.Visible = true;
                lblGorevliPersoneller.Enabled = true;
                lblPersonelGorevlendir.Visible = true;
                lblPersonelGorevlendir.Enabled = true;
                lblPersonelKategorisi.Visible = true;
                lblPersonelKategorisi.Enabled = true;
                lblPersonelSecimi.Visible = true;
                lblPersonelSecimi.Enabled = true;
                cmbPersonelKategorisi.Visible = true;
                cmbPersonelKategorisi.Enabled = true;
                btnGorevlendir.Visible = true;
                btnGorevlendir.Enabled = true;
                btnGorevlendirme.Visible = true;
                btnGorevlendirme.Enabled = true;
                listeGorevlenecekler.Visible = true;
                listeGorevlenecekler.Enabled = true;
                listePersonel.Visible = true;
                listePersonel.Enabled = true;
                btnOnayla.Enabled = true;
                btnOnayla.Visible = true;
                FiilComboboxPersonelKategori();
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
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                connection.Open();
                for (int i = 0; i < listeGorevlenecekler.Items.Count; i++)
                {
                    cmd.CommandText = "Insert into PersonelYemekGorevli values ('" + metroGrid1.SelectedCells[0].Value.ToString() + "','" + metroGrid1.SelectedCells[2].Value.ToString() + "' , '" + listeGorevlenecekler.Items[i].Text + "') ";
                    cmd.ExecuteNonQuery();
                }
                connection.Close();

                lblGorevliPersoneller.Visible = false;
                lblGorevliPersoneller.Enabled = false;
                lblPersonelGorevlendir.Visible = false;
                lblPersonelGorevlendir.Enabled = false;
                lblPersonelKategorisi.Visible = false;
                lblPersonelKategorisi.Enabled = false;
                lblPersonelSecimi.Visible = false;
                lblPersonelSecimi.Enabled = false;
                cmbPersonelKategorisi.Visible = false;
                cmbPersonelKategorisi.Enabled = false;
                btnGorevlendir.Visible = false;
                btnGorevlendir.Enabled = false;
                btnGorevlendirme.Visible = false;
                btnGorevlendirme.Enabled = false;
                listeGorevlenecekler.Visible = false;
                listeGorevlenecekler.Enabled = false;
                listePersonel.Visible = false;
                listePersonel.Enabled = false;
                btnOnayla.Enabled = false;
                btnOnayla.Visible = false;
                GorevliListeGuncelle();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void PersonelListesiGuncelleme()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();
                listePersonel.Items.Clear();
                SqlDataReader Dr;
                cmd.CommandText = "select * from Personel where personelDepartman='" + cmbPersonelKategorisi.SelectedItem.ToString() + "' and Sil=0";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                connection.Open();
                Dr = cmd.ExecuteReader();
                listePersonel.Items.Clear();
                while (Dr.Read())
                {
                    bool listedevar = false;
                    if (listeGorevlenecekler.Items.Count != 0)
                    {
                        for (int i = 0; i < listeGorevlenecekler.Items.Count; i++)
                        {
                            if (string.Equals(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString(), listeGorevlenecekler.Items[i].Text))
                            {
                                listedevar = true;
                            }
                            if (!listedevar)
                            {
                                if (ListeGörevliler.Items.Count != 0)
                                {
                                    for (int j = 0; j < ListeGörevliler.Items.Count; i++)
                                    {
                                        if (string.Equals(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString(), ListeGörevliler.Items[j].Text))
                                        {
                                            listedevar = true;
                                        }
                                    }
                                }
                                if (!listedevar)
                                {
                                    listePersonel.Items.Add(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString());
                                }
                            }

                        }
                    }
                    else
                    {
                        if (ListeGörevliler.Items.Count != 0)
                        {
                            for (int i = 0; i < ListeGörevliler.Items.Count; i++)
                            {
                                if (string.Equals(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString(), ListeGörevliler.Items[i].Text))
                                {
                                    listedevar = true;
                                }
                            }
                        }
                        if (!listedevar)
                        {
                            listePersonel.Items.Add(Dr["personelAdi"].ToString() + " " + Dr["personelSoyadi"].ToString());
                        }
                    }

                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }


        private void btnGorevlendir_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < listePersonel.SelectedItems.Count; i++)
                {
                    listeGorevlenecekler.Items.Add(listePersonel.SelectedItems[i].Text);
                    listePersonel.Items.RemoveAt(i);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void btnGorevlendirme_Click(object sender, EventArgs e)
        {
            try
            {
                listeGorevlenecekler.Items.Remove(listeGorevlenecekler.SelectedItems[0]);
                PersonelListesiGuncelleme();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void cmbPersonelKategorisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PersonelListesiGuncelleme();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Eğer öğün değilse OzelYemek formunda aç yemek bilgilerini
                if (!OgunKontrol(metroGrid1.SelectedCells[0].Value.ToString(), metroGrid1.SelectedCells[1].Value.ToString()))
                {
                    OzelYemek duzenle = new OzelYemek(metroGrid1.SelectedCells[0].Value.ToString(), metroGrid1.SelectedCells[1].Value.ToString());
                    duzenle.Show();
                }
                else
                {

                }
                //Eğer öğün ise bu yemek adı ve açıklamasına ai öğün tanımlama formunda aç
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
