namespace PI_projekt.Ulaznica
{
    partial class FrmUlaznica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUlaznica));
            this.Odjava = new System.Windows.Forms.LinkLabel();
            this.Prijava = new System.Windows.Forms.Label();
            this.lblDatumProjekcije = new System.Windows.Forms.Label();
            this.lblNazivProjekcije = new System.Windows.Forms.Label();
            this.cbNazivProjekcije = new System.Windows.Forms.ComboBox();
            this.Nazad = new System.Windows.Forms.Button();
            this.Dalje = new System.Windows.Forms.Button();
            this.Opcije = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbSjedala = new System.Windows.Forms.ListBox();
            this.cbDatum = new System.Windows.Forms.ComboBox();
            this.lblSjedalo = new System.Windows.Forms.Label();
            this.lblDvorana = new System.Windows.Forms.Label();
            this.cbDvorana = new System.Windows.Forms.ComboBox();
            this.Opcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // Odjava
            // 
            this.Odjava.AutoSize = true;
            this.Odjava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Odjava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Odjava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Odjava.LinkColor = System.Drawing.Color.Yellow;
            this.Odjava.Location = new System.Drawing.Point(1074, 9);
            this.Odjava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(63, 20);
            this.Odjava.TabIndex = 18;
            this.Odjava.TabStop = true;
            this.Odjava.Text = "odjava";
            // 
            // Prijava
            // 
            this.Prijava.AutoSize = true;
            this.Prijava.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Prijava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Prijava.Location = new System.Drawing.Point(9, 9);
            this.Prijava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prijava.Name = "Prijava";
            this.Prijava.Size = new System.Drawing.Size(165, 20);
            this.Prijava.TabIndex = 17;
            this.Prijava.Text = "Prijavljeni ste kao:";
            // 
            // lblDatumProjekcije
            // 
            this.lblDatumProjekcije.AutoSize = true;
            this.lblDatumProjekcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDatumProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatumProjekcije.Location = new System.Drawing.Point(7, 67);
            this.lblDatumProjekcije.Name = "lblDatumProjekcije";
            this.lblDatumProjekcije.Size = new System.Drawing.Size(157, 20);
            this.lblDatumProjekcije.TabIndex = 19;
            this.lblDatumProjekcije.Text = "Datum projekcije:";
            // 
            // lblNazivProjekcije
            // 
            this.lblNazivProjekcije.AutoSize = true;
            this.lblNazivProjekcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNazivProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNazivProjekcije.Location = new System.Drawing.Point(7, 33);
            this.lblNazivProjekcije.Name = "lblNazivProjekcije";
            this.lblNazivProjekcije.Size = new System.Drawing.Size(151, 20);
            this.lblNazivProjekcije.TabIndex = 20;
            this.lblNazivProjekcije.Text = "Naziv Projekcije:";
            // 
            // cbNazivProjekcije
            // 
            this.cbNazivProjekcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbNazivProjekcije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNazivProjekcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbNazivProjekcije.FormattingEnabled = true;
            this.cbNazivProjekcije.Location = new System.Drawing.Point(165, 30);
            this.cbNazivProjekcije.Name = "cbNazivProjekcije";
            this.cbNazivProjekcije.Size = new System.Drawing.Size(333, 28);
            this.cbNazivProjekcije.TabIndex = 21;
            this.cbNazivProjekcije.SelectedIndexChanged += new System.EventHandler(this.cbNazivProjekcije_SelectedIndexChanged);
            // 
            // Nazad
            // 
            this.Nazad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nazad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nazad.Location = new System.Drawing.Point(6, 547);
            this.Nazad.Margin = new System.Windows.Forms.Padding(4);
            this.Nazad.Name = "Nazad";
            this.Nazad.Size = new System.Drawing.Size(112, 35);
            this.Nazad.TabIndex = 26;
            this.Nazad.Text = "Nazad";
            this.Nazad.UseVisualStyleBackColor = false;
            this.Nazad.Click += new System.EventHandler(this.Nazad_Click);
            // 
            // Dalje
            // 
            this.Dalje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dalje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dalje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dalje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dalje.Location = new System.Drawing.Point(830, 547);
            this.Dalje.Margin = new System.Windows.Forms.Padding(4);
            this.Dalje.Name = "Dalje";
            this.Dalje.Size = new System.Drawing.Size(112, 35);
            this.Dalje.TabIndex = 25;
            this.Dalje.Text = "Dalje";
            this.Dalje.UseVisualStyleBackColor = false;
            // 
            // Opcije
            // 
            this.Opcije.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Opcije.Controls.Add(this.label1);
            this.Opcije.Controls.Add(this.btnUkloni);
            this.Opcije.Controls.Add(this.btnDodaj);
            this.Opcije.Controls.Add(this.listBox1);
            this.Opcije.Controls.Add(this.lbSjedala);
            this.Opcije.Controls.Add(this.cbDatum);
            this.Opcije.Controls.Add(this.lblSjedalo);
            this.Opcije.Controls.Add(this.lblDvorana);
            this.Opcije.Controls.Add(this.cbDvorana);
            this.Opcije.Controls.Add(this.lblDatumProjekcije);
            this.Opcije.Controls.Add(this.lblNazivProjekcije);
            this.Opcije.Controls.Add(this.cbNazivProjekcije);
            this.Opcije.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opcije.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Opcije.Location = new System.Drawing.Point(34, 46);
            this.Opcije.Margin = new System.Windows.Forms.Padding(4);
            this.Opcije.Name = "Opcije";
            this.Opcije.Padding = new System.Windows.Forms.Padding(4);
            this.Opcije.Size = new System.Drawing.Size(754, 472);
            this.Opcije.TabIndex = 27;
            this.Opcije.TabStop = false;
            this.Opcije.Text = "Opcije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Odabrano:";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(129, 268);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(43, 30);
            this.btnUkloni.TabIndex = 36;
            this.btnUkloni.Text = "<--";
            this.btnUkloni.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(129, 223);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(43, 28);
            this.btnDodaj.TabIndex = 35;
            this.btnDodaj.Text = "-->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(23, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(93, 164);
            this.listBox1.TabIndex = 34;
            // 
            // lbSjedala
            // 
            this.lbSjedala.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.lbSjedala.FormattingEnabled = true;
            this.lbSjedala.ItemHeight = 20;
            this.lbSjedala.Location = new System.Drawing.Point(188, 181);
            this.lbSjedala.Name = "lbSjedala";
            this.lbSjedala.Size = new System.Drawing.Size(83, 164);
            this.lbSjedala.TabIndex = 33;
            // 
            // cbDatum
            // 
            this.cbDatum.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbDatum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDatum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDatum.FormattingEnabled = true;
            this.cbDatum.Location = new System.Drawing.Point(165, 64);
            this.cbDatum.Name = "cbDatum";
            this.cbDatum.Size = new System.Drawing.Size(200, 28);
            this.cbDatum.TabIndex = 32;
            this.cbDatum.SelectedIndexChanged += new System.EventHandler(this.cbDatum_SelectedIndexChanged);
            // 
            // lblSjedalo
            // 
            this.lblSjedalo.AutoSize = true;
            this.lblSjedalo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSjedalo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSjedalo.Location = new System.Drawing.Point(19, 152);
            this.lblSjedalo.Name = "lblSjedalo";
            this.lblSjedalo.Size = new System.Drawing.Size(92, 20);
            this.lblSjedalo.TabIndex = 31;
            this.lblSjedalo.Text = "Slobodno:";
            // 
            // lblDvorana
            // 
            this.lblDvorana.AutoSize = true;
            this.lblDvorana.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDvorana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDvorana.Location = new System.Drawing.Point(7, 101);
            this.lblDvorana.Name = "lblDvorana";
            this.lblDvorana.Size = new System.Drawing.Size(85, 20);
            this.lblDvorana.TabIndex = 29;
            this.lblDvorana.Text = "Dvorana:";
            // 
            // cbDvorana
            // 
            this.cbDvorana.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbDvorana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDvorana.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDvorana.FormattingEnabled = true;
            this.cbDvorana.Location = new System.Drawing.Point(165, 98);
            this.cbDvorana.Name = "cbDvorana";
            this.cbDvorana.Size = new System.Drawing.Size(200, 28);
            this.cbDvorana.TabIndex = 28;
            // 
            // FrmUlaznica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 613);
            this.Controls.Add(this.Opcije);
            this.Controls.Add(this.Nazad);
            this.Controls.Add(this.Dalje);
            this.Controls.Add(this.Odjava);
            this.Controls.Add(this.Prijava);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUlaznica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ulaznica";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmUlaznica_FormClosed);
            this.Load += new System.EventHandler(this.FrmUlaznica_Load);
            this.Opcije.ResumeLayout(false);
            this.Opcije.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Odjava;
        private System.Windows.Forms.Label Prijava;
        private System.Windows.Forms.Label lblDatumProjekcije;
        private System.Windows.Forms.Label lblNazivProjekcije;
        private System.Windows.Forms.ComboBox cbNazivProjekcije;
        private System.Windows.Forms.Button Nazad;
        private System.Windows.Forms.Button Dalje;
        private System.Windows.Forms.GroupBox Opcije;
        private System.Windows.Forms.Label lblDvorana;
        private System.Windows.Forms.ComboBox cbDvorana;
        private System.Windows.Forms.Label lblSjedalo;
        private System.Windows.Forms.ComboBox cbDatum;
        private System.Windows.Forms.ListBox lbSjedala;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}