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
    public partial class FrmAdminZaposleniciDodaj : Form
    {

        private Zaposlenici zaposlenikAzuriraj = null;
        private bool pomOdjava = false;
        List<Uloga> listaUloga = new List<Uloga>();

        /// <summary>
        /// Konstruktor koji se poziva u slucaju dodavanja novog zaposlenika
        /// </summary> 
        public FrmAdminZaposleniciDodaj()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojećeg zaposlenika
        /// </summary>
        /// <param name="odabraniArtikl"></param>
        public FrmAdminZaposleniciDodaj (long odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenikAzuriraj = Zaposlenici.DohvatiZaposlenika(odabraniZaposlenik);
            txtZaposleniciDodajOIB.Text = zaposlenikAzuriraj.OIB.ToString();
            txtZaposleniciDodajIme.Text = zaposlenikAzuriraj.Ime.ToString();
            txtZaposleniciDodajPrezime.Text = zaposlenikAzuriraj.Prezime.ToString();
            txtZaposleniciDodajAdresa.Text = zaposlenikAzuriraj.Adresa.ToString();
            txtZaposleniciDodajKontakt.Text = zaposlenikAzuriraj.Kontakt.ToString();
            txtZaposleniciDodajEmail.Text = zaposlenikAzuriraj.Email.ToString();
            txtZaposleniciDodajKorime.Text = zaposlenikAzuriraj.KorIme.ToString();
            txtZaposleniciDodajLozinka.Text = zaposlenikAzuriraj.Lozinka.ToString();
            foreach (Uloga uloga in listaUloga)
            {
                if (uloga.IdUloge == zaposlenikAzuriraj.Uloga)
                {
                    cbUloga.SelectedIndex = cbUloga.FindStringExact(uloga.Naziv.ToString());
                }
            }

        }

        /// <summary>
        /// Rukuje dogadajem pokretanja forme, ukoliko se radi o ažuriranju dvorane tada formu popunjava sa postojecim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminZaposleniciDodaj_Load(object sender, EventArgs e)
        {
            listaUloga = Uloga.DohvatiSveUloge();
            foreach (Uloga uloga in listaUloga) 
            {
                cbUloga.Items.Add(uloga.Naziv);
         
            }

            //Ako je otvoren obrazac za ažuriranje
            if (zaposlenikAzuriraj != null)
            {
                txtZaposleniciDodajOIB.Text = zaposlenikAzuriraj.OIB.ToString();
                txtZaposleniciDodajIme.Text = zaposlenikAzuriraj.Ime.ToString();
                txtZaposleniciDodajPrezime.Text = zaposlenikAzuriraj.Prezime.ToString();
                txtZaposleniciDodajAdresa.Text = zaposlenikAzuriraj.Adresa.ToString();
                txtZaposleniciDodajKontakt.Text = zaposlenikAzuriraj.Kontakt.ToString();
                txtZaposleniciDodajEmail.Text = zaposlenikAzuriraj.Email.ToString();
                txtZaposleniciDodajKorime.Text = zaposlenikAzuriraj.KorIme.ToString();
                txtZaposleniciDodajLozinka.Text = zaposlenikAzuriraj.Lozinka.ToString();
                foreach (Uloga uloga in listaUloga)
                {
                    if (uloga.IdUloge == zaposlenikAzuriraj.Uloga)
                    {
                        cbUloga.SelectedIndex = cbUloga.FindStringExact(uloga.Naziv.ToString());
                    }
                }
            }

            //ako je otvoren obrazac za dodavanje
            else{
            foreach (Uloga uloga in listaUloga)
                {
                    if (uloga.IdUloge == zaposlenikAzuriraj.Uloga)
                    {
                        cbUloga.SelectedIndex = cbUloga.FindStringExact(uloga.Naziv.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Dodavanje novog zaposlenika prilikom klika na tipku dodaj!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            Zaposlenici noviZaposlenik = new Zaposlenici();
            noviZaposlenik.Ime = txtZaposleniciDodajIme.Text.ToString();
            noviZaposlenik.Prezime = txtZaposleniciDodajPrezime.Text.ToString();
            noviZaposlenik.Adresa = txtZaposleniciDodajAdresa.Text.ToString();
            noviZaposlenik.Kontakt = txtZaposleniciDodajKontakt.Text.ToString();
            noviZaposlenik.Email = txtZaposleniciDodajEmail.Text.ToString();
            noviZaposlenik.KorIme = txtZaposleniciDodajKorime.Text.ToString();
            noviZaposlenik.Lozinka = txtZaposleniciDodajLozinka.Text.ToString();
            noviZaposlenik.Uloga = listaUloga[cbUloga.SelectedIndex].IdUloge;
                
            //try
            //{                
               
            if (zaposlenikAzuriraj != null)
                {
                    noviZaposlenik.OIB = zaposlenikAzuriraj.OIB; 
                    Zaposlenici.AzurirajZaposlenika(noviZaposlenik);
                }
                
            else 
                {
                    noviZaposlenik.OIB = long.Parse(txtZaposleniciDodajOIB.Text.ToString());
                    Zaposlenici.DodajZaposlenika(noviZaposlenik);
                }


            //}

            //catch
            //{
            //    MessageBox.Show("Pogrešno uneseni podaci!");
            //}
        }

        /// <summary>
        /// Odustajanje od dodavanja novog zaposlenika prilikom klika na tipku odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciDodajOdustani_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminZaposlenici adminZaposlenici = new FrmAdminZaposlenici();
            adminZaposlenici.Show();
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
        private void FrmAdminZaposleniciDodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdminZaposlenici adminZaposlenici = new FrmAdminZaposlenici();
                adminZaposlenici.Show();
            }
        }       
    }
}
