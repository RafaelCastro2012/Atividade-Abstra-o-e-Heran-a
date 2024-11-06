using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    abstract class Escola
    {
        public abstract void CalcularMedia();

        public void DescobrirNome()
        {
            Console.WriteLine("Digite o nome da sua escola");
            string nomeEscola = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a cidade da sua escola");
            string cidadeEscola = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite o estado da sua escola");
            string estadoEscola = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a sua serie atual");
            string serieAtual = Console.ReadLine().ToUpper();

            Console.WriteLine(nomeEscola);

            Console.WriteLine(cidadeEscola);



            if (nomeEscola == "SESISENAI" && cidadeEscola == "GARÇA")
            {
                Console.WriteLine("Aluno Sesi / Senai");
            }
            else
            {
                Console.WriteLine("Sua escola é: " + nomeEscola + "que está na cidade: " + cidadeEscola);
            }

        }
    }
}
