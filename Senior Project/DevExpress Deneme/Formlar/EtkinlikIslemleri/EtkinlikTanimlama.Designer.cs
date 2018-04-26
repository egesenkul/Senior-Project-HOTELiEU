namespace Otel_Uygulamasi.Formlar.EtkinlikIslemleri
{
    partial class EtkinlikTanimlama
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
            this.dtEtkinlik = new DevExpress.XtraEditors.DateEdit();
            this.txtKisiLimiti = new MetroFramework.Controls.MetroTextBox();
            this.CheckBoxKisiLimiti = new MetroFramework.Controls.MetroCheckBox();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtEtkinlikAciklama = new MetroFramework.Controls.MetroTextBox();
            this.txtEtkinlikAdı = new MetroFramework.Controls.MetroTextBox();
            this.lblTarih = new MetroFramework.Controls.MetroLabel();
            this.lblKisiLimit = new MetroFramework.Controls.MetroLabel();
            this.lblAciklama = new MetroFramework.Controls.MetroLabel();
            this.lblEtkinlikismi = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEtkinlik.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEtkinlik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dtEtkinlik);
            this.metroPanel1.Controls.Add(this.txtKisiLimiti);
            this.metroPanel1.Controls.Add(this.CheckBoxKisiLimiti);
            this.metroPanel1.Controls.Add(this.btnTemizle);
            this.metroPanel1.Controls.Add(this.btnKlavye);
            this.metroPanel1.Controls.Add(this.btnIptal);
            this.metroPanel1.Controls.Add(this.btnKaydet);
            this.metroPanel1.Controls.Add(this.txtEtkinlikAciklama);
            this.metroPanel1.Controls.Add(this.txtEtkinlikAdı);
            this.metroPanel1.Controls.Add(this.lblTarih);
            this.metroPanel1.Controls.Add(this.lblKisiLimit);
            this.metroPanel1.Controls.Add(this.lblAciklama);
            this.metroPanel1.Controls.Add(this.lblEtkinlikismi);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(829, 692);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dtEtkinlik
            // 
            this.dtEtkinlik.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtEtkinlik.EditValue = new System.DateTime(2018, 3, 2, 0, 0, 0, 0);
            this.dtEtkinlik.Location = new System.Drawing.Point(431, 377);
            this.dtEtkinlik.Margin = new System.Windows.Forms.Padding(2);
            this.dtEtkinlik.Name = "dtEtkinlik";
            this.dtEtkinlik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.dtEtkinlik.Properties.Appearance.Options.UseFont = true;
            this.dtEtkinlik.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEtkinlik.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEtkinlik.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dtEtkinlik.Properties.DisplayFormat.FormatString = "g";
            this.dtEtkinlik.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtEtkinlik.Properties.EditFormat.FormatString = "g";
            this.dtEtkinlik.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dtEtkinlik.Properties.Mask.EditMask = "g";
            this.dtEtkinlik.Properties.NullDate = new System.DateTime(2017, 11, 30, 13, 12, 44, 361);
            this.dtEtkinlik.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dtEtkinlik.Size = new System.Drawing.Size(164, 26);
            this.dtEtkinlik.TabIndex = 32;
            // 
            // txtKisiLimiti
            // 
            this.txtKisiLimiti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtKisiLimiti.CustomButton.Image = null;
            this.txtKisiLimiti.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtKisiLimiti.CustomButton.Name = "";
            this.txtKisiLimiti.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKisiLimiti.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKisiLimiti.CustomButton.TabIndex = 1;
            this.txtKisiLimiti.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKisiLimiti.CustomButton.UseSelectable = true;
            this.txtKisiLimiti.CustomButton.Visible = false;
            this.txtKisiLimiti.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKisiLimiti.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtKisiLimiti.Lines = new string[0];
            this.txtKisiLimiti.Location = new System.Drawing.Point(431, 328);
            this.txtKisiLimiti.MaxLength = 32767;
            this.txtKisiLimiti.Name = "txtKisiLimiti";
            this.txtKisiLimiti.PasswordChar = '\0';
            this.txtKisiLimiti.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKisiLimiti.SelectedText = "";
            this.txtKisiLimiti.SelectionLength = 0;
            this.txtKisiLimiti.SelectionStart = 0;
            this.txtKisiLimiti.ShortcutsEnabled = true;
            this.txtKisiLimiti.ShowClearButton = true;
            this.txtKisiLimiti.Size = new System.Drawing.Size(164, 30);
            this.txtKisiLimiti.TabIndex = 25;
            this.txtKisiLimiti.UseCustomBackColor = true;
            this.txtKisiLimiti.UseCustomForeColor = true;
            this.txtKisiLimiti.UseSelectable = true;
            this.txtKisiLimiti.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKisiLimiti.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CheckBoxKisiLimiti
            // 
            this.CheckBoxKisiLimiti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckBoxKisiLimiti.AutoSize = true;
            this.CheckBoxKisiLimiti.Checked = true;
            this.CheckBoxKisiLimiti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxKisiLimiti.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.CheckBoxKisiLimiti.Location = new System.Drawing.Point(224, 285);
            this.CheckBoxKisiLimiti.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.CheckBoxKisiLimiti.Name = "CheckBoxKisiLimiti";
            this.CheckBoxKisiLimiti.Size = new System.Drawing.Size(132, 25);
            this.CheckBoxKisiLimiti.TabIndex = 24;
            this.CheckBoxKisiLimiti.Text = "Kişi Limiti Var";
            this.CheckBoxKisiLimiti.UseCustomBackColor = true;
            this.CheckBoxKisiLimiti.UseCustomForeColor = true;
            this.CheckBoxKisiLimiti.UseSelectable = true;
            this.CheckBoxKisiLimiti.CheckedChanged += new System.EventHandler(this.CheckBoxOzelGonderim_CheckedChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTemizle.Location = new System.Drawing.Point(347, 503);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 40);
            this.btnTemizle.TabIndex = 23;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(224, 452);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(370, 36);
            this.btnKlavye.TabIndex = 22;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(470, 503);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(125, 40);
            this.btnIptal.TabIndex = 21;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseCustomBackColor = true;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(224, 503);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(125, 40);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtEtkinlikAciklama
            // 
            this.txtEtkinlikAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtEtkinlikAciklama.CustomButton.Image = null;
            this.txtEtkinlikAciklama.CustomButton.Location = new System.Drawing.Point(40, 2);
            this.txtEtkinlikAciklama.CustomButton.Name = "";
            this.txtEtkinlikAciklama.CustomButton.Size = new System.Drawing.Size(121, 121);
            this.txtEtkinlikAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEtkinlikAciklama.CustomButton.TabIndex = 1;
            this.txtEtkinlikAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEtkinlikAciklama.CustomButton.UseSelectable = true;
            this.txtEtkinlikAciklama.CustomButton.Visible = false;
            this.txtEtkinlikAciklama.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEtkinlikAciklama.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtEtkinlikAciklama.Lines = new string[0];
            this.txtEtkinlikAciklama.Location = new System.Drawing.Point(431, 153);
            this.txtEtkinlikAciklama.MaxLength = 32767;
            this.txtEtkinlikAciklama.Multiline = true;
            this.txtEtkinlikAciklama.Name = "txtEtkinlikAciklama";
            this.txtEtkinlikAciklama.PasswordChar = '\0';
            this.txtEtkinlikAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEtkinlikAciklama.SelectedText = "";
            this.txtEtkinlikAciklama.SelectionLength = 0;
            this.txtEtkinlikAciklama.SelectionStart = 0;
            this.txtEtkinlikAciklama.ShortcutsEnabled = true;
            this.txtEtkinlikAciklama.ShowClearButton = true;
            this.txtEtkinlikAciklama.Size = new System.Drawing.Size(164, 126);
            this.txtEtkinlikAciklama.TabIndex = 7;
            this.txtEtkinlikAciklama.UseCustomBackColor = true;
            this.txtEtkinlikAciklama.UseCustomForeColor = true;
            this.txtEtkinlikAciklama.UseSelectable = true;
            this.txtEtkinlikAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEtkinlikAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEtkinlikAdı
            // 
            this.txtEtkinlikAdı.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtEtkinlikAdı.CustomButton.Image = null;
            this.txtEtkinlikAdı.CustomButton.Location = new System.Drawing.Point(136, 2);
            this.txtEtkinlikAdı.CustomButton.Name = "";
            this.txtEtkinlikAdı.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtEtkinlikAdı.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEtkinlikAdı.CustomButton.TabIndex = 1;
            this.txtEtkinlikAdı.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEtkinlikAdı.CustomButton.UseSelectable = true;
            this.txtEtkinlikAdı.CustomButton.Visible = false;
            this.txtEtkinlikAdı.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEtkinlikAdı.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtEtkinlikAdı.Lines = new string[0];
            this.txtEtkinlikAdı.Location = new System.Drawing.Point(431, 105);
            this.txtEtkinlikAdı.MaxLength = 32767;
            this.txtEtkinlikAdı.Name = "txtEtkinlikAdı";
            this.txtEtkinlikAdı.PasswordChar = '\0';
            this.txtEtkinlikAdı.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEtkinlikAdı.SelectedText = "";
            this.txtEtkinlikAdı.SelectionLength = 0;
            this.txtEtkinlikAdı.SelectionStart = 0;
            this.txtEtkinlikAdı.ShortcutsEnabled = true;
            this.txtEtkinlikAdı.ShowClearButton = true;
            this.txtEtkinlikAdı.Size = new System.Drawing.Size(164, 30);
            this.txtEtkinlikAdı.TabIndex = 6;
            this.txtEtkinlikAdı.UseCustomBackColor = true;
            this.txtEtkinlikAdı.UseCustomForeColor = true;
            this.txtEtkinlikAdı.UseSelectable = true;
            this.txtEtkinlikAdı.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEtkinlikAdı.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTarih
            // 
            this.lblTarih.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTarih.AutoSize = true;
            this.lblTarih.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTarih.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTarih.Location = new System.Drawing.Point(224, 378);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(59, 25);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Tarih :";
            this.lblTarih.UseCustomBackColor = true;
            this.lblTarih.UseCustomForeColor = true;
            // 
            // lblKisiLimit
            // 
            this.lblKisiLimit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKisiLimit.AutoSize = true;
            this.lblKisiLimit.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKisiLimit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKisiLimit.Location = new System.Drawing.Point(224, 328);
            this.lblKisiLimit.Name = "lblKisiLimit";
            this.lblKisiLimit.Size = new System.Drawing.Size(94, 25);
            this.lblKisiLimit.TabIndex = 4;
            this.lblKisiLimit.Text = "Kişi Limiti :";
            this.lblKisiLimit.UseCustomBackColor = true;
            this.lblKisiLimit.UseCustomForeColor = true;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAciklama.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAciklama.Location = new System.Drawing.Point(224, 153);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(104, 25);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklaması :";
            this.lblAciklama.UseCustomBackColor = true;
            this.lblAciklama.UseCustomForeColor = true;
            // 
            // lblEtkinlikismi
            // 
            this.lblEtkinlikismi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEtkinlikismi.AutoSize = true;
            this.lblEtkinlikismi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEtkinlikismi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEtkinlikismi.Location = new System.Drawing.Point(224, 105);
            this.lblEtkinlikismi.Name = "lblEtkinlikismi";
            this.lblEtkinlikismi.Size = new System.Drawing.Size(114, 25);
            this.lblEtkinlikismi.TabIndex = 2;
            this.lblEtkinlikismi.Text = "Etkinlik İsmi :";
            this.lblEtkinlikismi.UseCustomBackColor = true;
            this.lblEtkinlikismi.UseCustomForeColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // EtkinlikTanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 772);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "EtkinlikTanimlama";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EtkinlikTanimlama_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEtkinlik.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEtkinlik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtEtkinlikAciklama;
        private MetroFramework.Controls.MetroTextBox txtEtkinlikAdı;
        private MetroFramework.Controls.MetroLabel lblTarih;
        private MetroFramework.Controls.MetroLabel lblKisiLimit;
        private MetroFramework.Controls.MetroLabel lblAciklama;
        private MetroFramework.Controls.MetroLabel lblEtkinlikismi;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroCheckBox CheckBoxKisiLimiti;
        private MetroFramework.Controls.MetroTextBox txtKisiLimiti;
        private DevExpress.XtraEditors.DateEdit dtEtkinlik;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}