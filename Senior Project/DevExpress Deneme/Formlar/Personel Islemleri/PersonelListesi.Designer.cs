namespace Otel_Uygulamasi.Formlar.Personel_Islemleri
{
    partial class PersonelListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelListesi));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblPersonelListesi = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.btnSecenekler = new MetroFramework.Controls.MetroButton();
            this.btnKapat = new MetroFramework.Controls.MetroButton();
            this.lblPersonelKategorisi = new MetroFramework.Controls.MetroLabel();
            this.cmbPersonelGrubu = new MetroFramework.Controls.MetroComboBox();
            this.btnFiltrele = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tümBilgileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişPersonelleriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silinmişPersoneliGeriAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblPersonelListesi);
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.Controls.Add(this.btnSecenekler);
            this.metroPanel1.Controls.Add(this.btnKapat);
            this.metroPanel1.Controls.Add(this.lblPersonelKategorisi);
            this.metroPanel1.Controls.Add(this.cmbPersonelGrubu);
            this.metroPanel1.Controls.Add(this.btnFiltrele);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1248, 573);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblPersonelListesi
            // 
            this.lblPersonelListesi.AutoSize = true;
            this.lblPersonelListesi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPersonelListesi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPersonelListesi.Location = new System.Drawing.Point(276, 48);
            this.lblPersonelListesi.Name = "lblPersonelListesi";
            this.lblPersonelListesi.Size = new System.Drawing.Size(169, 25);
            this.lblPersonelListesi.TabIndex = 14;
            this.lblPersonelListesi.Text = "PERSONEL LİSTESİ";
            this.lblPersonelListesi.UseCustomBackColor = true;
            this.lblPersonelListesi.UseCustomForeColor = true;
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
            this.metroGrid1.Location = new System.Drawing.Point(3, 109);
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
            this.metroGrid1.Size = new System.Drawing.Size(1308, 464);
            this.metroGrid1.TabIndex = 13;
            this.metroGrid1.UseCustomBackColor = true;
            this.metroGrid1.UseCustomForeColor = true;
            this.metroGrid1.UseStyleColors = true;
            this.metroGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroGrid1_MouseClick_1);
            // 
            // btnSecenekler
            // 
            this.btnSecenekler.BackColor = System.Drawing.Color.Red;
            this.btnSecenekler.DisplayFocus = true;
            this.btnSecenekler.Location = new System.Drawing.Point(682, 17);
            this.btnSecenekler.Name = "btnSecenekler";
            this.btnSecenekler.Size = new System.Drawing.Size(120, 70);
            this.btnSecenekler.TabIndex = 11;
            this.btnSecenekler.Text = "SEÇENEKLER";
            this.btnSecenekler.UseSelectable = true;
            this.btnSecenekler.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Location = new System.Drawing.Point(819, 17);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(120, 70);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseCustomBackColor = true;
            this.btnKapat.UseSelectable = true;
            this.btnKapat.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // lblPersonelKategorisi
            // 
            this.lblPersonelKategorisi.AutoSize = true;
            this.lblPersonelKategorisi.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPersonelKategorisi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPersonelKategorisi.Location = new System.Drawing.Point(15, 17);
            this.lblPersonelKategorisi.Name = "lblPersonelKategorisi";
            this.lblPersonelKategorisi.Size = new System.Drawing.Size(214, 25);
            this.lblPersonelKategorisi.TabIndex = 9;
            this.lblPersonelKategorisi.Text = "PERSONEL KATEGORİSİ";
            this.lblPersonelKategorisi.UseCustomBackColor = true;
            this.lblPersonelKategorisi.UseCustomForeColor = true;
            // 
            // cmbPersonelGrubu
            // 
            this.cmbPersonelGrubu.FontSize = MetroFramework.MetroComboBoxSize.Tall;
            this.cmbPersonelGrubu.FormattingEnabled = true;
            this.cmbPersonelGrubu.ItemHeight = 29;
            this.cmbPersonelGrubu.Location = new System.Drawing.Point(15, 52);
            this.cmbPersonelGrubu.Name = "cmbPersonelGrubu";
            this.cmbPersonelGrubu.Size = new System.Drawing.Size(198, 35);
            this.cmbPersonelGrubu.TabIndex = 7;
            this.cmbPersonelGrubu.UseCustomBackColor = true;
            this.cmbPersonelGrubu.UseCustomForeColor = true;
            this.cmbPersonelGrubu.UseSelectable = true;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.Silver;
            this.btnFiltrele.Location = new System.Drawing.Point(546, 17);
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
            this.tümBilgileriGösterToolStripMenuItem,
            this.silinmişPersonelleriGösterToolStripMenuItem,
            this.silinmişPersoneliGeriAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 134);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tümBilgileriGösterToolStripMenuItem
            // 
            this.tümBilgileriGösterToolStripMenuItem.Name = "tümBilgileriGösterToolStripMenuItem";
            this.tümBilgileriGösterToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.tümBilgileriGösterToolStripMenuItem.Text = "Tüm Bilgileri Göster";
            this.tümBilgileriGösterToolStripMenuItem.Click += new System.EventHandler(this.tümBilgileriGösterToolStripMenuItem_Click);
            // 
            // silinmişPersonelleriGösterToolStripMenuItem
            // 
            this.silinmişPersonelleriGösterToolStripMenuItem.Name = "silinmişPersonelleriGösterToolStripMenuItem";
            this.silinmişPersonelleriGösterToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.silinmişPersonelleriGösterToolStripMenuItem.Text = "Silinmiş Personelleri Göster";
            this.silinmişPersonelleriGösterToolStripMenuItem.Click += new System.EventHandler(this.silinmişPersonelleriGösterToolStripMenuItem_Click);
            // 
            // silinmişPersoneliGeriAlToolStripMenuItem
            // 
            this.silinmişPersoneliGeriAlToolStripMenuItem.Name = "silinmişPersoneliGeriAlToolStripMenuItem";
            this.silinmişPersoneliGeriAlToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.silinmişPersoneliGeriAlToolStripMenuItem.Text = "Silinmiş Personeli Geri Al";
            this.silinmişPersoneliGeriAlToolStripMenuItem.Click += new System.EventHandler(this.silinmişPersoneliGeriAlToolStripMenuItem_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // PersonelListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 653);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "PersonelListesi";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelListesi_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSecenekler;
        private MetroFramework.Controls.MetroButton btnKapat;
        private MetroFramework.Controls.MetroLabel lblPersonelKategorisi;
        private MetroFramework.Controls.MetroComboBox cmbPersonelGrubu;
        private MetroFramework.Controls.MetroButton btnFiltrele;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tümBilgileriGösterToolStripMenuItem;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.ToolStripMenuItem silinmişPersonelleriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silinmişPersoneliGeriAlToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblPersonelListesi;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}