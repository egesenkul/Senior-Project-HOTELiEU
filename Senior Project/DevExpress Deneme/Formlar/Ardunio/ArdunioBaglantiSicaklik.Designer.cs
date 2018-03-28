namespace Otel_Uygulamasi.Formlar.Ardunio
{
    partial class ArdunioBaglantiSicaklik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cmbArdunioAktif = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmbComPort = new MetroFramework.Controls.MetroComboBox();
            this.btnAyarlariKaydet = new MetroFramework.Controls.MetroButton();
            this.btnBaglantiTestEt = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.cmbArdunioAktif);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.cmbComPort);
            this.metroPanel1.Controls.Add(this.btnAyarlariKaydet);
            this.metroPanel1.Controls.Add(this.btnBaglantiTestEt);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(16, 58);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(479, 631);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // cmbArdunioAktif
            // 
            this.cmbArdunioAktif.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbArdunioAktif.FormattingEnabled = true;
            this.cmbArdunioAktif.ItemHeight = 29;
            this.cmbArdunioAktif.Location = new System.Drawing.Point(254, 21);
            this.cmbArdunioAktif.Name = "cmbArdunioAktif";
            this.cmbArdunioAktif.Size = new System.Drawing.Size(159, 35);
            this.cmbArdunioAktif.TabIndex = 25;
            this.cmbArdunioAktif.UseCustomForeColor = true;
            this.cmbArdunioAktif.UseSelectable = true;
            this.cmbArdunioAktif.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(86, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(127, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Ardunio Aktif :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(86, 64);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 25);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "COM Port :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // cmbComPort
            // 
            this.cmbComPort.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.ItemHeight = 29;
            this.cmbComPort.Location = new System.Drawing.Point(254, 64);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(159, 35);
            this.cmbComPort.TabIndex = 22;
            this.cmbComPort.UseCustomForeColor = true;
            this.cmbComPort.UseSelectable = true;
            this.cmbComPort.UseStyleColors = true;
            // 
            // btnAyarlariKaydet
            // 
            this.btnAyarlariKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAyarlariKaydet.BackColor = System.Drawing.Color.Aqua;
            this.btnAyarlariKaydet.Location = new System.Drawing.Point(262, 125);
            this.btnAyarlariKaydet.Name = "btnAyarlariKaydet";
            this.btnAyarlariKaydet.Size = new System.Drawing.Size(194, 67);
            this.btnAyarlariKaydet.TabIndex = 20;
            this.btnAyarlariKaydet.Text = "Ayarları Kaydet";
            this.btnAyarlariKaydet.UseCustomBackColor = true;
            this.btnAyarlariKaydet.UseSelectable = true;
            this.btnAyarlariKaydet.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnBaglantiTestEt
            // 
            this.btnBaglantiTestEt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBaglantiTestEt.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBaglantiTestEt.Location = new System.Drawing.Point(19, 125);
            this.btnBaglantiTestEt.Name = "btnBaglantiTestEt";
            this.btnBaglantiTestEt.Size = new System.Drawing.Size(194, 67);
            this.btnBaglantiTestEt.TabIndex = 19;
            this.btnBaglantiTestEt.Text = "Bağlantı Test Et";
            this.btnBaglantiTestEt.UseCustomBackColor = true;
            this.btnBaglantiTestEt.UseSelectable = true;
            this.btnBaglantiTestEt.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButton3.BackColor = System.Drawing.Color.Red;
            this.metroButton3.Location = new System.Drawing.Point(93, 221);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(293, 67);
            this.metroButton3.TabIndex = 18;
            this.metroButton3.Text = "Kapat";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // ArdunioBaglantiSicaklik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 374);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ArdunioBaglantiSicaklik";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Ardunio Sıcaklık Bağlantı Ayarları";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ArdunioBaglantiSicaklik_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btnAyarlariKaydet;
        private MetroFramework.Controls.MetroButton btnBaglantiTestEt;
        private MetroFramework.Controls.MetroComboBox cmbComPort;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cmbArdunioAktif;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}