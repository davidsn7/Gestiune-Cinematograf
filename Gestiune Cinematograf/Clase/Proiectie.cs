using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Cinematograf.Clase
{
    class Proiectie
    {
        public int Id { get; set; }
        public Film Film { get; set; }
        public Sala Sala { get; set; }
        public string OraProiectiei { get; set; }

        public Proiectie(int id, Film film, Sala sala, string oraProiectiei)
        {
            Id = id;
            Film = film;
            Sala = sala;
            OraProiectiei = oraProiectiei;
        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Film: {Film.Titlu} | Sala: {Sala.Denumire} | Ora: {OraProiectiei}";
        }
    }
}
