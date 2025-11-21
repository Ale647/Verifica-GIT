using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica
{
    internal class Program
    {
        static string file = "file.txt";
        static void Main(string[] args)
        {
            string nome, indirizzo, orari;
            Console.WriteLine("Inserisci il nome della biblioteca:");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci l'indirizzo della biblioteca:");
            indirizzo = Console.ReadLine();
            Console.WriteLine("Inserisci gli orari di apertura della biblioteca:");
            orari = Console.ReadLine();
            Biblioteca biblioteca = new Biblioteca(nome, indirizzo, orari);

            Console.WriteLine("Console della biblioteca");
            Console.WriteLine("Scegliere una tra le seguenti opzioni:");
            Console.WriteLine("1.Aggiungi un libro");
            Console.WriteLine("2. Creca un libro");
            Console.WriteLine("3.Cerca un autore");
            Console.WriteLine("4.Deterrmina i libri presenti");
            Console.WriteLine("5.Esci");
            string scelta = Console.ReadLine();
            do
            {
                switch (scelta)
                {
                    case "1":
                        AggiungiLibro();
                        break;
                    case "2":
                        CercaLibro();
                        break;
                    case "3":
                        CercaAutore();
                        break;
                    case "4":
                        biblioteca.GetNumeroLibri();
                        break;

                    case "5":
                        Console.WriteLine("Uscita in corso...");
                        break;
                    default:
                        Console.WriteLine("Scelta non valida. Riprova.");
                        break;
                }
                Console.WriteLine("Scegliere una tra le seguenti opzioni:");
                Console.WriteLine("1.Aggiungi un libro");
                Console.WriteLine("2. Creca un libro");
                Console.WriteLine("3.Cerca un autore");
                Console.WriteLine("4.Esci");
                scelta = Console.ReadLine();
            } while (scelta != "5");

        }


        private void AggiungiLibro()
        {
            string titolo, autore, annoDiPubblicazione, Editore;
            int numeroDiPagine;
            Console.WriteLine("Insersci l'autore");
            autore = Console.ReadLine();
            Console.WriteLine("Insersci il titolo");
            titolo = Console.ReadLine();
            Console.WriteLine("Insersci L'anno di pubblicazione");
            annoDiPubblicazione = Console.ReadLine();
            Console.WriteLine("Insersci l'editore");
            Editore = Console.ReadLine();
            Console.WriteLine("Insersci il numero di pagine");
            numeroDiPagine = int.Parse(Console.ReadLine());
            Libro libro = new Libro(titolo, autore, annoDiPubblicazione, Editore, numeroDiPagine);
            Biblioteca.AggiungiLibro(libro);
        }
        private void CercaLibro()
        {
            Console.WriteLine("Inserisci il titolo del libro da cercare:");
            string titolo = Console.ReadLine();
            Console.WriteLine(Biblioteca.CercaLibro(titolo).ToString());
        }
        private void CercaAutore()
        {
            Console.WriteLine("Inserisci il nome dell'autore da cercare:");
            string autore = Console.ReadLine();
            List<Libro> libriAutore = Biblioteca.CercaAutore(autore);
            foreach (Libro libro in libriAutore)
            {
                Console.WriteLine(libro.ToString());
            }
        }
    }
}
