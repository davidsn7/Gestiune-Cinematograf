using System;
using Gestiune_Cinematograf.Clase;
using NivelStocareDate;

namespace Cinematograf
{
    class Program
    {
        static void Main()
        {
            AdministrareCinematograf admin = new AdministrareCinematograf();

            Console.WriteLine("Introduceti un film (ID, Titlu, Durata, Regizor, Gen, Descriere):");
            int idFilm = int.Parse(Console.ReadLine());
            string titluFilm = Console.ReadLine();
            int durataFilm = int.Parse(Console.ReadLine());
            string regizor = Console.ReadLine();
            string gen = Console.ReadLine();
            string descriere = Console.ReadLine();

            Film film = new Film(idFilm, titluFilm, durataFilm, regizor, gen, descriere);
            admin.AdaugaFilm(film);

            Console.WriteLine("Introduceti o sala (ID, Nume, Capacitate):");
            int idSala = int.Parse(Console.ReadLine());
            string numeSala = Console.ReadLine();
            int capacitateSala = int.Parse(Console.ReadLine());

            Sala sala = new Sala(idSala, numeSala, capacitateSala);
            admin.AdaugaSala(sala);

            Console.WriteLine("\nFilmele salvate:");
            Film[] filme = admin.GetFilme();
            foreach (var f in filme)
                Console.WriteLine(f.AfiseazaDetalii());

            Console.WriteLine("\nSalile salvate:");
            Sala[] sali = admin.GetSali();
            foreach (var s in sali)
                Console.WriteLine(s.AfiseazaDetalii());

            Console.WriteLine("\nIntroduceti titlul filmului pentru cautare:");
            Film[] filmeGasite = admin.CautaFilmeDupaTitlu(Console.ReadLine());
            foreach (var f in filmeGasite)
                Console.WriteLine(f.AfiseazaDetalii());

            Console.WriteLine("\nIntroduceti durata filmului pentru cautare:");
            Film[] filmeDupaDurata = admin.CautaFilmeDupaDurata(int.Parse(Console.ReadLine()));
            foreach (var f in filmeDupaDurata)
                Console.WriteLine(f.AfiseazaDetalii());

            Console.WriteLine("\nIntroduceti numele salii pentru cautare:");
            Sala[] saliGasite = admin.CautaSaliDupaNume(Console.ReadLine());
            foreach (var s in saliGasite)
                Console.WriteLine(s.AfiseazaDetalii());
        }
    }
}
