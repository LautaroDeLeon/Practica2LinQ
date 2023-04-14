using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EJ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SOLUCION VIEJA 
             
                    List<int> valores = new List<int>() { 1, 9, 3, 4, 5, 6, 7, 8, 2 };

                        for (var indice = 0; indice<valores.Count -1; indice++)
                        {
                            if (valores[indice] > valores[indice + 1])
                            {
                                var valorTemporal = valores[indice];

                    valores[indice] = valores[indice + 1];
                                valores[indice + 1] = valorTemporal;

                                indice = -1;
                            }
            }

            foreach (var valorOrdenado in valores)
            {
                Console.WriteLine(valorOrdenado);
            } 
            */

            var valores = new List<int> { 3, 6, 9, 7, 4, 1, 2, 5, 8 };
            var valoresOrdenados = valores.OrderBy(x => x);
            foreach (var valorOrdenado in valoresOrdenados)
            {
                Console.WriteLine(valorOrdenado);
            }
            Console.WriteLine("");
        }
    }
}
