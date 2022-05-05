using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_de_Klingon.Desafios
{
    public class VocabularioKlingon
    {
        
        public StringBuilder GetVocabulario(string texto)
        {
            List<string> listaTexto = texto.Split(' ').ToList();

            List<char> alfabetoKlingon = new List<char> { 'k', 'b', 'w', 'r', 'q', 'd', 'n', 'f', 'x', 'j', 'm', 'l', 'v', 'h', 't', 'c', 'g', 'z', 'p', 's' };
            List<string> vocabulario = new List<string>();

            vocabulario = listaTexto.Distinct().ToList();
            vocabulario = vocabulario.OrderBy(x => alfabetoKlingon.IndexOf(x[0]))
                                     .ThenBy(x => alfabetoKlingon.IndexOf(x[1]))
                                     .ThenBy(x => alfabetoKlingon.IndexOf(x[2])).ToList();

            var textoOrdenado = new StringBuilder("");

            foreach (var item in vocabulario)
            {
                textoOrdenado.Append(item + " ");
            }

            return textoOrdenado;
        }


    }
}
