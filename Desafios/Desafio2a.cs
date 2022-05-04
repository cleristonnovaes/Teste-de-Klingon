using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Klingon.Desafios
{
    public class Desafio2a
    {
        private readonly string _foo = "slfwek";

        public int GetVerbosTotal(string texto)
        {

            var qtde = 0;

            foreach (var word in texto.Split(" "))
            {
                var lastWord = word[word.Length - 1];

                if (word.Length >= 8 && _foo.Contains(lastWord))
                {
                    qtde++;
                }

            }
            return qtde;
        }
    }
}
