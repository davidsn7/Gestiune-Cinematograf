using Gestiune_Cinematograf.Clase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareProiectii
    {
        private const char SEPARATOR_PRINCIPAL = ';';
        private string numeFisier = "proiectii.txt";
        private List<Proiectie> proiectii = new List<Proiectie>();

        public void AdaugaProiectie(Proiectie proiectie)
        {
            proiectii.Add(proiectie);
            using (StreamWriter writer = new StreamWriter(numeFisier, true))
            {
                writer.WriteLine($"{proiectie.Id}{SEPARATOR_PRINCIPAL}{proiectie.Film.Id}{SEPARATOR_PRINCIPAL}{proiectie.Sala.Id}{SEPARATOR_PRINCIPAL}{proiectie.OraProiectiei}");
            }

        }

        public List<Proiectie> GetProiectii(List<Film> filme, List<Sala> sali)
        {
            List<Proiectie> listaProiectii = new List<Proiectie>();
            if (!File.Exists(numeFisier)) return listaProiectii;

            string[] linii = File.ReadAllLines(numeFisier);
            foreach (var linie in linii)
            {
                string[] date = linie.Split(SEPARATOR_PRINCIPAL);
                int id = int.Parse(date[0]);
                int idFilm = int.Parse(date[1]);
                int idSala = int.Parse(date[2]);
                string ora = date[3];

                Film film = filme.FirstOrDefault(f => f.Id == idFilm);
                Sala sala = sali.FirstOrDefault(s => s.Id == idSala);

                if (film != null && sala != null)
                {
                    listaProiectii.Add(new Proiectie(id, film, sala, ora));
                }
            }
            return listaProiectii;
        }
    }
}

       