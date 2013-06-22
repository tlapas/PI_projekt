namespace PI_projekt.Sucelja
{
    partial class FrmAdminZaposlenici
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
            this.dgvSviZaposlenici = new System.Windows.Forms.DataGridView();
            this.btnZaposleniciOsvjezi = new System.Windows.Forms.Button();
            this.btnZaposleniciDodaj = new System.Windows.Forms.Button();
            this.btnZaposleniciAzuriraj = new System.Windows.Forms.Button();
            this.lblSviZaposlenici = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviZaposlenici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSviZaposlenici
            // 
            this.dgvSviZaposlenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviZaposlenici.Location = new System.Drawing.Point(14, 95);
            this.dgvSviZaposlenici.Name = "dgvSviZaposlenici";
            this.dgvSviZaposlenici.Size = new System.Drawing.Size(754, 203);
            this.dgvSviZaposlenici.TabIndex = 24;
            this.dgvSviZaposlenici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviZaposlenici_CellClick);
            this.dgvSviZaposlenici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSviZaposlenici_CellClick);
            // 
            // btnZaposleniciOsvjezi
            // 
            this.btnZaposleniciOsvjezi.Location = new System.Drawing.Point(531, 320);
            this.btnZaposleniciOsvjezi.Name = "btnZaposleniciOsvjezi";
            this.btnZaposleniciOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciOsvjezi.TabIndex = 27;
            this.btnZaposleniciOsvjezi.Text = "Osvježi";
            this.btnZaposleniciOsvjezi.UseVisualStyleBackColor = true;
            this.btnZaposleniciOsvjezi.Click += new System.EventHandler(this.btnZaposleniciOsvjezi_Click);
            // 
            // btnZaposleniciDodaj
            // 
            this.btnZaposleniciDodaj.Location = new System.Drawing.Point(612, 320);
            this.btnZaposleniciDodaj.Name = "btnZaposleniciDodaj";
            this.btnZaposleniciDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciDodaj.TabIndex = 28;
            this.btnZaposleniciDodaj.Text = "Dodaj";
            this.btnZaposleniciDodaj.UseVisualStyleBackColor = true;
            this.btnZaposleniciDodaj.Click += new System.EventHandler(this.btnZaposleniciDodaj_Click);
            // 
            // btnZaposleniciAzuriraj
            // 
            this.btnZaposleniciAzuriraj.Location = new System.Drawing.Point(693, 320);
            this.btnZaposleniciAzuriraj.Name = "btnZaposleniciAzuriraj";
            this.btnZaposleniciAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnZaposleniciAzuriraj.TabIndex = 29;
            this.btnZaposleniciAzuriraj.Text = "Ažuriraj";
            this.btnZaposleniciAzuriraj.UseVisualStyleBackColor = true;
            this.btnZaposleniciAzuriraj.Click += new System.EventHandler(this.btnZaposleniciAzuriraj_Click);
            // 
            // lblSviZaposlenici
            // 
            this.lblSviZaposlenici.AutoSize = true;
            this.lblSviZaposlenici.Location = new System.Drawing.Point(12, 66);
            this.lblSviZaposlenici.Name = "lblSviZaposlenici";
            this.lblSviZaposlenici.Size = new System.Drawing.Size(80, 13);
            this.lblSviZaposlenici.TabIndex = 30;
            this.lblSviZaposlenici.Text = "Svi zaposlenici:";
            // 
            // FrmAdminZaposlenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 355);
            this.Controls.Add(this.lblSviZaposlenici);
            this.Controls.Add(this.btnZaposleniciAzuriraj);
            this.Controls.Add(this.btnZaposleniciDodaj);
            this.Controls.Add(this.btnZaposleniciOsvjezi);
            this.Controls.Add(this.dgvSviZaposlenici);
            this.Name = "FrmAdminZaposlenici";
            this.Text = "FrmAdminZaposlenici";
            this.Load += new System.EventHandler(this.FrmAdminZaposlenici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviZaposlenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviZaposlenici;
        private System.Windows.Forms.Button btnZaposleniciOsvjezi;
        private System.Windows.Forms.Button btnZaposleniciDodaj;
        private System.Windows.Forms.Button btnZaposleniciAzuriraj;
        private System.Windows.Forms.Label lblSviZaposlenici;

    }
}