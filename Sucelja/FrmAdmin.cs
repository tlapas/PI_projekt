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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            
        }

       
        
        private void miSifarniciZaposlenici_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminZaposlenici Odabir = new Sucelja.FrmAdminZaposlenici();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Maximized;
            Odabir.Show();
            
        }

        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminArtikli Odabir = new Sucelja.FrmAdminArtikli();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Maximized;
            Odabir.Show();

        }

        private void miSifarniciFilmovi_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminFilmovi Odabir = new Sucelja.FrmAdminFilmovi();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Maximized;
            Odabir.Show();

        }

        private void miSifarniciProjekcije_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminProjekcije Odabir = new Sucelja.FrmAdminProjekcije();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Maximized;
            Odabir.Show();

        }

        private void miSifarniciDvorane_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminDvorane Odabir = new Sucelja.FrmAdminDvorane();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Maximized;
            Odabir.Show();

        }

        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
        {
            FrmPocetna pocetna = new FrmPocetna();
            this.Close();
            pocetna.Show();
        }

        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();

        }
        
    
            
    }
}
    

