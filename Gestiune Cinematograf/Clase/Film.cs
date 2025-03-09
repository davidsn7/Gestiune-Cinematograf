namespace Gestiune_Cinematograf.Clase
{
    public class Film
    {
        public int Id { get; set; }
        public string Titlu { get; set; }
        public int Durata { get; set; }
        public string Regizor { get; set; }
        public string Gen { get; set; }
        public string DescriereFilm { get; set; }

        public Film(int id, string titlu, int durata, string regizor, string gen, string descriereFilm)
        {
            Id = id;
            Titlu = titlu;
            Durata = durata;
            Regizor = regizor;
            Gen = gen;
            DescriereFilm = descriereFilm;
        }

        public string AfiseazaDetalii()
        {
            return "ID: " + Id + " | Titlu: " + Titlu + " | Durata: " + Durata + " min | Regizor: " + Regizor + " | Gen: " + Gen + " | Descriere: " + DescriereFilm;
        }
    }
}
