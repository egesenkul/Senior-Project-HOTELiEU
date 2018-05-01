namespace DevExpress_Deneme
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemMusteriTanimlama = new DevExpress.XtraEditors.TileItem();
            this.tileItemMusteriListesi = new DevExpress.XtraEditors.TileItem();
            this.tileItemMusteriOdaIliskilendir = new DevExpress.XtraEditors.TileItem();
            this.tileItemKapat = new DevExpress.XtraEditors.TileItem();
            this.tileSureUzat = new DevExpress.XtraEditors.TileItem();
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
            this.tileControl1.MaxId = 11;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(898, 558);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItemMusteriTanimlama);
            this.tileGroup2.Items.Add(this.tileItemMusteriListesi);
            this.tileGroup2.Items.Add(this.tileItemMusteriOdaIliskilendir);
            this.tileGroup2.Items.Add(this.tileItemKapat);
            this.tileGroup2.Items.Add(this.tileSureUzat);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItemMusteriTanimlama
            // 
            this.tileItemMusteriTanimlama.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemMusteriTanimlama.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemMusteriTanimlama.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriTanimlama.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriTanimlama.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriTanimlama.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemMusteriTanimlama.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemMusteriTanimlama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemMusteriTanimlama.BackgroundImage")));
            tileItemElement1.Text = "Müşteri Tanımlama";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemMusteriTanimlama.Elements.Add(tileItemElement1);
            this.tileItemMusteriTanimlama.Id = 7;
            this.tileItemMusteriTanimlama.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemMusteriTanimlama.Name = "tileItemMusteriTanimlama";
            this.tileItemMusteriTanimlama.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItemMusteriListesi
            // 
            this.tileItemMusteriListesi.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemMusteriListesi.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemMusteriListesi.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriListesi.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriListesi.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriListesi.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemMusteriListesi.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemMusteriListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemMusteriListesi.BackgroundImage")));
            tileItemElement2.Text = "Müşteri Listesi";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemMusteriListesi.Elements.Add(tileItemElement2);
            this.tileItemMusteriListesi.Id = 8;
            this.tileItemMusteriListesi.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemMusteriListesi.Name = "tileItemMusteriListesi";
            this.tileItemMusteriListesi.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // tileItemMusteriOdaIliskilendir
            // 
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemMusteriOdaIliskilendir.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemMusteriOdaIliskilendir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemMusteriOdaIliskilendir.BackgroundImage")));
            tileItemElement3.Text = "Müşteri Check-in";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemMusteriOdaIliskilendir.Elements.Add(tileItemElement3);
            this.tileItemMusteriOdaIliskilendir.Id = 9;
            this.tileItemMusteriOdaIliskilendir.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemMusteriOdaIliskilendir.Name = "tileItemMusteriOdaIliskilendir";
            this.tileItemMusteriOdaIliskilendir.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem3_ItemClick);
            // 
            // tileItemKapat
            // 
            this.tileItemKapat.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BackColor2 = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileItemKapat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tileItemKapat.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItemKapat.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItemKapat.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemKapat.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemKapat.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemKapat.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemKapat.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemKapat.AppearanceItem.Pressed.Options.UseBorderColor = true;
            tileItemElement4.Text = "Kapat";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemKapat.Elements.Add(tileItemElement4);
            this.tileItemKapat.Id = 4;
            this.tileItemKapat.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemKapat.Name = "tileItemKapat";
            this.tileItemKapat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // tileSureUzat
            // 
            this.tileSureUzat.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileSureUzat.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement5.Text = "Süre Uzat";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileSureUzat.Elements.Add(tileItemElement5);
            this.tileSureUzat.Id = 10;
            this.tileSureUzat.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileSureUzat.Name = "tileSureUzat";
            this.tileSureUzat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileSureUzat_ItemClick);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 638);
            this.Controls.Add(this.tileControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "Form4";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItemKapat;
        private DevExpress.XtraEditors.TileItem tileItemMusteriTanimlama;
        private DevExpress.XtraEditors.TileItem tileItemMusteriListesi;
        private DevExpress.XtraEditors.TileItem tileItemMusteriOdaIliskilendir;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private DevExpress.XtraEditors.TileItem tileSureUzat;
    }
}