namespace PI_projekt.Sucelja
{
    partial class FrmAdminFilmovi
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
            this.lblSviFilmovi = new System.Windows.Forms.Label();
            this.dgvSviFilmovi = new System.Windows.Forms.DataGridView();
            this.btnFilmoviOsvjezi = new System.Windows.Forms.Button();
            this.btnFilmoviDodaj = new System.Windows.Forms.Button();
            this.btnFilmoviAzuriraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSviFilmovi
            // 
            this.lblSviFilmovi.AutoSize = true;
            this.lblSviFilmovi.Location = new System.Drawing.Point(12, 60);
            this.lblSviFilmovi.Name = "lblSviFilmovi";
            this.lblSviFilmovi.Size = new System.Drawing.Size(57, 13);
            this.lblSviFilmovi.TabIndex = 28;
            this.lblSviFilmovi.Text = "Svi filmovi:";
            // 
            // dgvSviFilmovi
            // 
            this.dgvSviFilmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviFilmovi.Location = new System.Drawing.Point(16, 76);
            this.dgvSviFilmovi.Name = "dgvSviFilmovi";
            this.dgvSviFilmovi.Size = new System.Drawing.Size(637, 263);
            this.dgvSviFilmovi.TabIndex = 29;
            this.dgvSviFilmovi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviFilmovi_CellClick);
            // 
            // btnFilmoviOsvjezi
            // 
            this.btnFilmoviOsvjezi.Location = new System.Drawing.Point(416, 359);
            this.btnFilmoviOsvjezi.Name = "btnFilmoviOsvjezi";
            this.btnFilmoviOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviOsvjezi.TabIndex = 31;
            this.btnFilmoviOsvjezi.Text = "Osvježi";
            this.btnFilmoviOsvjezi.UseVisualStyleBackColor = true;
            this.btnFilmoviOsvjezi.Click += new System.EventHandler(this.btnFilmoviOsvjezi_Click_1);
            // 
            // btnFilmoviDodaj
            // 
            this.btnFilmoviDodaj.Location = new System.Drawing.Point(497, 359);
            this.btnFilmoviDodaj.Name = "btnFilmoviDodaj";
            this.btnFilmoviDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviDodaj.TabIndex = 32;
            this.btnFilmoviDodaj.Text = "Dodaj";
            this.btnFilmoviDodaj.UseVisualStyleBackColor = true;
            this.btnFilmoviDodaj.Click += new System.EventHandler(this.btnFilmoviDodaj_Click);
            // 
            // btnFilmoviAzuriraj
            // 
            this.btnFilmoviAzuriraj.Location = new System.Drawing.Point(578, 359);
            this.btnFilmoviAzuriraj.Name = "btnFilmoviAzuriraj";
            this.btnFilmoviAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFilmoviAzuriraj.TabIndex = 33;
            this.btnFilmoviAzuriraj.Text = "Ažuriraj";
            this.btnFilmoviAzuriraj.UseVisualStyleBackColor = true;
            this.btnFilmoviAzuriraj.Click += new System.EventHandler(this.btnFilmoviAzuriraj_Click);
            // 
            // FrmAdminFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 403);
            this.Controls.Add(this.btnFilmoviAzuriraj);
            this.Controls.Add(this.btnFilmoviDodaj);
            this.Controls.Add(this.btnFilmoviOsvjezi);
            this.Controls.Add(this.dgvSviFilmovi);
            this.Controls.Add(this.lblSviFilmovi);
            this.Name = "FrmAdminFilmovi";
            this.Text = "FrmAdminFilmovi";
            this.Load += new System.EventHandler(this.FrmAdminFilmovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviFilmovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSviFilmovi;
        private System.Windows.Forms.DataGridView dgvSviFilmovi;
        private System.Windows.Forms.Button btnFilmoviOsvjezi;
        private System.Windows.Forms.Button btnFilmoviDodaj;
        private System.Windows.Forms.Button btnFilmoviAzuriraj;
    }
}