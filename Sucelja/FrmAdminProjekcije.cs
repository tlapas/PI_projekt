﻿using System;
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
    public partial class FrmAdminProjekcije : Form
    {
        private int IdProjekcije = -1;
        /// <summary>
        /// Prikazuje sve projekcije u dgvProjeckije
        /// </summary>
        private void OsvjeziProjekcije()
        {
            List<Projekcija> listaProjekcija = Projekcija.DohvatiProjekcije();
            dgvSveProjekcije.DataSource = listaProjekcija;
        }


        public FrmAdminProjekcije()

        {
            InitializeComponent();
        }

        private void btnProjekcijeOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziProjekcije();
        }

        private void FrmAdminProjekcije_Load(object sender, EventArgs e)
        {
            OsvjeziProjekcije();
        }

        /// <summary>
        /// Prilikom na određenu ćeliju dohvaća se id pojedine projekcije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSveProjekcije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSveProjekcije.Rows[e.RowIndex];
                //postavljamo id projekcije u varijablu IdProjeckije
                IdProjekcije = int.Parse(red.Cells["IdProjekcije"].Value.ToString());
            }
        }

        private void btnProjekcijeDodaj_Click(object sender, EventArgs e)
        {
            FrmAdminProjekcijeDodaj formaDodaj = new FrmAdminProjekcijeDodaj();
            formaDodaj.Show();
        }

        private void btnProjekcijeAžuriraj_Click(object sender, EventArgs e)
        {
            if (IdProjekcije != -1)
            {
                FrmAdminProjekcijeDodaj formaAzuriraj = new FrmAdminProjekcijeDodaj(IdProjekcije);
                formaAzuriraj.Show();
            }
            else
            {
                MessageBox.Show("Odaberite projekciju za ažuriranje!");
            }

        }

    }
}