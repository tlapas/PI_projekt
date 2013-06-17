using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt
{
    public partial class FrmAdminArtikliAzuriraj : Form
    {
        List<MjernaJedinica> listaMjernihJedinica = MjernaJedinica.DohvatiMjerneJedinice();
        
        public FrmAdminArtikliAzuriraj()
        {
            InitializeComponent();
            foreach (MjernaJedinica mJedinica in listaMjernihJedinica)
            {
                cbMjerneJedinice.Items.Add(mJedinica.Naziv);
            }
            //cbMjerneJedinice.SelectedIndex = 
        }

        private void FrmAdminArtikliAzuriraj_Load(object sender, EventArgs e)
        {

        }
    }
}
