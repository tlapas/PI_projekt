﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Projekcija
    {
          #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje  projekcije
        /// </summary>
        public Projekcija()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public Projekcija(DbDataReader dr)
        {
            if (dr != null)
            {
                IdProjekcije = int.Parse(dr["id_projekcije"].ToString());
                IdFilma= int.Parse(dr["id_filma"].ToString());
                BrojDvorane= int.Parse(dr["broj_dvorane"].ToString());
                VrijemeTrajanja= int.Parse(dr["vrijeme_trajanja"].ToString());
                BrojMjesta= int.Parse(dr["broje_mjesta"].ToString());
                ProdanoUlaznica= int.Parse(dr["prodano_ulaznica"].ToString());
                Cijena =float.Parse(dr["cijena"].ToString());
                Datum = DateTime.Parse(dr["datum"].ToString());
                
            }

        }

        #endregion

          #region Private Fields

        private int id_filma;
        private int id_projekcije;
        private int broj_dvorane;
        private int vrijeme_trajanja;
        private int broj_mjesta;
        private int prodano_ulaznica;
        private float cijena;
        private DateTime datum;
        
        
        #endregion

          #region Properties


        
        /// <summary>
        /// Jedinstveni identifikator projekcije
        /// </summary>
        public int IdProjekcije
        {
            get
            {
                return id_projekcije;
            }
            private set
            {
                if (id_projekcije != value)
                {
                    id_projekcije = value;
                }
            }
        }

        /// <summary>
        /// Jedinstveni identifikator filma
        /// </summary>
        public int IdFilma
        {
            get
            {
                return id_filma;
            }
            private set
            {
                if (id_filma != value)
                {
                    id_filma = value;
                }
            }
        }

        /// <summary>
        /// trajanja filma u minutama
        /// </summary>
        public int VrijemeTrajanja
        {
            get
            {
                return vrijeme_trajanja;
            }
            private set
            {
                if (vrijeme_trajanja != value)
                {
                    vrijeme_trajanja = value;
                }
            }
        }

        public int BrojDvorane
        {
            get
            {
                return broj_dvorane;
            }
            private set
            {
                if (broj_dvorane != value)
                {
                    broj_dvorane = value;
                }
            }
        }
         public int BrojMjesta
        {
            get
            {
                return broj_mjesta;
            }
            private set
            {
                if (broj_mjesta != value)
                {
                    broj_mjesta = value;
                }
            }
        }
        public int ProdanoUlaznica
        {
            get
            {
                return prodano_ulaznica;
            }
            private set
            {
                if (prodano_ulaznica != value)
                {
                    prodano_ulaznica = value;
                }
            }
        }
        public float Cijena
        {
            get
            {
                return cijena;
            }
            private set
            {
                if (cijena != value)
                {
                    cijena = value;
                }
            }
        }
        public DateTime Datum
        {
            get
            {
                return datum;
            }
            private set
            {
                if (datum != value)
                {
                    datum = value;
                }
            }
        }

        #endregion

          #region Methods

        /// <summary>
        /// Dohvaća sve projekcije
        /// </summary>
        /// <returns>Lista projekcija</returns>
        public static List<Projekcija> DohvatiProjekcije()
        {
            List<Projekcija> lista = new List<Projekcija>();
            string sqlUpit = "SELECT * FROM Projekcija;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Projekcija projekcija = new Projekcija(dr);
                lista.Add(projekcija);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }


        /// <summary>
        /// Dohvaća sve projekcije koje su aktualne i one koje su počele(najkasnije 15 minuta)
        /// </summary>
        /// <returns>Lista aktualnih projekcija</returns>
        public static List<Projekcija> DohvatiAktualneProjekcije()
        {
            List<Projekcija> lista = new List<Projekcija>();
            DateTime sada = DateTime.Now;
            sada.AddMinutes(15);

            string sqlUpit = "SELECT * FROM Projekcija WHERE datum="+sada.ToString()+";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Projekcija projekcija = new Projekcija(dr);
                lista.Add(projekcija);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        /// <summary>
        /// Unesi projekciju u bazu podataka
        /// </summary>
        /// <param name="novaProjekcija">Objekt klase projekcija sa podacima potrebnim za unos</param>
       /// <returns>Broj zahvaćenih redova</returns>
        public static int UnesiProjekciju(Projekcija novaProjekcija)
        {
            string sqlUpit = "INSERT INTO Projekcija ('broj_dvorane','id_filma','vrijeme_trajanja','broj_mjesta','prodano_ulaznica','cijena','datum',) VALUES ('"
                + novaProjekcija.BrojDvorane + "','" + novaProjekcija.IdFilma + "','" + novaProjekcija.VrijemeTrajanja + "','" + novaProjekcija.BrojMjesta 
                + "','" + novaProjekcija.ProdanoUlaznica + "','" + Kino.PretvoriCijenu(novaProjekcija.Cijena) + "','" + novaProjekcija.Datum + "');";
              int  zahvaceno = DB.Instance.IzvrsiUpit(sqlUpit);

            return zahvaceno;
        
        }

        /// <summary>
        /// Ažuriraj projekciju
        /// </summary>
        /// <param name="novaProjekcija">Objekt klase projekcija sa podacima potrebnim za ažuriranje</param>
        /// <returns>Broj zahvaćenih redova</returns>
        public static int AzurirajProjekciju(Projekcija novaProjekcija)
        {
            string sqlUpit = "UPDATE  Projekcija SET broj_dvorane='"+novaProjekcija.BrojDvorane+"',id_filma='"+novaProjekcija.IdFilma
                +"',vrijeme_trajanja='"+ novaProjekcija.VrijemeTrajanja+"','broj_mjesta='"+novaProjekcija.BrojMjesta
                + "','prodano_ulaznica='" + novaProjekcija.ProdanoUlaznica + "',cijena='" + Kino.PretvoriCijenu(novaProjekcija.Cijena)
                + "',datum='" + novaProjekcija.Datum + "' WHERE id_projekcije=" + novaProjekcija .IdProjekcije+ ";";
          
            int zahvaceno = DB.Instance.IzvrsiUpit(sqlUpit);

            return zahvaceno;

        }


        
        #endregion
    }
    
}
