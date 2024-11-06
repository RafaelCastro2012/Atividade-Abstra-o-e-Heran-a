using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class Professor
    {
        //Atributo com modificadores de acesso privados
        string nome = "Rafael";
        string idade = "17";
        string sobrenome = "Castro";

        private void LerNome()
        {
            Console.WriteLine(nome);
        }
        public static void LerIdade()
        {
            Console.WriteLine("Digite a sua idade");
            string idade = Console.ReadLine();
            Console.WriteLine(idade);
        }
    }
}
