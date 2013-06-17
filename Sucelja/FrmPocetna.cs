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
            for (int i = 0; i < 3; i++)
            {
                if (KorIme.Text == listaKorisnika[i].KorIme)
                {
                    if (Pass.Text == listaKorisnika[i].Lozinka)
                    {
                        if (listaKorisnika[i].KorIme == "inovak")
                        {
                            FrmAdmin admin = new FrmAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else if (listaKorisnika[i].KorIme != "inovak")
                        {
                            FrmProdavac prodavac = new FrmProdavac();
                            prodavac.Show();
                            this.Hide();
                        }
                    }
                }
            }
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
