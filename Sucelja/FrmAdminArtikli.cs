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
    public partial class FrmAdminArtikli : Form
    {   
        /// <summary>
        /// Metoda koja osvježava popis artikala u dgvSviArtikli objektu
        /// </summary>
        private void OsvjeziArtikle()
        {
            List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
            dgvSviArtikli.DataSource = listaArtikala;
        }

        public FrmAdminArtikli()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

        private void btnOsvjeziArtikle_Click(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

        private void dgvSviArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// Prilikom klika na određenu ćeliju prikazuju se detalji za artikl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSviArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSviArtikli.Rows[e.RowIndex];
                int IdArtikla = int.Parse(red.Cells["IdArtikla"].Value.ToString());
                Artikl detaljiArtikl = new Artikl();
                detaljiArtikl = Artikl.DohvatiArtikl(IdArtikla);
                MessageBox.Show(detaljiArtikl.Naziv.ToString());
                //dgvDetaljiArtikl. = detaljiArtikl;
            }
        }

        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmAdminArtikliDodaj formaDodaj = new FrmAdminArtikliDodaj();
            formaDodaj.Show();
        }
    }
}
