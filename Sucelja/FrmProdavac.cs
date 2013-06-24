﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Artikli;
using PI_projekt.Ulaznica;
using System.Threading;

namespace PI_projekt.Sucelja
{
    public partial class FrmProdavac : Form
    {
        public FrmProdavac()
        {
            InitializeComponent();
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
        }
        
        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
        {
            FrmPocetna pocetna = new FrmPocetna();
            _shouldStop = true;  
            this.Close();
            pocetna.Show();            
        }

        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void miSifarniciUlaznica_MouseUp(object sender, MouseEventArgs e)
        {
            Ulaznica.FrmUlaznica Odabir = new Ulaznica.FrmUlaznica();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }

        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Artikli.FrmArtikli Odabir = new Artikli.FrmArtikli();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }

        private static volatile bool _shouldStop;

        private void FrmProdavac_Load(object sender, EventArgs e)
        {
            Thread dretvaProjekcije = new Thread(DretvaProvjeriProjekcije);
            _shouldStop = false;
            dretvaProjekcije.Start();   
        }

        private static void DretvaProvjeriProjekcije()
        {
            Thread.Sleep(5000);   //odgodimo izvršavanje dretve prilikom pokretanja
            List<int> listaIdPrikazanihProjekcija = new List<int>();

            while (!_shouldStop)
            {
                List<Projekcija> listaPopunjenihProjekcija = Projekcija.ProvjeriProjekcije();
                if (listaPopunjenihProjekcija.Count > 0)
                {
                    foreach (Projekcija projekcija in listaPopunjenihProjekcija)
                    {
                        if (!listaIdPrikazanihProjekcija.Contains(projekcija.IdProjekcije))
                        {
                            listaIdPrikazanihProjekcija.Add(projekcija.IdProjekcije);
                            Film film = Film.DohvatiFilm(projekcija.IdFilma);

                            string poruka = film.Naziv + "\nVrijeme: " + projekcija.Datum + "\nPreostalo sjedala: " + (projekcija.BrojMjesta - projekcija.ProdanoUlaznica).ToString();
                            CustomMessageBox.ShowBox(poruka);
                        }
                    }
                }
                if (!_shouldStop) Thread.Sleep(10000);
            }
            
        }
       
    }
}
