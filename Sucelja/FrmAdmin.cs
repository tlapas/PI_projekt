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
            userName.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Uloga;
        }

        //varijabla koja provjerava da li se radi o odjavi ili o zatvaranju forme na x
        private bool pomOdjava = false;

        /// <summary>
        /// Klik na gumb otvara formu za rad sa podacima o zaposlenicima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Zaposlenici_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminZaposlenici adminZaposlenici = new FrmAdminZaposlenici();
            adminZaposlenici.Show();
            this.Close();
        } 

        /// <summary>
        /// Klik na gumb otvara formu za rad sa podacima o artiklima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Artikli_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminArtikli adminArtikli = new FrmAdminArtikli();
            adminArtikli.Show();
            this.Close();
        }
               
        /// <summary>
        /// Klik na gumb otvara formu za rad sa podacima o filmovima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Filmovi_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminFilmovi adminFilmovi = new FrmAdminFilmovi();
            adminFilmovi.Show();
            this.Close();
        }

        /// <summary>
        /// Klik na gumb otvara formu za rad sa podacima o projekcijama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Projekcije_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminProjekcije adminProjekcije = new FrmAdminProjekcije();
            adminProjekcije.Show();
            this.Close();
        }

        /// <summary>
        /// Klik na gumb otvara formu za rad sa podacima o dvoranama
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dvorane_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminDvorane adminDvorane = new FrmAdminDvorane();
            adminDvorane.Show();
            this.Close();
        }

        /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
        /// </summary>
        int odjavljivanje = 0;
        private void Odjava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                    PI_projekt.Sucelja.FrmPocetna pocetna = new PI_projekt.Sucelja.FrmPocetna();
                    pocetna.Show();
                    this.Close();
                }
            }
        }
        /// <summary>
        /// Metoda koja se poziva kada se forma zatvara na x (varijabla pomOdjava je ostala na false)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava) {
                FrmPocetna pocetna = new FrmPocetna();
                pocetna.Show();
            }
        }       
    }
}
    

