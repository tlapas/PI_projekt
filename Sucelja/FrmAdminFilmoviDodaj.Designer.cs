﻿namespace PI_projekt.Sucelja
{
    partial class FrmAdminFilmoviDodaj
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
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilmoviDodajSpremi = new System.Windows.Forms.Button();
            this.btnFilmoviDodajOdustani = new System.Windows.Forms.Button();
            this.lblFilmoviDodajNaziv = new System.Windows.Forms.Label();
            this.lblFilmoviDodajTrajanje = new System.Windows.Forms.Label();
            this.txtDodajFilmNaziv = new System.Windows.Forms.TextBox();
            this.txtFilmoviDodajTrajanje = new System.Windows.Forms.TextBox();
            this.lblFilmoviDodajTrajanjeMin = new System.Windows.Forms.Label();
            this.lblDilmoviDodajZanrovi = new System.Windows.Forms.Label();
            this.lblFilmoviDodajZanroviOdabrani = new System.Windows.Forms.Label();
            this.lbFilmoviDodajZanrovi = new System.Windows.Forms.ListBox();
            this.lbFilmoviDodajZanroviOdabrani = new System.Windows.Forms.ListBox();
            this.btnFilmoviDodajDodajLb = new System.Windows.Forms.Button();
            this.btnFilmoviDodajOdustaniLb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(374, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(39, 13);
            this.Odjava.TabIndex = 28;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Odjava_LinkClicked);
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(58, 33);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 27;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(13, 33);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(38, 13);
            this.uloga.TabIndex = 26;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(112, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(74, 13);
            this.userName.TabIndex = 25;
            this.userName.Text = "korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Prijavljeni ste kao:";
            // 
            // btnFilmoviDodajSpremi
            // 
            this.btnFilmoviDodajSpremi.Location = new System.Drawing.Point(15, 284);
            this.btnFilmoviDodajSpremi.Name = "btnFilmoviDodajSpremi";
            this.btnFilmoviDodajSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodajSpremi.TabIndex = 29;
            this.btnFilmoviDodajSpremi.Text = "Spremi";
            this.btnFilmoviDodajSpremi.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajSpremi.Click += new System.EventHandler(this.btnFilmoviDodajSpremi_Click);
            // 
            // btnFilmoviDodajOdustani
            // 
            this.btnFilmoviDodajOdustani.Location = new System.Drawing.Point(115, 284);
            this.btnFilmoviDodajOdustani.Name = "btnFilmoviDodajOdustani";
            this.btnFilmoviDodajOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodajOdustani.TabIndex = 30;
            this.btnFilmoviDodajOdustani.Text = "Odustani";
            this.btnFilmoviDodajOdustani.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajOdustani.Click += new System.EventHandler(this.btnFilmoviDodajOdustani_Click);
            // 
            // lblFilmoviDodajNaziv
            // 
            this.lblFilmoviDodajNaziv.AutoSize = true;
            this.lblFilmoviDodajNaziv.Location = new System.Drawing.Point(12, 68);
            this.lblFilmoviDodajNaziv.Name = "lblFilmoviDodajNaziv";
            this.lblFilmoviDodajNaziv.Size = new System.Drawing.Size(61, 13);
            this.lblFilmoviDodajNaziv.TabIndex = 31;
            this.lblFilmoviDodajNaziv.Text = "Naziv filma:";
            // 
            // lblFilmoviDodajTrajanje
            // 
            this.lblFilmoviDodajTrajanje.AutoSize = true;
            this.lblFilmoviDodajTrajanje.Location = new System.Drawing.Point(12, 101);
            this.lblFilmoviDodajTrajanje.Name = "lblFilmoviDodajTrajanje";
            this.lblFilmoviDodajTrajanje.Size = new System.Drawing.Size(48, 13);
            this.lblFilmoviDodajTrajanje.TabIndex = 32;
            this.lblFilmoviDodajTrajanje.Text = "Trajanje:";
            // 
            // txtDodajFilmNaziv
            // 
            this.txtDodajFilmNaziv.Location = new System.Drawing.Point(96, 65);
            this.txtDodajFilmNaziv.Name = "txtDodajFilmNaziv";
            this.txtDodajFilmNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtDodajFilmNaziv.TabIndex = 33;
            // 
            // txtFilmoviDodajTrajanje
            // 
            this.txtFilmoviDodajTrajanje.Location = new System.Drawing.Point(96, 98);
            this.txtFilmoviDodajTrajanje.Name = "txtFilmoviDodajTrajanje";
            this.txtFilmoviDodajTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtFilmoviDodajTrajanje.TabIndex = 34;
            // 
            // lblFilmoviDodajTrajanjeMin
            // 
            this.lblFilmoviDodajTrajanjeMin.AutoSize = true;
            this.lblFilmoviDodajTrajanjeMin.Location = new System.Drawing.Point(202, 101);
            this.lblFilmoviDodajTrajanjeMin.Name = "lblFilmoviDodajTrajanjeMin";
            this.lblFilmoviDodajTrajanjeMin.Size = new System.Drawing.Size(38, 13);
            this.lblFilmoviDodajTrajanjeMin.TabIndex = 35;
            this.lblFilmoviDodajTrajanjeMin.Text = "minuta";
            // 
            // lblDilmoviDodajZanrovi
            // 
            this.lblDilmoviDodajZanrovi.AutoSize = true;
            this.lblDilmoviDodajZanrovi.Location = new System.Drawing.Point(13, 145);
            this.lblDilmoviDodajZanrovi.Name = "lblDilmoviDodajZanrovi";
            this.lblDilmoviDodajZanrovi.Size = new System.Drawing.Size(73, 13);
            this.lblDilmoviDodajZanrovi.TabIndex = 36;
            this.lblDilmoviDodajZanrovi.Text = "Lista žanrova:";
            // 
            // lblFilmoviDodajZanroviOdabrani
            // 
            this.lblFilmoviDodajZanroviOdabrani.AutoSize = true;
            this.lblFilmoviDodajZanroviOdabrani.Location = new System.Drawing.Point(290, 145);
            this.lblFilmoviDodajZanroviOdabrani.Name = "lblFilmoviDodajZanroviOdabrani";
            this.lblFilmoviDodajZanroviOdabrani.Size = new System.Drawing.Size(90, 13);
            this.lblFilmoviDodajZanroviOdabrani.TabIndex = 37;
            this.lblFilmoviDodajZanroviOdabrani.Text = "Odabrani žanrovi:";
            // 
            // lbFilmoviDodajZanrovi
            // 
            this.lbFilmoviDodajZanrovi.DisplayMember = "Naziv";
            this.lbFilmoviDodajZanrovi.FormattingEnabled = true;
            this.lbFilmoviDodajZanrovi.Location = new System.Drawing.Point(12, 170);
            this.lbFilmoviDodajZanrovi.Name = "lbFilmoviDodajZanrovi";
            this.lbFilmoviDodajZanrovi.Size = new System.Drawing.Size(120, 95);
            this.lbFilmoviDodajZanrovi.TabIndex = 38;
            this.lbFilmoviDodajZanrovi.ValueMember = "idZanra";
            // 
            // lbFilmoviDodajZanroviOdabrani
            // 
            this.lbFilmoviDodajZanroviOdabrani.DisplayMember = "Naziv";
            this.lbFilmoviDodajZanroviOdabrani.FormattingEnabled = true;
            this.lbFilmoviDodajZanroviOdabrani.Location = new System.Drawing.Point(293, 170);
            this.lbFilmoviDodajZanroviOdabrani.Name = "lbFilmoviDodajZanroviOdabrani";
            this.lbFilmoviDodajZanroviOdabrani.Size = new System.Drawing.Size(120, 95);
            this.lbFilmoviDodajZanroviOdabrani.TabIndex = 39;
            // 
            // btnFilmoviDodajDodajLb
            // 
            this.btnFilmoviDodajDodajLb.Location = new System.Drawing.Point(177, 186);
            this.btnFilmoviDodajDodajLb.Name = "btnFilmoviDodajDodajLb";
            this.btnFilmoviDodajDodajLb.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodajDodajLb.TabIndex = 40;
            this.btnFilmoviDodajDodajLb.Text = "Dodaj";
            this.btnFilmoviDodajDodajLb.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajDodajLb.Click += new System.EventHandler(this.btnFilmoviDodajDodajLb_Click);
            // 
            // btnFilmoviDodajOdustaniLb
            // 
            this.btnFilmoviDodajOdustaniLb.Location = new System.Drawing.Point(177, 227);
            this.btnFilmoviDodajOdustaniLb.Name = "btnFilmoviDodajOdustaniLb";
            this.btnFilmoviDodajOdustaniLb.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodajOdustaniLb.TabIndex = 41;
            this.btnFilmoviDodajOdustaniLb.Text = "Odustani";
            this.btnFilmoviDodajOdustaniLb.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajOdustaniLb.Click += new System.EventHandler(this.btnFilmoviDodajOdustaniLb_Click);
            // 
            // FrmAdminFilmoviDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 312);
            this.Controls.Add(this.btnFilmoviDodajOdustaniLb);
            this.Controls.Add(this.btnFilmoviDodajDodajLb);
            this.Controls.Add(this.lbFilmoviDodajZanroviOdabrani);
            this.Controls.Add(this.lbFilmoviDodajZanrovi);
            this.Controls.Add(this.lblFilmoviDodajZanroviOdabrani);
            this.Controls.Add(this.lblDilmoviDodajZanrovi);
            this.Controls.Add(this.lblFilmoviDodajTrajanjeMin);
            this.Controls.Add(this.txtFilmoviDodajTrajanje);
            this.Controls.Add(this.txtDodajFilmNaziv);
            this.Controls.Add(this.lblFilmoviDodajTrajanje);
            this.Controls.Add(this.lblFilmoviDodajNaziv);
            this.Controls.Add(this.btnFilmoviDodajOdustani);
            this.Controls.Add(this.btnFilmoviDodajSpremi);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmAdminFilmoviDodaj";
            this.Text = "Admin Dodaj Film";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminFilmoviDodaj_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdminFilmDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFilmoviDodajSpremi;
        private System.Windows.Forms.Button btnFilmoviDodajOdustani;
        private System.Windows.Forms.Label lblFilmoviDodajNaziv;
        private System.Windows.Forms.Label lblFilmoviDodajTrajanje;
        private System.Windows.Forms.TextBox txtDodajFilmNaziv;
        private System.Windows.Forms.TextBox txtFilmoviDodajTrajanje;
        private System.Windows.Forms.Label lblFilmoviDodajTrajanjeMin;
        private System.Windows.Forms.Label lblDilmoviDodajZanrovi;
        private System.Windows.Forms.Label lblFilmoviDodajZanroviOdabrani;
        private System.Windows.Forms.ListBox lbFilmoviDodajZanrovi;
        private System.Windows.Forms.ListBox lbFilmoviDodajZanroviOdabrani;
        private System.Windows.Forms.Button btnFilmoviDodajDodajLb;
        private System.Windows.Forms.Button btnFilmoviDodajOdustaniLb;
    }
}