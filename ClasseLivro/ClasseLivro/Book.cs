using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Book
    {
        public string Titulo;
        public string Autor;
        public int NumeroPaginas;
        public string AnoPublicacao;

        public void DadosBook() 
        {
            Console.WriteLine("Digite o nome do livro que você mais gosta");
            string nome = Console.ReadLine();

            Console.WriteLine("O meu livro favorito é:"+nome);
        }
    }
}
