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
    public partial class FrmAdminFilmoviDodaj : Form
    {
        private bool pomOdjava = false;
        private Film filmAzuriraj = null;



        /// <summary>
        /// Konstruktor koji se poziva u slučaju dodavanja novog filma
        /// </summary>
        public FrmAdminFilmoviDodaj()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }
        
        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojćeg filma
        /// </summary>
        /// <param name="odabraniFilm"></param>
        public FrmAdminFilmoviDodaj(int odabraniFilm)
        {
            InitializeComponent();
            filmAzuriraj = Film.DohvatiFilm(odabraniFilm);
            txtDodajFilmNaziv.Text = filmAzuriraj.Naziv.ToString();
            txtFilmoviDodajTrajanje.Text = filmAzuriraj.VrijemeTrajanja.ToString();

        }

        /// <summary>
        /// Rukuje događajem pokretanja forme, ukoliko se radi o ažuriranju tima tada formulu popunjava sa postojećim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminFilmDodaj_Load(object sender, EventArgs e)
        {
            txtDodajFilmNaziv.Text = filmAzuriraj.Naziv.ToString();
            txtFilmoviDodajTrajanje.Text = filmAzuriraj.VrijemeTrajanja.ToString();
        }

        /// <summary>
        /// Dodavanje novog filma prilikom klika na tipku dodaj!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            Film noviFilm = new Film();
            noviFilm.Naziv = txtDodajFilmNaziv.Text.ToString();
            try
            {
                if (filmAzuriraj != null)
                {
                    noviFilm.IdFilma = filmAzuriraj.IdFilma;
                    Film.AzurirajFilm(noviFilm);

                }
                else
                {
                    Film.DodajFilm(noviFilm);

                }
                FrmAdminFilmovi adminFilmovi = new FrmAdminFilmovi();
                adminFilmovi.Show();
                this.Close();
            }
            catch
            {

                MessageBox.Show("Pogrešan unos podataka!");
            }
        }

        /// <summary>
        /// Odustajanje od dodavanja novog artikla prilikom klika na tipku odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajOdustani_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminFilmovi adminFilmovi = new FrmAdminFilmovi();
            adminFilmovi.Show();
            this.Close();
        }

        /// <summary>
        /// Dodavanje novog artikla prilikom klika na tipku spremi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajSpremi_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            Film noviFilm = new Film();
            try
            {
                noviFilm.Naziv = txtDodajFilmNaziv.Text.ToString();
                noviFilm.VrijemeTrajanja = int.Parse(txtFilmoviDodajTrajanje.Text.ToString());
                if (filmAzuriraj != null)
                {
                    noviFilm.IdFilma = filmAzuriraj.IdFilma;
                    Film.AzurirajFilm(noviFilm);
                }
                else
                {
                    Film.DodajFilm(noviFilm);
                }
                FrmAdminFilmovi adminFilmovi = new FrmAdminFilmovi();
                adminFilmovi.Show();
                this.Close();
            }
            catch {
                MessageBox.Show("Pogrešan unos podataka!");
            }
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
        private void FrmAdminFilmoviDodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdminFilmovi adminFilmovi = new FrmAdminFilmovi();
                adminFilmovi.Show();
            }
        }            
    }
}
