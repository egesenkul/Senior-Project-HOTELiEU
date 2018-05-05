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

namespace Otel_Uygulamasi.Formlar.Duyuru_Islemleri
{
    public partial class DuyuruListesi : MetroFramework.Forms.MetroForm
    {
        public DuyuruListesi()
        {
            InitializeComponent();
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                düzenleToolStripMenuItem.Visible = false;
                silToolStripMenuItem.Visible = false;
            }
        }

        public void FiilComboboxOdaGrubu()
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Select OdaKategoriAciklama from OdaKategori";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                ComboBoxOdaGrubu.Items.Add(Dr["OdaKategoriAciklama"]);
            }
            connection.Close();
        }

        private void MultiLanguage()
        {
            lblDuyuruTipi.Text = Localization.lblDuyuruGrubu;
            KriterLabel.Text = Localization.KriterLabel;
            LabelPersonelGrup.Text = Localization.lblPersonelGrubu;
            MusteriAdLabel.Text = Localization.MusteriAdLabel;
            OdaGrupLabel.Text = Localization.OdaGrupLabel;
            CheckBoxTumPersoneller.Text = Localization.chechBoxTümPersoneller;
            CheckBoxOzelGonderim.Text = Localization.CheckBoxOzelGonderim;
            btnSecenekler.Text = Localization.btnSecenekler;
            btnFiltrele.Text = Localization.btnFiltrele;
            metroButton2.Text = Localization.btnKapat;
            metroButton3.Text = Localization.btnTemizle;
            düzenleToolStripMenuItem.Text = Localization.Duzenle;
            silinmişDuyurularıGösterToolStripMenuItem.Text = Localization.silinmisDuyurulariGoster;
            silinmişDuyuruyuGeriAlToolStripMenuItem.Text = Localization.silinmisDuyurulariGeriAl;
            silToolStripMenuItem.Text = Localization.Sil;
            tümBilgileriGösterToolStripMenuItem.Text = Localization.tumBilgileriGoster;
        }


        private void DuyuruListesi_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                silinmişDuyuruyuGeriAlToolStripMenuItem.Visible = false;
                cmbDuyuruTipi.Items.Add(Localization.Tümü);
                FiilCombobox();
                FiilComboboxOdaGrubu();
                FiilComboboxMusteriAdi();
                metroDateTime1.Value = DateTime.Now.AddDays(-1);
                Yetki();
                ComboBoxKriter.Items.Add(Localization.OdaGrubu);
                ComboBoxKriter.Items.Add(Localization.OzelMusteri);
                ComboBoxKriter.Items.Add(Localization.Personel);
                this.Text = Localization.duyuruListesi;
                ComboBoxKriter.SelectedIndex = 0;
                FiilComboboxPersonelGrubu();
                KriterLabel.Visible = false;
                OdaGrupLabel.Visible = false;
                ComboBoxKriter.Visible = false;
                ComboBoxOdaGrubu.Visible = false;
                ortakFormIslemleri.cmbIlkDegerGetir(cmbDuyuruTipi, cmbMusteriAdi, ComboBoxKriter, ComboBoxOdaGrubu, ComboBoxPersonelGrubu);
                btnFiltrele.PerformClick();
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

        public void FiilComboboxPersonelGrubu()
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
                    ComboBoxPersonelGrubu.Items.Add(Dr["KategoriAciklama"]);
                }
                connection.Close();
                ComboBoxPersonelGrubu.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilCombobox()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select DuyuruKategoriAciklama from DuyuruKategori";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbDuyuruTipi.Items.Add(Dr["DuyuruKategoriAciklama"]);
                }
                connection.Close();
                cmbDuyuruTipi.SelectedIndex = 0;
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
                ortakFormIslemleri.comboBoxTemizle(cmbDuyuruTipi);
                ortakFormIslemleri.metroGridTemizle(metroGrid1);
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
                GridGuncelle();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        public void FiilComboboxMusteriAdi()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "select musteriAdi,musteriSoyadi from Musteriler";
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                SqlDataReader Dr;
                connection.Open();
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    cmbMusteriAdi.Items.Add(Dr["musteriAdi"].ToString() + " " + Dr["musteriSoyadi"]);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void GridGuncelle()
        {
            try
            {
                string sorgu = "";
                string tarih = Convert.ToDateTime(metroDateTime1.Value).ToString("MM.dd.yyyy HH:mm:ss");
                string tarih2 = Convert.ToDateTime(metroDateTime2.Value).ToString("MM.dd.yyyy HH:mm:ss");
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                //duyuru tipini her türlü oku 
                if (!CheckBoxOzelGonderim.Checked)
                {
                    //özel gönderim değil direk tarihler arası ve türe göre select çek
                    if (cmbDuyuruTipi.SelectedIndex != 0)
                    {
                        sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "' and DuyuruGrubu='" + cmbDuyuruTipi.SelectedItem.ToString() + "' and Gorunur=1";
                    }
                    else
                    {
                        sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "' and Gorunur=1";
                    }
                }
                else
                {
                    //Özel gönderim
                    if (ComboBoxKriter.SelectedIndex == 0)
                    {
                        if (cmbDuyuruTipi.SelectedIndex != 0)
                        {
                            sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "' and DuyuruGrubu='" + cmbDuyuruTipi.SelectedItem.ToString() + "'and OdaGrubu='" + ComboBoxOdaGrubu.SelectedItem.ToString() + "' and Gorunur=1";
                        }
                        else
                        {
                            sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "'and OdaGrubu='" + ComboBoxOdaGrubu.SelectedItem.ToString() + "' and Gorunur=1";
                        }
                    }
                    else if (ComboBoxKriter.SelectedIndex == 1)
                    {
                        if (cmbDuyuruTipi.SelectedIndex != 0)
                        {
                            sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih2 + "' and DuyuruTarihi <= '" + tarih2 + "' and DuyuruGrubu='" + cmbDuyuruTipi.SelectedItem.ToString() + "'and MusteriAdi='" + cmbMusteriAdi.SelectedItem.ToString() + "' and Gorunur=1";
                        }
                        else
                        {
                            sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "'and MusteriAdi='" + cmbMusteriAdi.SelectedItem.ToString() + "' and Gorunur=1";
                        }
                    }
                    else if (ComboBoxKriter.SelectedIndex == 2)
                    {
                        if (CheckBoxTumPersoneller.Checked)
                        {
                            //tüm personellere giden duyurular
                            if (cmbDuyuruTipi.SelectedIndex != 0)
                            {
                                sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "' and DuyuruGrubu='" + cmbDuyuruTipi.SelectedItem.ToString() + "'and PersonelGrubu='" + ComboBoxPersonelGrubu.SelectedItem.ToString() + "'";
                            }
                            else
                            {
                                sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "'and Kriter='Personel"  + "' and Gorunur=1";
                            }
                        }
                        else
                        {
                            if (cmbDuyuruTipi.SelectedIndex != 0)
                            {
                                sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "' and DuyuruGrubu='" + cmbDuyuruTipi.SelectedItem.ToString() + "'and PersonelGrubu='" + ComboBoxPersonelGrubu.SelectedItem.ToString() + "' and Gorunur=1";
                            }
                            else
                            {
                                sorgu = "select * from Duyuru where DuyuruTarihi >= '" + tarih + "' and DuyuruTarihi <= '" + tarih2 + "'and PersonelGrubu='" + ComboBoxPersonelGrubu.SelectedItem.ToString() + "' and Gorunur=1";
                            }
                        }
                    }
                }
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = sorgu;
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                metroGrid1.DataSource = dtRecord;
                metroGrid1.Columns[0].HeaderText = Localization.lblBaslik;
                metroGrid1.Columns[1].HeaderText = Localization.lblDuyuruGrubu;
                metroGrid1.Columns[2].HeaderText = Localization.lbliCerik;
                metroGrid1.Columns[3].HeaderText = Localization.KriterLabel;
                metroGrid1.Columns[4].Visible = false;
                metroGrid1.Columns[5].Visible = false;
                metroGrid1.Columns[6].Visible = false;
                metroGrid1.Columns[8].HeaderText = Localization.lblTarih;
                metroGrid1.Columns[7].Visible = false;
                
                metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Duyuru set Gorunur=0 where Baslik='" + metroGrid1.SelectedCells[0].Value.ToString() + "' and DuyuruGrubu='" + metroGrid1.SelectedCells[1].Value.ToString() + "' and Icerik='" + metroGrid1.SelectedCells[2].Value.ToString() + "'";
                    // Personel türünü Rıza'ya sor.
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.DuyuruSilmeBasarili, Localization.Tamam, 0);
                    }
                    btnFiltrele.PerformClick();
                }
                else
                {
                    HotelWarningForm.Show(Localization.SilmekicinDuyuruSec, Localization.Tamam, 1);
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
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    DuyuruEkle duyuruDuzenle = new DuyuruEkle(Convert.ToDateTime(metroGrid1.SelectedCells[7].Value), metroGrid1.SelectedCells[0].Value.ToString(), 1);
                    duyuruDuzenle.Show();
                }
                else
                {
                    HotelWarningForm.Show(string.Format(Localization.DuzenlemekicinDuyuruSec, "\n"), Localization.Tamam, 1);
                }
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
                DuyuruEkle duyuruGoster = new DuyuruEkle(Convert.ToDateTime(metroGrid1.SelectedCells[7].Value), metroGrid1.SelectedCells[0].Value.ToString(), 2);
                duyuruGoster.Show();
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

        private void CheckBoxOzelGonderim_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CheckBoxOzelGonderim.Checked)
                {
                    ComboBoxKriter.Visible = true;
                    KriterLabel.Visible = true;
                    OdaGrupLabel.Visible = true;
                    ComboBoxOdaGrubu.Visible = true;
                }
                else
                {
                    ComboBoxKriter.Visible = false;
                    KriterLabel.Visible = false;
                    OdaGrupLabel.Visible = false;
                    ComboBoxOdaGrubu.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                    CheckBoxTumPersoneller.Enabled = false;
                    LabelPersonelGrup.Enabled = false;
                    LabelPersonelGrup.Visible = false;
                    ComboBoxPersonelGrubu.Visible = false;
                    ComboBoxPersonelGrubu.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void ComboBoxKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComboBoxKriter.SelectedIndex == 0)
                {
                    OdaGrupLabel.Visible = true;
                    ComboBoxOdaGrubu.Visible = true;
                    MusteriAdLabel.Visible = false;
                    cmbMusteriAdi.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                }
                else if (ComboBoxKriter.SelectedIndex == 1)
                {
                    OdaGrupLabel.Visible = false;
                    ComboBoxOdaGrubu.Visible = false;
                    MusteriAdLabel.Visible = true;
                    cmbMusteriAdi.Visible = true;
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                    CheckBoxTumPersoneller.Visible = false;
                }
                else if (ComboBoxKriter.SelectedIndex == 2)
                {
                    OdaGrupLabel.Visible = false;
                    ComboBoxOdaGrubu.Visible = false;
                    MusteriAdLabel.Visible = false;
                    cmbMusteriAdi.Visible = false;
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                    CheckBoxTumPersoneller.Visible = true;
                    CheckBoxTumPersoneller.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void CheckBoxTumPersoneller_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (CheckBoxTumPersoneller.Checked)
                {
                    ComboBoxPersonelGrubu.Visible = false;
                    LabelPersonelGrup.Visible = false;
                }
                else
                {
                    ComboBoxPersonelGrubu.Visible = true;
                    LabelPersonelGrup.Visible = true;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroGrid1_MouseClick_1(object sender, MouseEventArgs e)
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

        private void silinmişDuyurularıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                cmbDuyuruTipi.SelectedIndex = 0;
                CheckBoxOzelGonderim.Checked = false;
                if (!string.Equals(silinmişDuyurularıGösterToolStripMenuItem.Text, Localization.SilinmisDuyurulariGosterme))
                {
                    silinmişDuyurularıGösterToolStripMenuItem.Text = Localization.SilinmisDuyurulariGosterme;
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = connection;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "select * from Duyuru where Gorunur=0";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    metroGrid1.DataSource = dtRecord;
                    if (dtRecord.Rows.Count > 0)
                    {
                        metroGrid1.Columns[0].HeaderText = Localization.lblBaslik;
                        metroGrid1.Columns[1].HeaderText = Localization.lblDuyuruGrubu;
                        metroGrid1.Columns[2].HeaderText = Localization.lbliCerik;
                        metroGrid1.Columns[3].HeaderText = Localization.KriterLabel;
                        metroGrid1.Columns[4].Visible = false;
                        metroGrid1.Columns[5].Visible = false;
                        metroGrid1.Columns[6].Visible = false;
                        metroGrid1.Columns[8].Visible = false;
                    }
                    else
                    {
                        HotelWarningForm.Show(String.Format(Localization.NoResult,"\n"), Localization.Tamam, 1);
                    }
                    //GridView yayılsın
                    metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    silinmişDuyuruyuGeriAlToolStripMenuItem.Visible = true;
                }
                else
                {
                    silinmişDuyurularıGösterToolStripMenuItem.Text = Localization.silinmisDuyurulariGoster;
                    GridGuncelle();
                    silinmişDuyuruyuGeriAlToolStripMenuItem.Visible = false;
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void silinmişDuyuruyuGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Duyuru set Gorunur=1 where Baslik='" + metroGrid1.SelectedCells[0].Value.ToString() + "' and DuyuruGrubu='" + metroGrid1.SelectedCells[1].Value.ToString() + "' and Icerik='" + metroGrid1.SelectedCells[2].Value.ToString() + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    if (Kullanici.BilgilendirmeFormlari.Equals("True"))
                    {
                        HotelWarningForm.Show(Localization.DuyuruGerialmaBasarili, Localization.Tamam, 0);
                    }
                    btnFiltrele.PerformClick();
                }
                else
                {
                    HotelWarningForm.Show(Localization.GeriAlinacakDuyuruSec, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}

