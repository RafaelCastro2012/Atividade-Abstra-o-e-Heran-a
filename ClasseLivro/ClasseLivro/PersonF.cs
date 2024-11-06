using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
     class PersonF : Padrao
    {
        //Método obrigatório, criar as regras de negócios
        public override void TaxaEmprestimo(double valor) 
        {
            Console.WriteLine("Digite o valor da taxa a ser paga");
            double taxa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O valor da taxa de empréstimo para" + " Pessoa Física é de: " + (valor * taxa));
        }
    }
}
