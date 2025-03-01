using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Cinematograf.Clase
{
    class Film
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public int Durata { get; set; }
        public string Gen { get; set; }
        public string DescriereFilm { get; set; }

        public Film(int id, string titlu, int durata, string gen, string descriereFilm)
        {
            Id = id;
            Titlu = titlu;
            Durata = durata;
            Gen = gen;
            DescriereFilm = descriereFilm;
        }

        public string afiseazaDetalii()
        {
            return $"ID: {Id} | Titlu: {Titlu} | Gen: {Gen} | Durata: {Durata} min | Descriere film: {DescriereFilm} ";
        }
    }
}
