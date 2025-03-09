namespace Gestiune_Cinematograf.Clase
{
    public class Proiectie
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
            return $"ID: {Id} | Film: {Film.Titlu} | Sala: {Sala.Nume} | Ora: {OraProiectiei}";
        }
    }
}
