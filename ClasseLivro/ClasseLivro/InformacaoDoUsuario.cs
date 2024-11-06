using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseLivro
{
    internal class InformacaoDoUsuario
    {
        //public void DadosUsuario()
        //{
        //    Console.WriteLine("Digite o seu Nome");
        //    string nome = Console.ReadLine();
        //    Console.WriteLine("Digite o seu CPF");
        //    string cpf = Console.ReadLine();
        //    Console.WriteLine("Digite a sua idade");
        //    int idade = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Digite o seu Endereço");
        //    string endereco = Console.ReadLine();
        //    Console.WriteLine("Digite a sua cidade");
        //    string cidade = Console.ReadLine();
        //    Console.WriteLine("Digite o seu Estado");
        //    string estado = Console.ReadLine();
        //    Console.WriteLine("Digite o seu pais");
        //    string pais = Console.ReadLine();

        //    Console.WriteLine("Nome:" + nome);
        //    Console.WriteLine("Cpf:" + cpf);
        //    Console.WriteLine("Idade:" + idade);
        //    Console.WriteLine("Endereço:" + endereco);
        //    Console.WriteLine("Cidade:" + cidade);
        //    Console.WriteLine("Estado:" + estado);
        //    Console.WriteLine("Pais:" + pais);

        //}

        //public void DadosJogador()
        //{
        //    Console.WriteLine("Digite o seu nome");
        //    string nome = Console.ReadLine();
        //    Console.WriteLine("Digite o seu time");
        //    string time = Console.ReadLine();
        //    Console.WriteLine("Digite a sua cidade");
        //    string cidade = Console.ReadLine();
        //    Console.WriteLine("Digite o seu Estado");
        //    string estado = Console.ReadLine();
        //    Console.WriteLine("Qual o seu esporte?");
        //    string esporte = Console.ReadLine();

        //    Console.WriteLine("Digite a sua idade:");
        //    int idade = Convert.ToInt32(Console.ReadLine());


        //    if (idade < 12)
        //    {
        //        Console.WriteLine("Categoria Infantil");
        //    }
        //    if (idade > 12 && idade < 16)
        //    {
        //        Console.WriteLine("Categoria Juvenil");
        //    }
        //    if (idade > 16 && idade < 20)
        //    {
        //        Console.WriteLine("Categoria Junior");
        //    }
        //    if (idade > 20)
        //    {
        //        Console.WriteLine("Categoria Adulto");
        //    }
        //}

        //public void QuantidadeProduto()
        //{
        //        Console.WriteLine("Digite o nome do produto");
        //        string NomeProduto = Console.ReadLine();
        //        Console.WriteLine("Digite a marca do produto");
        //        string MarcaProduto = Console.ReadLine();
        //        Console.WriteLine("Digite o código do produto");
        //        string CodigoProduto = Console.ReadLine();

        //        Console.WriteLine("Digite quantos produtos");
        //        int quantidade = Convert.ToInt32(Console.ReadLine());

        //        if (quantidade < 10)
        //        {
        //        Console.WriteLine("O preço é de: R$" + quantidade * 12.00);
        //        }
        //        else if (quantidade > 10 && quantidade < 20)
        //        {
        //            Console.WriteLine("O preço é de: R$" + quantidade * 15.00);
        //        }
        //        else
        //        {
        //            Console.WriteLine("O preço é de: R$" + quantidade * 5.00);
        //        }

        //public void Estudar()
        //{
        //    Console.WriteLine("Digite o seu nome");
        //    string nome = Console.ReadLine();
        //    Console.WriteLine("Digite a sua idade");
        //    int idade = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Digite o nome de sua escola");
        //    string escola = Console.ReadLine();

        //    if (escola == "senai")
        //    {
        //        Console.WriteLine("Parabéns você está cursando em uma excelente escola");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Aluno não pertence ao Senai");
        //    }
        //}

        //public void AreaQuadrado()
        //{
        //    Console.WriteLine("Digite a largura do quadrado");
        //    double larguraQuadrado = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digite a altura do quadrado");
        //    double alturaQuadrado = Convert.ToDouble(Console.ReadLine());
        //    double areaQuadrado = alturaQuadrado * larguraQuadrado;
        //    Console.WriteLine("A area do quadrado:" + areaQuadrado);
        //}

        //public void AreaTriangulo()
        //{
        //    Console.WriteLine("Digite a base do triangulo");
        //    double baseTriangulo = Convert.ToDouble(Console.ReadLine());
        //    Console.WriteLine("Digite a altura do triangulo");
        //    double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
        //    double areaTriangulo = (alturaTriangulo * baseTriangulo) / 2;
        //    Console.WriteLine("A area do triangulo:" + areaTriangulo);
        //}

        //public void AreaCirculo()
        //{
        //    Console.WriteLine("Digite o raio do circulo");
        //    double raioCirculo = Convert.ToDouble(Console.ReadLine());
        //    double areaCirculo = raioCirculo * raioCirculo * 3.14;
        //    Console.WriteLine("A área do triangulo:" + areaCirculo);
        //}

        public void Professor()
        {
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a sua matéria que você atua");
            string materia = Console.ReadLine();
            Console.WriteLine("Digite a sua cidade");
            string cidade = Console.ReadLine();
            Console.WriteLine("Qual a escola que você trabalha?");
            string escola = Console.ReadLine();
        }
        public void MediaDoAluno(double nota, double nota2, double nota3, double nota4)
        {
            Console.WriteLine("Digite o nome do aluno");
            string aluno = Console.ReadLine();
            double media = (nota + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A media do aluno: " + aluno + " é :" + media);
        }
    }
}

