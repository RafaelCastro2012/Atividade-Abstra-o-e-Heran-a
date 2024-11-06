using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class AtividadeProfessor : PessoaAtividade
    {
        private string nif;
        
        public string Nif
        {
            get 
            { 
                return nif;
            }
            set
            {
                nif = value;
            }
        }
        private string cpf;

        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            { 
                cpf = value;
            }
        }
    }
}
