namespace Otel_Uygulamasi.Formlar.Personel_Islemleri
{
    partial class ToplantiOlustur
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
            this.dtToplantiTarihSaat = new DevExpress.XtraEditors.DateEdit();
            this.chechBoxTümPersoneller = new MetroFramework.Controls.MetroCheckBox();
            this.btnToplantıSalonuEkle = new MetroFramework.Controls.MetroButton();
            this.btnPersonelKategoriEkle = new MetroFramework.Controls.MetroButton();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.lblAciklama = new MetroFramework.Controls.MetroLabel();
            this.cmbPersonelKategori = new MetroFramework.Controls.MetroComboBox();
            this.lblPersonelKategori = new MetroFramework.Controls.MetroLabel();
            this.lblToplantiTarihi = new MetroFramework.Controls.MetroLabel();
            this.cmbSalon = new MetroFramework.Controls.MetroComboBox();
            this.lblToplantiSalonu = new MetroFramework.Controls.MetroLabel();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtisim = new MetroFramework.Controls.MetroTextBox();
            this.lblToplantiKonusu = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtToplantiTarihSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToplantiTarihSaat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dtToplantiTarihSaat);
            this.metroPanel1.Controls.Add(this.chechBoxTümPersoneller);
            this.metroPanel1.Controls.Add(this.btnToplantıSalonuEkle);
            this.metroPanel1.Controls.Add(this.btnPersonelKategoriEkle);
            this.metroPanel1.Controls.Add(this.txtAciklama);
            this.metroPanel1.Controls.Add(this.lblAciklama);
            this.metroPanel1.Controls.Add(this.cmbPersonelKategori);
            this.metroPanel1.Controls.Add(this.lblPersonelKategori);
            this.metroPanel1.Controls.Add(this.lblToplantiTarihi);
            this.metroPanel1.Controls.Add(this.cmbSalon);
            this.metroPanel1.Controls.Add(this.lblToplantiSalonu);
            this.metroPanel1.Controls.Add(this.btnTemizle);
            this.metroPanel1.Controls.Add(this.btnKlavye);
            this.metroPanel1.Controls.Add(this.btnKapat);
            this.metroPanel1.Controls.Add(this.btnKaydet);
            this.metroPanel1.Controls.Add(this.txtisim);
            this.metroPanel1.Controls.Add(this.lblToplantiKonusu);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1188, 625);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtToplantiTarihSaat
            // 
            this.dtToplantiTarihSaat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtToplantiTarihSaat.EditValue = new System.DateTime(2018, 3, 6, 0, 0, 0, 0);
            this.dtToplantiTarihSaat.Location = new System.Drawing.Point(624, 152);
            this.dtToplantiTarihSaat.Margin = new System.Windows.Forms.Padding(2);
            this.dtToplantiTarihSaat.Name = "dtToplantiTarihSaat";
            // 
            // 
            // 
            this.dtToplantiTarihSaat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtToplantiTarihSaat.Properties.Appearance.Options.UseFont = true;
            this.dtToplantiTarihSaat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // 
            // 
            this.dtToplantiTarihSaat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToplantiTarihSaat.Properties.DisplayFormat.FormatString = "g";
            this.dtToplantiTarihSaat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtToplantiTarihSaat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtToplantiTarihSaat.Properties.Mask.EditMask = "g";
            this.dtToplantiTarihSaat.Properties.NullDate = new System.DateTime(2017, 11, 30, 13, 12, 44, 361);
            this.dtToplantiTarihSaat.Size = new System.Drawing.Size(175, 26);
            this.dtToplantiTarihSaat.TabIndex = 32;
            // 
            // chechBoxTümPersoneller
            // 
            this.chechBoxTümPersoneller.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chechBoxTümPersoneller.AutoSize = true;
            this.chechBoxTümPersoneller.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.chechBoxTümPersoneller.Location = new System.Drawing.Point(418, 196);
            this.chechBoxTümPersoneller.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.chechBoxTümPersoneller.Name = "chechBoxTümPersoneller";
            this.chechBoxTümPersoneller.Size = new System.Drawing.Size(154, 25);
            this.chechBoxTümPersoneller.TabIndex = 30;
            this.chechBoxTümPersoneller.Text = "Tüm Personeller";
            this.chechBoxTümPersoneller.UseCustomBackColor = true;
            this.chechBoxTümPersoneller.UseCustomForeColor = true;
            this.chechBoxTümPersoneller.UseSelectable = true;
            this.chechBoxTümPersoneller.CheckedChanged += new System.EventHandler(this.chechBoxTümPersoneller_CheckedChanged);
            // 
            // btnToplantıSalonuEkle
            // 
            this.btnToplantıSalonuEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnToplantıSalonuEkle.Location = new System.Drawing.Point(815, 93);
            this.btnToplantıSalonuEkle.Name = "btnToplantıSalonuEkle";
            this.btnToplantıSalonuEkle.Size = new System.Drawing.Size(35, 35);
            this.btnToplantıSalonuEkle.TabIndex = 29;
            this.btnToplantıSalonuEkle.Text = "+";
            this.btnToplantıSalonuEkle.UseSelectable = true;
            this.btnToplantıSalonuEkle.Click += new System.EventHandler(this.btnToplantıSalonuEkle_Click);
            // 
            // btnPersonelKategoriEkle
            // 
            this.btnPersonelKategoriEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPersonelKategoriEkle.Location = new System.Drawing.Point(815, 243);
            this.btnPersonelKategoriEkle.Name = "btnPersonelKategoriEkle";
            this.btnPersonelKategoriEkle.Size = new System.Drawing.Size(35, 35);
            this.btnPersonelKategoriEkle.TabIndex = 28;
            this.btnPersonelKategoriEkle.Text = "+";
            this.btnPersonelKategoriEkle.UseSelectable = true;
            this.btnPersonelKategoriEkle.Click += new System.EventHandler(this.btnPersonelKategoriEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(-5, 2);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(177, 177);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(624, 305);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(175, 182);
            this.txtAciklama.TabIndex = 27;
            this.txtAciklama.UseCustomBackColor = true;
            this.txtAciklama.UseCustomForeColor = true;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAciklama.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAciklama.Location = new System.Drawing.Point(418, 304);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(92, 25);
            this.lblAciklama.TabIndex = 26;
            this.lblAciklama.Text = "Açıklama :";
            this.lblAciklama.UseCustomBackColor = true;
            this.lblAciklama.UseCustomForeColor = true;
            // 
            // cmbPersonelKategori
            // 
            this.cmbPersonelKategori.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPersonelKategori.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbPersonelKategori.FormattingEnabled = true;
            this.cmbPersonelKategori.ItemHeight = 29;
            this.cmbPersonelKategori.Location = new System.Drawing.Point(624, 243);
            this.cmbPersonelKategori.Name = "cmbPersonelKategori";
            this.cmbPersonelKategori.Size = new System.Drawing.Size(175, 35);
            this.cmbPersonelKategori.TabIndex = 25;
            this.cmbPersonelKategori.UseCustomBackColor = true;
            this.cmbPersonelKategori.UseCustomForeColor = true;
            this.cmbPersonelKategori.UseSelectable = true;
            // 
            // lblPersonelKategori
            // 
            this.lblPersonelKategori.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPersonelKategori.AutoSize = true;
            this.lblPersonelKategori.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPersonelKategori.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPersonelKategori.Location = new System.Drawing.Point(418, 250);
            this.lblPersonelKategori.Name = "lblPersonelKategori";
            this.lblPersonelKategori.Size = new System.Drawing.Size(171, 25);
            this.lblPersonelKategori.TabIndex = 24;
            this.lblPersonelKategori.Text = "Personel Kategorisi :";
            this.lblPersonelKategori.UseCustomBackColor = true;
            this.lblPersonelKategori.UseCustomForeColor = true;
            // 
            // lblToplantiTarihi
            // 
            this.lblToplantiTarihi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToplantiTarihi.AutoSize = true;
            this.lblToplantiTarihi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblToplantiTarihi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblToplantiTarihi.Location = new System.Drawing.Point(418, 142);
            this.lblToplantiTarihi.Name = "lblToplantiTarihi";
            this.lblToplantiTarihi.Size = new System.Drawing.Size(132, 25);
            this.lblToplantiTarihi.TabIndex = 22;
            this.lblToplantiTarihi.Text = "Toplantı Tarihi :";
            this.lblToplantiTarihi.UseCustomBackColor = true;
            this.lblToplantiTarihi.UseCustomForeColor = true;
            // 
            // cmbSalon
            // 
            this.cmbSalon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSalon.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.ItemHeight = 29;
            this.cmbSalon.Location = new System.Drawing.Point(624, 93);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(175, 35);
            this.cmbSalon.TabIndex = 21;
            this.cmbSalon.UseCustomBackColor = true;
            this.cmbSalon.UseCustomForeColor = true;
            this.cmbSalon.UseSelectable = true;
            // 
            // lblToplantiSalonu
            // 
            this.lblToplantiSalonu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToplantiSalonu.AutoSize = true;
            this.lblToplantiSalonu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblToplantiSalonu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblToplantiSalonu.Location = new System.Drawing.Point(418, 88);
            this.lblToplantiSalonu.Name = "lblToplantiSalonu";
            this.lblToplantiSalonu.Size = new System.Drawing.Size(144, 25);
            this.lblToplantiSalonu.TabIndex = 20;
            this.lblToplantiSalonu.Text = "Toplantı Salonu :";
            this.lblToplantiSalonu.UseCustomBackColor = true;
            this.lblToplantiSalonu.UseCustomForeColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTemizle.Location = new System.Drawing.Point(550, 548);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 40);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(411, 493);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(404, 36);
            this.btnKlavye.TabIndex = 18;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(675, 548);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(140, 40);
            this.btnKapat.TabIndex = 17;
            this.btnKapat.Text = "İptal";
            this.btnKapat.UseCustomBackColor = true;
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(411, 548);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 40);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtisim
            // 
            this.txtisim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtisim.CustomButton.Image = null;
            this.txtisim.CustomButton.Location = new System.Drawing.Point(147, 2);
            this.txtisim.CustomButton.Name = "";
            this.txtisim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtisim.CustomButton.TabIndex = 1;
            this.txtisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtisim.CustomButton.UseSelectable = true;
            this.txtisim.CustomButton.Visible = false;
            this.txtisim.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtisim.Lines = new string[0];
            this.txtisim.Location = new System.Drawing.Point(624, 37);
            this.txtisim.MaxLength = 32767;
            this.txtisim.Name = "txtisim";
            this.txtisim.PasswordChar = '\0';
            this.txtisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtisim.SelectedText = "";
            this.txtisim.SelectionLength = 0;
            this.txtisim.SelectionStart = 0;
            this.txtisim.ShortcutsEnabled = true;
            this.txtisim.ShowClearButton = true;
            this.txtisim.Size = new System.Drawing.Size(175, 30);
            this.txtisim.TabIndex = 9;
            this.txtisim.UseCustomBackColor = true;
            this.txtisim.UseCustomForeColor = true;
            this.txtisim.UseSelectable = true;
            this.txtisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblToplantiKonusu
            // 
            this.lblToplantiKonusu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblToplantiKonusu.AutoSize = true;
            this.lblToplantiKonusu.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblToplantiKonusu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblToplantiKonusu.Location = new System.Drawing.Point(418, 34);
            this.lblToplantiKonusu.Name = "lblToplantiKonusu";
            this.lblToplantiKonusu.Size = new System.Drawing.Size(149, 25);
            this.lblToplantiKonusu.TabIndex = 2;
            this.lblToplantiKonusu.Text = "Toplantı Konusu :";
            this.lblToplantiKonusu.UseCustomBackColor = true;
            this.lblToplantiKonusu.UseCustomForeColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // ToplantiOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 705);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "ToplantiOlustur";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ToplantiOlustur_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtToplantiTarihSaat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToplantiTarihSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroTextBox txtisim;
        private MetroFramework.Controls.MetroLabel lblToplantiKonusu;
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private MetroFramework.Controls.MetroLabel lblAciklama;
        private MetroFramework.Controls.MetroComboBox cmbPersonelKategori;
        private MetroFramework.Controls.MetroLabel lblPersonelKategori;
        private MetroFramework.Controls.MetroLabel lblToplantiTarihi;
        private MetroFramework.Controls.MetroComboBox cmbSalon;
        private MetroFramework.Controls.MetroLabel lblToplantiSalonu;
        private MetroFramework.Controls.MetroButton btnPersonelKategoriEkle;
        private MetroFramework.Controls.MetroButton btnToplantıSalonuEkle;
        private MetroFramework.Controls.MetroCheckBox chechBoxTümPersoneller;
        private DevExpress.XtraEditors.DateEdit dtToplantiTarihSaat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}