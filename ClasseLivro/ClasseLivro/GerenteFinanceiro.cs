﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class GerenteFinanceiro : Imposto
    {
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine("O desconto padrão do vale alimentação é de: " + salario * 0.3 + " reais");
        }
    }
}