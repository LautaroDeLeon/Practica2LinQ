using System;
using System.Collections.Generic;

namespace P2EJ6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SOLUCION VIEJA
            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario");
            string letra = Console.ReadLine();

            if(letra == "a")
            {
                Console.WriteLine("La siguiente letra del abecedario es B");
            }
            if (letra == "b")
            {
                Console.WriteLine("La siguiente letra del abecedario es C");
            }
            if (letra == "c")
            {
                Console.WriteLine("La siguiente letra del abecedario es D");
            }
            if (letra == "d")
            {
                Console.WriteLine("La siguiente letra del abecedario es E");
            }
            if (letra == "e")
            {
                Console.WriteLine("La siguiente letra del abecedario es F");
            }
            if (letra == "f")
            {
                Console.WriteLine("La siguiente letra del abecedario es G");
            } */


            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario");
            char eleccion = char.Parse(Console.ReadLine());
            for (char letra = eleccion; letra <= 'f'; letra++) {
                Console.WriteLine($"La siguiente letra del abecedario es: {letra}");
                break;
            }          
        }
    }
}