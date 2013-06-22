namespace PI_projekt.Sucelja
{
    partial class FrmProdavac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdavac));
            this.msIzbornik = new System.Windows.Forms.MenuStrip();
            this.miOpcije = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpcijeOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpcijeIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarnici = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciUlaznica = new System.Windows.Forms.ToolStripMenuItem();
            this.miSifarniciArtikli = new System.Windows.Forms.ToolStripMenuItem();
            this.statusnaTraka = new System.Windows.Forms.StatusStrip();
            this.sstext = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.msIzbornik.SuspendLayout();
            this.statusnaTraka.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIzbornik
            // 
            this.msIzbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcije,
            this.miSifarnici});
            this.msIzbornik.Location = new System.Drawing.Point(0, 0);
            this.msIzbornik.Name = "msIzbornik";
            this.msIzbornik.Size = new System.Drawing.Size(699, 24);
            this.msIzbornik.TabIndex = 7;
            this.msIzbornik.Text = "Izbornik";
            // 
            // miOpcije
            // 
            this.miOpcije.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpcijeOdjava,
            this.miOpcijeIzlaz});
            this.miOpcije.Name = "miOpcije";
            this.miOpcije.Size = new System.Drawing.Size(53, 20);
            this.miOpcije.Text = "Opcije";
            // 
            // miOpcijeOdjava
            // 
            this.miOpcijeOdjava.Name = "miOpcijeOdjava";
            this.miOpcijeOdjava.Size = new System.Drawing.Size(111, 22);
            this.miOpcijeOdjava.Text = "Odjava";
            this.miOpcijeOdjava.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miOpcijeOdjava_MouseUp);
            // 
            // miOpcijeIzlaz
            // 
            this.miOpcijeIzlaz.Name = "miOpcijeIzlaz";
            this.miOpcijeIzlaz.Size = new System.Drawing.Size(111, 22);
            this.miOpcijeIzlaz.Text = "Izlaz";
            this.miOpcijeIzlaz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miOpcijeIzlaz_MouseUp);
            // 
            // miSifarnici
            // 
            this.miSifarnici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSifarniciUlaznica,
            this.miSifarniciArtikli});
            this.miSifarnici.Name = "miSifarnici";
            this.miSifarnici.Size = new System.Drawing.Size(61, 20);
            this.miSifarnici.Text = "Šifranici";
            // 
            // miSifarniciUlaznica
            // 
            this.miSifarniciUlaznica.Name = "miSifarniciUlaznica";
            this.miSifarniciUlaznica.Size = new System.Drawing.Size(118, 22);
            this.miSifarniciUlaznica.Text = "Ulaznica";
            this.miSifarniciUlaznica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciUlaznica_MouseUp);
            // 
            // miSifarniciArtikli
            // 
            this.miSifarniciArtikli.Name = "miSifarniciArtikli";
            this.miSifarniciArtikli.Size = new System.Drawing.Size(118, 22);
            this.miSifarniciArtikli.Text = "Artikli";
            this.miSifarniciArtikli.MouseUp += new System.Windows.Forms.MouseEventHandler(this.miSifarniciArtikli_MouseUp);
            // 
            // statusnaTraka
            // 
            this.statusnaTraka.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sstext,
            this.ssUsername});
            this.statusnaTraka.Location = new System.Drawing.Point(0, 405);
            this.statusnaTraka.Name = "statusnaTraka";
            this.statusnaTraka.Size = new System.Drawing.Size(699, 22);
            this.statusnaTraka.TabIndex = 9;
            this.statusnaTraka.Text = "status";
            // 
            // sstext
            // 
            this.sstext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sstext.ForeColor = System.Drawing.Color.White;
            this.sstext.Name = "sstext";
            this.sstext.Size = new System.Drawing.Size(101, 17);
            this.sstext.Text = "Prijavljeni ste kao:";
            // 
            // ssUsername
            // 
            this.ssUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ssUsername.ForeColor = System.Drawing.Color.Red;
            this.ssUsername.Name = "ssUsername";
            this.ssUsername.Size = new System.Drawing.Size(59, 17);
            this.ssUsername.Text = "username";
            // 
            // FrmProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_projekt.Properties.Resources.BCKground_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 427);
            this.Controls.Add(this.statusnaTraka);
            this.Controls.Add(this.msIzbornik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIzbornik;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(459, 244);
            this.Name = "FrmProdavac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prodavač";
            this.msIzbornik.ResumeLayout(false);
            this.msIzbornik.PerformLayout();
            this.statusnaTraka.ResumeLayout(false);
            this.statusnaTraka.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIzbornik;
        private System.Windows.Forms.ToolStripMenuItem miOpcije;
        private System.Windows.Forms.ToolStripMenuItem miOpcijeOdjava;
        private System.Windows.Forms.ToolStripMenuItem miOpcijeIzlaz;
        private System.Windows.Forms.ToolStripMenuItem miSifarnici;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciUlaznica;
        private System.Windows.Forms.ToolStripMenuItem miSifarniciArtikli;
        private System.Windows.Forms.StatusStrip statusnaTraka;
        private System.Windows.Forms.ToolStripStatusLabel sstext;
        private System.Windows.Forms.ToolStripStatusLabel ssUsername;
    }
}