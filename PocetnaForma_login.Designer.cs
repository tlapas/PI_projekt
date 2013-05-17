namespace PI_projekt
{
    partial class PocetnaForma_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PocetnaForma_login));
            this.prijava = new System.Windows.Forms.Button();
            this.korisnickoIme = new System.Windows.Forms.TextBox();
            this.korIme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.odustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijava
            // 
            this.prijava.BackColor = System.Drawing.Color.SeaGreen;
            this.prijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prijava.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.prijava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.prijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijava.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prijava.Location = new System.Drawing.Point(27, 90);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(92, 40);
            this.prijava.TabIndex = 0;
            this.prijava.Text = "Prijava";
            this.prijava.UseVisualStyleBackColor = false;
            this.prijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // korisnickoIme
            // 
            this.korisnickoIme.Location = new System.Drawing.Point(112, 22);
            this.korisnickoIme.Name = "korisnickoIme";
            this.korisnickoIme.Size = new System.Drawing.Size(144, 20);
            this.korisnickoIme.TabIndex = 1;
            // 
            // korIme
            // 
            this.korIme.AutoSize = true;
            this.korIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.korIme.Location = new System.Drawing.Point(5, 25);
            this.korIme.Name = "korIme";
            this.korIme.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.korIme.Size = new System.Drawing.Size(99, 13);
            this.korIme.TabIndex = 2;
            this.korIme.Text = "Korisničko ime";
            this.korIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lozinka";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 3;
            // 
            // odustani
            // 
            this.odustani.BackColor = System.Drawing.Color.SeaGreen;
            this.odustani.Cursor = System.Windows.Forms.Cursors.Hand;
            this.odustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.odustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odustani.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odustani.Location = new System.Drawing.Point(136, 90);
            this.odustani.Name = "odustani";
            this.odustani.Size = new System.Drawing.Size(92, 40);
            this.odustani.TabIndex = 5;
            this.odustani.Text = "Odustani";
            this.odustani.UseVisualStyleBackColor = false;
            this.odustani.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PocetnaForma_login
            // 
            this.AcceptButton = this.prijava;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.odustani;
            this.ClientSize = new System.Drawing.Size(265, 147);
            this.Controls.Add(this.odustani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.korIme);
            this.Controls.Add(this.korisnickoIme);
            this.Controls.Add(this.prijava);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PocetnaForma_login";
            this.Text = "Prijava u sustav";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.Label korIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button odustani;
    }
}

