using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EJ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int sumaTotalParesMayoresOcho = 0;
            int sumaTotalParesMenoresOcho = 0;

            foreach (var valor in valores)
            {
                if (valor % 2 == 0 && valor > 8)
                {
                    sumaTotalParesMayoresOcho += valor;
                }
                if (valor % 2 == 0 && valor < 8)
                {
                    sumaTotalParesMenoresOcho += valor;
                }
            }
            Console.WriteLine($"La suma total de los pares mayores a ocho es: {sumaTotalParesMayoresOcho}");
            Console.WriteLine($"La suma total de los pares menores a ocho es: {sumaTotalParesMenoresOcho}");
            Console.WriteLine("");

            //usando LinQ
            var valoresParesMayoresOcho = valores.Where(valor => valor % 2 == 0 && valor > 8);
            var valoresParesMenoresOcho = valores.Where(valor => valor % 2 == 0 && valor < 8);
            var sumaMayoresOcho = valoresParesMayoresOcho.Sum();
            var sumaMenoresOcho= valoresParesMenoresOcho.Sum();
            Console.WriteLine($"La suma total de los pares mayores a ocho es: {sumaMayoresOcho}");
            Console.WriteLine($"La suma total de los pares menores a ocho es: {sumaMenoresOcho}");
        }
    }
}