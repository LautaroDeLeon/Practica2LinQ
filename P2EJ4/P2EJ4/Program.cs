using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EJ4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* SOLUCION ANTERIOR
            List<int> valores = new List<int>() { 1,2,3,4,5,6,7,8,9};
            int sumaTotal = 0;

            foreach (var valor in valores)
            {
                sumaTotal += valor;
            }
            Console.WriteLine($"La suma total es {sumaTotal}");
            */

            //usando LinQ
            var valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valoresSumados = valores.Sum();
            Console.WriteLine($"La suma total es {valoresSumados}");

            //______________________________________________________________________________________

            /* SOLUCION ANTERIOR
            List<int> valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sumaTotalPares = 0;

            foreach (var valor in valores2)
            {
                if (valor % 2 == 0)
                {
                    sumaTotalPares += valor;
                }
            }
            Console.WriteLine($"La suma total de los valores pares es {sumaTotalPares}"); */

            //usando LinQ
            var valores2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var valoresPares = valores2.Where(valor=>valor%2==0).ToList();
            var valoresParesSumados = valoresPares.Sum();
            Console.WriteLine($"La suma de los valores pares es {valoresParesSumados}");
        }
    }
}
