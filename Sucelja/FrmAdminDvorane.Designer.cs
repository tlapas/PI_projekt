namespace PI_projekt.Sucelja
{
    partial class FrmAdminDvorane
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
            this.btnDvoraneAzuriraj = new System.Windows.Forms.Button();
            this.btnDvoraneDodaj = new System.Windows.Forms.Button();
            this.btnDvoraneOsvjezi = new System.Windows.Forms.Button();
            this.dgvSveDvorane = new System.Windows.Forms.DataGridView();
            this.lblDvorane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveDvorane)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDvoraneAzuriraj
            // 
            this.btnDvoraneAzuriraj.Location = new System.Drawing.Point(695, 398);
            this.btnDvoraneAzuriraj.Name = "btnDvoraneAzuriraj";
            this.btnDvoraneAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnDvoraneAzuriraj.TabIndex = 1;
            this.btnDvoraneAzuriraj.Text = "Ažuriraj";
            this.btnDvoraneAzuriraj.UseVisualStyleBackColor = true;
            this.btnDvoraneAzuriraj.Click += new System.EventHandler(this.btnDvoraneAzuriraj_Click);
            // 
            // btnDvoraneDodaj
            // 
            this.btnDvoraneDodaj.Location = new System.Drawing.Point(614, 398);
            this.btnDvoraneDodaj.Name = "btnDvoraneDodaj";
            this.btnDvoraneDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDvoraneDodaj.TabIndex = 2;
            this.btnDvoraneDodaj.Text = "Dodaj";
            this.btnDvoraneDodaj.UseVisualStyleBackColor = true;
            this.btnDvoraneDodaj.Click += new System.EventHandler(this.btnDvoraneDodaj_Click);
            // 
            // btnDvoraneOsvjezi
            // 
            this.btnDvoraneOsvjezi.Location = new System.Drawing.Point(533, 398);
            this.btnDvoraneOsvjezi.Name = "btnDvoraneOsvjezi";
            this.btnDvoraneOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnDvoraneOsvjezi.TabIndex = 3;
            this.btnDvoraneOsvjezi.Text = "Osvježi";
            this.btnDvoraneOsvjezi.UseVisualStyleBackColor = true;
            this.btnDvoraneOsvjezi.Click += new System.EventHandler(this.btnDvoraneOsvjezi_Click);
            // 
            // dgvSveDvorane
            // 
            this.dgvSveDvorane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveDvorane.Location = new System.Drawing.Point(13, 110);
            this.dgvSveDvorane.Name = "dgvSveDvorane";
            this.dgvSveDvorane.Size = new System.Drawing.Size(757, 282);
            this.dgvSveDvorane.TabIndex = 4;
            this.dgvSveDvorane.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSveDvorane_CellClick);
            // 
            // lblDvorane
            // 
            this.lblDvorane.AutoSize = true;
            this.lblDvorane.Location = new System.Drawing.Point(9, 80);
            this.lblDvorane.Name = "lblDvorane";
            this.lblDvorane.Size = new System.Drawing.Size(71, 13);
            this.lblDvorane.TabIndex = 5;
            this.lblDvorane.Text = "Sve dvorane:";
            // 
            // FrmAdminDvorane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 440);
            this.Controls.Add(this.lblDvorane);
            this.Controls.Add(this.dgvSveDvorane);
            this.Controls.Add(this.btnDvoraneOsvjezi);
            this.Controls.Add(this.btnDvoraneDodaj);
            this.Controls.Add(this.btnDvoraneAzuriraj);
            this.Name = "FrmAdminDvorane";
            this.Text = "Administrator Dvorane";
            this.Load += new System.EventHandler(this.FrmAdminDvorane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveDvorane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDvoraneAzuriraj;
        private System.Windows.Forms.Button btnDvoraneDodaj;
        private System.Windows.Forms.Button btnDvoraneOsvjezi;
        private System.Windows.Forms.DataGridView dgvSveDvorane;
        private System.Windows.Forms.Label lblDvorane;
    }
}