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
            userName.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Uloga;
        }

        private float CijenaUkupno = 0;
        List<Artikl> listaArtikala = Artikl.DohvatiArtikle();

        private void FrmArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajStavke();
        }

        private void Dalje_Click(object sender, EventArgs e)
        {

        }

        private void OsvjeziArtikle()
        {
            int brojac = 0;
            foreach (Artikl Id in listaArtikala)
            {
                Naziv.Items.Add(listaArtikala[brojac].Naziv);
                brojac++;
            }
        }

        private void Naziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cijena_box.Text = listaArtikala[Naziv.SelectedIndex].Cijena.ToString() + " kn";
        }

        private void DodajStavke()
        {
            try
            {
                Stavke.Text += listaArtikala[Naziv.SelectedIndex].Naziv + "\t Cijena: " + listaArtikala[Naziv.SelectedIndex].Cijena + "\t Količina:" + KolicinaBox.Text + "\r\n";
                CijenaUkupno += listaArtikala[Naziv.SelectedIndex].Cijena * Convert.ToInt32(KolicinaBox.Text);
                Ukupno.Text = CijenaUkupno.ToString() + " kn";
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Niste odabrali artikl.");
            }
        }

        private void KolicinaBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(KolicinaBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Greška! Količina ne smije biti slovo. Unesite broj.");
            }
        }

        private void Ponisti_Click(object sender, EventArgs e)
        {
            Stavke.Text = "";
            Ukupno.Text = "0,00 kn";
        }


        //funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        // i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        // u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
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
                    PI_projekt.Sucelja.FrmPocetna pocetna = new PI_projekt.Sucelja.FrmPocetna();
                    pocetna.Show();
                    this.Close();
                }
            }
        }       
    }
}
