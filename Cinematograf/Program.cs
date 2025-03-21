using System;
using System.Collections.Generic;
using Gestiune_Cinematograf.Clase;
using NivelStocareDate;

namespace Cinematograf
{
    class Program
    {
        static void Main()
        {
            AdministrareFilme adminFilme = new AdministrareFilme();
            AdministrareSali adminSali = new AdministrareSali();
            AdministrareProiectii adminProiectii = new AdministrareProiectii();
            AdministrareRezervari adminRezervari = new AdministrareRezervari();

            // 1️⃣ Adăugare film și salvare în fișier
            Console.WriteLine("Introduceti un film (ID, Titlu, Durata, Regizor, Gen, Descriere):");
            int idFilm = int.Parse(Console.ReadLine());
            string titluFilm = Console.ReadLine();
            int durataFilm = int.Parse(Console.ReadLine());
            string regizor = Console.ReadLine();
            string gen = Console.ReadLine();
            string descriere = Console.ReadLine();

            Film film = new Film(idFilm, titluFilm, durataFilm, regizor, gen, descriere);
            adminFilme.AdaugaFilm(film);

            // 2️⃣ Adăugare sală și salvare în fișier
            Console.WriteLine("Introduceti o sala (ID, Nume, Capacitate):");
            int idSala = int.Parse(Console.ReadLine());
            string numeSala = Console.ReadLine();
            int capacitateSala = int.Parse(Console.ReadLine());

            Sala sala = new Sala(idSala, numeSala, capacitateSala);
            adminSali.AdaugaSala(sala);

            // 3️⃣ Afișare filme din fișier
            Console.WriteLine("\nFilmele salvate:");
            List<Film> filme = adminFilme.GetFilme();
            foreach (var f in filme)
                Console.WriteLine(f.AfiseazaDetalii());

            // 4️⃣ Afișare săli din fișier
            Console.WriteLine("\nSalile salvate:");
            List<Sala> sali = adminSali.GetSali();
            foreach (var s in sali)
                Console.WriteLine(s.AfiseazaDetalii());

            // 5️⃣ Căutare filme după titlu
            Console.WriteLine("\nIntroduceti titlul filmului pentru cautare:");
            string titluCautat = Console.ReadLine();
            List<Film> filmeGasite = adminFilme.CautaFilmeDupaTitlu(titluCautat);
            foreach (var f in filmeGasite)
                Console.WriteLine(f.AfiseazaDetalii());

            // 6️⃣ Căutare filme după durată
            Console.WriteLine("\nIntroduceti durata filmului pentru cautare:");
            int durataCautata = int.Parse(Console.ReadLine());
            List<Film> filmeDupaDurata = adminFilme.CautaFilmeDupaDurata(durataCautata);
            foreach (var f in filmeDupaDurata)
                Console.WriteLine(f.AfiseazaDetalii());

            // 7️⃣ Căutare săli după nume
            Console.WriteLine("\nIntroduceti numele salii pentru cautare:");
            string numeSalaCautata = Console.ReadLine();
            List<Sala> saliGasite = adminSali.CautaSaliDupaNume(numeSalaCautata);
            foreach (var s in saliGasite)
                Console.WriteLine(s.AfiseazaDetalii());

            // 8️⃣ Adăugare proiecție și salvare în fișier
            Console.WriteLine("\nIntroduceti o proiecție (ID, ID Film, ID Sala, Ora):");
            int idProiectie = int.Parse(Console.ReadLine());
            int idFilmProiectie = int.Parse(Console.ReadLine());
            int idSalaProiectie = int.Parse(Console.ReadLine());
            string oraProiectie = Console.ReadLine();

            // Caută filmul și sala
            Film filmAles = filme.Find(f => f.Id == idFilmProiectie);
            Sala salaAleasa = sali.Find(s => s.Id == idSalaProiectie);

            if (filmAles != null && salaAleasa != null)
            {
                Proiectie proiectieNoua = new Proiectie(idProiectie, filmAles, salaAleasa, oraProiectie);
                adminProiectii.AdaugaProiectie(proiectieNoua);
            }
            else
            {
                Console.WriteLine("Eroare: Filmul sau sala nu există.");
            }

            // 9️⃣ Afișare proiecții din fișier
            Console.WriteLine("\nProiecțiile salvate:");
            List<Proiectie> proiectii = adminProiectii.GetProiectii(filme, sali);
            foreach (var p in proiectii)
                Console.WriteLine(p.AfiseazaDetalii());

            // 🔟 Adăugare rezervare și salvare în fișier
            Console.WriteLine("\nIntroduceti o rezervare (ID, ID Proiectie, Nume Client, Loc, Pret Bilet):");
            int idRezervare = int.Parse(Console.ReadLine());
            int idProiectieRezervare = int.Parse(Console.ReadLine());
            string clientNume = Console.ReadLine();
            int loc = int.Parse(Console.ReadLine());
            double pretBilet = double.Parse(Console.ReadLine());

            // Caută proiecția
            Proiectie proiectieRezervata = proiectii.Find(p => p.Id == idProiectieRezervare);

            if (proiectieRezervata != null)
            {
                Rezervare rezervareNoua = new Rezervare(idRezervare, proiectieRezervata, clientNume, loc, pretBilet);
                adminRezervari.AdaugaRezervare(rezervareNoua);
            }
            else
            {
                Console.WriteLine("Eroare: Proiecția nu există.");
            }

            // 🔟+1 Afișare rezervări din fișier
            Console.WriteLine("\nRezervările salvate:");
            List<Rezervare> rezervari = adminRezervari.GetRezervari(proiectii);
            foreach (var r in rezervari)
                Console.WriteLine(r.AfiseazaDetalii());
        }
    }
}
