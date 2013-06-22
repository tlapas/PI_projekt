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
    public partial class FrmAdminProjekcijeDodaj : Form
    {
       
        List<VrstaProjekcije> listaVrste = new List<VrstaProjekcije>();
        List<Dvorana> listaDvorana = new List<Dvorana>();
        Projekcija novaProjekcija = new Projekcija();
        List<Film> listaFilmova = new List<Film>();
        List<VrstaProjekcije> azurirajProjekcijaVrste = null;
        Projekcija azurirajProjekcija = null;

        public FrmAdminProjekcijeDodaj()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        /// <summary>
        /// Kontruktor koji se poziva kada se poziva forma za ažuriranje projekcije
        /// </summary>
        /// <param name="IdProjekcije"></param>
        public FrmAdminProjekcijeDodaj(int IdProjekcije)
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
            novaProjekcija.IdProjekcije = IdProjekcije;
            azurirajProjekcija = Projekcija.DohvatiProjekciju(IdProjekcije);
            azurirajProjekcijaVrste = VrstaProjekcije.DohvatiVrste(IdProjekcije);

        }



        private bool pomOdjava = false;

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


        private void FrmAdminProjekcijeDodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdminProjekcije adminProjekcije = new FrmAdminProjekcije();
                adminProjekcije.Show();
            }
        }

        private void btnProjekcijeDodajOdustani_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminProjekcije adminProjekcije = new FrmAdminProjekcije();
            adminProjekcije.Show();
            this.Close();
        }

        private void FrmAdminProjekcijeDodaj_Load(object sender, EventArgs e)
        {
            
            listaVrste = VrstaProjekcije.DohvatiSveVrste();
            listaDvorana = Dvorana.DohvatiDvorane();
            listaFilmova = Film.DohvatiFilmove();

            foreach (Dvorana dvorana in listaDvorana) 
            {
                cbBrojDvorana.Items.Add(dvorana.Naziv);
            }
            
            
            foreach (Film filmovi in listaFilmova) 
            {
                cbNazivFilma.Items.Add(filmovi.Naziv);
            }

            //ukoliko je otvoren prozor za ažuriranje projekcije postavljamo podatke o projekciji 
            if (azurirajProjekcija != null)
            {
                txtProjekcijeDodajCijena.Text = azurirajProjekcija.Cijena.ToString();
                txtProjekcijeDodajTrajanje.Text = azurirajProjekcija.VrijemeTrajanja.ToString();
                dtDatum.Text = azurirajProjekcija.Datum.ToString();

                foreach (Film film in listaFilmova)
                {
                    if (film.IdFilma == azurirajProjekcija.IdFilma)
                    {
                        cbNazivFilma.SelectedIndex = cbNazivFilma.FindStringExact(film.Naziv.ToString());
                    }
                }
                foreach (Dvorana dvorana in listaDvorana)
                {
                    if (dvorana.BrojDvorane == azurirajProjekcija.BrojDvorane)
                    {
                        cbBrojDvorana.SelectedIndex = cbBrojDvorana.FindStringExact(dvorana.Naziv.ToString());
                    }
                }

                //u listu spremimo sve Id-e od vrsta projekcija koje su spremljene u bazi podataka zha određenu projekciju
                List<int> azurirajProjekcijaVrsteID = new List<int>();
                foreach (VrstaProjekcije vrsta in azurirajProjekcijaVrste)
                {
                    azurirajProjekcijaVrsteID.Add(vrsta.IdVrste);
                }

                //prilikom popunjavanja lbOdabrane dvorane provjeravamo je li vec ta vrsta odabrana, ukoliko je onda je sklanjamo iz lbSveVrste i stavljamo u lbOdabrane
                foreach (VrstaProjekcije vrste in listaVrste)
                {
                    if (!azurirajProjekcijaVrsteID.Contains(int.Parse(vrste.IdVrste.ToString())))
                    {
                        lbVrsteProjekcija.Items.Add(vrste);
                    }
                    else
                    {
                        lbOdabrane.Items.Add(vrste);
                    }
                }


            }
            else   //ukoliko je otvoren obrazac za dodavanje nove projekcije
            {
                foreach (VrstaProjekcije vrste in listaVrste)
                {
                    lbVrsteProjekcija.Items.Add(vrste);
                }
            }

       }


        /// <summary>
        /// Dodaje vrste projekcija za određeni film
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblDodaj_Click(object sender, EventArgs e)
        {
            if (lbVrsteProjekcija.SelectedItem != null)
            {
                lbOdabrane.Items.Add(lbVrsteProjekcija.SelectedItem);
                lbVrsteProjekcija.Items.Remove(lbVrsteProjekcija.SelectedItem);
            }
            else 
            {
                MessageBox.Show("Odaberite vrstu projekcije!");
            } 
        }


        /// <summary>
        /// Uklanja vrste porjekcija za određeni film
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUkloni_Click(object sender, EventArgs e)
        {
            if (lbOdabrane.SelectedItem != null)
            {
                lbVrsteProjekcija.Items.Add(lbOdabrane.SelectedItem);
                lbOdabrane.Items.Remove(lbOdabrane.SelectedItem);

            }
            else
            {
                MessageBox.Show("Odaberite vrstu projekcije!");
            } 
        }

        private void btnFilmoviDodajSpremi_Click(object sender, EventArgs e)
        {            
            //Pokušavamo parsirati korisnički unos, ukoliko je korisnički unos validan i dodana je vrsta projekcije nastavljamo sa unosom projekcije u bazu
           try
           {
                novaProjekcija.BrojDvorane = listaDvorana[cbBrojDvorana.SelectedIndex].BrojDvorane;
                novaProjekcija.IdFilma = listaFilmova[cbNazivFilma.SelectedIndex].IdFilma;
                novaProjekcija.VrijemeTrajanja = int.Parse(txtProjekcijeDodajTrajanje.Text.ToString());
                novaProjekcija.Cijena = float.Parse(txtProjekcijeDodajCijena.Text.ToString());
                novaProjekcija.Datum = DateTime.Parse(dtDatum.Text.ToString());
                novaProjekcija.BrojMjesta = listaDvorana[cbBrojDvorana.SelectedIndex].BrojSjedala;
                List<int> listaOdabraneVrste = new List<int>();

                //Prolazimo kroz svaku odabranu vrstu projekcije iz lbOdabrane i 
                //spremamo u pomoćnu listu listaOdabraneVrste listu ID-a svih odabranih vrsta projekcija 
                foreach (VrstaProjekcije vrsta in lbOdabrane.Items)
                {
                       listaOdabraneVrste.Add(vrsta.IdVrste);
                }
        
                //ako je korisnik odabrao vrste projekcije nastavljamo sa unosom projekcije u bazu podataka
                if (listaOdabraneVrste != null)
                {
                    //ako se ažurira projekcija
                    if (azurirajProjekcija != null)
                    {
                       
                        Projekcija.AzurirajProjekciju(novaProjekcija);
                        ProjekcijaVrstaProjekcije.AzurirajProjekcijaVrste(novaProjekcija.IdProjekcije, listaOdabraneVrste);
                    }
                    else //ako se dodaje nova projekcija
                    {
                       int idUneseneProjekcije= Projekcija.UnesiProjekciju(novaProjekcija);
                       ProjekcijaVrstaProjekcije.UnesiProjekciju(idUneseneProjekcije, listaOdabraneVrste);
                    }
                } 
                else //ako korisnik nije unio vrste projekcije ispisuje se poruka o pogrešci
                {
                    MessageBox.Show("Odaberite vrstu projekcije!");
                }
           }
            //Ukoliko korisnički unos nije validan ispisuje se poruka o pogrešci
           catch 
           {
                MessageBox.Show("Pogrešno uneseni podaci!");
           }
        }
    }
}