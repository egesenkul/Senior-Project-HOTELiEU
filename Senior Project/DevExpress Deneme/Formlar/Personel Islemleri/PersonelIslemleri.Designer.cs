namespace Otel_Uygulamasi.Formlar.Personel_Islemleri
{
    partial class PersonelIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonelIslemleri));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileControl2 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemPersonelOlusturma = new DevExpress.XtraEditors.TileItem();
            this.tileItemPersonelListesi = new DevExpress.XtraEditors.TileItem();
            this.tileItemKapat = new DevExpress.XtraEditors.TileItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Location = new System.Drawing.Point(20, 60);
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(757, 427);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileControl2
            // 
            this.tileControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl2.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl2.Groups.Add(this.tileGroup2);
            this.tileControl2.ItemSize = 180;
            this.tileControl2.Location = new System.Drawing.Point(20, 60);
            this.tileControl2.MaxId = 3;
            this.tileControl2.Name = "tileControl2";
            this.tileControl2.Size = new System.Drawing.Size(757, 427);
            this.tileControl2.TabIndex = 1;
            this.tileControl2.Text = "tileControl2";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItemPersonelOlusturma);
            this.tileGroup2.Items.Add(this.tileItemPersonelListesi);
            this.tileGroup2.Items.Add(this.tileItemKapat);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItemPersonelOlusturma
            // 
            this.tileItemPersonelOlusturma.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemPersonelOlusturma.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemPersonelOlusturma.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelOlusturma.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelOlusturma.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelOlusturma.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemPersonelOlusturma.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemPersonelOlusturma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemPersonelOlusturma.BackgroundImage")));
            tileItemElement1.Text = "Personel Oluşturma";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemPersonelOlusturma.Elements.Add(tileItemElement1);
            this.tileItemPersonelOlusturma.Id = 0;
            this.tileItemPersonelOlusturma.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemPersonelOlusturma.Name = "tileItemPersonelOlusturma";
            this.tileItemPersonelOlusturma.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItemPersonelListesi
            // 
            this.tileItemPersonelListesi.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemPersonelListesi.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemPersonelListesi.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelListesi.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelListesi.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelListesi.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemPersonelListesi.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemPersonelListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemPersonelListesi.BackgroundImage")));
            tileItemElement2.Text = "Personel Listesi";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemPersonelListesi.Elements.Add(tileItemElement2);
            this.tileItemPersonelListesi.Id = 1;
            this.tileItemPersonelListesi.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemPersonelListesi.Name = "tileItemPersonelListesi";
            this.tileItemPersonelListesi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItemKapat
            // 
            this.tileItemKapat.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.tileItemKapat.AppearanceItem.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
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
            // PersonelIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 507);
            this.Controls.Add(this.tileControl2);
            this.Controls.Add(this.tileControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "PersonelIslemleri";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PersonelIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileControl tileControl2;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItemPersonelOlusturma;
        private DevExpress.XtraEditors.TileItem tileItemPersonelListesi;
        private DevExpress.XtraEditors.TileItem tileItemKapat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    }
}