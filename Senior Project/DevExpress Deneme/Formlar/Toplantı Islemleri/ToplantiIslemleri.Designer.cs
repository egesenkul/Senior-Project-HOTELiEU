namespace Otel_Uygulamasi.Formlar.Toplantı_Islemleri
{
    partial class ToplantiIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToplantiIslemleri));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemToplantiOlustur = new DevExpress.XtraEditors.TileItem();
            this.tileItemToplantiListesi = new DevExpress.XtraEditors.TileItem();
            this.tileItemKapat = new DevExpress.XtraEditors.TileItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 180;
            this.tileControl1.Location = new System.Drawing.Point(13, 60);
            this.tileControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Padding = new System.Windows.Forms.Padding(12);
            this.tileControl1.Size = new System.Drawing.Size(828, 398);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItemToplantiOlustur);
            this.tileGroup2.Items.Add(this.tileItemToplantiListesi);
            this.tileGroup2.Items.Add(this.tileItemKapat);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItemToplantiOlustur
            // 
            this.tileItemToplantiOlustur.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemToplantiOlustur.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemToplantiOlustur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemToplantiOlustur.BackgroundImage")));
            tileItemElement1.Text = "Toplantı Oluştur";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemToplantiOlustur.Elements.Add(tileItemElement1);
            this.tileItemToplantiOlustur.Id = 0;
            this.tileItemToplantiOlustur.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemToplantiOlustur.Name = "tileItemToplantiOlustur";
            this.tileItemToplantiOlustur.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItemToplantiListesi
            // 
            this.tileItemToplantiListesi.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemToplantiListesi.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemToplantiListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemToplantiListesi.BackgroundImage")));
            tileItemElement2.Text = "Toplantı Listesi";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemToplantiListesi.Elements.Add(tileItemElement2);
            this.tileItemToplantiListesi.Id = 1;
            this.tileItemToplantiListesi.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemToplantiListesi.Name = "tileItemToplantiListesi";
            this.tileItemToplantiListesi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItemToplantiListesi_ItemClick);
            // 
            // tileItemKapat
            // 
            this.tileItemKapat.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemKapat.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemKapat.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemKapat.AppearanceItem.Normal.Options.UseFont = true;
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
            // ToplantiIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 471);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ToplantiIslemleri";
            this.Padding = new System.Windows.Forms.Padding(13, 60, 13, 13);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ToplantiIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItemToplantiOlustur;
        private DevExpress.XtraEditors.TileItem tileItemToplantiListesi;
        private DevExpress.XtraEditors.TileItem tileItemKapat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}