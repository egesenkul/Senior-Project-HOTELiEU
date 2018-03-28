using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Otel_Uygulamasi.Formlar.Genel
{
    public partial class Guncelleme : MetroFramework.Forms.MetroForm
    {
        public Guncelleme()
        {
            InitializeComponent();
        }

        private void Guncelleme_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            if (Convert.ToInt32(DateTime.Now.Hour.ToString()) < 7)
            {//dark tema
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroPanel1.ForeColor = Color.Black;
                metroLabel1.ForeColor = Color.Black;
                metroLabel2.ForeColor = Color.Black;
                metroLabel3.ForeColor = Color.Black;
                metroLabel4.ForeColor = Color.Black;
                metroLabel5.ForeColor = Color.Black;
                metroLabel6.ForeColor = Color.Black;
                metroButton1.ForeColor = Color.Black;
                metroButton2.ForeColor = Color.Black;
                metroButton4.ForeColor = Color.Black;
            }
        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            Destek destek = new Destek();
            destek.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
