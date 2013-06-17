namespace PI_projekt
{
    partial class FrmAdminArtikliAzuriraj
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
            this.lblNaslovAzurirajArtikl = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblMjernaJedinica = new System.Windows.Forms.Label();
            this.lblCijenaArtikla = new System.Windows.Forms.Label();
            this.lblNazivArtikla = new System.Windows.Forms.Label();
            this.cbMjerneJedinice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNaslovAzurirajArtikl
            // 
            this.lblNaslovAzurirajArtikl.AutoSize = true;
            this.lblNaslovAzurirajArtikl.Location = new System.Drawing.Point(142, 19);
            this.lblNaslovAzurirajArtikl.Name = "lblNaslovAzurirajArtikl";
            this.lblNaslovAzurirajArtikl.Size = new System.Drawing.Size(90, 17);
            this.lblNaslovAzurirajArtikl.TabIndex = 1;
            this.lblNaslovAzurirajArtikl.Text = "Ažuriraj artikl";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(226, 198);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 25);
            this.btnOdustani.TabIndex = 17;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(321, 199);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(85, 24);
            this.btnAzuriraj.TabIndex = 16;
            this.btnAzuriraj.Text = "Ažuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(129, 101);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(141, 22);
            this.txtCijena.TabIndex = 14;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(129, 55);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(299, 22);
            this.txtNaziv.TabIndex = 13;
            // 
            // lblMjernaJedinica
            // 
            this.lblMjernaJedinica.AutoSize = true;
            this.lblMjernaJedinica.Location = new System.Drawing.Point(12, 154);
            this.lblMjernaJedinica.Name = "lblMjernaJedinica";
            this.lblMjernaJedinica.Size = new System.Drawing.Size(107, 17);
            this.lblMjernaJedinica.TabIndex = 12;
            this.lblMjernaJedinica.Text = "Mjerna jedinica:";
            // 
            // lblCijenaArtikla
            // 
            this.lblCijenaArtikla.AutoSize = true;
            this.lblCijenaArtikla.Location = new System.Drawing.Point(12, 101);
            this.lblCijenaArtikla.Name = "lblCijenaArtikla";
            this.lblCijenaArtikla.Size = new System.Drawing.Size(51, 17);
            this.lblCijenaArtikla.TabIndex = 11;
            this.lblCijenaArtikla.Text = "Cijena:";
            // 
            // lblNazivArtikla
            // 
            this.lblNazivArtikla.AutoSize = true;
            this.lblNazivArtikla.Location = new System.Drawing.Point(12, 56);
            this.lblNazivArtikla.Name = "lblNazivArtikla";
            this.lblNazivArtikla.Size = new System.Drawing.Size(47, 17);
            this.lblNazivArtikla.TabIndex = 10;
            this.lblNazivArtikla.Text = "Naziv:";
            // 
            // cbMjerneJedinice
            // 
            this.cbMjerneJedinice.FormattingEnabled = true;
            this.cbMjerneJedinice.Location = new System.Drawing.Point(125, 151);
            this.cbMjerneJedinice.Name = "cbMjerneJedinice";
            this.cbMjerneJedinice.Size = new System.Drawing.Size(145, 24);
            this.cbMjerneJedinice.TabIndex = 18;
            // 
            // FrmAdminArtikliAzuriraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 269);
            this.Controls.Add(this.cbMjerneJedinice);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblMjernaJedinica);
            this.Controls.Add(this.lblCijenaArtikla);
            this.Controls.Add(this.lblNazivArtikla);
            this.Controls.Add(this.lblNaslovAzurirajArtikl);
            this.Name = "FrmAdminArtikliAzuriraj";
            this.Text = "Ažuriraj Artikl";
            this.Load += new System.EventHandler(this.FrmAdminArtikliAzuriraj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslovAzurirajArtikl;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label lblMjernaJedinica;
        private System.Windows.Forms.Label lblCijenaArtikla;
        private System.Windows.Forms.Label lblNazivArtikla;
        private System.Windows.Forms.ComboBox cbMjerneJedinice;
    }
}