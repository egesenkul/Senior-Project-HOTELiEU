using Otel_Uygulamasi.Classlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Genel
{
    public partial class Destek : MetroFramework.Forms.MetroForm
    {
        public Destek()
        {
            InitializeComponent();
        }

        private void Destek_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-R5FHQ20;Initial Catalog=OtelOdev;Persist Security Info=True;User ID=sa;Password=14101410.,");
            SqlDataAdapter Sda = new SqlDataAdapter("select * from otelBilgileri", connection);

            DataTable dt = new DataTable();
            Sda.Fill(dt);

            ortakFormIslemleri.LogoGetir(pictureBox1);


            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroPanel1.BackColor = Color.White;
                metroLabel1.ForeColor = Color.White;
                metroLabel2.ForeColor = Color.White;
                metroLabel4.ForeColor = Color.White;
                metroLabel5.ForeColor = Color.White;
                metroLabel6.ForeColor = Color.White;
                metroButton1.BackColor = Color.White;
                metroButton1.ForeColor = Color.Black;
                metroButton2.BackColor = Color.White;
                metroButton2.ForeColor = Color.Black;
                metroButton3.BackColor = Color.White;
                metroButton3.ForeColor = Color.Black;
            }
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                            (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
