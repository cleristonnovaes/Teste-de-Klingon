using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Klingon.Desafios
{
    public class NumerosBonitos
    {
        
        public int GetValor(string texto)
        {
            List <char> alfabetoKlingon = new() { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };
            int countBonitos = 0;

            foreach (var palavras in texto.Split(" "))
            {
                double numero = 0;
                int peso = 0;

                foreach (var letra in palavras)
                {
                    numero += alfabetoKlingon.IndexOf(letra) * Math.Pow(20, peso);
                    peso++;
                }
                if(numero >= 440566 && numero % 3 == 0)
                {
                    countBonitos++;
                }
            }
            return countBonitos;
        }
    }
}
