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

        private void StatistikaProjekcije_Load(object sender, EventArgs e)
        {
            this.projekcijaTableAdapter.FillByIdProjekcije(this.kinoDBDataSet.Projekcija, 3);
            this.filmTableAdapter.FillByIdFilma(this.kinoDBDataSet.Film, 3);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
