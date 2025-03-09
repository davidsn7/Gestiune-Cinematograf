namespace Gestiune_Cinematograf.Clase
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public int Capacitate { get; set; }

        public Sala(int id, string nume, int capacitate)
        {
            Id = id;
            Nume = nume;
            Capacitate = capacitate;
        }

        public string AfiseazaDetalii()
        {
            return $"ID: {Id} | Nume: {Nume} | Capacitate: {Capacitate}";
        }
    }
}
