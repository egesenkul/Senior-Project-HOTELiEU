using MetroFramework;
using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Ardunio
{
    public partial class ArdunioBaglantiSicaklik : MetroFramework.Forms.MetroForm
    {
        public ArdunioBaglantiSicaklik()
        {
            InitializeComponent();
        }

        private void BilgileriDoldur()
        {
            if (Classlar.Ardunio.ArdunioAktif == true)
            {
                cmbArdunioAktif.SelectedIndex = 0;
            }
            else { cmbArdunioAktif.SelectedIndex = 1; }
        }

        private void ArdunioBaglantiSicaklik_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7 && Kullanici.otoGeceModu.Equals("True"))
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                ortakFormIslemleri.LabelRenkDegistir(Color.White, metroLabel1, metroLabel8);
                ortakFormIslemleri.ComboBoxRenkDegistir(Color.Gray, cmbArdunioAktif, cmbComPort);
            }
            cmbArdunioAktif.Items.Add("Evet");
            cmbArdunioAktif.Items.Add("Hayır");
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbComPort.Items.Add(s);
            }
            BilgileriDoldur();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Classlar.Ardunio.Port = cmbComPort.SelectedValue.ToString();
            Classlar.Ardunio.ArdunioBaglantiBilgierliGuncelle();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Bu özellik en yakın zamanda güncelleme ile aktif hale gelecektir.", "Özellik Henüz Aktif Değildir", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
