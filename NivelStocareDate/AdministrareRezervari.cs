using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gestiune_Cinematograf.Clase;

namespace NivelStocareDate
{
    public class AdministrareRezervari
    {
        private const char SEPARATOR_PRINCIPAL = ';';
        private string numeFisier = "rezervari.txt";
        private List<Rezervare> rezervari = new List<Rezervare>();

        public void AdaugaRezervare(Rezervare rezervare)
        {
            rezervari.Add(rezervare);
            using (StreamWriter writer = new StreamWriter(numeFisier, true))
            {
                writer.WriteLine(rezervare.ConversieLaSir_fisier());
            }
        }

        public List<Rezervare> GetRezervari(List<Proiectie> proiectii)
        {
            List<Rezervare> listaRezervari = new List<Rezervare>();
            if (!File.Exists(numeFisier)) return listaRezervari;

            string[] linii = File.ReadAllLines(numeFisier);
            foreach (var linie in linii)
            {
                string[] date = linie.Split(SEPARATOR_PRINCIPAL);
                int id = int.Parse(date[0]);
                int idProiectie = int.Parse(date[1]);
                string clientNume = date[2];
                int loc = int.Parse(date[3]);
                double pretBilet = double.Parse(date[4]);

                Proiectie proiectie = proiectii.FirstOrDefault(p => p.Id == idProiectie);
                if (proiectie != null)
                {
                    listaRezervari.Add(new Rezervare(id, proiectie, clientNume, loc, pretBilet));
                }
            }
            return listaRezervari;
        }
    }
}
