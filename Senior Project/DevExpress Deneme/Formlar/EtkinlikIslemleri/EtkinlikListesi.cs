﻿using MetroFramework;
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
{
    public partial class EtkinlikListesi : MetroFramework.Forms.MetroForm
    {
        public bool ilkAcilis = true;

        public EtkinlikListesi()
        {
            InitializeComponent();
        }

        private void MultiLanguage()
        {
            try
            {
                btnFiltrele.Text = Localization.btnFiltrele;
                btnKapat.Text = Localization.btnKapat;
                btnSecenekler.Text = Localization.btnSecenekler;
                btnTemizle.Text = Localization.btnTemizle;
                düzenleToolStripMenuItem.Text = Localization.Duzenle;
                silinenEtkinlikleriGösterToolStripMenuItem.Text = Localization.SilinenEtkinlikleriGoster;
                silinenEtkinliğiGeriAlToolStripMenuItem.Text = Localization.SilinenEtkinligiGeriAl;
                metroLabel6.Text = Localization.SilinenEtkinlikleriGoster;
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void EtkinlikListesi_Load(object sender, EventArgs e)
        {
            try
            {
                MultiLanguage();
                this.Text = Localization.etkinlikListesi;
                silinenEtkinliğiGeriAlToolStripMenuItem.Visible = false;
                metroLabel6.Visible = false;
                this.StyleManager = metroStyleManager1;
                if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
                {
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    ortakFormIslemleri.LabelRenkDegistir(Color.White, metroLabel6);
                }
                metroDateTime1.Value = DateTime.Now.AddDays(-1);
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

                metroGrid1.Columns[0].HeaderText = "Etkinlik ID";
                metroGrid1.Columns[0].Visible = false;
                metroGrid1.Columns[1].HeaderText = "Etkinlik Adı";
                metroGrid1.Columns[2].HeaderText = "Etkinlik Açıklaması";
                metroGrid1.Columns[3].HeaderText = "Etkinlik Tarihi";
                metroGrid1.Columns[4].HeaderText = "Kişi Limiti";
                metroGrid1.Columns[5].Visible = false;
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
                FillDataGridView("SELECT * FROM Etkinlik WHERE EtkinlikTarihi>='" + tarih + "' and EtkinlikTarihi<='" + tarih2 + "' and Gorunur=1");
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
                ortakFormIslemleri.metroGridTemizle(metroGrid1);
                ortakFormIslemleri.dateTimeTemizle(metroDateTime1, metroDateTime2);
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
                contextMenuStrip1.Show(Cursor.Position);
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

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    EtkinlikTanimlama duzenle = new EtkinlikTanimlama(metroGrid1.SelectedCells[0].Value.ToString());
                    duzenle.Show();
                }
                else
                {
                    HotelWarningForm.Show(Localization.duzenlenecekEtkinlikSecin, Localization.Tamam, 1);
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
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Etkinlik set Gorunur=0 where Etkinlikno='" + Convert.ToInt32(metroGrid1.SelectedCells[0].Value) + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    HotelWarningForm.Show(Localization.etkinlikSilinmistir, Localization.Tamam, 0);
                    btnFiltrele.PerformClick();
                }
                else
                {
                    HotelWarningForm.Show(Localization.silinecekEtkinlikSecin, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void silinenEtkinlikleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ortakFormIslemleri.dateTimeTemizle(metroDateTime1, metroDateTime2);
                if (string.Equals(silinenEtkinlikleriGösterToolStripMenuItem.Text, "Silinen Etkinlikleri Göster"))
                {
                    FillDataGridView("SELECT * FROM Etkinlik WHERE Gorunur=0");
                    silinenEtkinliğiGeriAlToolStripMenuItem.Visible = true;
                    silinenEtkinlikleriGösterToolStripMenuItem.Text = "Silinen etkinlikleri gösterme";
                    metroLabel6.Visible = true;
                }
                else
                {
                    silinenEtkinliğiGeriAlToolStripMenuItem.Visible = false;
                    silinenEtkinlikleriGösterToolStripMenuItem.Text = "Silinen etkinlikleri göster";
                    metroLabel6.Visible = false;
                    FillDataGridView("SELECT * FROM Etkinlik and Gorunur=1");
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void silinenEtkinliğiGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGrid1.SelectedCells.Count > 0)
                {
                    SqlCommand cmd = new SqlCommand();
                    SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                    cmd.Connection = connection;
                    connection.Open();
                    cmd.CommandText = "update Etkinlik set Gorunur=1 where Etkinlikno='" + Convert.ToInt32(metroGrid1.SelectedCells[0].Value) + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    HotelWarningForm.Show(Localization.etkinlikGeriAlmaBasarili, Localization.Tamam, 0);
                    btnFiltrele.PerformClick();
                }
                else
                {
                    HotelWarningForm.Show(Localization.GeriAlinacakEtkinlikSec, Localization.Tamam, 1);
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
