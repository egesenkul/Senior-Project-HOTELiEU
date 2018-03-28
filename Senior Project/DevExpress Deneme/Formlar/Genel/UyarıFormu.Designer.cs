namespace Otel_Uygulamasi.Formlar.Genel
{
    partial class UyarıFormu
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
            this.btnSol = new MetroFramework.Controls.MetroButton();
            this.btnSag = new MetroFramework.Controls.MetroButton();
            this.lblUyari = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnSol
            // 
            this.btnSol.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSol.Location = new System.Drawing.Point(45, 223);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(185, 52);
            this.btnSol.TabIndex = 15;
            this.btnSol.Text = "Alpemix";
            this.btnSol.UseCustomBackColor = true;
            this.btnSol.UseCustomForeColor = true;
            this.btnSol.UseSelectable = true;
            // 
            // btnSag
            // 
            this.btnSag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSag.BackColor = System.Drawing.Color.Red;
            this.btnSag.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSag.Location = new System.Drawing.Point(341, 223);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(185, 52);
            this.btnSag.TabIndex = 16;
            this.btnSag.Text = "Alpemix";
            this.btnSag.UseCustomBackColor = true;
            this.btnSag.UseCustomForeColor = true;
            this.btnSag.UseSelectable = true;
            // 
            // lblUyari
            // 
            this.lblUyari.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUyari.AutoSize = true;
            this.lblUyari.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUyari.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUyari.Location = new System.Drawing.Point(45, 88);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(185, 25);
            this.lblUyari.TabIndex = 17;
            this.lblUyari.Text = "Destek Programları :";
            // 
            // UyarıFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 298);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.btnSol);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "UyarıFormu";
            this.Resizable = false;
            this.Text = "HoteliEU";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.UyarıFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnSol;
        private MetroFramework.Controls.MetroButton btnSag;
        private MetroFramework.Controls.MetroLabel lblUyari;
    }
}