﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class ProjekcijaVrstaProjekcije
    {
         #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje  vrste projekcije za određenu projekciju
        /// </summary>
        public ProjekcijaVrstaProjekcije()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public ProjekcijaVrstaProjekcije(DbDataReader dr)
        {
            if (dr != null)
            {
                IdProjekcije = int.Parse(dr["id_projekcije"].ToString());
                IdVrste= int.Parse(dr["id_vrste"].ToString());
               
                
            }

        }

        #endregion

         #region Private Fields

        private int id_vrste;
        private int id_projekcije;
     
        #endregion

         #region Properties


        
        /// <summary>
        /// Jedinstveni identifikator vrste projekcije
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
        /// Jedinstveni identifikator projekcije
        /// </summary>
        public int IdVrste
        {
            get
            {
                return id_vrste;
            }
            private set
            {
                if (id_vrste != value)
                {
                    id_vrste = value;
                }
            }
        }

        #endregion

         #region Methods

        /// <summary>
        /// Dohvaća sve vrste projekcije za određenu projekciju
        /// </summary>
        /// <returns>Lista vrsta projekcija</returns>
        public static List<VrstaProjekcije> DohvatiVrsteProjekcije(int IdProjekcije)
        {
            List<VrstaProjekcije> lista = new List<VrstaProjekcije>();
            string sqlUpit = "SELECT vrsta* FROM Projekcija WHERE id_projekcije=" + IdProjekcije+ " ;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                VrstaProjekcije vrstaProjekcije= new VrstaProjekcije(dr);
                lista.Add(vrstaProjekcije);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }


        /// <summary>
        /// Dodaje vrste projekcije za određenu projekciju
        /// </summary>
        /// <param name="idProjekcije">Id projekcije za koju se dodaje vrsta</param>
        /// <param name="idVrsteProjekcije">Lista vrsta projekcija</param>
        /// <returns></returns>
        public static int UnesiProjekciju(int idProjekcije, List<int> idVrsteProjekcije)
        {
            int zahvaceno = 0;
            foreach (int idVrste in idVrsteProjekcije)
            {
                string sqlUpit = "INSERT INTO projekcija_vrsta ('id_projekcije','id_vrste') VALUES ('"
                + idProjekcije + "','" + idVrste + "');";
                zahvaceno += DB.Instance.IzvrsiUpit(sqlUpit);
            }
            return zahvaceno;
        
        }

               
        #endregion
    }
    
}
