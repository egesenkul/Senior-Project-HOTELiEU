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

namespace Otel_Uygulamasi.Formlar.Toplantı_Islemleri
{
    public partial class ToplantiListesi : MetroFramework.Forms.MetroForm
    {
        public bool ilkAcilis = true;

        public ToplantiListesi()
        {
            InitializeComponent();
        }

        public void FiilToplantiSalonu()
        {
            cmbToplantiSalonu.Items.Clear();
            cmbToplantiSalonu.Items.Add(Localization.Tümü);
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select* from Salon where kategori='Toplantı Salonu'";
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;

            SqlDataReader Dr;
            connection.Open();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {
                cmbToplantiSalonu.Items.Add(Dr["salonAdı"]);
            }
            connection.Close();
            ortakFormIslemleri.cmbIlkDegerGetir(cmbToplantiSalonu);
        }

        private void Multilanguage()
        {
            lblToplantiSalonu.Text = Localization.lblToplantiSalonu;
            btnFiltrele.Text = Localization.btnFiltrele;
            btnKapat.Text = Localization.btnKapat;
            btnTemizle.Text = Localization.btnTemizle;
        }

        private void ToplantiListesi_Load(object sender, EventArgs e)
        {
            try
            {
                Multilanguage();
                FiilToplantiSalonu();
                btnFiltrele.PerformClick();
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
                ortakFormIslemleri.comboBoxTemizle(cmbToplantiSalonu);
                ortakFormIslemleri.dateTimeTemizle(metroDateTime1, metroDateTime2);
                ortakFormIslemleri.metroGridTemizle(metroGrid1);
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

                //GridView Column isimlerini değiştirmek için
                //datatable boş değilse bunları yapsın 

                metroGrid1.Columns[0].HeaderText = Localization.lblToplantiKonusu;
                metroGrid1.Columns[1].HeaderText = Localization.lblToplantiSalonu;
                metroGrid1.Columns[2].HeaderText = Localization.lblToplantiTarihi;
                metroGrid1.Columns[3].HeaderText = Localization.Kitle;
                metroGrid1.Columns[4].HeaderText = Localization.lblAciklama;
                metroGrid1.Columns[5].Visible = false;
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

                if (cmbToplantiSalonu.SelectedIndex != 0)
                {
                    FillDataGridView("select * from Toplanti where ToplantiTarihi >= '" + tarih + "' and ToplantiTarihi <= '" + tarih2 + "' and ToplantiSalonu='" + cmbToplantiSalonu.SelectedItem.ToString() + "'");
                }
                else
                {
                    FillDataGridView("select * from Toplanti where ToplantiTarihi >= '" + tarih + "' and ToplantiTarihi <= '" + tarih2 + "'");
                }
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }

        private void metroGrid1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                HotelWarningForm.Show(metroGrid1.SelectedCells[4].Value.ToString(), Localization.Tamam, 2);
            }
            catch (Exception ex)
            {
                HotelWarningForm.Show(ex.ToString(), Localization.Tamam, 1);
            }
        }
    }
}
