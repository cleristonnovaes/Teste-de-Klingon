using System;
using System.IO;

namespace Teste_de_Klingon
{
    public class Program
    {
        static void Main(string[] args)
        {
            Desafio1 desafio1 = new Desafio1();
            TextReader textoB = new StreamReader("klingon-textoB.txt");
            var questao1 = desafio1.GetProposicoes(textoB.ReadToEnd()); 
            Console.WriteLine(questao1);

            Console.ReadKey();

        }
    }
}
