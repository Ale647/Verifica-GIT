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
        static Biblioteca biblioteca;
        static void Main(string[] args)
        {
            string nome, indirizzo, orari;//dati della biblioteca
            Console.WriteLine("Inserisci il nome della biblioteca:");
            nome = Console.ReadLine();
            Console.WriteLine("Inserisci l'indirizzo della biblioteca:");
            indirizzo = Console.ReadLine();
            Console.WriteLine("Inserisci gli orari di apertura della biblioteca:");
            orari = Console.ReadLine();
            biblioteca = new Biblioteca(nome, indirizzo, orari);//creazione dell'oggetto biblioteca

            Console.WriteLine("Console della biblioteca");
            Console.WriteLine("Scegliere una tra le seguenti opzioni:");
            Console.WriteLine("1.Aggiungi un libro");
            Console.WriteLine("2. Creca un libro");
            Console.WriteLine("3.Cerca un autore");
            Console.WriteLine("4.Deterrmina i libri presenti");
            Console.WriteLine("5.Esci");
            string scelta = Console.ReadLine();
            do//ciclo do-while per il menu
            {
                switch (scelta)
                {
                    case "1":
                        Program.AggiungiLibro();
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


        static public void AggiungiLibro() //metodo per aggiungere un libro
        {
            string titolo, autore,Editore;
            int numeroDiPagine, annoDiPubblicazione;
            Console.WriteLine("Insersci l'autore");
            autore = Console.ReadLine();
            Console.WriteLine("Insersci il titolo");
            titolo = Console.ReadLine();
            Console.WriteLine("Insersci L'anno di pubblicazione");
            annoDiPubblicazione = int.Parse(Console.ReadLine());
            Console.WriteLine("Insersci l'editore");
            Editore = Console.ReadLine();
            Console.WriteLine("Insersci il numero di pagine");
            numeroDiPagine = int.Parse(Console.ReadLine());
            Libro libro = new Libro(titolo, autore, annoDiPubblicazione, Editore, numeroDiPagine);
            biblioteca.AggiungiLibro(libro);
        }
        static public void CercaLibro() //metodo per cercare un libro
        {
            Console.WriteLine("Inserisci il titolo del libro da cercare:");
            string titolo = Console.ReadLine();
            Console.WriteLine(biblioteca.cercaLibro(titolo).ToString());
        }
        static public void CercaAutore() //metodo per cercare un autore
        {
            Console.WriteLine("Inserisci il nome dell'autore da cercare:");
            string autore = Console.ReadLine();
            List<Libro> libriAutore = biblioteca.CercaAutore(autore);
            foreach (Libro libro in libriAutore)
            {
                Console.WriteLine(libro.ToString());
            }
        }
    }
}
