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
    public partial class FrmAdminZaposlenici : Form
    {
        public FrmAdminZaposlenici()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        //varijabla koja provjerava da li se radi o odjavi ili o zatvaranju forme na x
        private bool pomOdjava = false;

        //objekt klase zaposlenik u kojeg se sprema zaposlenik za uređivanje
        //Zaposlenici detaljiZaposlenik = null;
        long oib = -1;

        /// <summary>
        /// Prilikom klika na odredenu celiju dohvaca se OIB pojedinog zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dgvSviZaposlenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pomOdjava = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSviZaposlenici.Rows[e.RowIndex];
                //postavljamo OIB zaposlenika u varijablu OIB
                oib = long.Parse(red.Cells["oib"].Value.ToString());
            }
        }


        /// <summary>
        /// Metoda koja osvježava popis zaposlenika u dgvSviZaposlenici objektu
        /// </summary>
        /// 
        private void OsvjeziZaposlenike()
        {
            List<Zaposlenici> listaZaposlenika = Zaposlenici.DohvatiZaposlenike();
            dgvSviZaposlenici.DataSource = listaZaposlenika;
        }


        /// <summary>
        /// Pri učitavanju forme poziva se metoda osvježi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminZaposlenici_Load(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }

        /// <summary>
        /// Gumb osvježava spisak zaposlenika koji se nalaze u dgvSviZaposlenici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void btnZaposleniciOsvjezi_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            OsvjeziZaposlenike();
        }

       
        /// <summary>
        /// Klikom na gumb dodaj otvara se forma za dodavanje novog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminZaposleniciDodaj formaDodaj = new FrmAdminZaposleniciDodaj();
            formaDodaj.Show();
            this.Close();
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabran zaposlenik u dgvSviZaposlenici i ako je odabran poziva formu za dodavanje/ažuriranje zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciAzuriraj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;

            //ako je odabran zaposlenik u dgvSviZaposlenici

            //MessageBox.Show(oib.ToString());
            if (oib > -1)
            {
                FrmAdminZaposleniciDodaj formaAzuriraj = new FrmAdminZaposleniciDodaj(oib);
                formaAzuriraj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite zaposlenika!");
            }
        }

        /// <summary>
        /// Gumb povratak vraća na prethodnu stranicu (glavna Admin)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciPovratak_Click(object sender, EventArgs e)
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
        private void FrmAdminZaposlenici_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdmin admin = new FrmAdmin();
                admin.Show();
            }
        }

        
    }
}
