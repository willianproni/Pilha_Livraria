using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha_Livraria
{
    internal class Livro
    {
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public int AnoPublicacao { get; set; }
        public Livro Anterior { get; set; }

        public Livro(int isbn, string titulo, int anopublicacao)
        {
            this.ISBN = isbn;
            this.Titulo = titulo;
            this.AnoPublicacao = anopublicacao;
            this.Anterior = null;
        }

        public override string ToString()
        {
            return  $"\nNome do Livro: {Titulo} " +
                    $"\nISBN: {ISBN}" +
                    $"\nAno de publicação: {AnoPublicacao}";
        }
    }
}
