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
    public partial class FrmAdminArtikliDodaj : Form
    {
        List<MjernaJedinica> listaMjernihJedinica = MjernaJedinica.DohvatiMjerneJedinice();

        public FrmAdminArtikliDodaj()
        {
            InitializeComponent();
            
           
            foreach (MjernaJedinica mJedinica in listaMjernihJedinica)
            {
                cbMjerneJedinice.Items.Add(mJedinica.Naziv);
            }

        }

        private void cbMjerneJedinice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Dodavanje novog artikla prilikom klika na tipku dodaj!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Artikl noviArtikl = new Artikl();
            noviArtikl.Naziv = txtNazivDodajArtikl.Text.ToString();
            //MessageBox.Show(txtCijenaDodajArtikl.Text.ToString());
           try
           {
                
                noviArtikl.Cijena = float.Parse(txtCijenaDodajArtikl.Text.ToString());
                
                noviArtikl.IdMjerneJedinice = int.Parse(listaMjernihJedinica[cbMjerneJedinice.SelectedIndex].IdMjerneJedinice.ToString());
                if (Artikl.DodajArtikl(noviArtikl)!=0)
                { //OVO:nakon što se sredi mjerna jedinica

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dodavanje artikla nije uspjelo!");
                }   
            }
            catch
            {
                
                MessageBox.Show("Pogrešan unos podataka!");
            }


        }

        private void FrmAdminArtikliDodaj_Load(object sender, EventArgs e)
        {

        }
    }
}
