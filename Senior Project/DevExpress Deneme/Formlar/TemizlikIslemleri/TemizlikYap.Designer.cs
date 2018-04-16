namespace Otel_Uygulamasi.Formlar.TemizlikIslemleri
{
    partial class TemizlikYap
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.ListeOdalar = new MetroFramework.Controls.MetroListView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Blok = new MetroFramework.Controls.MetroLabel();
            this.cmbKat = new MetroFramework.Controls.MetroComboBox();
            this.cmbOdaBlok = new MetroFramework.Controls.MetroComboBox();
            this.cmbTemizlikci = new MetroFramework.Controls.MetroComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.btnKlavye = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.ListeOdalar);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.Blok);
            this.metroPanel1.Controls.Add(this.cmbKat);
            this.metroPanel1.Controls.Add(this.cmbOdaBlok);
            this.metroPanel1.Controls.Add(this.cmbTemizlikci);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.btnKlavye);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(911, 517);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(151, 189);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(169, 40);
            this.metroButton3.TabIndex = 30;
            this.metroButton3.Text = "Filtrele";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // ListeOdalar
            // 
            this.ListeOdalar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListeOdalar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListeOdalar.FullRowSelect = true;
            this.ListeOdalar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListeOdalar.Location = new System.Drawing.Point(404, 144);
            this.ListeOdalar.MultiSelect = false;
            this.ListeOdalar.Name = "ListeOdalar";
            this.ListeOdalar.OwnerDraw = true;
            this.ListeOdalar.Size = new System.Drawing.Size(341, 155);
            this.ListeOdalar.TabIndex = 29;
            this.ListeOdalar.UseCompatibleStateImageBehavior = false;
            this.ListeOdalar.UseSelectable = true;
            this.ListeOdalar.View = System.Windows.Forms.View.Tile;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(646, 47);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "KAT";
            // 
            // Blok
            // 
            this.Blok.AutoSize = true;
            this.Blok.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Blok.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.Blok.Location = new System.Drawing.Point(440, 47);
            this.Blok.Name = "Blok";
            this.Blok.Size = new System.Drawing.Size(59, 25);
            this.Blok.TabIndex = 24;
            this.Blok.Text = "BLOK";
            // 
            // cmbKat
            // 
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.ItemHeight = 23;
            this.cmbKat.Location = new System.Drawing.Point(601, 88);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(144, 29);
            this.cmbKat.TabIndex = 23;
            this.cmbKat.UseSelectable = true;
            // 
            // cmbOdaBlok
            // 
            this.cmbOdaBlok.FormattingEnabled = true;
            this.cmbOdaBlok.ItemHeight = 23;
            this.cmbOdaBlok.Location = new System.Drawing.Point(404, 88);
            this.cmbOdaBlok.Name = "cmbOdaBlok";
            this.cmbOdaBlok.Size = new System.Drawing.Size(145, 29);
            this.cmbOdaBlok.TabIndex = 21;
            this.cmbOdaBlok.UseSelectable = true;
            this.cmbOdaBlok.SelectedIndexChanged += new System.EventHandler(this.cmbOdaBlok_SelectedIndexChanged);
            // 
            // cmbTemizlikci
            // 
            this.cmbTemizlikci.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbTemizlikci.FormattingEnabled = true;
            this.cmbTemizlikci.ItemHeight = 29;
            this.cmbTemizlikci.Location = new System.Drawing.Point(404, 320);
            this.cmbTemizlikci.Name = "cmbTemizlikci";
            this.cmbTemizlikci.Size = new System.Drawing.Size(341, 35);
            this.cmbTemizlikci.TabIndex = 20;
            this.cmbTemizlikci.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(368, 456);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(169, 40);
            this.metroButton4.TabIndex = 19;
            this.metroButton4.Text = "Temizle";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // btnKlavye
            // 
            this.btnKlavye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnKlavye.Location = new System.Drawing.Point(151, 383);
            this.btnKlavye.Name = "btnKlavye";
            this.btnKlavye.Size = new System.Drawing.Size(594, 36);
            this.btnKlavye.TabIndex = 18;
            this.btnKlavye.Text = "Klavye Aç";
            this.btnKlavye.UseCustomBackColor = true;
            this.btnKlavye.UseSelectable = true;
            this.btnKlavye.Click += new System.EventHandler(this.btnKlavye_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Red;
            this.metroButton2.Location = new System.Drawing.Point(564, 456);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(181, 40);
            this.metroButton2.TabIndex = 17;
            this.metroButton2.Text = "İptal";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.metroButton1.Location = new System.Drawing.Point(151, 456);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(187, 40);
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "Kaydet";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(151, 320);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(210, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Temizlik Yapan Personel :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(151, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Oda Seçimi :";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // TemizlikYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 597);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "TemizlikYap";
            this.Load += new System.EventHandler(this.TemizlikYap_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cmbTemizlikci;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton btnKlavye;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbKat;
        private MetroFramework.Controls.MetroComboBox cmbOdaBlok;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel Blok;
        private MetroFramework.Controls.MetroListView ListeOdalar;
        private MetroFramework.Controls.MetroButton metroButton3;
    }
}