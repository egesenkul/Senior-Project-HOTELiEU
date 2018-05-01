namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    partial class KategoriTanimlamalari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KategoriTanimlamalari));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.cmbKategoriBolum = new MetroFramework.Controls.MetroComboBox();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtisim = new MetroFramework.Controls.MetroTextBox();
            this.lblBolumeAitKategori = new MetroFramework.Controls.MetroLabel();
            this.lblKategoriAitBolum = new MetroFramework.Controls.MetroLabel();
            this.lblKategoriAdi = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroListView1);
            this.metroPanel1.Controls.Add(this.cmbKategoriBolum);
            this.metroPanel1.Controls.Add(this.btnTemizle);
            this.metroPanel1.Controls.Add(this.btnKlavye);
            this.metroPanel1.Controls.Add(this.btnIptal);
            this.metroPanel1.Controls.Add(this.btnKaydet);
            this.metroPanel1.Controls.Add(this.txtisim);
            this.metroPanel1.Controls.Add(this.lblBolumeAitKategori);
            this.metroPanel1.Controls.Add(this.lblKategoriAitBolum);
            this.metroPanel1.Controls.Add(this.lblKategoriAdi);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1085, 539);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.metroListView1.Location = new System.Drawing.Point(506, 183);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(341, 167);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Tile;
            // 
            // cmbKategoriBolum
            // 
            this.cmbKategoriBolum.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbKategoriBolum.FormattingEnabled = true;
            this.cmbKategoriBolum.ItemHeight = 29;
            this.cmbKategoriBolum.Location = new System.Drawing.Point(506, 116);
            this.cmbKategoriBolum.Name = "cmbKategoriBolum";
            this.cmbKategoriBolum.Size = new System.Drawing.Size(341, 35);
            this.cmbKategoriBolum.TabIndex = 1;
            this.cmbKategoriBolum.UseCustomBackColor = true;
            this.cmbKategoriBolum.UseCustomForeColor = true;
            this.cmbKategoriBolum.UseSelectable = true;
            this.cmbKategoriBolum.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriBolum_SelectedIndexChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(432, 457);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(169, 40);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(215, 394);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(594, 36);
            this.btnKlavye.TabIndex = 6;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.Red;
            this.btnIptal.Location = new System.Drawing.Point(628, 457);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(181, 40);
            this.btnIptal.TabIndex = 4;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseCustomBackColor = true;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(215, 457);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(187, 40);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtisim
            // 
            // 
            // 
            // 
            this.txtisim.CustomButton.Image = null;
            this.txtisim.CustomButton.Location = new System.Drawing.Point(313, 2);
            this.txtisim.CustomButton.Name = "";
            this.txtisim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtisim.CustomButton.TabIndex = 1;
            this.txtisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtisim.CustomButton.UseSelectable = true;
            this.txtisim.CustomButton.Visible = false;
            this.txtisim.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtisim.Lines = new string[0];
            this.txtisim.Location = new System.Drawing.Point(506, 52);
            this.txtisim.MaxLength = 32767;
            this.txtisim.Name = "txtisim";
            this.txtisim.PasswordChar = '\0';
            this.txtisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtisim.SelectedText = "";
            this.txtisim.SelectionLength = 0;
            this.txtisim.SelectionStart = 0;
            this.txtisim.ShortcutsEnabled = true;
            this.txtisim.ShowClearButton = true;
            this.txtisim.Size = new System.Drawing.Size(341, 30);
            this.txtisim.TabIndex = 0;
            this.txtisim.UseCustomBackColor = true;
            this.txtisim.UseCustomForeColor = true;
            this.txtisim.UseSelectable = true;
            this.txtisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBolumeAitKategori
            // 
            this.lblBolumeAitKategori.AutoSize = true;
            this.lblBolumeAitKategori.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBolumeAitKategori.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBolumeAitKategori.Location = new System.Drawing.Point(159, 183);
            this.lblBolumeAitKategori.Name = "lblBolumeAitKategori";
            this.lblBolumeAitKategori.Size = new System.Drawing.Size(198, 25);
            this.lblBolumeAitKategori.TabIndex = 5;
            this.lblBolumeAitKategori.Text = "Bölüme Ait Kategoriler :";
            this.lblBolumeAitKategori.UseCustomBackColor = true;
            this.lblBolumeAitKategori.UseCustomForeColor = true;
            // 
            // lblKategoriAitBolum
            // 
            this.lblKategoriAitBolum.AutoSize = true;
            this.lblKategoriAitBolum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKategoriAitBolum.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKategoriAitBolum.Location = new System.Drawing.Point(159, 116);
            this.lblKategoriAitBolum.Name = "lblKategoriAitBolum";
            this.lblKategoriAitBolum.Size = new System.Drawing.Size(164, 25);
            this.lblKategoriAitBolum.TabIndex = 3;
            this.lblKategoriAitBolum.Text = "Ait Olduğu Bölüm :";
            this.lblKategoriAitBolum.UseCustomBackColor = true;
            this.lblKategoriAitBolum.UseCustomForeColor = true;
            // 
            // lblKategoriAdi
            // 
            this.lblKategoriAdi.AutoSize = true;
            this.lblKategoriAdi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKategoriAdi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKategoriAdi.Location = new System.Drawing.Point(159, 50);
            this.lblKategoriAdi.Name = "lblKategoriAdi";
            this.lblKategoriAdi.Size = new System.Drawing.Size(125, 25);
            this.lblKategoriAdi.TabIndex = 2;
            this.lblKategoriAdi.Text = "Kategori İsmi :";
            this.lblKategoriAdi.UseCustomBackColor = true;
            this.lblKategoriAdi.UseCustomForeColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // KategoriTanimlamalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 619);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "KategoriTanimlamalari";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.KategoriTanimlamalari_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroComboBox cmbKategoriBolum;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroTextBox txtisim;
        private MetroFramework.Controls.MetroLabel lblBolumeAitKategori;
        private MetroFramework.Controls.MetroLabel lblKategoriAitBolum;
        private MetroFramework.Controls.MetroLabel lblKategoriAdi;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}