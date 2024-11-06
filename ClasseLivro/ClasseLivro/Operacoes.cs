using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class Operacoes
    {
        //Método sem parâmetro
        public void Somar()
        {
            Console.WriteLine("Digite um número inteiro");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int resultado = numero1 + numero2;

            Console.WriteLine("O resultado da soma é:" + resultado);
        }

        //Método com parâmetro
        public void Subtrair(int number, int number2, int number3)
        {
            int result = number - number2 - number3;
            Console.WriteLine("O resultado da subtração é: " + result);
        }

        //Método com Retorno
        public int Dividir()
        {
            Console.WriteLine("Digite um número inteiro diferente de 0");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            while(numero1 == 0 || numero2 == 0) 
            {
                Console.WriteLine("Você digitou um número errado");
                Console.WriteLine("Digite um número inteiro");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo número inteiro");
                numero2 = Convert.ToInt32(Console.ReadLine());
            }
            int resultado = numero1 / numero2;

            return resultado;
        }

        public int Multiplicar(int number, int number2, int number3)
        {
            return number * number2 * number3;
        }
    }
}
