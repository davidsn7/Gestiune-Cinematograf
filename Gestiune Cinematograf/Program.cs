using Gestiune_Cinematograf.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_Cinematograf
{
    class Program
    {
        static void Main()        {
            Film f1 = new Film(1, "Joker", 122, "Drama", "Arthur Fleck, un clovn de petrecere și un comedian ratat, duce o viață grea alături de mama lui bolnavă. Respins de societate și considerat un ciudat, ajunge să îmbrățișeze haosul din Gotham City.");
            Sala s1 = new Sala(4, "VIP", 150);
            Proiectie p1 = new Proiectie(3, f1, s1, "19:30");
            Rezervare r1 = new Rezervare(29, p1, "Simion David", 22);

            Console.WriteLine(p1.AfiseazaDetalii());
            Console.WriteLine(r1.AfiseazaDetalii());



        }
    }
}
