namespace PI_projekt.Sucelja
{
    partial class FrmAdminDvoraneDodaj
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
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblDodajDvoranuNaziv = new System.Windows.Forms.Label();
            this.lblDodajDvoranuBrSjedala = new System.Windows.Forms.Label();
            this.txtDodajDvoranuNaziv = new System.Windows.Forms.TextBox();
            this.txtDodajDvoranuBrSjedala = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(161, 146);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 0;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(257, 146);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblDodajDvoranuNaziv
            // 
            this.lblDodajDvoranuNaziv.AutoSize = true;
            this.lblDodajDvoranuNaziv.Location = new System.Drawing.Point(12, 65);
            this.lblDodajDvoranuNaziv.Name = "lblDodajDvoranuNaziv";
            this.lblDodajDvoranuNaziv.Size = new System.Drawing.Size(79, 13);
            this.lblDodajDvoranuNaziv.TabIndex = 2;
            this.lblDodajDvoranuNaziv.Text = "Naziv dvorane:";
            // 
            // lblDodajDvoranuBrSjedala
            // 
            this.lblDodajDvoranuBrSjedala.AutoSize = true;
            this.lblDodajDvoranuBrSjedala.Location = new System.Drawing.Point(12, 101);
            this.lblDodajDvoranuBrSjedala.Name = "lblDodajDvoranuBrSjedala";
            this.lblDodajDvoranuBrSjedala.Size = new System.Drawing.Size(64, 13);
            this.lblDodajDvoranuBrSjedala.TabIndex = 3;
            this.lblDodajDvoranuBrSjedala.Text = "Broj sjedala:";
            // 
            // txtDodajDvoranuNaziv
            // 
            this.txtDodajDvoranuNaziv.Location = new System.Drawing.Point(97, 62);
            this.txtDodajDvoranuNaziv.Name = "txtDodajDvoranuNaziv";
            this.txtDodajDvoranuNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtDodajDvoranuNaziv.TabIndex = 4;
            // 
            // txtDodajDvoranuBrSjedala
            // 
            this.txtDodajDvoranuBrSjedala.AcceptsReturn = true;
            this.txtDodajDvoranuBrSjedala.Location = new System.Drawing.Point(97, 98);
            this.txtDodajDvoranuBrSjedala.Name = "txtDodajDvoranuBrSjedala";
            this.txtDodajDvoranuBrSjedala.Size = new System.Drawing.Size(100, 20);
            this.txtDodajDvoranuBrSjedala.TabIndex = 5;
            // 
            // FrmAdminDvoraneDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.txtDodajDvoranuBrSjedala);
            this.Controls.Add(this.txtDodajDvoranuNaziv);
            this.Controls.Add(this.lblDodajDvoranuBrSjedala);
            this.Controls.Add(this.lblDodajDvoranuNaziv);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Name = "FrmAdminDvoraneDodaj";
            this.Text = "Administrator Dodaj Dvoranu";
            this.Load += new System.EventHandler(this.FrmAdminDvoraneDodaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblDodajDvoranuNaziv;
        private System.Windows.Forms.Label lblDodajDvoranuBrSjedala;
        private System.Windows.Forms.TextBox txtDodajDvoranuNaziv;
        private System.Windows.Forms.TextBox txtDodajDvoranuBrSjedala;
    }
}