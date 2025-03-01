using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Cinematograf.Clase
{
    class Rezervare
    {
        public int Id { get; set; }
        public Proiectie Proiectie { get; set; }
        public string ClientNume { get; set; }
        public int Loc { get; set; }

        public Rezervare(int id, Proiectie proiectie, string clientNume, int loc)
        {
            Id = id;
            Proiectie = proiectie;
            ClientNume = clientNume;
            Loc = loc;
        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Client: {ClientNume} | Film: {Proiectie.Film.Titlu} | Loc: {Loc}";
        }
    }
}

