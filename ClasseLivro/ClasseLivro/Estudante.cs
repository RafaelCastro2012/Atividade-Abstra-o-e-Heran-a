using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class Estudante
    {
        //Modificador de acesso protegido
        protected string nome="Ricardo";
        protected string idade="30";
        protected string sobrenome="Fonseca";

        public string LerNome()
        {
            return nome;
        }

        public string LerIdade()
        {
            return idade;
        }

        public string LerSobrenome()
        {
            return sobrenome;
        }
    }

 
}
