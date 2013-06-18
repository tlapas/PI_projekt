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
            List<Film> filmovi= new List<Film>();
            filmovi = Film.DohvatiAktualneFilmove();
            foreach (Film film in filmovi)
            {
                cbNazivProjekcije.Items.Add(film.Naziv);
            }

        }
    }
}
