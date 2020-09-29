using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesDiplomatura
{
    class Libro
    {
        private string autor;
        private int id;
        private string titulo;
        private bool leido;

        public Libro(string autor, int id, string titulo, bool leido)
        {
            this.autor = autor;
            this.id = id;
            this.titulo = titulo;
            this.leido = leido;
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public bool Leido
        {
            get { return leido; }
            set { leido = value; }
        }

        
        public bool IsLeido()
        {
            return leido;
        }
    }
}
