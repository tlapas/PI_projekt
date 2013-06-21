using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Sucelja;

namespace PI_projekt.Artikli
{
    public partial class FrmArtikli : Form
    {
        //postavimo na null i -1 i kasnije kod kreiranja računa ukoliko su te vrijednosti i dalje iste tada nema kupljenih ulaznica
        private List<int> listaIdUlaznica = null;
        private Popust  odabraniPopust = null;

        /// <summary>
        /// Konstruktor za FrmArtikli ukoliko se pristupa direktno iz izbornika prodavača
        /// </summary>
        public FrmArtikli()
        {
            InitializeComponent();
            userName.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Uloga;
        }


        public FrmArtikli(List<int> listaIdUlaznicaArg, int idPopustArg)
        {
            InitializeComponent();
            userName.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Uloga;
            listaIdUlaznica = listaIdUlaznicaArg;
            odabraniPopust = Popust.DohvatiPopust(idPopustArg);
        }

        private float CijenaUkupno = 0;
        private int IdNacinaPlacanja = 1;
        List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
        List<Artikl> listaOdabranihArtikala = new List<Artikl>();
        public List<int> listaKolicina = new List<int>();
        List<NaciniPlacanja> listaNacinaPlacanja = NaciniPlacanja.DohvatiNacinePlacanja();

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
            foreach (NaciniPlacanja NacinPlacanja in listaNacinaPlacanja)
            {
                nacinPlacanja.Items.Add(NacinPlacanja.Naziv);
            }
            nacinPlacanja.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajStavke();
        }

        private void Dalje_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenik = Zaposlenici.DohvatiZaposlenika(userName.Text);
            if (listaIdUlaznica == null && listaOdabranihArtikala.Count == 0)
            {
                string message = "Unijeli ste račun bez stavki.";
                string caption = "Greška!";
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption);
            }
            else
            {
                Kino.KreirajRacun(zaposlenik.OIB, IdNacinaPlacanja, listaOdabranihArtikala, listaKolicina, listaIdUlaznica, odabraniPopust);
                MessageBox.Show("OIB zaposlenika: " + zaposlenik.OIB.ToString());
            }
        }

        private void OsvjeziArtikle()
        {
            foreach (Artikl artikl in listaArtikala)
            {
                naziv.Items.Add(artikl.Naziv);
            }
        }

        private void Naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            jedinicnaCijena.Text = listaArtikala[naziv.SelectedIndex].Cijena.ToString() + " kn";
            kolicinaNum.Value = 1;
        }

        private int redak = 0;
        private void DodajStavke()
        {
            try
            {
                int stupac = 0;
                this.Stavke.Rows.Add();
                listaOdabranihArtikala.Add(listaArtikala[naziv.SelectedIndex]);
                this.Stavke.Rows[redak].Cells[stupac++].Value = listaArtikala[naziv.SelectedIndex].Naziv;
                this.Stavke.Rows[redak].Cells[stupac++].Value = listaArtikala[naziv.SelectedIndex].Cijena;
                listaKolicina.Add((int)kolicinaNum.Value);
                this.Stavke.Rows[redak++].Cells[stupac++].Value = kolicinaNum.Value;
                CijenaUkupno += listaArtikala[naziv.SelectedIndex].Cijena * Convert.ToInt32(kolicinaNum.Value);
                ukupanIznos.Text = CijenaUkupno.ToString() + " kn";
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Niste odabrali artikl.");
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            Stavke.Rows.Clear();
            listaOdabranihArtikala.Clear();
            listaKolicina.Clear();
            redak = 0;
            ukupanIznos.Text = "0,00 kn";
            kolicinaNum.Value = 1;
        }

        private void nacinPlacanja_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (NaciniPlacanja nacin in listaNacinaPlacanja)
            {
                if (nacin.Naziv == nacinPlacanja.Text)
                {
                    IdNacinaPlacanja = nacin.IdNacinaPlacanja;
                }
            }
        }

        //funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        // i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        // u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
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
                    PI_projekt.Sucelja.FrmPocetna pocetna = new PI_projekt.Sucelja.FrmPocetna();
                    pocetna.Show();
                    this.Close();
                }
            }
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmArtikli_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProdavac prodavac = new FrmProdavac();
            prodavac.Show();
        }
    }
}
