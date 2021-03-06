﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za rad s računima
    /// </summary>
    class Racun
    {

        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje računa
        /// </summary>
        public Racun()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za račun.</param>
        public Racun(DbDataReader dr)
        {
            if (dr != null)
            {
                IdRacuna = int.Parse(dr["id_racuna"].ToString());
                OIB = float.Parse(dr["OIB"].ToString());
                IdNacinaPlacanja = int.Parse(dr["id_nacina_placanja"].ToString());
                Datum = DateTime.Parse(dr["datum"].ToString());
            }

        }

        #endregion

        #region Private Fields

        private int id_racuna;
        private float oib;
        private int id_nacina_placanja;
        private DateTime datum;

        #endregion

        #region Properties



        /// <summary>
        /// Jedinstveni identifikator računa
        /// </summary>
        public int IdRacuna
        {
            get
            {
                return id_racuna;
            }
            private set
            {
                if (id_racuna != value)
                {
                    id_racuna = value;
                }
            }
        }

        /// <summary>
        /// OIB
        /// </summary>
        public float OIB
        {
            get
            {
                return oib;
            }
            private set
            {
                if (oib != value)
                {
                    oib = value;
                }
            }
        }

        /// <summary>
        /// Jedinstveni identifikator načina plaćanja
        /// </summary>
        public int IdNacinaPlacanja
        {
            get
            {
                return id_nacina_placanja;
            }
            private set
            {
                if (id_nacina_placanja != value)
                {
                    id_nacina_placanja = value;
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
        /// Metoda koja dohvaća sve račune
        /// </summary>
        /// <returns>Lista svih računa</returns>
        public static List<Racun> DohvatiSveRacune()
        {
            List<Racun> lista = new List<Racun>();
            string sqlUpit = "SELECT * FROM Racun;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Racun racun = new Racun(dr);
                lista.Add(racun);
            }
            dr.Close();
            return lista;
        }

        /// <summary>
        /// Metoda koja unosi račun u bazu
        /// </summary>
        /// <param name="idRacuna">Id računa</param>
        /// <returns>int vraća ID računa</returns>
        public static int UnesiRacun(long OIB, int IDNacinaPlacanja)
        {
            string sqlUpit = "INSERT INTO Racun (OIB, id_nacina_placanja, datum) VALUES (" + OIB + ", " + IDNacinaPlacanja + ", datetime('now'));";
            int idRacuna = DB.Instance.IzvrsiUpitID(sqlUpit);

            return idRacuna;
        }

        #endregion
    }
}