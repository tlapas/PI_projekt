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
    public partial class FrmAdminFilmovi : Form
    {
        public FrmAdminFilmovi()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }
        //varijabla koja provjerava da li se radi o odjavi ili o zatvaranju forme na x
        private bool pomOdjava = false;

        /// <summary>
        /// Metoda koja osvježava popis filmova u dgvSviFilmovi objektu
        /// </summary>
        private void OsvjeziFilmove()
        {
            List<Film> listaFilmova = Film.DohvatiFilmove();
            dgvSviFilmovi.DataSource = listaFilmova;
        }

        /// <summary>
        /// Pri učitavanju forme poziva se metoda osvježi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminFilmovi_Load(object sender, EventArgs e)
        {
            pomOdjava = true;
            OsvjeziFilmove();
        }

        //objekt klase film ukog se sprema film za uređivanje
        Film detaljiFilm = new Film();
        int IdFilma = -1;
        /// <summary>
        /// Klikom na pojedinu ćeliju u dgvSviFilmovi odabiremo pojedini element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSviFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pomOdjava = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSviFilmovi.Rows[e.RowIndex];
                //postavljamo id filma u varijablu IdFilma
                IdFilma = int.Parse(red.Cells["IdFilma"].Value.ToString());
            }

        }

        /// <summary>
        /// Gumb osvježi osvježava spisak filmova koji se nalaze u dgvSviFilmovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviOsvjezi_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            OsvjeziFilmove();

        }

        /// <summary>
        /// Gumb dodaj otvara formu za unos novih filmova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminFilmoviDodaj formaDodaj = new FrmAdminFilmoviDodaj();
            formaDodaj.Show();
            this.Close();
        }

        /// <summary>
        /// Gumb dodaj otvara formu za ažuriranje postojećih
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviAzuriraj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            //ako je odabran artikl u dgvSviArtikli
            if (IdFilma > -1)
            {
                pomOdjava = true;
                FrmAdminFilmoviDodaj formaAzuriraj = new FrmAdminFilmoviDodaj(IdFilma);
                formaAzuriraj.Show();
                this.Close();
            }

        }
                                           
        /// <summary>
        /// Gumb povratak vraća na prethodnu stranicu (glavna Admin)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviPovratak_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Close();
        }

        /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
        /// Varijabla pomOdjava je na true
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
        private void FrmAdminFilmovi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdmin admin = new FrmAdmin();
                admin.Show();
            }
        }       
    }
}
