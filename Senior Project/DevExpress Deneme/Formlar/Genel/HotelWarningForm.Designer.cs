namespace Otel_Uygulamasi.Formlar.Genel
{
    partial class HotelWarningForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metrolbl = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 70);
            this.label1.TabIndex = 25;
            this.label1.Text = "!";
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroButton2.BackColor = System.Drawing.Color.Transparent;
            this.metroButton2.Location = new System.Drawing.Point(237, 151);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(151, 45);
            this.metroButton2.TabIndex = 24;
            this.metroButton2.Text = "TeamViewer";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metrolbl
            // 
            this.metrolbl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metrolbl.AutoSize = true;
            this.metrolbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metrolbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metrolbl.Location = new System.Drawing.Point(137, 69);
            this.metrolbl.Name = "metrolbl";
            this.metrolbl.Size = new System.Drawing.Size(163, 25);
            this.metrolbl.TabIndex = 22;
            this.metrolbl.Text = "X (XXX) XXX XX XX";
            // 
            // HotelWarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metrolbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "HotelWarningForm";
            this.Resizable = false;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metrolbl;
    }
}