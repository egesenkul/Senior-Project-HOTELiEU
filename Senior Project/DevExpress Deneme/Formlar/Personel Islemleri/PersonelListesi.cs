using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using MetroFramework;
using Otel_Uygulamasi.Classlar;
using Otel_Uygulamasi.Formlar.Duyuru_Islemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Personel_Islemleri
{
    public partial class PersonelListesi : MetroFramework.Forms.MetroForm
    {
        public PersonelListesi()
        {
            InitializeComponent();
        }

        public void FiilCombobox()
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
                cmbPersonelGrubu.Items.Add(Dr["KategoriAciklama"]);
            }
            connection.Close();
            cmbPersonelGrubu.SelectedIndex = 0;
        }

        public void FillDataGridView(string sorgu)
        {
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = sorgu;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            metroGrid1.DataSource = dtRecord;

            //GridView Column isimlerini değiştirmek için
            //datatable boş değilse bunları yapsın 
            if (dtRecord.Rows.Count > 0)
            {
                metroGrid1.Columns[0].HeaderText = Localization.personelAdi;
                metroGrid1.Columns[1].HeaderText = Localization.personelSoyadi;
                metroGrid1.Columns[2].HeaderText = Localization.personelDepartman;
                metroGrid1.Columns[3].HeaderText = "Personel Kullanıcı Adı";
                metroGrid1.Columns[3].Visible = false;
            }
            //GridView yayılsın
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void ExcelAktar(MetroFramework.Controls.MetroGrid GridControl)
        {
            try
            {
                //MetroFramework.Controls.MetroGrid View = MetroFramework.Controls.MetroGrid.vi
                //GridView View = GridControl.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                //if (View != null)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Excel Dosyası|*.xls";
                    saveFileDialog1.Title = "Personel Listesi Dışa Aktarım";
                    saveFileDialog1.OverwritePrompt = true;//Aynı İsimle Dosya Var İse Üzerine Kaydedip Kaydetmeyeceğini Sorar.
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                    {
                        //View.ExportToXls(saveFileDialog1.FileName);
                        MetroMessageBox.Show(this, "", "Dışa Aktarım İşlemi Tamamlanmıştır.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Message : " + ex.Message + "\nSource : " + ex.Source + "\nStackTrace : " + ex.StackTrace, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SilinmisKayitGosterButtonKontrol() // Silinmiş kayıtları göster butonu görünsün mü görünmesin mi ?
        {
            if (silinmişPersonelleriGösterToolStripMenuItem.Text == Localization.SilinmisKayitlariGoster)
            {
                silinmişPersoneliGeriAlToolStripMenuItem.Visible = true;
            }
            else
            {
                silinmişPersoneliGeriAlToolStripMenuItem.Visible = false;
            }
        }

        private void MultiLanguage()
        {
            btnFiltrele.Text = Localization.btnFiltrele;
            btnKapat.Text = Localization.btnKapat;
            btnSecenekler.Text = Localization.btnSecenekler;
            lblPersonelKategorisi.Text = Localization.lblPersonelGrubu;
            lblPersonelListesi.Text = Localization.lblPersonelListesi;
            düzenleToolStripMenuItem.Text = Localization.Duzenle;
            silinmişPersoneliGeriAlToolStripMenuItem.Text = Localization.silinmisPersoneliGeriAl;
            silinmişPersonelleriGösterToolStripMenuItem.Text = Localization.silinmisPersonelleriGoster;
            tümBilgileriGösterToolStripMenuItem.Text = Localization.tumBilgileriGoster;
            silToolStripMenuItem.Text = Localization.Sil;
        }

        private void Yetki()
        {
            if (!string.Equals(Kullanici.yetki, "admin") && !string.Equals(Kullanici.yetki, "Resepsiyon'"))
            {
                düzenleToolStripMenuItem.Visible = false;
                silToolStripMenuItem.Visible = false;
            }
        }

        private void PersonelListesi_Load(object sender, EventArgs e)
        {
            MultiLanguage();
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, lblPersonelListesi, lblPersonelKategorisi);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbPersonelGrubu);
            }
            cmbPersonelGrubu.Items.Add("Tüm Personeller");
            FiilCombobox();
            FillDataGridView("Select personelAdi, personelSoyadi, personelDepartman, personelKullaniciAdi from Personel where Sil =0");
            SilinmisKayitGosterButtonKontrol();
            Yetki();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmbPersonelGrubu.SelectedIndex == 0)
            {
                FillDataGridView("Select personelAdi, personelSoyadi, personelDepartman, personelKullaniciAdi from Personel");
            }
            else
            {
                string calisacakSorgu = "Select personelAdi, personelSoyadi, personelDepartman,personelKullaniciAdi from Personel where personelDepartman= '" + cmbPersonelGrubu.SelectedItem.ToString()+"'";
                FillDataGridView(calisacakSorgu);
            }
        }

        private void metroGrid1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tümBilgileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = metroGrid1.SelectedCells[3].Value.ToString();
           // select olduğu şeyi şey yap
            PersonelOlusturma bilgileriGoster = new PersonelOlusturma(kullaniciAdi, 1);
            bilgileriGoster.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Sili 1e dönüştür ki tablodan gizlensin
            if (metroGrid1.SelectedCells.Count > 0)
            {
                SqlCommand cmd = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "update Personel set Sil=1 where personelKullaniciAdi='" + metroGrid1.SelectedCells[3].Value.ToString() + "'";
                // Personel türünü Rıza'ya sor.
                cmd.ExecuteNonQuery();
                connection.Close();
                MetroMessageBox.Show(this, "Başarılı bir şekilde personel silinmiştir. ", "Personel Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataGridView("Select personelAdi, personelSoyadi, personelDepartman, personelKullaniciAdi from Personel where Sil =0");
            }
            else
            {
                MetroMessageBox.Show(this, "", Localization.personelSilmeBasarili, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                string kullaniciAdi = metroGrid1.SelectedCells[3].Value.ToString();
                PersonelOlusturma bilgileriGoster = new PersonelOlusturma(kullaniciAdi, 0);
                bilgileriGoster.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "", Localization.duzenlenecekPersonelSec, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            //ExcelAktar(metroGrid1);
        }

        private void metroGrid1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void silinmişPersonelleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (silinmişPersonelleriGösterToolStripMenuItem.Text != Localization.SilinmisKayitlariGosterme)
            {
                lblPersonelListesi.Text = "Silinmiş Personeller";
                FillDataGridView("Select personelAdi, personelSoyadi, personelDepartman, personelKullaniciAdi from Personel where Sil =1");
                silinmişPersonelleriGösterToolStripMenuItem.Text = "Silinmiş Kayıtları Gösterme";
                silinmişPersonelleriGösterToolStripMenuItem.BackColor = Color.YellowGreen;
                metroGrid1.DefaultCellStyle.BackColor = Color.Red;
            }
            else
            {
                lblPersonelListesi.Text = "Personel Listesi";
                FillDataGridView("Select personelAdi, personelSoyadi, personelDepartman, personelKullaniciAdi from Personel where Sil =0");
                silinmişPersonelleriGösterToolStripMenuItem.Text = "Silinmiş Kayıtları Göster";
                silinmişPersonelleriGösterToolStripMenuItem.BackColor = Color.White;
                metroGrid1.DefaultCellStyle.BackColor = Color.White;
            }
            SilinmisKayitGosterButtonKontrol();
        }

        private void silinmişPersoneliGeriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Server = tcp:hotelieu.database.windows.net,1433; Initial Catalog = HotelProject; Persist Security Info = False; User ID = hotelieu; Password = Hotelproject35; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
            cmd.Connection = connection;
            connection.Open();
            cmd.CommandText = "update Personel set Sil=0 where personelKullaniciAdi='" + metroGrid1.SelectedCells[3].Value.ToString() + "'";
            // Personel türünü Rıza'ya sor.
            cmd.ExecuteNonQuery();
            connection.Close();
            MetroMessageBox.Show(this, "", Localization.PersonelGeriAlindi, MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDataGridView("Select personelAdi, personelSoyadi, personelDepartman, personelKullaniciAdi from Personel where Sil =1");
            SilinmisKayitGosterButtonKontrol();
        }
    }
}
