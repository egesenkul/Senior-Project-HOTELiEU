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
                lblYemekSalonu.Text = Localization.yemekSalonu;
                lblYemekTuru.Text = Localization.yemekTuru;
                btnFiltrele.Text = Localization.btnFiltrele;
                btnTemizle.Text = Localization.btnTemizle;
                btnKapat.Text = Localization.btnKapat;
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
                this.Text = Localization.tileYemekListesi;
                FiilYemekTuru();
                silinmişPersoneliGeriAlToolStripMenuItem.Visible = false;
                Yetki();
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, lblYemekTuru, lblYemekSalonu);
                    ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray,  cmbYemekSalonu, cmbYemekTur);
                    ortakFormIslemleri.ListViewRenkDegistir(Color.Black);
                }
                metroDateTime1.Value = DateTime.Now.AddDays(-1);
                btnFiltrele.PerformClick();
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
                        HotelWarningForm.Show(String.Format(Localization.NoResult, "\n"), Localization.Tamam, 1);
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
