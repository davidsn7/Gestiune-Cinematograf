namespace Gestiune_Cinematograf.Clase
{
    public class Rezervare
    {
        public int Id { get; set; }
        public Proiectie Proiectie { get; set; }
        public string ClientNume { get; set; }
        public int Loc { get; set; }
        public double PretBilet { get; set; }

        public Rezervare(int id, Proiectie proiectie, string clientNume, int loc, double pretBilet)
        {
            Id = id;
            Proiectie = proiectie;
            ClientNume = clientNume;
            Loc = loc;
            PretBilet = pretBilet;
        }

        public string ConversieLaSir_fisier()
        {
            const char SEPARATOR = ';';
            return $"{Id}{SEPARATOR}{Proiectie.Id}{SEPARATOR}{ClientNume}{SEPARATOR}{Loc}{SEPARATOR}{PretBilet}";
        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Client: {ClientNume} | Film: {Proiectie.Film.Titlu} | Sala: {Proiectie.Sala.Nume} | Loc: {Loc}";
        }
    }
}
