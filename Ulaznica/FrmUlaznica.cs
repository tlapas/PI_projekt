using PI_projekt.Sucelja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Ulaznica
{
    public partial class FrmUlaznica : Form
    {

        //lista filmova
        private List<Film> filmovi = new List<Film>();
        private List<Projekcija> projekcije = new List<Projekcija>();
        Projekcija projekcija = new Projekcija();
        private int idFilma = 0;
        private int idProjekcije = 0;

        private void Osvjezi()
        {
            cbDatum.Items.Clear();
            cbDvorana.Items.Clear();
            idProjekcije = 0;
            idFilma = 0;

        }

        public FrmUlaznica()
        {
            InitializeComponent();
        }

        private void Nazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUlaznica_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmProdavac prodavac = new FrmProdavac();
            prodavac.Show();
        }

        private void FrmUlaznica_Load(object sender, EventArgs e)
        {
            /*
          List<Projekcija> listaProjekcija = new List<Projekcija>();
          listaProjekcija = Projekcija.DohvatiAktualneProjekcije();
          */

            // filmovi = Film.DohvatiAktualneFilmove();
            filmovi = Film.DohvatiFilmove();
            foreach (Film film in filmovi)
            {
                cbNazivProjekcije.Items.Add(film.Naziv);
            }

        }

        private void cbNazivProjekcije_SelectedIndexChanged(object sender, EventArgs e)
        {

            Osvjezi();
            idFilma = filmovi[cbNazivProjekcije.SelectedIndex].IdFilma;
            projekcije = Projekcija.DohvatiProjekcijeFilm(idFilma);
            foreach (Projekcija projekcija in projekcije)
            {
                cbDatum.Items.Add(projekcija.Datum);
            }
            //obrisi sve iz ostalih boxova
        }

        private void cbDatum_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProjekcije = projekcije[cbDatum.SelectedIndex].IdProjekcije;
            //foreach(Projekcija
        }
    }
}
