using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Artikli;
using PI_projekt.Ulaznica;
using System.Threading;

namespace PI_projekt.Sucelja
{
    public partial class FrmProdavac : Form
    {
        public FrmProdavac()
        {
            InitializeComponent();
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
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
                    FrmPocetna pocetna = new FrmPocetna();
                    this.Close();
                    pocetna.Show();

                }
            }
        }

        /// <summary>
        ///funkcija za izlaz iz aplikacije 
        /// </summary>
        int izlaz = 0;
        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            izlaz = 1;
            izlazak();
        }

        private void izlazak()
        {
            if (izlaz == 1)
            {
                string message = "Želite li ugasiti aplikaciju?";
                string caption = "Gašenje aplikacije";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }  
            
        private void miSifarniciUlaznica_MouseUp(object sender, MouseEventArgs e)
        {
            Ulaznica.FrmUlaznica Odabir = new Ulaznica.FrmUlaznica();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }

        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Artikli.FrmArtikli Odabir = new Artikli.FrmArtikli();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }

        private static volatile bool _shouldStop;

        private void FrmProdavac_Load(object sender, EventArgs e)
        {
            Thread dretvaProjekcije = new Thread(DretvaProvjeriProjekcije);
            _shouldStop = false;
            dretvaProjekcije.Start();   
        }

        private static void DretvaProvjeriProjekcije()
        {
            Thread.Sleep(5000);   //odgodimo izvršavanje dretve prilikom pokretanja
            List<int> listaIdPrikazanihProjekcija = new List<int>();

            while (!_shouldStop)
            {
                List<Projekcija> listaPopunjenihProjekcija = Projekcija.ProvjeriProjekcije();
                if (listaPopunjenihProjekcija.Count > 0)
                {
                    foreach (Projekcija projekcija in listaPopunjenihProjekcija)
                    {
                        if (!listaIdPrikazanihProjekcija.Contains(projekcija.IdProjekcije))
                        {
                            listaIdPrikazanihProjekcija.Add(projekcija.IdProjekcije);
                            Film film = Film.DohvatiFilm(projekcija.IdFilma);

                            string poruka = film.Naziv + "\nVrijeme: " + projekcija.Datum + "\nPreostalo sjedala: " + (projekcija.BrojMjesta - projekcija.ProdanoUlaznica).ToString();
                            CustomMessageBox.ShowBox(poruka);
                        }
                    }
                }
                if (!_shouldStop) Thread.Sleep(10000);
            }
            
        }
       
    }
}
