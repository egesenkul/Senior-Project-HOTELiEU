namespace DevExpress_Deneme
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileKullaniciTercihleri = new DevExpress.XtraEditors.TileItem();
            this.tileYetki = new DevExpress.XtraEditors.TileItem();
            this.tileKapat = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileOtelTanimlamalari = new DevExpress.XtraEditors.TileItem();
            this.tileSalonTanimlamalari = new DevExpress.XtraEditors.TileItem();
            this.tileKategoriTanimlamari = new DevExpress.XtraEditors.TileItem();
            this.tileGroup4 = new DevExpress.XtraEditors.TileGroup();
            this.tileBlokEkle = new DevExpress.XtraEditors.TileItem();
            this.tileHavuzEkle = new DevExpress.XtraEditors.TileItem();
            this.tileKatEkle = new DevExpress.XtraEditors.TileItem();
            this.tileGroup5 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemSıcaklıkArdunio = new DevExpress.XtraEditors.TileItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.Groups.Add(this.tileGroup3);
            this.tileControl1.Groups.Add(this.tileGroup4);
            this.tileControl1.Groups.Add(this.tileGroup5);
            this.tileControl1.ItemSize = 180;
            this.tileControl1.Location = new System.Drawing.Point(20, 60);
            this.tileControl1.MaxId = 14;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1160, 577);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileKullaniciTercihleri);
            this.tileGroup2.Items.Add(this.tileYetki);
            this.tileGroup2.Items.Add(this.tileKapat);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileKullaniciTercihleri
            // 
            this.tileKullaniciTercihleri.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileKullaniciTercihleri.AppearanceItem.Normal.Options.UseFont = true;
            this.tileKullaniciTercihleri.AppearanceItem.Pressed.BackColor = System.Drawing.Color.GreenYellow;
            this.tileKullaniciTercihleri.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.GreenYellow;
            this.tileKullaniciTercihleri.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.GreenYellow;
            this.tileKullaniciTercihleri.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileKullaniciTercihleri.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileKullaniciTercihleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileKullaniciTercihleri.BackgroundImage")));
            tileItemElement1.Text = "Kullanıcı Tercihleri";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileKullaniciTercihleri.Elements.Add(tileItemElement1);
            this.tileKullaniciTercihleri.Id = 7;
            this.tileKullaniciTercihleri.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileKullaniciTercihleri.Name = "tileKullaniciTercihleri";
            this.tileKullaniciTercihleri.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem7_ItemClick);
            // 
            // tileYetki
            // 
            this.tileYetki.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileYetki.AppearanceItem.Normal.Options.UseFont = true;
            this.tileYetki.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileYetki.BackgroundImage")));
            tileItemElement3.Text = "Yetki İşlemleri";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileYetki.Elements.Add(tileItemElement3);
            this.tileYetki.Id = 13;
            this.tileYetki.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileYetki.Name = "tileYetki";
            this.tileYetki.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileYetki_ItemClick);
            // 
            // tileKapat
            // 
            this.tileKapat.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileKapat.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Red;
            this.tileKapat.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileKapat.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileKapat.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileKapat.AppearanceItem.Normal.Options.UseFont = true;
            this.tileKapat.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileKapat.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileKapat.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileKapat.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileKapat.AppearanceItem.Pressed.Options.UseBorderColor = true;
            tileItemElement4.Text = "Kapat";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileKapat.Elements.Add(tileItemElement4);
            this.tileKapat.Id = 2;
            this.tileKapat.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileKapat.Name = "tileKapat";
            this.tileKapat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileOtelTanimlamalari);
            this.tileGroup3.Items.Add(this.tileSalonTanimlamalari);
            this.tileGroup3.Items.Add(this.tileKategoriTanimlamari);
            this.tileGroup3.Name = "tileGroup3";
            this.tileGroup3.Text = "Tanımlamalar";
            // 
            // tileOtelTanimlamalari
            // 
            this.tileOtelTanimlamalari.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileOtelTanimlamalari.AppearanceItem.Normal.Options.UseFont = true;
            this.tileOtelTanimlamalari.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileOtelTanimlamalari.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileOtelTanimlamalari.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileOtelTanimlamalari.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileOtelTanimlamalari.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileOtelTanimlamalari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileOtelTanimlamalari.BackgroundImage")));
            tileItemElement5.Text = "Otel Tanımlamaları";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileOtelTanimlamalari.Elements.Add(tileItemElement5);
            this.tileOtelTanimlamalari.Id = 1;
            this.tileOtelTanimlamalari.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileOtelTanimlamalari.Name = "tileOtelTanimlamalari";
            this.tileOtelTanimlamalari.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileSalonTanimlamalari
            // 
            this.tileSalonTanimlamalari.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileSalonTanimlamalari.AppearanceItem.Normal.Options.UseFont = true;
            this.tileSalonTanimlamalari.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileSalonTanimlamalari.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileSalonTanimlamalari.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileSalonTanimlamalari.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileSalonTanimlamalari.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileSalonTanimlamalari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileSalonTanimlamalari.BackgroundImage")));
            tileItemElement6.Text = "Salon Tanımlamaları";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSalonTanimlamalari.Elements.Add(tileItemElement6);
            this.tileSalonTanimlamalari.Id = 3;
            this.tileSalonTanimlamalari.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileSalonTanimlamalari.Name = "tileSalonTanimlamalari";
            this.tileSalonTanimlamalari.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // tileKategoriTanimlamari
            // 
            this.tileKategoriTanimlamari.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileKategoriTanimlamari.AppearanceItem.Normal.Options.UseFont = true;
            this.tileKategoriTanimlamari.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileKategoriTanimlamari.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileKategoriTanimlamari.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileKategoriTanimlamari.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileKategoriTanimlamari.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileKategoriTanimlamari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileKategoriTanimlamari.BackgroundImage")));
            tileItemElement7.Text = "Kategori Tanımlamaları";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileKategoriTanimlamari.Elements.Add(tileItemElement7);
            this.tileKategoriTanimlamari.Id = 4;
            this.tileKategoriTanimlamari.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileKategoriTanimlamari.Name = "tileKategoriTanimlamari";
            this.tileKategoriTanimlamari.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem5_ItemClick);
            // 
            // tileGroup4
            // 
            this.tileGroup4.Items.Add(this.tileBlokEkle);
            this.tileGroup4.Items.Add(this.tileHavuzEkle);
            this.tileGroup4.Items.Add(this.tileKatEkle);
            this.tileGroup4.Name = "tileGroup4";
            // 
            // tileBlokEkle
            // 
            this.tileBlokEkle.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileBlokEkle.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBlokEkle.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileBlokEkle.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileBlokEkle.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileBlokEkle.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileBlokEkle.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileBlokEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileBlokEkle.BackgroundImage")));
            tileItemElement8.Text = "Blok Ekle";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileBlokEkle.Elements.Add(tileItemElement8);
            this.tileBlokEkle.Id = 8;
            this.tileBlokEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileBlokEkle.Name = "tileBlokEkle";
            this.tileBlokEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem8_ItemClick);
            // 
            // tileHavuzEkle
            // 
            this.tileHavuzEkle.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileHavuzEkle.AppearanceItem.Normal.Options.UseFont = true;
            this.tileHavuzEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileHavuzEkle.BackgroundImage")));
            tileItemElement9.Text = "Havuz Ekle";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileHavuzEkle.Elements.Add(tileItemElement9);
            this.tileHavuzEkle.Id = 9;
            this.tileHavuzEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileHavuzEkle.Name = "tileHavuzEkle";
            this.tileHavuzEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileHavuzEkle_ItemClick);
            // 
            // tileKatEkle
            // 
            this.tileKatEkle.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileKatEkle.AppearanceItem.Normal.Options.UseFont = true;
            this.tileKatEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileKatEkle.BackgroundImage")));
            tileItemElement10.Text = "Kat Ekle";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileKatEkle.Elements.Add(tileItemElement10);
            this.tileKatEkle.Id = 11;
            this.tileKatEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileKatEkle.Name = "tileKatEkle";
            this.tileKatEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileGroup5
            // 
            this.tileGroup5.Items.Add(this.tileItemSıcaklıkArdunio);
            this.tileGroup5.Name = "tileGroup5";
            this.tileGroup5.Text = "Ardunio Bilgileri";
            // 
            // tileItemSıcaklıkArdunio
            // 
            this.tileItemSıcaklıkArdunio.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemSıcaklıkArdunio.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemSıcaklıkArdunio.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemSıcaklıkArdunio.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemSıcaklıkArdunio.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemSıcaklıkArdunio.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemSıcaklıkArdunio.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemSıcaklıkArdunio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemSıcaklıkArdunio.BackgroundImage")));
            tileItemElement11.Text = "Sıcaklık İçin Ardunio Bağlantı";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemSıcaklıkArdunio.Elements.Add(tileItemElement11);
            this.tileItemSıcaklıkArdunio.Id = 10;
            this.tileItemSıcaklıkArdunio.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemSıcaklıkArdunio.Name = "tileItemSıcaklıkArdunio";
            this.tileItemSıcaklıkArdunio.Visible = false;
            this.tileItemSıcaklıkArdunio.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItemSıcaklıkArdunio_ItemClick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Form2";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileOtelTanimlamalari;
        private DevExpress.XtraEditors.TileItem tileKapat;
        private DevExpress.XtraEditors.TileItem tileSalonTanimlamalari;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileKategoriTanimlamari;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private DevExpress.XtraEditors.TileItem tileKullaniciTercihleri;
        private DevExpress.XtraEditors.TileGroup tileGroup4;
        private DevExpress.XtraEditors.TileItem tileBlokEkle;
        private DevExpress.XtraEditors.TileItem tileHavuzEkle;
        private DevExpress.XtraEditors.TileGroup tileGroup5;
        private DevExpress.XtraEditors.TileItem tileItemSıcaklıkArdunio;
        private DevExpress.XtraEditors.TileItem tileKatEkle;
        private DevExpress.XtraEditors.TileItem tileYetki;
    }
}