namespace PI_projekt.Sucelja
{
    partial class FrmAdminProjekcije
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
            this.dgvSveProjekcije = new System.Windows.Forms.DataGridView();
            this.btnProjekcijeOsvjezi = new System.Windows.Forms.Button();
            this.btnProjekcijeDodaj = new System.Windows.Forms.Button();
            this.btnProjekcijeAžuriraj = new System.Windows.Forms.Button();
            this.lblSveProjekcije = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveProjekcije)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSveProjekcije
            // 
            this.dgvSveProjekcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveProjekcije.Location = new System.Drawing.Point(14, 98);
            this.dgvSveProjekcije.Name = "dgvSveProjekcije";
            this.dgvSveProjekcije.Size = new System.Drawing.Size(758, 226);
            this.dgvSveProjekcije.TabIndex = 23;
            this.dgvSveProjekcije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSveProjekcije_CellClick);
            // 
            // btnProjekcijeOsvjezi
            // 
            this.btnProjekcijeOsvjezi.Location = new System.Drawing.Point(470, 338);
            this.btnProjekcijeOsvjezi.Name = "btnProjekcijeOsvjezi";
            this.btnProjekcijeOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijeOsvjezi.TabIndex = 25;
            this.btnProjekcijeOsvjezi.Text = "Osvježi";
            this.btnProjekcijeOsvjezi.UseVisualStyleBackColor = true;
            this.btnProjekcijeOsvjezi.Click += new System.EventHandler(this.btnProjekcijeOsvjezi_Click);
            // 
            // btnProjekcijeDodaj
            // 
            this.btnProjekcijeDodaj.Location = new System.Drawing.Point(551, 338);
            this.btnProjekcijeDodaj.Name = "btnProjekcijeDodaj";
            this.btnProjekcijeDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijeDodaj.TabIndex = 26;
            this.btnProjekcijeDodaj.Text = "Dodaj";
            this.btnProjekcijeDodaj.UseVisualStyleBackColor = true;
            this.btnProjekcijeDodaj.Click += new System.EventHandler(this.btnProjekcijeDodaj_Click);
            // 
            // btnProjekcijeAžuriraj
            // 
            this.btnProjekcijeAžuriraj.Location = new System.Drawing.Point(632, 338);
            this.btnProjekcijeAžuriraj.Name = "btnProjekcijeAžuriraj";
            this.btnProjekcijeAžuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnProjekcijeAžuriraj.TabIndex = 27;
            this.btnProjekcijeAžuriraj.Text = "Ažuriraj";
            this.btnProjekcijeAžuriraj.UseVisualStyleBackColor = true;
            this.btnProjekcijeAžuriraj.Click += new System.EventHandler(this.btnProjekcijeAžuriraj_Click);
            // 
            // lblSveProjekcije
            // 
            this.lblSveProjekcije.AutoSize = true;
            this.lblSveProjekcije.Location = new System.Drawing.Point(14, 72);
            this.lblSveProjekcije.Name = "lblSveProjekcije";
            this.lblSveProjekcije.Size = new System.Drawing.Size(77, 13);
            this.lblSveProjekcije.TabIndex = 28;
            this.lblSveProjekcije.Text = "Sve projekcije:";
            // 
            // FrmAdminProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 373);
            this.Controls.Add(this.lblSveProjekcije);
            this.Controls.Add(this.btnProjekcijeAžuriraj);
            this.Controls.Add(this.btnProjekcijeDodaj);
            this.Controls.Add(this.btnProjekcijeOsvjezi);
            this.Controls.Add(this.dgvSveProjekcije);
            this.Name = "FrmAdminProjekcije";
            this.Text = "FrmAdminProjekcije";
            this.Load += new System.EventHandler(this.FrmAdminProjekcije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveProjekcije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSveProjekcije;
        private System.Windows.Forms.Button btnProjekcijeOsvjezi;
        private System.Windows.Forms.Button btnProjekcijeDodaj;
        private System.Windows.Forms.Button btnProjekcijeAžuriraj;
        private System.Windows.Forms.Label lblSveProjekcije;
    }
}