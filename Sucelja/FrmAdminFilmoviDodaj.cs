using System;
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
        /// Lista koja prikazuje moguće žanrove i lista koja pokazuje koji su od ponuđenih
        /// žanrova odabrani
        /// </summary>
        List<Zanrovi> listaZanrova = new List<Zanrovi>();
        List<int> listaOdabranih = new List<int>();
        
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
        /// Rukuje događajem pokretanja forme, ukoliko se radi o ažuriranju filma tada formu popunjava sa postojećim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminFilmDodaj_Load(object sender, EventArgs e)
        {
            listaZanrova = Zanrovi.DohvatiZanrove();

            foreach (Zanrovi zanr in listaZanrova)
            {
                lbFilmoviDodajZanrovi.Items.Add(zanr);
            }

            //ukoliko se radi o ažuriranju
            if (filmAzuriraj != null)
            {
                txtDodajFilmNaziv.Text = filmAzuriraj.Naziv.ToString();
                txtFilmoviDodajTrajanje.Text = filmAzuriraj.VrijemeTrajanja.ToString();

                //foreach (Zanrovi zanr in listaZanrova2)
                //{
                //    if (!listaZanrova2.Contains(zanr))//ako film nema taj žanr, onda ga sprema  u lbFilmDodajZanrovi
                //    {
                //        lbFilmoviDodajZanrovi.Items.Add(zanr);
                //    }
                //}
                //foreach (Zanrovi zanr in listaZanrova2) {
                //    if (listaZanrova.Contains(zanr)) {
                //        lbFilmoviDodajZanroviOdabrani.Items.Add(zanr);
                //    }
                //}
            }
            else //ako je otvoren obrazac za dodavanje
            {
                foreach (Zanrovi zanr in listaZanrova)
                {
                    lbFilmoviDodajZanrovi.Items.Add(zanr);
                }
            }
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
        /// Dodaje žanr za film koji se unosi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajDodajLb_Click(object sender, EventArgs e)
        {
            if (lbFilmoviDodajZanrovi.SelectedItem != null)
            {
                lbFilmoviDodajZanroviOdabrani.Items.Add(lbFilmoviDodajZanrovi.SelectedItem);
                lbFilmoviDodajZanrovi.Items.Remove(lbFilmoviDodajZanrovi.SelectedItem);
            }
            else
            {
                MessageBox.Show("Odaberite Žanr!");
            }
        }
        /// <summary>
        /// Uklanja žanr za film koji se unosi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodajOdustaniLb_Click(object sender, EventArgs e)
        {
            if (lbFilmoviDodajZanroviOdabrani != null)
            {
                lbFilmoviDodajZanrovi.Items.Add(lbFilmoviDodajZanroviOdabrani.SelectedItem);
                lbFilmoviDodajZanroviOdabrani.Items.Remove(lbFilmoviDodajZanroviOdabrani.SelectedItem);
            }
            else
            {
                MessageBox.Show("Odaberite Žanr!");
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
                //Prolazimo kroz svaku odabranu vrstu projekcije iz lbOdabrane i 
                //spremamo u pomoćnu listu lbFilmoviDodajZanroviOdabrani listu ID-a svih odabranih žanrova projekcija 
                foreach (Zanrovi zanr in lbFilmoviDodajZanroviOdabrani.Items)
                {
                    listaOdabranih.Add(zanr.IdZanra);
                }
        

                //ako je korisnik odabrao vrste projekcije nastavljamo sa unosom projekcije u bazu podataka
                if (listaOdabranih != null)                   
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
                        int IdDodanogFilma = Film.DodajFilm(noviFilm);
                        FilmZanrovi.UnesiZanrove(IdDodanogFilma, listaOdabranih);
                    }
                    FrmAdminFilmovi adminFilmovi = new FrmAdminFilmovi();
                    adminFilmovi.Show();
                    this.Close();

                } 
                else //ako korisnik nije unio žanrove ispisuje se poruka o pogrešci
                {
                    MessageBox.Show("Odaberite žanr!");
                }
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
