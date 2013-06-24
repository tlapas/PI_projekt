﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Kino
    {   
        /// <summary>
        /// Pretvara zapis cijene iz floata u float oblik sa točkom potreban za unos u SQLite bazu podataka
        /// </summary>
        /// <param name="cijenaFloat">Float zapis sa ,</param>
        /// <returns>String sa .</returns>
        public static string PretvoriCijenu(float cijenaFloat)
        {
            string cijenaString = cijenaFloat.ToString();
            if (cijenaString.Contains(","))
                cijenaString = cijenaString.Replace(",", ".");
            return cijenaString;
        }


        /// <summary>
        /// Sprema kupljene ulaznice u bazu podataka, ispisuje ulaznicu u obliku pdf.a
        /// </summary>
        /// <param name="odabranaSjedala">Lista odabranih sjedala</param>
        /// <param name="odabranaProjekcija">Objekt odabrana projekcija</param>
        /// <returns>Vraća listu ID-a unešenih ulaznica</returns>
        public static List<int> IzradiUlaznicu(List<int> odabranaSjedala, Projekcija odabranaProjekcija)
        {
            List<int> listaIdUlaznica = new List<int>();
            

            foreach (int sjedalo in odabranaSjedala)
            {   
                listaIdUlaznica.Add(Ulaznice.UnesiUlaznicu(sjedalo, odabranaProjekcija.IdProjekcije));
            }

            return listaIdUlaznica;
        }


        public static void KreirajRacun(long OIB, int idNacinaPlacanja, List<Artikl> listaArtikala, List<int> listaKolicina, List<int> listaIdUlaznica, Popust popust, float ukupnaCijenaUlaznica, float ukupnaCijenaArtikala)
        {
            int IdRacun = Racun.UnesiRacun(OIB, idNacinaPlacanja);
            if (listaArtikala != null)
            {
                int brojElemenata = listaArtikala.Count;
                for (int i = 0; i < brojElemenata; i++)
                {
                    RacunArtikl.UnesiRacunArtikl(IdRacun, listaArtikala[i].IdArtikla, listaKolicina[i]);
                }
            }
            if (listaIdUlaznica != null)
            {
                foreach (int ID in listaIdUlaznica)
                {
                    RacunUlaznica.UnesiRacunUlaznica(IdRacun, ID, popust.IdPopusta);
                }
               
                //Poziva se report viewer UlaznicaIspis.cs za svaku kupljenu ulaznicu
                foreach (int idUlaznice in listaIdUlaznica)
                {
                    Izvjestaj.UlaznicaIspis ispisUlaznice = new Izvjestaj.UlaznicaIspis(idUlaznice);
                    ispisUlaznice.Show();
                }
            }

///ZA racun potrebno maknuti komentare ispod
///
///

            Izvjestaj.RacunIzvjestaj racun = new Izvjestaj.RacunIzvjestaj(IdRacun, ukupnaCijenaUlaznica, ukupnaCijenaArtikala);
            racun.Show();
        }

     
    }
}
