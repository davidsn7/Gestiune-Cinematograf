using Gestiune_Cinematograf.Clase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NivelStocareDate
{
    public class AdministrareFilme
    {
        private const char SEPARATOR_PRINCIPAL = ';';
        private string numeFisier = "filme.txt";
        private List<Film> filme = new List<Film>();

        public void AdaugaFilm(Film film)
        {
            filme.Add(film);
            using (StreamWriter writer = new StreamWriter(numeFisier, true))
            {
                writer.WriteLine($"{film.Id}{SEPARATOR_PRINCIPAL}{film.Titlu}{SEPARATOR_PRINCIPAL}{film.Durata}{SEPARATOR_PRINCIPAL}{film.Regizor}{SEPARATOR_PRINCIPAL}{film.Gen}{SEPARATOR_PRINCIPAL}{film.DescriereFilm}");
            }
        }

        public List<Film> GetFilme()
        {
            List<Film> listaFilme = new List<Film>();
            if (!File.Exists(numeFisier)) return listaFilme;

            string[] linii = File.ReadAllLines(numeFisier);
            foreach (var linie in linii)
            {
                string[] date = linie.Split(SEPARATOR_PRINCIPAL);
                listaFilme.Add(new Film(int.Parse(date[0]), date[1], int.Parse(date[2]), date[3], date[4], date[5]));
            }
            return listaFilme;
        }

        public List<Film> CautaFilmeDupaTitlu(string titlu)
        {
            List<Film> filme = GetFilme(); 
            return filme.Where(f => f.Titlu.ToLower().Contains(titlu.ToLower())).ToList();
        }

        public List<Film> CautaFilmeDupaDurata(int durata)
        {
            List<Film> filme = GetFilme(); 
            return filme.Where(f => f.Durata == durata).ToList();
        }
    }
}
