using Gestiune_Cinematograf.Clase;
using System;

namespace NivelStocareDate
{
    public class AdministrareCinematograf
    {
        private Film[] filme = new Film[100]; 
        private int nrFilme = 0;

        private Sala[] sali = new Sala[100]; 
        private int nrSali = 0;

        
        public void AdaugaFilm(Film film)
        {
            if (nrFilme < filme.Length)
            {
                filme[nrFilme++] = film;
            }
        }

        
        public Film[] GetFilme()
        {
            Film[] rezultat = new Film[nrFilme];
            for (int i = 0; i < nrFilme; i++)
                rezultat[i] = filme[i];
            return rezultat;
        }

        
        public void AdaugaSala(Sala sala)
        {
            if (nrSali < sali.Length)
            {
                sali[nrSali++] = sala;
            }
        }

        
        public Sala[] GetSali()
        {
            Sala[] rezultat = new Sala[nrSali];
            for (int i = 0; i < nrSali; i++)
                rezultat[i] = sali[i];
            return rezultat;
        }

        
        public Film[] CautaFilmeDupaTitlu(string titlu)
        {
            int count = 0;
            Film[] rezultat = new Film[nrFilme];

            for (int i = 0; i < nrFilme; i++)
            {
                if (filme[i].Titlu.ToLower().Contains(titlu.ToLower()))
                {
                    rezultat[count++] = filme[i];
                }
            }
            Array.Resize(ref rezultat, count);
            return rezultat;
        }

        
        public Film[] CautaFilmeDupaDurata(int durata)
        {
            int count = 0;
            Film[] rezultat = new Film[nrFilme];

            for (int i = 0; i < nrFilme; i++)
            {
                if (filme[i].Durata == durata)
                {
                    rezultat[count++] = filme[i];
                }
            }
            Array.Resize(ref rezultat, count);
            return rezultat;
        }

        
        public Sala[] CautaSaliDupaNume(string nume)
        {
            int count = 0;
            Sala[] rezultat = new Sala[nrSali];

            for (int i = 0; i < nrSali; i++)
            {
                if (sali[i].Nume.ToLower().Contains(nume.ToLower()))
                {
                    rezultat[count++] = sali[i];
                }
            }
            Array.Resize(ref rezultat, count);
            return rezultat;
        }
    }
}
