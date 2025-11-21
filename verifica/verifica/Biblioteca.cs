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
    }
}
