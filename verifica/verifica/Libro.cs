using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica
{
    internal class Libro
    {
        public string titolo;
        public string autore;
        public int annoPubblicazione;
        public string editore;
        public int numeroPagine;
        public Libro(string titolo, string autore, int annoPubblicazione, string editore, int numeroPagine) //Costruttore
        {
            this.titolo = titolo;
            this.autore = autore;
            this.annoPubblicazione = annoPubblicazione;
            this.editore = editore;
            this.numeroPagine = numeroPagine;
        }

        public override string ToString() //Metodo ToString per stampare le informazioni del libro
        {
            return $"{titolo}, {autore}, {annoPubblicazione}, {editore}, {numeroPagine} pagine";
        }
        public string ReadingTime() // Metodo per calcolare il tempo di lettura stimato
        {
            string tempo;
            if (numeroPagine < 100)
            {
                tempo = "1h";
            }
            else
            {
                if (numeroPagine >= 100 && numeroPagine < 200)
                {
                    tempo = "2h";
                }
                else
                {
                    tempo = ">2h";
                }
            }

            return $"Tempo di lettura stimato: {tempo} ore";
        }

    }

}
