using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Izvjestaj
{
    public partial class StatistikaProjekcije : Form
    {
        public StatistikaProjekcije()
        {
            InitializeComponent();
        }

        private List<Film> listaFilmova = Film.DohvatiFilmove();

        private void StatistikaProjekcije_Load(object sender, EventArgs e)
        {
            OsvjeziFilmove();
            this.projekcijaTableAdapter.FillByIdProjekcije(this.kinoDBDataSet.Projekcija, listaFilmova[0].IdFilma);
            this.filmTableAdapter.FillByIdFilma(this.kinoDBDataSet.Film, listaFilmova[0].IdFilma);
            
            this.reportViewer1.RefreshReport();
        }

        private void OsvjeziFilmove()
        {
            foreach (Film film in listaFilmova)
            {
                cbFilm.Items.Add(film.Naziv);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.projekcijaTableAdapter.FillByIdProjekcije(this.kinoDBDataSet.Projekcija, listaFilmova[cbFilm.SelectedIndex].IdFilma);
            this.filmTableAdapter.FillByIdFilma(this.kinoDBDataSet.Film, listaFilmova[cbFilm.SelectedIndex].IdFilma);

            this.reportViewer1.RefreshReport();
        }
    }
}
