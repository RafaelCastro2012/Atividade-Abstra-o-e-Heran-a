using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
     class Senai : Escola
        {
        public override void CalcularMedia()
        {
            Console.WriteLine("digite as quatro notas de 0 a 100");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());
            double nota4 = Convert.ToDouble(Console.ReadLine());

            double resultado = nota1 + nota2 + nota3 + nota4 / 4;

            Console.WriteLine("Frequencia do aluno");
            double frequencia = Convert.ToDouble(resultado);

            if (frequencia >= 90 && resultado >= 70)
            {
                Console.WriteLine("parabéns você foi aprovdo no curso tecnico do Senai");
            }
            else if (frequencia >= 90 && resultado < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else if (frequencia < 90 && resultado > 7)
            {
                Console.WriteLine("Você foi reprovado por falta");
            }
            else
            {
                Console.WriteLine("Você foi reprovado");
            }
        }
    }
}
