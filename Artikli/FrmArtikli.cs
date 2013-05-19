﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Artikli
{
    public partial class FrmArtikli : Form
    {
        public FrmArtikli()
        {
            InitializeComponent();
        }

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dalje_Click(object sender, EventArgs e)
        {

        }

        private void OsvjeziArtikle()
        {
            List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
            int brojac = 0;
            foreach (Artikl Id in listaArtikala)
            {
                Naziv.Items.Add(listaArtikala[brojac].Naziv);
                brojac++;
            }
        }

        private void Naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
            if (Naziv.SelectedIndex == 0)
                Cijena_box.Text = listaArtikala[0].Cijena.ToString() + " kn";
            else if (Naziv.SelectedIndex == 1)
                Cijena_box.Text = listaArtikala[1].Cijena.ToString() + " kn";
            else if (Naziv.SelectedIndex == 2)
                Cijena_box.Text = listaArtikala[2].Cijena.ToString() + " kn";
            else if (Naziv.SelectedIndex == 3)
                Cijena_box.Text = listaArtikala[3].Cijena.ToString() + " kn";
            else if (Naziv.SelectedIndex == 4)
                Cijena_box.Text = listaArtikala[4].Cijena.ToString() + " kn";
            else if (Naziv.SelectedIndex == 5)
                Cijena_box.Text = listaArtikala[5].Cijena.ToString() + " kn";
        }
    }
}
