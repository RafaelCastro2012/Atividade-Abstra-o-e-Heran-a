using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Empregado
    {
        public string Nome;
        public int Idade;
        public string Setor;
        private string Cpf;
        private string Rg;

        public void CalcularSalario(double salario)
        {


            if (salario < 2500 && salario > 3500)
            {
                double salarioTotal = salario * 1.10;
                Console.WriteLine("Seu novo salário:" + salarioTotal);
            }
            else if (salario > 3500){
                double salarioTotal = salario * 1.08;
                Console.WriteLine("Seu novo salário:" + salarioTotal);
            }
            else
            {
                double salarioTotal = salario * 1.12;
                Console.WriteLine("Seu novo salário:" + salarioTotal);
            }
            
        }
        public static void CalcularAlimentacao()
        {

        }
    }
}
