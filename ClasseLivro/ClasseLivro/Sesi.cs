using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
        class Sesi : Escola
        {
            public override void CalcularMedia()
            {
            Console.WriteLine("Digite as três notas abaixo");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());
            double result = nota1 + nota2 + nota3 / 3;

            if (result >= 7)
            {
                Console.WriteLine("Aluno aprovado");
            }
            else if (result >= 4)
            {
                Console.WriteLine("Aluno em recuperação");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}

 
