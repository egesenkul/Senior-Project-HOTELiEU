namespace Otel_Uygulamasi.Formlar.OdaIslemleri
{
    partial class OdaListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSecenekler = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.lblKat = new MetroFramework.Controls.MetroLabel();
            this.cmbKat = new MetroFramework.Controls.MetroComboBox();
            this.btnTemizle = new MetroFramework.Controls.MetroButton();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.lblOdaGrup = new MetroFramework.Controls.MetroLabel();
            this.lblBlok = new MetroFramework.Controls.MetroLabel();
            this.cmbOdaTipi = new MetroFramework.Controls.MetroComboBox();
            this.cmbOdaBlok = new MetroFramework.Controls.MetroComboBox();
            this.btnFiltrele = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişOdalarıGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişOdayıGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSecenekler);
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.Controls.Add(this.lblKat);
            this.metroPanel1.Controls.Add(this.cmbKat);
            this.metroPanel1.Controls.Add(this.btnTemizle);
            this.metroPanel1.Controls.Add(this.btnKapat);
            this.metroPanel1.Controls.Add(this.lblOdaGrup);
            this.metroPanel1.Controls.Add(this.lblBlok);
            this.metroPanel1.Controls.Add(this.cmbOdaTipi);
            this.metroPanel1.Controls.Add(this.cmbOdaBlok);
            this.metroPanel1.Controls.Add(this.btnFiltrele);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1138, 516);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnSecenekler
            // 
            this.btnSecenekler.BackColor = System.Drawing.Color.Red;
            this.btnSecenekler.Location = new System.Drawing.Point(834, 17);
            this.btnSecenekler.Name = "btnSecenekler";
            this.btnSecenekler.Size = new System.Drawing.Size(120, 70);
            this.btnSecenekler.TabIndex = 15;
            this.btnSecenekler.Text = "SEÇENEKLER";
            this.btnSecenekler.UseSelectable = true;
            this.btnSecenekler.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.metroGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CausesValidation = false;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(2, 115);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidth = 50;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 30;
            this.metroGrid1.RowTemplate.ReadOnly = true;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.ShowEditingIcon = false;
            this.metroGrid1.ShowRowErrors = false;
            this.metroGrid1.Size = new System.Drawing.Size(1138, 464);
            this.metroGrid1.TabIndex = 14;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseClick);
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblKat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblKat.Location = new System.Drawing.Point(211, 21);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(48, 25);
            this.lblKat.TabIndex = 13;
            this.lblKat.Text = "KAT";
            this.lblKat.UseCustomBackColor = true;
            this.lblKat.UseCustomForeColor = true;
            // 
            // cmbKat
            // 
            this.cmbKat.FormattingEnabled = true;
            this.cmbKat.ItemHeight = 23;
            this.cmbKat.Location = new System.Drawing.Point(172, 58);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(121, 29);
            this.cmbKat.TabIndex = 12;
            this.cmbKat.UseCustomBackColor = true;
            this.cmbKat.UseCustomForeColor = true;
            this.cmbKat.UseSelectable = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Red;
            this.btnTemizle.Location = new System.Drawing.Point(698, 17);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 70);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseSelectable = true;
            this.btnTemizle.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(972, 17);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 70);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseCustomBackColor = true;
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblOdaGrup
            // 
            this.lblOdaGrup.AutoSize = true;
            this.lblOdaGrup.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblOdaGrup.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOdaGrup.Location = new System.Drawing.Point(362, 21);
            this.lblOdaGrup.Name = "lblOdaGrup";
            this.lblOdaGrup.Size = new System.Drawing.Size(91, 25);
            this.lblOdaGrup.TabIndex = 9;
            this.lblOdaGrup.Text = "ODA TİPİ";
            this.lblOdaGrup.UseCustomBackColor = true;
            this.lblOdaGrup.UseCustomForeColor = true;
            // 
            // lblBlok
            // 
            this.lblBlok.AutoSize = true;
            this.lblBlok.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBlok.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblBlok.Location = new System.Drawing.Point(15, 21);
            this.lblBlok.Name = "lblBlok";
            this.lblBlok.Size = new System.Drawing.Size(59, 25);
            this.lblBlok.TabIndex = 8;
            this.lblBlok.Text = "BLOK";
            this.lblBlok.UseCustomBackColor = true;
            this.lblBlok.UseCustomForeColor = true;
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.ItemHeight = 23;
            this.cmbOdaTipi.Location = new System.Drawing.Point(329, 58);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(162, 29);
            this.cmbOdaTipi.TabIndex = 7;
            this.cmbOdaTipi.UseCustomBackColor = true;
            this.cmbOdaTipi.UseCustomForeColor = true;
            this.cmbOdaTipi.UseSelectable = true;
            // 
            // cmbOdaBlok
            // 
            this.cmbOdaBlok.FormattingEnabled = true;
            this.cmbOdaBlok.ItemHeight = 23;
            this.cmbOdaBlok.Location = new System.Drawing.Point(15, 58);
            this.cmbOdaBlok.Name = "cmbOdaBlok";
            this.cmbOdaBlok.Size = new System.Drawing.Size(121, 29);
            this.cmbOdaBlok.TabIndex = 6;
            this.cmbOdaBlok.UseCustomBackColor = true;
            this.cmbOdaBlok.UseCustomForeColor = true;
            this.cmbOdaBlok.UseSelectable = true;
            this.cmbOdaBlok.SelectedIndexChanged += new System.EventHandler(this.cmbOdaBlok_SelectedIndexChanged);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.Silver;
            this.btnFiltrele.Location = new System.Drawing.Point(560, 17);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(120, 70);
            this.btnFiltrele.TabIndex = 3;
            this.btnFiltrele.Text = "FİLTRELE";
            this.btnFiltrele.UseCustomBackColor = true;
            this.btnFiltrele.UseSelectable = true;
            this.btnFiltrele.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.silinmişOdalarıGösterToolStripMenuItem,
            this.silinmişOdayıGeriAlToolStripMenuItem,
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 134);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // silinmişOdalarıGösterToolStripMenuItem
            // 
            this.silinmişOdalarıGösterToolStripMenuItem.Name = "silinmişOdalarıGösterToolStripMenuItem";
            this.silinmişOdalarıGösterToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.silinmişOdalarıGösterToolStripMenuItem.Text = "Silinmiş Odaları Göster";
            this.silinmişOdalarıGösterToolStripMenuItem.Click += new System.EventHandler(this.silinmişOdalarıGösterToolStripMenuItem_Click);
            // 
            // silinmişOdayıGeriAlToolStripMenuItem
            // 
            this.silinmişOdayıGeriAlToolStripMenuItem.Name = "silinmişOdayıGeriAlToolStripMenuItem";
            this.silinmişOdayıGeriAlToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.silinmişOdayıGeriAlToolStripMenuItem.Text = "Silinmiş Odayı Geri Al";
            this.silinmişOdayıGeriAlToolStripMenuItem.Click += new System.EventHandler(this.silinmişOdayıGeriAlToolStripMenuItem_Click);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Enabled = false;
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve Et";
            this.rezerveEtToolStripMenuItem.Visible = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // OdaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 596);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "OdaListesi";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OdaListesi_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblOdaGrup;
        private MetroFramework.Controls.MetroLabel lblBlok;
        private MetroFramework.Controls.MetroComboBox cmbOdaTipi;
        private MetroFramework.Controls.MetroComboBox cmbOdaBlok;
        private MetroFramework.Controls.MetroButton btnFiltrele;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroButton btnTemizle;
        private MetroFramework.Controls.MetroLabel lblKat;
        private MetroFramework.Controls.MetroComboBox cmbKat;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MetroFramework.Controls.MetroButton btnSecenekler;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişOdalarıGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişOdayıGeriAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}