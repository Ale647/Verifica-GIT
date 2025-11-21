using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verifica
{
    internal class Biblioteca
    {
        public List<Libro> libri;
        private string nome;
        private string indirizzo;
        private string orarioApertura;

        public Biblioteca(string nome, string indirizzo, string orarioApertura)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orarioApertura = orarioApertura;
            this.libri = new List<Libro>();
        }

        public int GetNumeroLibri()
        {
            return libri.Count;
        }

        public void AggiungiLibro(Libro libro)
        {
            libri.Add(libro);
        }

        public Libro cercaLibro(string titolo)
        {
            foreach (var libro in libri)
            {
                // Assuming Libro has a property 'Titolo'
                if (libro.GetTitolo() == titolo)
                {
                     return libro;
                 }
            }

            return null;
        }

        public List<Libro>CercaAutore(string autore)
        {
            List<Libro> libriAutore = new List<Libro>();
            foreach (var libro in libri)
            {
                
                if (libro.GetAutore() == autore)
                {
                     libriAutore.Add(libro);
                }
            }

            return libriAutore;
        }

    }
}
