namespace Otel_Uygulamasi.Formlar.Ayarlar
{
    partial class KatEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KatEkle));
            this.txtKatAdi = new MetroFramework.Controls.MetroTextBox();
            this.lblKatAdi = new MetroFramework.Controls.MetroLabel();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.cmbBlok = new MetroFramework.Controls.MetroComboBox();
            this.lblBlok = new MetroFramework.Controls.MetroLabel();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnKatEkle = new MetroFramework.Controls.MetroButton();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.lblBloktakiKatlar = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenlePersoneliGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKayıtlarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişKaydıGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSecenekler = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKatAdi
            // 
            this.txtKatAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtKatAdi.CustomButton.Image = null;
            this.txtKatAdi.CustomButton.Location = new System.Drawing.Point(148, 2);
            this.txtKatAdi.CustomButton.Name = "";
            this.txtKatAdi.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtKatAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKatAdi.CustomButton.TabIndex = 1;
            this.txtKatAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKatAdi.CustomButton.UseSelectable = true;
            this.txtKatAdi.CustomButton.Visible = false;
            this.txtKatAdi.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtKatAdi.Lines = new string[0];
            this.txtKatAdi.Location = new System.Drawing.Point(553, 134);
            this.txtKatAdi.MaxLength = 32767;
            this.txtKatAdi.Name = "txtKatAdi";
            this.txtKatAdi.PasswordChar = '\0';
            this.txtKatAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKatAdi.SelectedText = "";
            this.txtKatAdi.SelectionLength = 0;
            this.txtKatAdi.SelectionStart = 0;
            this.txtKatAdi.ShortcutsEnabled = true;
            this.txtKatAdi.ShowClearButton = true;
            this.txtKatAdi.Size = new System.Drawing.Size(176, 30);
            this.txtKatAdi.TabIndex = 0;
            this.txtKatAdi.UseCustomBackColor = true;
            this.txtKatAdi.UseCustomForeColor = true;
            this.txtKatAdi.UseSelectable = true;
            this.txtKatAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKatAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblKatAdi
            // 
            this.lblKatAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKatAdi.AutoSize = true;
            this.lblKatAdi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKatAdi.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblKatAdi.Location = new System.Drawing.Point(359, 141);
            this.lblKatAdi.Name = "lblKatAdi";
            this.lblKatAdi.Size = new System.Drawing.Size(78, 25);
            this.lblKatAdi.TabIndex = 10;
            this.lblKatAdi.Text = "Kat Adı :";
            this.lblKatAdi.UseCustomBackColor = true;
            this.lblKatAdi.UseCustomForeColor = true;
            // 
            // btnKlavye
            // 
            this.btnKlavye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(379, 454);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(370, 36);
            this.btnKlavye.TabIndex = 7;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // cmbBlok
            // 
            this.cmbBlok.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbBlok.FormattingEnabled = true;
            this.cmbBlok.ItemHeight = 29;
            this.cmbBlok.Location = new System.Drawing.Point(552, 197);
            this.cmbBlok.Name = "cmbBlok";
            this.cmbBlok.Size = new System.Drawing.Size(176, 35);
            this.cmbBlok.Sorted = true;
            this.cmbBlok.TabIndex = 1;
            this.cmbBlok.UseCustomBackColor = true;
            this.cmbBlok.UseCustomForeColor = true;
            this.cmbBlok.UseSelectable = true;
            this.cmbBlok.SelectedIndexChanged += new System.EventHandler(this.cmbBlok_SelectedIndexChanged);
            // 
            // lblBlok
            // 
            this.lblBlok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlok.AutoSize = true;
            this.lblBlok.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBlok.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBlok.Location = new System.Drawing.Point(358, 197);
            this.lblBlok.Name = "lblBlok";
            this.lblBlok.Size = new System.Drawing.Size(55, 25);
            this.lblBlok.TabIndex = 26;
            this.lblBlok.Text = "Blok :";
            this.lblBlok.UseCustomBackColor = true;
            this.lblBlok.UseCustomForeColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTemizle.Location = new System.Drawing.Point(500, 529);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(125, 40);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroButton2.BackColor = System.Drawing.Color.Red;
            this.metroButton2.Location = new System.Drawing.Point(624, 529);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(125, 40);
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "İptal";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // btnKatEkle
            // 
            this.btnKatEkle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKatEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKatEkle.Location = new System.Drawing.Point(379, 529);
            this.btnKatEkle.Name = "btnKatEkle";
            this.btnKatEkle.Size = new System.Drawing.Size(125, 40);
            this.btnKatEkle.TabIndex = 3;
            this.btnKatEkle.Text = "Kaydet";
            this.btnKatEkle.UseCustomBackColor = true;
            this.btnKatEkle.UseSelectable = true;
            this.btnKatEkle.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroListView1
            // 
            this.metroListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.metroListView1.Location = new System.Drawing.Point(552, 270);
            this.metroListView1.MultiSelect = false;
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(177, 167);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseCustomBackColor = true;
            this.metroListView1.UseCustomForeColor = true;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.List;
            this.metroListView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroListView1_MouseClick);
            // 
            // lblBloktakiKatlar
            // 
            this.lblBloktakiKatlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBloktakiKatlar.AutoSize = true;
            this.lblBloktakiKatlar.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBloktakiKatlar.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBloktakiKatlar.Location = new System.Drawing.Point(359, 270);
            this.lblBloktakiKatlar.Name = "lblBloktakiKatlar";
            this.lblBloktakiKatlar.Size = new System.Drawing.Size(132, 25);
            this.lblBloktakiKatlar.TabIndex = 31;
            this.lblBloktakiKatlar.Text = "Bloktaki Katlar :";
            this.lblBloktakiKatlar.UseCustomBackColor = true;
            this.lblBloktakiKatlar.UseCustomForeColor = true;
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
            this.düzenlePersoneliGeriAlToolStripMenuItem.Click += new System.EventHandler(this.silinmişPersoneliGeriAlToolStripMenuItem_Click);
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
            this.silinmişKaydıGeriAlToolStripMenuItem.Visible = false;
            this.silinmişKaydıGeriAlToolStripMenuItem.Click += new System.EventHandler(this.silinmişKaydıGeriAlToolStripMenuItem_Click);
            // 
            // btnSecenekler
            // 
            this.btnSecenekler.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSecenekler.Location = new System.Drawing.Point(366, 324);
            this.btnSecenekler.Name = "btnSecenekler";
            this.btnSecenekler.Size = new System.Drawing.Size(125, 40);
            this.btnSecenekler.TabIndex = 6;
            this.btnSecenekler.Text = "Seçenekler";
            this.btnSecenekler.UseSelectable = true;
            this.btnSecenekler.Click += new System.EventHandler(this.btnSecenekler_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // KatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 619);
            this.Controls.Add(this.btnSecenekler);
            this.Controls.Add(this.lblBloktakiKatlar);
            this.Controls.Add(this.metroListView1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnKatEkle);
            this.Controls.Add(this.lblBlok);
            this.Controls.Add(this.cmbBlok);
            this.Controls.Add(this.btnKlavye);
            this.Controls.Add(this.txtKatAdi);
            this.Controls.Add(this.lblKatAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "KatEkle";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.KatEkle_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtKatAdi;
        private MetroFramework.Controls.MetroLabel lblKatAdi;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroComboBox cmbBlok;
        private MetroFramework.Controls.MetroLabel lblBlok;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnKatEkle;
        private MetroFramework.Controls.MetroListView metroListView1;
        private MetroFramework.Controls.MetroLabel lblBloktakiKatlar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenlePersoneliGeriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişKayıtlarıGösterToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnSecenekler;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.ToolStripMenuItem silinmişKaydıGeriAlToolStripMenuItem;
    }
}