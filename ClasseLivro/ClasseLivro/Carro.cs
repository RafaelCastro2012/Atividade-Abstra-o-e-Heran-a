using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class Carro
    {
        //atributo privado
        private string nome;
        string mensagem;

        //propriedade get e set para manipular atributo privado
        public string Name
        {
            //Obter o valor
            get
            {
                return nome;
            }

            //Definir o valor
            set
            {
                nome = value;
            }
        }
        public string Mensagem(string mensagem)
        {
            return this.mensagem = mensagem;
        }
    }
}
