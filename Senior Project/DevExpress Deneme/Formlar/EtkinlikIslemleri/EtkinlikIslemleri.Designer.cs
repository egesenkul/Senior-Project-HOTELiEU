namespace Otel_Uygulamasi.Formlar.EtkinlikIslemleri
{
    partial class EtkinlikIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtkinlikIslemleri));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemEtkinlikOlustur = new DevExpress.XtraEditors.TileItem();
            this.tileItemEtkinlikListesi = new DevExpress.XtraEditors.TileItem();
            this.tileItemKapat = new DevExpress.XtraEditors.TileItem();
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
            this.tileControl1.Size = new System.Drawing.Size(756, 427);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItemEtkinlikOlustur);
            this.tileGroup2.Items.Add(this.tileItemEtkinlikListesi);
            this.tileGroup2.Items.Add(this.tileItemKapat);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItemEtkinlikOlustur
            // 
            this.tileItemEtkinlikOlustur.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemEtkinlikOlustur.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemEtkinlikOlustur.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemEtkinlikOlustur.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemEtkinlikOlustur.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemEtkinlikOlustur.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemEtkinlikOlustur.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemEtkinlikOlustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemEtkinlikOlustur.BackgroundImage")));
            tileItemElement1.Text = "Etkinlik Oluştur";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemEtkinlikOlustur.Elements.Add(tileItemElement1);
            this.tileItemEtkinlikOlustur.Id = 0;
            this.tileItemEtkinlikOlustur.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemEtkinlikOlustur.Name = "tileItemEtkinlikOlustur";
            this.tileItemEtkinlikOlustur.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItemEtkinlikListesi
            // 
            this.tileItemEtkinlikListesi.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemEtkinlikListesi.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemEtkinlikListesi.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemEtkinlikListesi.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemEtkinlikListesi.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemEtkinlikListesi.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemEtkinlikListesi.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemEtkinlikListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemEtkinlikListesi.BackgroundImage")));
            tileItemElement2.Text = "Etkinlik Listesi";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemEtkinlikListesi.Elements.Add(tileItemElement2);
            this.tileItemEtkinlikListesi.Id = 1;
            this.tileItemEtkinlikListesi.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemEtkinlikListesi.Name = "tileItemEtkinlikListesi";
            this.tileItemEtkinlikListesi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItemKapat
            // 
            this.tileItemKapat.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.tileItemKapat.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemKapat.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemKapat.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemKapat.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemKapat.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemKapat.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemKapat.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemKapat.AppearanceItem.Pressed.Options.UseBorderColor = true;
            tileItemElement3.Text = "Kapat";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemKapat.Elements.Add(tileItemElement3);
            this.tileItemKapat.Id = 2;
            this.tileItemKapat.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemKapat.Name = "tileItemKapat";
            this.tileItemKapat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // EtkinlikIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 507);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "EtkinlikIslemleri";
            this.Resizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EtkinlikIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItemEtkinlikOlustur;
        private DevExpress.XtraEditors.TileItem tileItemEtkinlikListesi;
        private DevExpress.XtraEditors.TileItem tileItemKapat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}