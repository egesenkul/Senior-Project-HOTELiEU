namespace Otel_Uygulamasi.Formlar.TemizlikIslemleri
{
    partial class TemizlikIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemizlikIslemleri));
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItemOdaKontrol = new DevExpress.XtraEditors.TileItem();
            this.tileItemPersonelKontrol = new DevExpress.XtraEditors.TileItem();
            this.tileItemKapat = new DevExpress.XtraEditors.TileItem();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileControl1
            // 
            this.tileControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileControl1.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl1.Groups.Add(this.tileGroup2);
            this.tileControl1.ItemSize = 180;
            this.tileControl1.Location = new System.Drawing.Point(20, 60);
            this.tileControl1.MaxId = 8;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(1133, 510);
            this.tileControl1.TabIndex = 0;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItemOdaKontrol);
            this.tileGroup2.Items.Add(this.tileItemPersonelKontrol);
            this.tileGroup2.Items.Add(this.tileItemKapat);
            this.tileGroup2.Items.Add(this.tileItem1);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItemOdaKontrol
            // 
            this.tileItemOdaKontrol.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemOdaKontrol.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemOdaKontrol.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemOdaKontrol.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemOdaKontrol.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemOdaKontrol.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemOdaKontrol.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemOdaKontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemOdaKontrol.BackgroundImage")));
            tileItemElement1.Text = "Oda Kontrol";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemOdaKontrol.Elements.Add(tileItemElement1);
            this.tileItemOdaKontrol.Id = 0;
            this.tileItemOdaKontrol.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemOdaKontrol.Name = "tileItemOdaKontrol";
            this.tileItemOdaKontrol.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItemPersonelKontrol
            // 
            this.tileItemPersonelKontrol.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItemPersonelKontrol.AppearanceItem.Normal.Options.UseFont = true;
            this.tileItemPersonelKontrol.AppearanceItem.Pressed.BackColor = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelKontrol.AppearanceItem.Pressed.BackColor2 = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelKontrol.AppearanceItem.Pressed.BorderColor = System.Drawing.Color.YellowGreen;
            this.tileItemPersonelKontrol.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileItemPersonelKontrol.AppearanceItem.Pressed.Options.UseBorderColor = true;
            this.tileItemPersonelKontrol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tileItemPersonelKontrol.BackgroundImage")));
            tileItemElement2.Text = "Personel Kontrol";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItemPersonelKontrol.Elements.Add(tileItemElement2);
            this.tileItemPersonelKontrol.Id = 1;
            this.tileItemPersonelKontrol.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemPersonelKontrol.Name = "tileItemPersonelKontrol";
            this.tileItemPersonelKontrol.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
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
            this.tileItemKapat.Id = 5;
            this.tileItemKapat.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemKapat.Name = "tileItemKapat";
            this.tileItemKapat.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem4_ItemClick);
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Temizlik Yap";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileItem1.Elements.Add(tileItemElement4);
            this.tileItem1.Id = 7;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Large;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick_1);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // TemizlikIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 590);
            this.Controls.Add(this.tileControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "TemizlikIslemleri";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TemizlikIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItemOdaKontrol;
        private DevExpress.XtraEditors.TileItem tileItemPersonelKontrol;
        private DevExpress.XtraEditors.TileItem tileItemKapat;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private DevExpress.XtraEditors.TileItem tileItem1;
    }
}