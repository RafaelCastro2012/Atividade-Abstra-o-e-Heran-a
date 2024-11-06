using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Imposto
    {
        public virtual void ValeAlimentacao(double salario)
        {
            Console.WriteLine("O desconto padrão do vale alimentação é de: " +  salario * 0.1 + " reais");
        }

        public void ValeTransporte(double salario)
        {
            Console.WriteLine("O desconto padrão do vale transporte é de: " + salario * 0.06 + " reais");
        }
    }
}
