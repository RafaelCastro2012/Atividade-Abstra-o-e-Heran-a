using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    class Desenvolvedor : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a sua modalidade de trabalho");
            string modalidade = Console.ReadLine();
            string presencial = "a";
            string hibrido = "b";
            string remoto = "c";

            Console.WriteLine("Digite a sua quantidade de horas extra");
            double quantidadeDeHoras = Convert.ToDouble(Console.ReadLine());

            if (modalidade == presencial)
            {
                double total = quantidadeDeHoras * 100;
                Console.WriteLine("O seu total de hora que você irá receber é: " + total);
            }
            else if (modalidade == hibrido)
            {
                double total = quantidadeDeHoras * 50;
                Console.WriteLine("O seu total de hora que você irá receber é: " + total);
            }
            else if(modalidade == remoto)
            {
                Console.WriteLine("Seu seu horário é flexível, ou seja, você escolhe seu horário de trabalho, então não contempla horas extras");
            }
            else 
            {
                Console.WriteLine("Você digitou uma opção invalida");
            }

        }
    }
}
