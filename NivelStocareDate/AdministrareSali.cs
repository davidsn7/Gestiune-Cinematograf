using Gestiune_Cinematograf.Clase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NivelStocareDate
{
    public class AdministrareSali
    {
        private const char SEPARATOR_PRINCIPAL = ';';
        private string numeFisier = "sali.txt";
        private List<Sala> sali = new List<Sala>();

        public void AdaugaSala(Sala sala)
        {
            sali.Add(sala);
            using (StreamWriter writer = new StreamWriter(numeFisier, true))
            {
                writer.WriteLine($"{sala.Id}{SEPARATOR_PRINCIPAL}{sala.Nume}{SEPARATOR_PRINCIPAL}{sala.Capacitate}");
            }
        }

        public List<Sala> GetSali()
        {
            List<Sala> listaSali = new List<Sala>();
            if (!File.Exists(numeFisier)) return listaSali;

            string[] linii = File.ReadAllLines(numeFisier);
            foreach (var linie in linii)
            {
                string[] date = linie.Split(SEPARATOR_PRINCIPAL);
                listaSali.Add(new Sala(int.Parse(date[0]), date[1], int.Parse(date[2])));
            }
            return listaSali;
        }

        public List<Sala> CautaSaliDupaNume(string nume)
        {
            List<Sala> sali = GetSali(); // Citim toate sălile din fișier
            return sali.Where(s => s.Nume.ToLower().Contains(nume.ToLower())).ToList();
        }
    }
}
