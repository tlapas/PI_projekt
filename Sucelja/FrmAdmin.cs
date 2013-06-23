﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Sucelja
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            
            InitializeComponent();
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
        }

        //varijabla koja provjerava da li se radi o odjavi
        private bool pomOdjava = false;
            
        private void miSifarniciZaposlenici_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminZaposlenici Odabir = new Sucelja.FrmAdminZaposlenici();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);
            
        }

        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminArtikli Odabir = new Sucelja.FrmAdminArtikli();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

        private void miSifarniciFilmovi_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminFilmovi Odabir = new Sucelja.FrmAdminFilmovi();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

        private void miSifarniciProjekcije_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminProjekcije Odabir = new Sucelja.FrmAdminProjekcije();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

        private void miSifarniciDvorane_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminDvorane Odabir = new Sucelja.FrmAdminDvorane();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

         /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
        /// </summary>
        int odjavljivanje = 0;
        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
        {
         
            odjavljivanje = 1;
            odjava();
        }

        private void odjava()
        {
            if (odjavljivanje == 1)
            {
                string message = "Želite li se odjaviti iz sustava?";
                string caption = "Odjava iz sustava";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    pomOdjava = true;
                    FrmPocetna pocetna = new FrmPocetna();
                    this.Close();
                    pocetna.Show();
                    
                }
            }
        }

        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();

        }
            
    }
}
    

