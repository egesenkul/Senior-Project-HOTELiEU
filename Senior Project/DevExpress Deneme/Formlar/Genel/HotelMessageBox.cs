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
    public partial class HotelMessageBox : MetroFramework.Forms.MetroForm
    {
        public HotelMessageBox()
        {
            InitializeComponent();
        }
        static HotelMessageBox MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string Text , string btnOk, string btnCancel)
        {
            MsgBox = new HotelMessageBox();
            MsgBox.metrolbl.Text = Text;
            MsgBox.metroButton1.Text = btnOk;
            MsgBox.metroButton2.Text = btnCancel;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
        }


        private void HotelMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; MsgBox.Close();
        }
        
    }
}
