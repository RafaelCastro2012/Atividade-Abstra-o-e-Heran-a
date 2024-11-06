using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    class GerenteTi : Colaborador
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("digite a quantidade de horas extras feitas no mês");
            double quantidadeDeHoras = Convert.ToDouble(Console.ReadLine());

            if (quantidadeDeHoras > 100)
            {
                double metadeHora = quantidadeDeHoras / 2;
                double total = metadeHora * 200 + 500;
                double descanso = metadeHora * 8;
                Console.WriteLine("O total de horas que você irá receber é: " + total + "e o total de dias de descanso que você ira ter é: " + descanso);
            }
            else
            {
                double total = quantidadeDeHoras * 400;
                Console.WriteLine("O total de horas que você irá receber é: " + total);
            }

        }
    }
}
