﻿namespace PI_projekt.Sucelja
{
    partial class FrmAdminProjekcijeDodaj
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
            this.lblProjekcijeDodajTrajanjeMin = new System.Windows.Forms.Label();
            this.txtProjekcijeDodajTrajanje = new System.Windows.Forms.TextBox();
            this.lblProjekcijeDodajTrajanje = new System.Windows.Forms.Label();
            this.lblProjekcijeDodajIdDvorane = new System.Windows.Forms.Label();
            this.btnFilmoviDodajOdustani = new System.Windows.Forms.Button();
            this.btnFilmoviDodajSpremi = new System.Windows.Forms.Button();
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.userRole = new System.Windows.Forms.Label();
            this.uloga = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNazivFilma = new System.Windows.Forms.Label();
            this.txtProjekcijeDodajCijena = new System.Windows.Forms.TextBox();
            this.lblProjekcijeDodajCijena = new System.Windows.Forms.Label();
            this.lblProjekcijeDodajDatum = new System.Windows.Forms.Label();
            this.cbBrojDvorana = new System.Windows.Forms.ComboBox();
            this.cbNazivFilma = new System.Windows.Forms.ComboBox();
            this.lbVrsteProjekcija = new System.Windows.Forms.ListBox();
            this.lbOdabrane = new System.Windows.Forms.ListBox();
            this.lblDodaj = new System.Windows.Forms.Button();
            this.lblUkloni = new System.Windows.Forms.Button();
            this.lblVrsteProjekcija = new System.Windows.Forms.Label();
            this.lblOdabrane = new System.Windows.Forms.Label();
            this.dtDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblProjekcijeDodajTrajanjeMin
            // 
            this.lblProjekcijeDodajTrajanjeMin.AutoSize = true;
            this.lblProjekcijeDodajTrajanjeMin.Location = new System.Drawing.Point(198, 123);
            this.lblProjekcijeDodajTrajanjeMin.Name = "lblProjekcijeDodajTrajanjeMin";
            this.lblProjekcijeDodajTrajanjeMin.Size = new System.Drawing.Size(38, 13);
            this.lblProjekcijeDodajTrajanjeMin.TabIndex = 47;
            this.lblProjekcijeDodajTrajanjeMin.Text = "minuta";
            // 
            // txtProjekcijeDodajTrajanje
            // 
            this.txtProjekcijeDodajTrajanje.Location = new System.Drawing.Point(92, 120);
            this.txtProjekcijeDodajTrajanje.Name = "txtProjekcijeDodajTrajanje";
            this.txtProjekcijeDodajTrajanje.Size = new System.Drawing.Size(100, 20);
            this.txtProjekcijeDodajTrajanje.TabIndex = 46;
            // 
            // lblProjekcijeDodajTrajanje
            // 
            this.lblProjekcijeDodajTrajanje.AutoSize = true;
            this.lblProjekcijeDodajTrajanje.Location = new System.Drawing.Point(8, 123);
            this.lblProjekcijeDodajTrajanje.Name = "lblProjekcijeDodajTrajanje";
            this.lblProjekcijeDodajTrajanje.Size = new System.Drawing.Size(48, 13);
            this.lblProjekcijeDodajTrajanje.TabIndex = 44;
            this.lblProjekcijeDodajTrajanje.Text = "Trajanje:";
            // 
            // lblProjekcijeDodajIdDvorane
            // 
            this.lblProjekcijeDodajIdDvorane.AutoSize = true;
            this.lblProjekcijeDodajIdDvorane.Location = new System.Drawing.Point(8, 69);
            this.lblProjekcijeDodajIdDvorane.Name = "lblProjekcijeDodajIdDvorane";
            this.lblProjekcijeDodajIdDvorane.Size = new System.Drawing.Size(70, 13);
            this.lblProjekcijeDodajIdDvorane.TabIndex = 43;
            this.lblProjekcijeDodajIdDvorane.Text = "Broj dvorane:";
            // 
            // btnFilmoviDodajOdustani
            // 
            this.btnFilmoviDodajOdustani.Location = new System.Drawing.Point(201, 215);
            this.btnFilmoviDodajOdustani.Name = "btnFilmoviDodajOdustani";
            this.btnFilmoviDodajOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodajOdustani.TabIndex = 42;
            this.btnFilmoviDodajOdustani.Text = "Odustani";
            this.btnFilmoviDodajOdustani.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajOdustani.Click += new System.EventHandler(this.btnProjekcijeDodajOdustani_Click);
            // 
            // btnFilmoviDodajSpremi
            // 
            this.btnFilmoviDodajSpremi.Location = new System.Drawing.Point(101, 215);
            this.btnFilmoviDodajSpremi.Name = "btnFilmoviDodajSpremi";
            this.btnFilmoviDodajSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodajSpremi.TabIndex = 41;
            this.btnFilmoviDodajSpremi.Text = "Spremi";
            this.btnFilmoviDodajSpremi.UseVisualStyleBackColor = true;
            this.btnFilmoviDodajSpremi.Click += new System.EventHandler(this.btnFilmoviDodajSpremi_Click);
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(237, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(39, 13);
            this.Odjava.TabIndex = 40;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            this.Odjava.Click += new System.EventHandler(this.btnProjekcijeDodajOdustani_Click);
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userRole.ForeColor = System.Drawing.Color.Red;
            this.userRole.Location = new System.Drawing.Point(54, 34);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(33, 13);
            this.userRole.TabIndex = 39;
            this.userRole.Text = "uloga";
            // 
            // uloga
            // 
            this.uloga.AutoSize = true;
            this.uloga.BackColor = System.Drawing.Color.Black;
            this.uloga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.uloga.Location = new System.Drawing.Point(9, 34);
            this.uloga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uloga.Name = "uloga";
            this.uloga.Size = new System.Drawing.Size(38, 13);
            this.uloga.TabIndex = 38;
            this.uloga.Text = "Uloga:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userName.ForeColor = System.Drawing.Color.Red;
            this.userName.Location = new System.Drawing.Point(108, 10);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(74, 13);
            this.userName.TabIndex = 37;
            this.userName.Text = "korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Prijavljeni ste kao:";
            // 
            // lblNazivFilma
            // 
            this.lblNazivFilma.AutoSize = true;
            this.lblNazivFilma.Location = new System.Drawing.Point(8, 95);
            this.lblNazivFilma.Name = "lblNazivFilma";
            this.lblNazivFilma.Size = new System.Drawing.Size(61, 13);
            this.lblNazivFilma.TabIndex = 48;
            this.lblNazivFilma.Text = "Naziv filma:";
            // 
            // txtProjekcijeDodajCijena
            // 
            this.txtProjekcijeDodajCijena.Location = new System.Drawing.Point(92, 146);
            this.txtProjekcijeDodajCijena.Name = "txtProjekcijeDodajCijena";
            this.txtProjekcijeDodajCijena.Size = new System.Drawing.Size(100, 20);
            this.txtProjekcijeDodajCijena.TabIndex = 51;
            // 
            // lblProjekcijeDodajCijena
            // 
            this.lblProjekcijeDodajCijena.AutoSize = true;
            this.lblProjekcijeDodajCijena.Location = new System.Drawing.Point(8, 149);
            this.lblProjekcijeDodajCijena.Name = "lblProjekcijeDodajCijena";
            this.lblProjekcijeDodajCijena.Size = new System.Drawing.Size(81, 13);
            this.lblProjekcijeDodajCijena.TabIndex = 50;
            this.lblProjekcijeDodajCijena.Text = "Cijena ulaznice:";
            // 
            // lblProjekcijeDodajDatum
            // 
            this.lblProjekcijeDodajDatum.AutoSize = true;
            this.lblProjekcijeDodajDatum.Location = new System.Drawing.Point(8, 175);
            this.lblProjekcijeDodajDatum.Name = "lblProjekcijeDodajDatum";
            this.lblProjekcijeDodajDatum.Size = new System.Drawing.Size(41, 13);
            this.lblProjekcijeDodajDatum.TabIndex = 52;
            this.lblProjekcijeDodajDatum.Text = "Datum:";
            // 
            // cbBrojDvorana
            // 
            this.cbBrojDvorana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBrojDvorana.FormattingEnabled = true;
            this.cbBrojDvorana.Location = new System.Drawing.Point(101, 69);
            this.cbBrojDvorana.Name = "cbBrojDvorana";
            this.cbBrojDvorana.Size = new System.Drawing.Size(121, 21);
            this.cbBrojDvorana.TabIndex = 54;
            // 
            // cbNazivFilma
            // 
            this.cbNazivFilma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazivFilma.FormattingEnabled = true;
            this.cbNazivFilma.Location = new System.Drawing.Point(101, 95);
            this.cbNazivFilma.Name = "cbNazivFilma";
            this.cbNazivFilma.Size = new System.Drawing.Size(121, 21);
            this.cbNazivFilma.TabIndex = 55;
            // 
            // lbVrsteProjekcija
            // 
            this.lbVrsteProjekcija.DisplayMember = "Naziv";
            this.lbVrsteProjekcija.FormattingEnabled = true;
            this.lbVrsteProjekcija.Location = new System.Drawing.Point(318, 69);
            this.lbVrsteProjekcija.Name = "lbVrsteProjekcija";
            this.lbVrsteProjekcija.Size = new System.Drawing.Size(172, 95);
            this.lbVrsteProjekcija.TabIndex = 56;
            // 
            // lbOdabrane
            // 
            this.lbOdabrane.DisplayMember = "Naziv";
            this.lbOdabrane.FormattingEnabled = true;
            this.lbOdabrane.Location = new System.Drawing.Point(607, 71);
            this.lbOdabrane.Name = "lbOdabrane";
            this.lbOdabrane.Size = new System.Drawing.Size(158, 95);
            this.lbOdabrane.TabIndex = 57;
            // 
            // lblDodaj
            // 
            this.lblDodaj.Location = new System.Drawing.Point(509, 69);
            this.lblDodaj.Name = "lblDodaj";
            this.lblDodaj.Size = new System.Drawing.Size(75, 37);
            this.lblDodaj.TabIndex = 58;
            this.lblDodaj.Text = "Dodaj";
            this.lblDodaj.UseVisualStyleBackColor = true;
            this.lblDodaj.Click += new System.EventHandler(this.lblDodaj_Click);
            // 
            // lblUkloni
            // 
            this.lblUkloni.Location = new System.Drawing.Point(509, 123);
            this.lblUkloni.Name = "lblUkloni";
            this.lblUkloni.Size = new System.Drawing.Size(75, 39);
            this.lblUkloni.TabIndex = 59;
            this.lblUkloni.Text = "Ukloni";
            this.lblUkloni.UseVisualStyleBackColor = true;
            this.lblUkloni.Click += new System.EventHandler(this.lblUkloni_Click);
            // 
            // lblVrsteProjekcija
            // 
            this.lblVrsteProjekcija.AutoSize = true;
            this.lblVrsteProjekcija.Location = new System.Drawing.Point(331, 34);
            this.lblVrsteProjekcija.Name = "lblVrsteProjekcija";
            this.lblVrsteProjekcija.Size = new System.Drawing.Size(79, 13);
            this.lblVrsteProjekcija.TabIndex = 61;
            this.lblVrsteProjekcija.Text = "Vrste projekcija";
            // 
            // lblOdabrane
            // 
            this.lblOdabrane.AutoSize = true;
            this.lblOdabrane.Location = new System.Drawing.Point(639, 34);
            this.lblOdabrane.Name = "lblOdabrane";
            this.lblOdabrane.Size = new System.Drawing.Size(54, 13);
            this.lblOdabrane.TabIndex = 62;
            this.lblOdabrane.Text = "Odabrane";
            // 
            // dtDatum
            // 
            this.dtDatum.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dtDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDatum.Location = new System.Drawing.Point(92, 167);
            this.dtDatum.Name = "dtDatum";
            this.dtDatum.ShowUpDown = true;
            this.dtDatum.Size = new System.Drawing.Size(200, 20);
            this.dtDatum.TabIndex = 63;
            // 
            // FrmAdminProjekcijeDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 367);
            this.Controls.Add(this.dtDatum);
            this.Controls.Add(this.lblOdabrane);
            this.Controls.Add(this.lblVrsteProjekcija);
            this.Controls.Add(this.lblUkloni);
            this.Controls.Add(this.lblDodaj);
            this.Controls.Add(this.lbOdabrane);
            this.Controls.Add(this.lbVrsteProjekcija);
            this.Controls.Add(this.cbNazivFilma);
            this.Controls.Add(this.cbBrojDvorana);
            this.Controls.Add(this.lblProjekcijeDodajDatum);
            this.Controls.Add(this.txtProjekcijeDodajCijena);
            this.Controls.Add(this.lblProjekcijeDodajCijena);
            this.Controls.Add(this.lblNazivFilma);
            this.Controls.Add(this.lblProjekcijeDodajTrajanjeMin);
            this.Controls.Add(this.txtProjekcijeDodajTrajanje);
            this.Controls.Add(this.lblProjekcijeDodajTrajanje);
            this.Controls.Add(this.lblProjekcijeDodajIdDvorane);
            this.Controls.Add(this.btnFilmoviDodajOdustani);
            this.Controls.Add(this.btnFilmoviDodajSpremi);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.uloga);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdminProjekcijeDodaj";
            this.Text = "Admin Dodaj Projekciju";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdminProjekcijeDodaj_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdminProjekcijeDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjekcijeDodajTrajanjeMin;
        private System.Windows.Forms.TextBox txtProjekcijeDodajTrajanje;
        private System.Windows.Forms.Label lblProjekcijeDodajTrajanje;
        private System.Windows.Forms.Label lblProjekcijeDodajIdDvorane;
        private System.Windows.Forms.Button btnFilmoviDodajOdustani;
        private System.Windows.Forms.Button btnFilmoviDodajSpremi;
        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label uloga;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNazivFilma;
        private System.Windows.Forms.TextBox txtProjekcijeDodajCijena;
        private System.Windows.Forms.Label lblProjekcijeDodajCijena;
        private System.Windows.Forms.Label lblProjekcijeDodajDatum;
        private System.Windows.Forms.ComboBox cbBrojDvorana;
        private System.Windows.Forms.ComboBox cbNazivFilma;
        private System.Windows.Forms.ListBox lbVrsteProjekcija;
        private System.Windows.Forms.ListBox lbOdabrane;
        private System.Windows.Forms.Button lblDodaj;
        private System.Windows.Forms.Button lblUkloni;
        private System.Windows.Forms.Label lblVrsteProjekcija;
        private System.Windows.Forms.Label lblOdabrane;
        private System.Windows.Forms.DateTimePicker dtDatum;
    }
}