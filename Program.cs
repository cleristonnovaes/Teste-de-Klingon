using System;
using System.IO;
using System.Text;
using Teste_de_Klingon.Desafios;

namespace Teste_de_Klingon
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pathTextoA = "D:/C#/Teste de Klingon/klingon-textoA.txt";
            var pathTextoB = "D:/C#/Teste de Klingon/klingon-textoB.txt";
            var textoA = File.ReadAllText(pathTextoA, Encoding.UTF8);
            var textoB = File.ReadAllText(pathTextoB, Encoding.UTF8);

            // Desafio 1
            Desafio1 desafio1 = new Desafio1();
            var questao1 = desafio1.GetProposicoes(textoB); 
            Console.WriteLine("O total de preposições são: " + questao1);

            //Desafio 2a - Total Verbos
            Desafio2a desafio2a = new Desafio2a();
            var questao2a = desafio2a.GetVerbosTotal(textoB);
            Console.WriteLine("O total de Verbos são: " + questao2a);

            //Desafio 2b - Total Verbos Primeira Pessoa
            Desafio2b desafio2b = new Desafio2b();
            var questao2b = desafio2b.GetVerbosPrimeira(textoB);
            Console.WriteLine("O total de Verbos em primeira pessoa são: " + questao2b);


            Console.ReadKey();

        }
    }
}
