using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Otel_Uygulamasi.Formlar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void DovizKuruGetir()
        {
            try
            {
                if (NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    string Bugun = "http://www.tcmb.gov.tr/kurlar/today.xml";
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(Bugun);

                    // Xml içinden tarihi alma - gerekli olabilir
                    DateTime exchangeDate = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

                    string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                    string EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                    string POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;

                    label1.Text = (string.Format("Tarih {0} USD      : {1}", DateTime.Now.ToShortDateString(), USD));
                    label2.Text = (string.Format("Tarih {0} EURO    : {1}", DateTime.Now.ToShortDateString(), EURO));
                    label3.Text = (string.Format("Tarih {0} POUND : {1}", DateTime.Now.ToShortDateString(), POUND));
                    //webBrowser1.Navigate("http://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=169&cad=rja&uact=8&ved=0ahUKEwiZzKSIxZ_UAhWDVhoKHVxrDnA4oAEQFghKMAg&url=http%3A%2F%2Fwww.zentekyazilim.net%2F&usg=AFQjCNHc2Df9xQjv-O16X96EJPC9xH4gUw&sig2=ovl3PoVp-vgX913SQBeYTw");
                }
                else
                {

                }
            }
            catch (Exception)
            {

                MessageBox.Show("İnternet Bağlantısı Sağlanamadı. Döviz Kurları Gücellenemedi.", "Zentek Yazılım A.Ş.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            DovizKuruGetir();
        }
    }
}
