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
    public partial class RacunIzvjestaj : Form
    {
        private int IdRacuna = 0;
        public RacunIzvjestaj(int IDRacuna)
        {
            InitializeComponent();
            IdRacuna = IDRacuna;
        }

        private void RacunIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoDBDataSet.Racun' table. You can move, or remove it, as needed.
            //this.racunTableAdapter.Fill(this.kinoDBDataSet.Racun);
            // TODO: This line of code loads data into the 'kinoDBDataSet.Racun' table. You can move, or remove it, as needed.
            this.racunTableAdapter.FillByIdRacuna(this.kinoDBDataSet.Racun, IdRacuna);

            this.reportViewer1.RefreshReport();
        }
    }
}
