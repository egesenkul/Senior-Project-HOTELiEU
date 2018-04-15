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
    public partial class HotelWarningForm : MetroFramework.Forms.MetroForm
    {
        public HotelWarningForm()
        {
            InitializeComponent();
        }
        static HotelWarningForm MsgBox; static DialogResult result = DialogResult.No;

        public static DialogResult Show(string Text, string btnOk)
        {
            MsgBox = new HotelWarningForm();
            MsgBox.metrolbl.Text = Text;
            MsgBox.metroButton2.Text = btnOk;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }

        private void HotelWarningForm_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }
    }
}
