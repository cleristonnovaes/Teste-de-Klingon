﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Klingon
{
    public class Desafio1
    {
        private readonly string _foo = "slfwek";
        
        public int GetProposicoes(string texto)
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
