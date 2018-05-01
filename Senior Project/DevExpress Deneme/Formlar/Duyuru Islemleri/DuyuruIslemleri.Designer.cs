namespace Otel_Uygulamasi.Formlar.Duyuru_Islemleri
{
    partial class DuyuruIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuyuruIslemleri));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileDuyuruEkle = new DevExpress.XtraEditors.TileItem();
            this.tileDuyuruListesi = new DevExpress.XtraEditors.TileItem();
            this.tileKapat = new DevExpress.XtraEditors.TileItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 180;
            this.tileControl1.Location = new System.Drawing.Point(20, 60);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(802, 515);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileDuyuruEkle);
            this.tileGroup2.Items.Add(this.tileDuyuruListesi);
            this.tileGroup2.Items.Add(this.tileKapat);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileDuyuruEkle
            // 
            this.tileDuyuruEkle.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileDuyuruEkle.AppearanceItem.Normal.Options.UseFont = true;
            this.tileDuyuruEkle.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileDuyuruEkle.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileDuyuruEkle.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileDuyuruEkle.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileDuyuruEkle.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileDuyuruEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileDuyuruEkle.BackgroundImage")));
            tileItemElement1.Text = "Duyuru Ekle";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileDuyuruEkle.Elements.Add(tileItemElement1);
            this.tileDuyuruEkle.Id = 0;
            this.tileDuyuruEkle.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDuyuruEkle.Name = "tileDuyuruEkle";
            this.tileDuyuruEkle.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileDuyuruListesi
            // 
            this.tileDuyuruListesi.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileDuyuruListesi.AppearanceItem.Normal.Options.UseFont = true;
            this.tileDuyuruListesi.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileDuyuruListesi.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileDuyuruListesi.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileDuyuruListesi.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileDuyuruListesi.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileDuyuruListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileDuyuruListesi.BackgroundImage")));
            tileItemElement2.Text = "Duyuru Listesi";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileDuyuruListesi.Elements.Add(tileItemElement2);
            this.tileDuyuruListesi.Id = 1;
            this.tileDuyuruListesi.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileDuyuruListesi.Name = "tileDuyuruListesi";
            this.tileDuyuruListesi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileKapat
            // 
            this.tileKapat.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileKapat.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Red;
            this.tileKapat.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.tileKapat.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileKapat.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileKapat.AppearanceItem.Normal.Options.UseFont = true;
            this.tileKapat.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileKapat.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileKapat.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileKapat.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileKapat.AppearanceItem.Pressed.Options.UseBorderColor = true;
            tileItemElement3.Text = "Kapat";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileKapat.Elements.Add(tileItemElement3);
            this.tileKapat.Id = 2;
            this.tileKapat.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileKapat.Name = "tileKapat";
            this.tileKapat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // DuyuruIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 595);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "DuyuruIslemleri";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DuyuruIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileDuyuruEkle;
        private DevExpress.XtraEditors.TileItem tileDuyuruListesi;
        private DevExpress.XtraEditors.TileItem tileKapat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}