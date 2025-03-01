using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Cinematograf.Clase
{
    class Sala
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public int Capacitate { get; set; }

        public Sala(int id, string denumire, int capacitate)
        {
            Id = id;
            Denumire = denumire;
            Capacitate = capacitate;
        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Sala: {Denumire} | Capacitate: {Capacitate} locuri";
        }
    }
}
