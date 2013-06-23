﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Izvjestaj
{
    public partial class RacunIzvjestaj : Form
    {
        private int IdRacuna = 0;
        private float ukupnaCijenaUlaznica, ukupnaCijenaArtikala;
        private bool popust = true;
        public RacunIzvjestaj(int IDRacuna, float ukupnoUlaznice, float ukupnoArtikli)
        {
            InitializeComponent();
            IdRacuna = IDRacuna;
            if (ukupnoUlaznice == 0)
            {
                popust = false;
            }
            ukupnaCijenaUlaznica = ukupnoUlaznice;
            ukupnaCijenaArtikala = ukupnoArtikli;
        }

        private void RacunIzvjestaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kinoDBDataSet.CijenaArtikala' table. You can move, or remove it, as needed.
            this.cijenaArtikalaTableAdapter.Fill(this.kinoDBDataSet.CijenaArtikala);
            this.racunTableAdapter.FillByIdRacuna(this.kinoDBDataSet.Racun, IdRacuna);
            this.nacin_placanjaTableAdapter.Fill(this.kinoDBDataSet.Nacin_placanja, IdRacuna);
            this.zaposlenikTableAdapter.Fill(this.kinoDBDataSet.Zaposlenik, IdRacuna);
            this.artiklTableAdapter.Fill(this.kinoDBDataSet.Artikl, IdRacuna);
            this.mjerna_jedinicaTableAdapter.Fill(this.kinoDBDataSet.Mjerna_jedinica, IdRacuna);
            this.stavka_racunaTableAdapter.Fill(this.kinoDBDataSet.stavka_racuna, IdRacuna);
            this.kartaTableAdapter.Fill(this.kinoDBDataSet.Karta, IdRacuna);
            this.racun_kartaTableAdapter.Fill(this.kinoDBDataSet.racun_karta, IdRacuna);
            this.projekcijaTableAdapter.Fill(this.kinoDBDataSet.Projekcija, IdRacuna);
            this.filmTableAdapter.Fill(this.kinoDBDataSet.Film, IdRacuna);
            if (!popust)
            {
                this.popustTableAdapter.FillByMin(this.kinoDBDataSet.Popust);
            }
            else
            {
                this.popustTableAdapter.Fill(this.kinoDBDataSet.Popust, IdRacuna);
            }
            this.cijenaUlaznicaTableAdapter.UpdateQuery((decimal)ukupnaCijenaUlaznica);
            this.cijenaUlaznicaTableAdapter.Fill(this.kinoDBDataSet.CijenaUlaznica);
            this.cijenaArtikalaTableAdapter.UpdateQuery((decimal)ukupnaCijenaArtikala);
            this.cijenaArtikalaTableAdapter.Fill(this.kinoDBDataSet.CijenaArtikala);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
