using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    public class AlunoAtividade : PessoaAtividade
    {
        private string ra;
        public string Ra
        {
            get
            {
                return ra;
            }
            set 
            {
                ra = value;
            }
        }

    }
}
