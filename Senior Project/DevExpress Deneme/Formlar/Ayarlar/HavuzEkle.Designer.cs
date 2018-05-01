namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    partial class HavuzEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HavuzEkle));
            this.ListeHavuzlar = new MetroFramework.Controls.MetroListView();
            this.lblHavuzlar = new MetroFramework.Controls.MetroLabel();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnIptal = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.txtisim = new MetroFramework.Controls.MetroTextBox();
            this.lblHavuzAdı = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenlePersoneliGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKayıtlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKaydıGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSecenekler = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.jsonUrl = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListeHavuzlar
            // 
            this.ListeHavuzlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeHavuzlar.BackColor = System.Drawing.SystemColors.Window;
            this.ListeHavuzlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListeHavuzlar.FullRowSelect = true;
            this.ListeHavuzlar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListeHavuzlar.Location = new System.Drawing.Point(541, 150);
            this.ListeHavuzlar.MultiSelect = false;
            this.ListeHavuzlar.Name = "ListeHavuzlar";
            this.ListeHavuzlar.OwnerDraw = true;
            this.ListeHavuzlar.Size = new System.Drawing.Size(238, 155);
            this.ListeHavuzlar.TabIndex = 0;
            this.ListeHavuzlar.UseCompatibleStateImageBehavior = false;
            this.ListeHavuzlar.UseCustomBackColor = true;
            this.ListeHavuzlar.UseCustomForeColor = true;
            this.ListeHavuzlar.UseSelectable = true;
            this.ListeHavuzlar.View = System.Windows.Forms.View.Tile;
            this.ListeHavuzlar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListeHavuzlar_MouseClick);
            // 
            // lblHavuzlar
            // 
            this.lblHavuzlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHavuzlar.AutoSize = true;
            this.lblHavuzlar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHavuzlar.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHavuzlar.Location = new System.Drawing.Point(347, 150);
            this.lblHavuzlar.Name = "lblHavuzlar";
            this.lblHavuzlar.Size = new System.Drawing.Size(89, 25);
            this.lblHavuzlar.TabIndex = 27;
            this.lblHavuzlar.Text = "Havuzlar :";
            this.lblHavuzlar.UseCustomBackColor = true;
            this.lblHavuzlar.UseCustomForeColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.Location = new System.Drawing.Point(499, 569);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(135, 40);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(351, 503);
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
            this.btnIptal.Location = new System.Drawing.Point(646, 569);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(135, 40);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseCustomBackColor = true;
            this.btnIptal.UseSelectable = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(351, 569);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtisim
            // 
            this.txtisim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtisim.CustomButton.Image = null;
            this.txtisim.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.txtisim.CustomButton.Name = "";
            this.txtisim.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtisim.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtisim.CustomButton.TabIndex = 1;
            this.txtisim.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtisim.CustomButton.UseSelectable = true;
            this.txtisim.CustomButton.Visible = false;
            this.txtisim.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtisim.Lines = new string[0];
            this.txtisim.Location = new System.Drawing.Point(541, 326);
            this.txtisim.MaxLength = 32767;
            this.txtisim.Name = "txtisim";
            this.txtisim.PasswordChar = '\0';
            this.txtisim.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtisim.SelectedText = "";
            this.txtisim.SelectionLength = 0;
            this.txtisim.SelectionStart = 0;
            this.txtisim.ShortcutsEnabled = true;
            this.txtisim.ShowClearButton = true;
            this.txtisim.Size = new System.Drawing.Size(237, 30);
            this.txtisim.TabIndex = 1;
            this.txtisim.UseCustomBackColor = true;
            this.txtisim.UseCustomForeColor = true;
            this.txtisim.UseSelectable = true;
            this.txtisim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtisim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblHavuzAdı
            // 
            this.lblHavuzAdı.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHavuzAdı.AutoSize = true;
            this.lblHavuzAdı.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblHavuzAdı.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblHavuzAdı.Location = new System.Drawing.Point(347, 332);
            this.lblHavuzAdı.Name = "lblHavuzAdı";
            this.lblHavuzAdı.Size = new System.Drawing.Size(102, 25);
            this.lblHavuzAdı.TabIndex = 2;
            this.lblHavuzAdı.Text = "Havuz Adı :";
            this.lblHavuzAdı.UseCustomBackColor = true;
            this.lblHavuzAdı.UseCustomForeColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenlePersoneliGeriAlToolStripMenuItem,
            this.silToolStripMenuItem,
            this.silinmişKayıtlarıGösterToolStripMenuItem,
            this.silinmişKaydıGeriAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(246, 108);
            // 
            // düzenlePersoneliGeriAlToolStripMenuItem
            // 
            this.düzenlePersoneliGeriAlToolStripMenuItem.Name = "düzenlePersoneliGeriAlToolStripMenuItem";
            this.düzenlePersoneliGeriAlToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.düzenlePersoneliGeriAlToolStripMenuItem.Text = "Düzenle";
            this.düzenlePersoneliGeriAlToolStripMenuItem.Click += new System.EventHandler(this.düzenlePersoneliGeriAlToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // silinmişKayıtlarıGösterToolStripMenuItem
            // 
            this.silinmişKayıtlarıGösterToolStripMenuItem.Name = "silinmişKayıtlarıGösterToolStripMenuItem";
            this.silinmişKayıtlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.silinmişKayıtlarıGösterToolStripMenuItem.Text = "Silinmiş Kayıtları Göster";
            this.silinmişKayıtlarıGösterToolStripMenuItem.Click += new System.EventHandler(this.silinmişKayıtlarıGösterToolStripMenuItem_Click);
            // 
            // silinmişKaydıGeriAlToolStripMenuItem
            // 
            this.silinmişKaydıGeriAlToolStripMenuItem.Name = "silinmişKaydıGeriAlToolStripMenuItem";
            this.silinmişKaydıGeriAlToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.silinmişKaydıGeriAlToolStripMenuItem.Text = "Silinmiş Kaydı Geri Al";
            this.silinmişKaydıGeriAlToolStripMenuItem.Click += new System.EventHandler(this.silinmişKaydıGeriAlToolStripMenuItem_Click);
            // 
            // btnSecenekler
            // 
            this.btnSecenekler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSecenekler.Location = new System.Drawing.Point(509, 438);
            this.btnSecenekler.Name = "btnSecenekler";
            this.btnSecenekler.Size = new System.Drawing.Size(125, 40);
            this.btnSecenekler.TabIndex = 5;
            this.btnSecenekler.Text = "Seçenekler";
            this.btnSecenekler.UseSelectable = true;
            this.btnSecenekler.Click += new System.EventHandler(this.btnSecenekler_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(347, 387);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 25);
            this.metroLabel1.TabIndex = 29;
            this.metroLabel1.Text = "JSON URL :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // jsonUrl
            // 
            this.jsonUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.jsonUrl.CustomButton.Image = null;
            this.jsonUrl.CustomButton.Location = new System.Drawing.Point(209, 2);
            this.jsonUrl.CustomButton.Name = "";
            this.jsonUrl.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.jsonUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.jsonUrl.CustomButton.TabIndex = 1;
            this.jsonUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.jsonUrl.CustomButton.UseSelectable = true;
            this.jsonUrl.CustomButton.Visible = false;
            this.jsonUrl.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.jsonUrl.Lines = new string[0];
            this.jsonUrl.Location = new System.Drawing.Point(541, 381);
            this.jsonUrl.MaxLength = 32767;
            this.jsonUrl.Name = "jsonUrl";
            this.jsonUrl.PasswordChar = '\0';
            this.jsonUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.jsonUrl.SelectedText = "";
            this.jsonUrl.SelectionLength = 0;
            this.jsonUrl.SelectionStart = 0;
            this.jsonUrl.ShortcutsEnabled = true;
            this.jsonUrl.ShowClearButton = true;
            this.jsonUrl.Size = new System.Drawing.Size(237, 30);
            this.jsonUrl.TabIndex = 28;
            this.jsonUrl.UseCustomBackColor = true;
            this.jsonUrl.UseCustomForeColor = true;
            this.jsonUrl.UseSelectable = true;
            this.jsonUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.jsonUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // HavuzEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 629);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.jsonUrl);
            this.Controls.Add(this.btnSecenekler);
            this.Controls.Add(this.lblHavuzlar);
            this.Controls.Add(this.ListeHavuzlar);
            this.Controls.Add(this.lblHavuzAdı);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnKlavye);
            this.Controls.Add(this.btnIptal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "HavuzEkle";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.HavuzEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroListView ListeHavuzlar;
        private MetroFramework.Controls.MetroLabel lblHavuzlar;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnIptal;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroTextBox txtisim;
        private MetroFramework.Controls.MetroLabel lblHavuzAdı;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenlePersoneliGeriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişKayıtlarıGösterToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnSecenekler;
        private System.Windows.Forms.ToolStripMenuItem silinmişKaydıGeriAlToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox jsonUrl;
    }
}