namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    partial class AyarlarYetki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyarlarYetki));
            this.lblKullanıcıListesi = new MetroFramework.Controls.MetroLabel();
            this.ListeKullanicilar = new MetroFramework.Controls.MetroListView();
            this.lblKullaniciDepartman = new MetroFramework.Controls.MetroLabel();
            this.cmbKullaniciDepartman = new MetroFramework.Controls.MetroComboBox();
            this.lblTanımlıYetki = new MetroFramework.Controls.MetroLabel();
            this.lblYetki = new MetroFramework.Controls.MetroLabel();
            this.lblYetkiler = new MetroFramework.Controls.MetroLabel();
            this.cmbYetki = new MetroFramework.Controls.MetroComboBox();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKullanıcıListesi
            // 
            this.lblKullanıcıListesi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKullanıcıListesi.AutoSize = true;
            this.lblKullanıcıListesi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKullanıcıListesi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKullanıcıListesi.Location = new System.Drawing.Point(30, 200);
            this.lblKullanıcıListesi.Name = "lblKullanıcıListesi";
            this.lblKullanıcıListesi.Size = new System.Drawing.Size(136, 25);
            this.lblKullanıcıListesi.TabIndex = 29;
            this.lblKullanıcıListesi.Text = "Kullanıcı Listesi :";
            this.lblKullanıcıListesi.UseCustomBackColor = true;
            this.lblKullanıcıListesi.UseCustomForeColor = true;
            // 
            // ListeKullanicilar
            // 
            this.ListeKullanicilar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ListeKullanicilar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListeKullanicilar.FullRowSelect = true;
            this.ListeKullanicilar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListeKullanicilar.Location = new System.Drawing.Point(275, 200);
            this.ListeKullanicilar.MultiSelect = false;
            this.ListeKullanicilar.Name = "ListeKullanicilar";
            this.ListeKullanicilar.OwnerDraw = true;
            this.ListeKullanicilar.Size = new System.Drawing.Size(303, 244);
            this.ListeKullanicilar.TabIndex = 1;
            this.ListeKullanicilar.UseCompatibleStateImageBehavior = false;
            this.ListeKullanicilar.UseCustomBackColor = true;
            this.ListeKullanicilar.UseCustomForeColor = true;
            this.ListeKullanicilar.UseSelectable = true;
            this.ListeKullanicilar.View = System.Windows.Forms.View.Tile;
            this.ListeKullanicilar.SelectedIndexChanged += new System.EventHandler(this.ListeKullanicilar_SelectedIndexChanged);
            // 
            // lblKullaniciDepartman
            // 
            this.lblKullaniciDepartman.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKullaniciDepartman.AutoSize = true;
            this.lblKullaniciDepartman.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKullaniciDepartman.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKullaniciDepartman.Location = new System.Drawing.Point(30, 110);
            this.lblKullaniciDepartman.Name = "lblKullaniciDepartman";
            this.lblKullaniciDepartman.Size = new System.Drawing.Size(182, 25);
            this.lblKullaniciDepartman.TabIndex = 31;
            this.lblKullaniciDepartman.Text = "Kullanıcı Departmanı :";
            this.lblKullaniciDepartman.UseCustomBackColor = true;
            this.lblKullaniciDepartman.UseCustomForeColor = true;
            // 
            // cmbKullaniciDepartman
            // 
            this.cmbKullaniciDepartman.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbKullaniciDepartman.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbKullaniciDepartman.FormattingEnabled = true;
            this.cmbKullaniciDepartman.ItemHeight = 29;
            this.cmbKullaniciDepartman.Location = new System.Drawing.Point(275, 110);
            this.cmbKullaniciDepartman.Name = "cmbKullaniciDepartman";
            this.cmbKullaniciDepartman.Size = new System.Drawing.Size(303, 35);
            this.cmbKullaniciDepartman.TabIndex = 0;
            this.cmbKullaniciDepartman.UseCustomBackColor = true;
            this.cmbKullaniciDepartman.UseCustomForeColor = true;
            this.cmbKullaniciDepartman.UseSelectable = true;
            this.cmbKullaniciDepartman.SelectedIndexChanged += new System.EventHandler(this.cmbKullaniciDepartman_SelectedIndexChanged);
            // 
            // lblTanımlıYetki
            // 
            this.lblTanımlıYetki.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTanımlıYetki.AutoSize = true;
            this.lblTanımlıYetki.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTanımlıYetki.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTanımlıYetki.Location = new System.Drawing.Point(667, 214);
            this.lblTanımlıYetki.Name = "lblTanımlıYetki";
            this.lblTanımlıYetki.Size = new System.Drawing.Size(120, 25);
            this.lblTanımlıYetki.TabIndex = 33;
            this.lblTanımlıYetki.Text = "Tanımlı Yetki :";
            this.lblTanımlıYetki.UseCustomBackColor = true;
            this.lblTanımlıYetki.UseCustomForeColor = true;
            // 
            // lblYetki
            // 
            this.lblYetki.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYetki.AutoSize = true;
            this.lblYetki.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblYetki.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblYetki.Location = new System.Drawing.Point(840, 214);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(89, 25);
            this.lblYetki.TabIndex = 34;
            this.lblYetki.Text = "Yetki Adı";
            this.lblYetki.UseCustomBackColor = true;
            this.lblYetki.UseCustomForeColor = true;
            // 
            // lblYetkiler
            // 
            this.lblYetkiler.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblYetkiler.AutoSize = true;
            this.lblYetkiler.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblYetkiler.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblYetkiler.Location = new System.Drawing.Point(667, 294);
            this.lblYetkiler.Name = "lblYetkiler";
            this.lblYetkiler.Size = new System.Drawing.Size(78, 25);
            this.lblYetkiler.TabIndex = 35;
            this.lblYetkiler.Text = "Yetkiler :";
            this.lblYetkiler.UseCustomBackColor = true;
            this.lblYetkiler.UseCustomForeColor = true;
            // 
            // cmbYetki
            // 
            this.cmbYetki.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbYetki.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbYetki.FormattingEnabled = true;
            this.cmbYetki.ItemHeight = 29;
            this.cmbYetki.Location = new System.Drawing.Point(840, 294);
            this.cmbYetki.Name = "cmbYetki";
            this.cmbYetki.Size = new System.Drawing.Size(169, 35);
            this.cmbYetki.TabIndex = 2;
            this.cmbYetki.UseCustomBackColor = true;
            this.cmbYetki.UseCustomForeColor = true;
            this.cmbYetki.UseSelectable = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.Location = new System.Drawing.Point(506, 570);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(135, 40);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(358, 570);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(358, 504);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(431, 36);
            this.btnKlavye.TabIndex = 6;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(653, 570);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(135, 40);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseCustomBackColor = true;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // AyarlarYetki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 633);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKlavye);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.cmbYetki);
            this.Controls.Add(this.lblYetkiler);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblTanımlıYetki);
            this.Controls.Add(this.cmbKullaniciDepartman);
            this.Controls.Add(this.lblKullaniciDepartman);
            this.Controls.Add(this.lblKullanıcıListesi);
            this.Controls.Add(this.ListeKullanicilar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AyarlarYetki";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.AyarlarYetki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblKullanıcıListesi;
        private MetroFramework.Controls.MetroListView ListeKullanicilar;
        private MetroFramework.Controls.MetroLabel lblKullaniciDepartman;
        private MetroFramework.Controls.MetroComboBox cmbKullaniciDepartman;
        private MetroFramework.Controls.MetroLabel lblTanımlıYetki;
        private MetroFramework.Controls.MetroLabel lblYetki;
        private MetroFramework.Controls.MetroLabel lblYetkiler;
        private MetroFramework.Controls.MetroComboBox cmbYetki;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}