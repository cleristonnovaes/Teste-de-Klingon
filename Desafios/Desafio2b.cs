using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Klingon.Desafios
{
    public class Desafio2b
    {
        private readonly string _foo = "slfwek";

        public int GetVerbosPrimeira(string texto)
        {
            var qtde = 0;

            foreach (var word in texto.Split(" "))
            {
                var lastWord = word[word.Length - 1];
                var firstWord = word[0];

                if (word.Length >= 8 && _foo.Contains(lastWord) && !_foo.Contains(firstWord))
                {
                    qtde++;
                }

            }
            return qtde;
        }
    }
}
