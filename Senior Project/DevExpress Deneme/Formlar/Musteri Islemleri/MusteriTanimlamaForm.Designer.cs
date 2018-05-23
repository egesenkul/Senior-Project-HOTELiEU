namespace DevExpress_Deneme
{
    partial class MusteriTanimlamaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriTanimlamaForm));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtSifre = new MetroFramework.Controls.MetroTextBox();
            this.txtKullaniciAdi = new MetroFramework.Controls.MetroTextBox();
            this.txtmail = new MetroFramework.Controls.MetroTextBox();
            this.txtadres = new MetroFramework.Controls.MetroTextBox();
            this.txttelefon = new MetroFramework.Controls.MetroTextBox();
            this.txtsoyisim = new MetroFramework.Controls.MetroTextBox();
            this.txtisim = new MetroFramework.Controls.MetroTextBox();
            this.lblSifre = new MetroFramework.Controls.MetroLabel();
            this.lblKullaniciAdi = new MetroFramework.Controls.MetroLabel();
            this.lblMail = new MetroFramework.Controls.MetroLabel();
            this.lblAdres = new MetroFramework.Controls.MetroLabel();
            this.lblTelefon = new MetroFramework.Controls.MetroLabel();
            this.lblMusteriSoyadi = new MetroFramework.Controls.MetroLabel();
            this.lblMusteriAdi = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnTemizle);
            this.metroPanel1.Controls.Add(this.btnKlavye);
            this.metroPanel1.Controls.Add(this.btnIptal);
            this.metroPanel1.Controls.Add(this.btnKaydet);
            this.metroPanel1.Controls.Add(this.txtSifre);
            this.metroPanel1.Controls.Add(this.txtKullaniciAdi);
            this.metroPanel1.Controls.Add(this.txtmail);
            this.metroPanel1.Controls.Add(this.txtadres);
            this.metroPanel1.Controls.Add(this.txttelefon);
            this.metroPanel1.Controls.Add(this.txtsoyisim);
            this.metroPanel1.Controls.Add(this.txtisim);
            this.metroPanel1.Controls.Add(this.lblSifre);
            this.metroPanel1.Controls.Add(this.lblKullaniciAdi);
            this.metroPanel1.Controls.Add(this.lblMail);
            this.metroPanel1.Controls.Add(this.lblAdres);
            this.metroPanel1.Controls.Add(this.lblTelefon);
            this.metroPanel1.Controls.Add(this.lblMusteriSoyadi);
            this.metroPanel1.Controls.Add(this.lblMusteriAdi);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 86);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(840, 577);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(363, 523);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 40);
            this.btnTemizle.TabIndex = 19;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(241, 468);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(370, 36);
            this.btnKlavye.TabIndex = 18;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(486, 523);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 40);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseCustomBackColor = true;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(241, 523);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(125, 40);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtSifre
            // 
            // 
            // 
            // 
            this.txtSifre.CustomButton.Image = null;
            this.txtSifre.CustomButton.Location = new System.Drawing.Point(133, 2);
            this.txtSifre.CustomButton.Name = "";
            this.txtSifre.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSifre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSifre.CustomButton.TabIndex = 1;
            this.txtSifre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSifre.CustomButton.UseSelectable = true;
            this.txtSifre.CustomButton.Visible = false;
            this.txtSifre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSifre.Lines = new string[0];
            this.txtSifre.Location = new System.Drawing.Point(436, 410);
            this.txtSifre.MaxLength = 32767;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '\0';
            this.txtSifre.ReadOnly = true;
            this.txtSifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSifre.SelectedText = "";
            this.txtSifre.SelectionLength = 0;
            this.txtSifre.SelectionStart = 0;
            this.txtSifre.ShortcutsEnabled = true;
            this.txtSifre.Size = new System.Drawing.Size(159, 28);
            this.txtSifre.TabIndex = 15;
            this.txtSifre.UseCustomBackColor = true;
            this.txtSifre.UseCustomForeColor = true;
            this.txtSifre.UseSelectable = true;
            this.txtSifre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSifre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtKullaniciAdi
            // 
            // 
            // 
            // 
            this.txtKullaniciAdi.CustomButton.Image = null;
            this.txtKullaniciAdi.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtKullaniciAdi.CustomButton.Name = "";
            this.txtKullaniciAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKullaniciAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKullaniciAdi.CustomButton.TabIndex = 1;
            this.txtKullaniciAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKullaniciAdi.CustomButton.UseSelectable = true;
            this.txtKullaniciAdi.CustomButton.Visible = false;
            this.txtKullaniciAdi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKullaniciAdi.Lines = new string[0];
            this.txtKullaniciAdi.Location = new System.Drawing.Point(436, 357);
            this.txtKullaniciAdi.MaxLength = 32767;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.PasswordChar = '\0';
            this.txtKullaniciAdi.ReadOnly = true;
            this.txtKullaniciAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKullaniciAdi.SelectedText = "";
            this.txtKullaniciAdi.SelectionLength = 0;
            this.txtKullaniciAdi.SelectionStart = 0;
            this.txtKullaniciAdi.ShortcutsEnabled = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(159, 30);
            this.txtKullaniciAdi.TabIndex = 14;
            this.txtKullaniciAdi.UseCustomBackColor = true;
            this.txtKullaniciAdi.UseCustomForeColor = true;
            this.txtKullaniciAdi.UseSelectable = true;
            this.txtKullaniciAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKullaniciAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // txtmail
            // 
            // 
            // 
            // 
            this.txtmail.CustomButton.Image = null;
            this.txtmail.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtmail.CustomButton.Name = "";
            this.txtmail.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtmail.CustomButton.TabIndex = 1;
            this.txtmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtmail.CustomButton.UseSelectable = true;
            this.txtmail.CustomButton.Visible = false;
            this.txtmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtmail.Lines = new string[0];
            this.txtmail.Location = new System.Drawing.Point(436, 187);
            this.txtmail.MaxLength = 32767;
            this.txtmail.Name = "txtmail";
            this.txtmail.PasswordChar = '\0';
            this.txtmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtmail.SelectedText = "";
            this.txtmail.SelectionLength = 0;
            this.txtmail.SelectionStart = 0;
            this.txtmail.ShortcutsEnabled = true;
            this.txtmail.ShowClearButton = true;
            this.txtmail.Size = new System.Drawing.Size(159, 30);
            this.txtmail.TabIndex = 12;
            this.txtmail.UseCustomBackColor = true;
            this.txtmail.UseCustomForeColor = true;
            this.txtmail.UseSelectable = true;
            this.txtmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtadres
            // 
            // 
            // 
            // 
            this.txtadres.CustomButton.Image = null;
            this.txtadres.CustomButton.Location = new System.Drawing.Point(55, 1);
            this.txtadres.CustomButton.Name = "";
            this.txtadres.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.txtadres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtadres.CustomButton.TabIndex = 1;
            this.txtadres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtadres.CustomButton.UseSelectable = true;
            this.txtadres.CustomButton.Visible = false;
            this.txtadres.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtadres.Lines = new string[0];
            this.txtadres.Location = new System.Drawing.Point(436, 236);
            this.txtadres.MaxLength = 32767;
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.PasswordChar = '\0';
            this.txtadres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtadres.SelectedText = "";
            this.txtadres.SelectionLength = 0;
            this.txtadres.SelectionStart = 0;
            this.txtadres.ShortcutsEnabled = true;
            this.txtadres.ShowClearButton = true;
            this.txtadres.Size = new System.Drawing.Size(159, 105);
            this.txtadres.TabIndex = 13;
            this.txtadres.UseCustomBackColor = true;
            this.txtadres.UseCustomForeColor = true;
            this.txtadres.UseSelectable = true;
            this.txtadres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtadres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txttelefon
            // 
            // 
            // 
            // 
            this.txttelefon.CustomButton.Image = null;
            this.txttelefon.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txttelefon.CustomButton.Name = "";
            this.txttelefon.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txttelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttelefon.CustomButton.TabIndex = 1;
            this.txttelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttelefon.CustomButton.UseSelectable = true;
            this.txttelefon.CustomButton.Visible = false;
            this.txttelefon.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txttelefon.Lines = new string[0];
            this.txttelefon.Location = new System.Drawing.Point(436, 144);
            this.txttelefon.MaxLength = 32767;
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.PasswordChar = '\0';
            this.txttelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttelefon.SelectedText = "";
            this.txttelefon.SelectionLength = 0;
            this.txttelefon.SelectionStart = 0;
            this.txttelefon.ShortcutsEnabled = true;
            this.txttelefon.ShowClearButton = true;
            this.txttelefon.Size = new System.Drawing.Size(159, 30);
            this.txttelefon.TabIndex = 11;
            this.txttelefon.UseCustomBackColor = true;
            this.txttelefon.UseCustomForeColor = true;
            this.txttelefon.UseSelectable = true;
            this.txttelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtsoyisim
            // 
            // 
            // 
            // 
            this.txtsoyisim.CustomButton.Image = null;
            this.txtsoyisim.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtsoyisim.CustomButton.Name = "";
            this.txtsoyisim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtsoyisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsoyisim.CustomButton.TabIndex = 1;
            this.txtsoyisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsoyisim.CustomButton.UseSelectable = true;
            this.txtsoyisim.CustomButton.Visible = false;
            this.txtsoyisim.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtsoyisim.Lines = new string[0];
            this.txtsoyisim.Location = new System.Drawing.Point(436, 93);
            this.txtsoyisim.MaxLength = 32767;
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.PasswordChar = '\0';
            this.txtsoyisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsoyisim.SelectedText = "";
            this.txtsoyisim.SelectionLength = 0;
            this.txtsoyisim.SelectionStart = 0;
            this.txtsoyisim.ShortcutsEnabled = true;
            this.txtsoyisim.ShowClearButton = true;
            this.txtsoyisim.Size = new System.Drawing.Size(159, 30);
            this.txtsoyisim.TabIndex = 10;
            this.txtsoyisim.UseCustomBackColor = true;
            this.txtsoyisim.UseCustomForeColor = true;
            this.txtsoyisim.UseSelectable = true;
            this.txtsoyisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsoyisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsoyisim.TextChanged += new System.EventHandler(this.txtsoyisim_TextChanged);
            // 
            // txtisim
            // 
            // 
            // 
            // 
            this.txtisim.CustomButton.Image = null;
            this.txtisim.CustomButton.Location = new System.Drawing.Point(131, 2);
            this.txtisim.CustomButton.Name = "";
            this.txtisim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtisim.CustomButton.TabIndex = 1;
            this.txtisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtisim.CustomButton.UseSelectable = true;
            this.txtisim.CustomButton.Visible = false;
            this.txtisim.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtisim.Lines = new string[0];
            this.txtisim.Location = new System.Drawing.Point(436, 47);
            this.txtisim.MaxLength = 32767;
            this.txtisim.Name = "txtisim";
            this.txtisim.PasswordChar = '\0';
            this.txtisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtisim.SelectedText = "";
            this.txtisim.SelectionLength = 0;
            this.txtisim.SelectionStart = 0;
            this.txtisim.ShortcutsEnabled = true;
            this.txtisim.ShowClearButton = true;
            this.txtisim.Size = new System.Drawing.Size(159, 30);
            this.txtisim.TabIndex = 9;
            this.txtisim.UseCustomBackColor = true;
            this.txtisim.UseCustomForeColor = true;
            this.txtisim.UseSelectable = true;
            this.txtisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtisim.TextChanged += new System.EventHandler(this.txtisim_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSifre.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSifre.Location = new System.Drawing.Point(244, 410);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(61, 25);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "Şifre :";
            this.lblSifre.UseCustomBackColor = true;
            this.lblSifre.UseCustomForeColor = true;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKullaniciAdi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(244, 355);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(129, 25);
            this.lblKullaniciAdi.TabIndex = 7;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı :";
            this.lblKullaniciAdi.UseCustomBackColor = true;
            this.lblKullaniciAdi.UseCustomForeColor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMail.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMail.Location = new System.Drawing.Point(244, 185);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 25);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail :";
            this.lblMail.UseCustomBackColor = true;
            this.lblMail.UseCustomForeColor = true;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAdres.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdres.Location = new System.Drawing.Point(244, 236);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(67, 25);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres :";
            this.lblAdres.UseCustomBackColor = true;
            this.lblAdres.UseCustomForeColor = true;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTelefon.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTelefon.Location = new System.Drawing.Point(244, 142);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(79, 25);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon :";
            this.lblTelefon.UseCustomBackColor = true;
            this.lblTelefon.UseCustomForeColor = true;
            // 
            // lblMusteriSoyadi
            // 
            this.lblMusteriSoyadi.AutoSize = true;
            this.lblMusteriSoyadi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMusteriSoyadi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMusteriSoyadi.Location = new System.Drawing.Point(244, 91);
            this.lblMusteriSoyadi.Name = "lblMusteriSoyadi";
            this.lblMusteriSoyadi.Size = new System.Drawing.Size(83, 25);
            this.lblMusteriSoyadi.TabIndex = 3;
            this.lblMusteriSoyadi.Text = "Soyisim :";
            this.lblMusteriSoyadi.UseCustomBackColor = true;
            this.lblMusteriSoyadi.UseCustomForeColor = true;
            // 
            // lblMusteriAdi
            // 
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMusteriAdi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMusteriAdi.Location = new System.Drawing.Point(244, 45);
            this.lblMusteriAdi.Name = "lblMusteriAdi";
            this.lblMusteriAdi.Size = new System.Drawing.Size(54, 25);
            this.lblMusteriAdi.TabIndex = 2;
            this.lblMusteriAdi.Text = "İsim :";
            this.lblMusteriAdi.UseCustomBackColor = true;
            this.lblMusteriAdi.UseCustomForeColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // MusteriTanimlamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 686);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "MusteriTanimlamaForm";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriTanimlamaForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblMusteriAdi;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroTextBox txtSifre;
        private MetroFramework.Controls.MetroTextBox txtKullaniciAdi;
        private MetroFramework.Controls.MetroTextBox txtmail;
        private MetroFramework.Controls.MetroTextBox txtadres;
        private MetroFramework.Controls.MetroTextBox txttelefon;
        private MetroFramework.Controls.MetroTextBox txtsoyisim;
        private MetroFramework.Controls.MetroTextBox txtisim;
        private MetroFramework.Controls.MetroLabel lblSifre;
        private MetroFramework.Controls.MetroLabel lblKullaniciAdi;
        private MetroFramework.Controls.MetroLabel lblMail;
        private MetroFramework.Controls.MetroLabel lblAdres;
        private MetroFramework.Controls.MetroLabel lblTelefon;
        private MetroFramework.Controls.MetroLabel lblMusteriSoyadi;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}