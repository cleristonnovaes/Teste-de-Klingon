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
            var _foo = "slfwek";

            var textoA = File.ReadAllText(pathTextoA, Encoding.UTF8);
            var textoB = File.ReadAllText(pathTextoB, Encoding.UTF8);

            // Desafio 1
            Preposicao desafio1 = new Preposicao();
            var questao1 = desafio1.GetValor(textoB, _foo); 
            Console.WriteLine("O total de preposições são: " + questao1);

            //Desafio 2a - Total Verbos
            VerboTotal desafio2a = new VerboTotal();
            var questao2a = desafio2a.GetValor(textoB, _foo);
            Console.WriteLine("O total de Verbos são: " + questao2a);

            //Desafio 2b - Total Verbos Primeira Pessoa
            VerboPrimeira desafio2b = new VerboPrimeira();
            var questao2b = desafio2b.GetValor(textoB, _foo);
            Console.WriteLine("O total de Verbos em primeira pessoa são: " + questao2b);


            Console.ReadKey();

        }
    }
}
