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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            List<Zaposlenici> listaKorisnika = Zaposlenici.DohvatiZaposlenike();
            for (int i = 0; i < 4; i++)
            {
                if (KorIme.Text == listaKorisnika[i].KorIme)
                {
                    SpremnikPodataka.Zaposlenik = KorIme.Text;
                    if (Pass.Text == listaKorisnika[i].Lozinka)
                    {
                        if (listaKorisnika[i].Uloga == 2)
                        {
                            FrmAdmin admin = new FrmAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else if (listaKorisnika[i].Uloga == 1)
                        {
                            FrmProdavac prodavac = new FrmProdavac();
                            prodavac.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        public static class SpremnikPodataka
        {
            public static String Zaposlenik;
        }



        private void Ponisti_Click(object sender, EventArgs e)
        {
            KorIme.Clear();
            Pass.Clear();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
