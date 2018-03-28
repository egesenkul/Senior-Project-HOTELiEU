namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    partial class blokEkle
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
            this.btnSecenekler = new MetroFramework.Controls.MetroButton();
            this.lblBlokListesi = new MetroFramework.Controls.MetroLabel();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.txtBlokAdi = new MetroFramework.Controls.MetroTextBox();
            this.lblBlokAdı = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenlePersoneliGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKayıtlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKayıtlarıGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSecenekler
            // 
            this.btnSecenekler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSecenekler.Location = new System.Drawing.Point(310, 301);
            this.btnSecenekler.Name = "btnSecenekler";
            this.btnSecenekler.Size = new System.Drawing.Size(125, 40);
            this.btnSecenekler.TabIndex = 5;
            this.btnSecenekler.Text = "Seçenekler";
            this.btnSecenekler.UseSelectable = true;
            this.btnSecenekler.Click += new System.EventHandler(this.btnSecenekler_Click);
            // 
            // lblBlokListesi
            // 
            this.lblBlokListesi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlokListesi.AutoSize = true;
            this.lblBlokListesi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBlokListesi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBlokListesi.Location = new System.Drawing.Point(281, 218);
            this.lblBlokListesi.Name = "lblBlokListesi";
            this.lblBlokListesi.Size = new System.Drawing.Size(107, 25);
            this.lblBlokListesi.TabIndex = 42;
            this.lblBlokListesi.Text = "Blok Listesi :";
            this.lblBlokListesi.UseCustomBackColor = true;
            this.lblBlokListesi.UseCustomForeColor = true;
            // 
            // metroListView1
            // 
            this.metroListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.metroListView1.Location = new System.Drawing.Point(512, 218);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(341, 167);
            this.metroListView1.TabIndex = 1;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.Tile;
            this.metroListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroListView1_MouseClick);
            // 
            // txtBlokAdi
            // 
            this.txtBlokAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtBlokAdi.CustomButton.Image = null;
            this.txtBlokAdi.CustomButton.Location = new System.Drawing.Point(312, 2);
            this.txtBlokAdi.CustomButton.Name = "";
            this.txtBlokAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtBlokAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBlokAdi.CustomButton.TabIndex = 1;
            this.txtBlokAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBlokAdi.CustomButton.UseSelectable = true;
            this.txtBlokAdi.CustomButton.Visible = false;
            this.txtBlokAdi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBlokAdi.Lines = new string[0];
            this.txtBlokAdi.Location = new System.Drawing.Point(513, 139);
            this.txtBlokAdi.MaxLength = 32767;
            this.txtBlokAdi.Name = "txtBlokAdi";
            this.txtBlokAdi.PasswordChar = '\0';
            this.txtBlokAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBlokAdi.SelectedText = "";
            this.txtBlokAdi.SelectionLength = 0;
            this.txtBlokAdi.SelectionStart = 0;
            this.txtBlokAdi.ShortcutsEnabled = true;
            this.txtBlokAdi.ShowClearButton = true;
            this.txtBlokAdi.Size = new System.Drawing.Size(340, 30);
            this.txtBlokAdi.TabIndex = 0;
            this.txtBlokAdi.UseCustomBackColor = true;
            this.txtBlokAdi.UseCustomForeColor = true;
            this.txtBlokAdi.UseSelectable = true;
            this.txtBlokAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBlokAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBlokAdı
            // 
            this.lblBlokAdı.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlokAdı.AutoSize = true;
            this.lblBlokAdı.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBlokAdı.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBlokAdı.Location = new System.Drawing.Point(281, 144);
            this.lblBlokAdı.Name = "lblBlokAdı";
            this.lblBlokAdı.Size = new System.Drawing.Size(87, 25);
            this.lblBlokAdı.TabIndex = 33;
            this.lblBlokAdı.Text = "Blok Adı :";
            this.lblBlokAdı.UseCustomBackColor = true;
            this.lblBlokAdı.UseCustomForeColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenlePersoneliGeriAlToolStripMenuItem,
            this.silToolStripMenuItem,
            this.silinmişKayıtlarıGösterToolStripMenuItem,
            this.silinmişKayıtlarıGeriAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(247, 108);
            // 
            // düzenlePersoneliGeriAlToolStripMenuItem
            // 
            this.düzenlePersoneliGeriAlToolStripMenuItem.Name = "düzenlePersoneliGeriAlToolStripMenuItem";
            this.düzenlePersoneliGeriAlToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.düzenlePersoneliGeriAlToolStripMenuItem.Text = "Düzenle";
            this.düzenlePersoneliGeriAlToolStripMenuItem.Click += new System.EventHandler(this.düzenlePersoneliGeriAlToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // silinmişKayıtlarıGösterToolStripMenuItem
            // 
            this.silinmişKayıtlarıGösterToolStripMenuItem.Name = "silinmişKayıtlarıGösterToolStripMenuItem";
            this.silinmişKayıtlarıGösterToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.silinmişKayıtlarıGösterToolStripMenuItem.Text = "Silinmiş Kayıtları Göster";
            this.silinmişKayıtlarıGösterToolStripMenuItem.Click += new System.EventHandler(this.silinmişKayıtlarıGösterToolStripMenuItem_Click);
            // 
            // silinmişKayıtlarıGeriAlToolStripMenuItem
            // 
            this.silinmişKayıtlarıGeriAlToolStripMenuItem.Name = "silinmişKayıtlarıGeriAlToolStripMenuItem";
            this.silinmişKayıtlarıGeriAlToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.silinmişKayıtlarıGeriAlToolStripMenuItem.Text = "Silinmiş Kayıtları Geri Al";
            this.silinmişKayıtlarıGeriAlToolStripMenuItem.Click += new System.EventHandler(this.silinmişKayıtlarıGeriAlToolStripMenuItem_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(476, 498);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(169, 40);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(259, 435);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(594, 36);
            this.btnKlavye.TabIndex = 6;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(672, 498);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(181, 40);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "İptal";
            this.btnKapat.UseCustomBackColor = true;
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.Location = new System.Drawing.Point(259, 498);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(187, 40);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseCustomBackColor = true;
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // blokEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 629);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKlavye);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSecenekler);
            this.Controls.Add(this.lblBlokListesi);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.txtBlokAdi);
            this.Controls.Add(this.lblBlokAdı);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "blokEkle";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.blokEkle_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSecenekler;
        private MetroFramework.Controls.MetroLabel lblBlokListesi;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroTextBox txtBlokAdi;
        private MetroFramework.Controls.MetroLabel lblBlokAdı;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenlePersoneliGeriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişKayıtlarıGösterToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ToolStripMenuItem silinmişKayıtlarıGeriAlToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnKaydet;
    }
}