using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste_de_Klingon.Desafios;

namespace Teste_de_Klingon
{
    public class Preposicao : IDesafio
    {
        public int GetValor(string texto, string _foo)
        {
            var qtde = 0;

            foreach (var word in texto.Split(" "))
            {
                var lastWord = word[word.Length - 1];
                if(word.Length == 3 && !_foo.Contains(lastWord) && !word.Contains("d"))
                {
                    qtde++;
                }

            }
            return qtde;
        }
       
      
    }
}
