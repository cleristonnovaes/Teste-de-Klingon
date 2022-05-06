using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Klingon.Desafios
{
    public class VerboTotal : IDesafio
    {
        public int GetValor(string texto, string _foo)
        {

            var count = 0;

            foreach (var word in texto.Split(" "))
            {
                var lastWord = word[^1];

                if (word.Length >= 8 && _foo.Contains(lastWord))
                {
                    count++;
                }

            }
            return count;
        }
    }
}
