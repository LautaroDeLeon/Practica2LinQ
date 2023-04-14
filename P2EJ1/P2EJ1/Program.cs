using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EJ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>
            {
            new Persona() { Nombre = "Juan", Edad = 24, Ciudad = "Lima" },
            new Persona() { Nombre = "Maria", Edad = 36, Ciudad = "Bogota" },
            new Persona() { Nombre = "Pedro", Edad = 34, Ciudad = "Madrid" },
            new Persona() { Nombre = "Ana", Edad = 35, Ciudad = "Lima" },
            new Persona() { Nombre = "Jose", Edad = 40, Ciudad = "Buenos Aires" }
        };


            var consulta = from p in personas
                           where p.Edad < 25 && p.Ciudad == "Lima"
                           orderby p.Nombre ascending
                           select new { p.Nombre, p.Edad };
            foreach (var persona in consulta)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }
            Console.WriteLine("");

            var consulta2= from p in personas
                           where p.Edad > 35 && p.Ciudad == "Bogota"
                           orderby p.Nombre ascending
                           select new { p.Nombre,p.Edad };
            foreach (var persona in consulta2)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }
            Console.WriteLine("");

            var consulta3 = from p in personas
                            where p.Edad >= 25 && p.Edad <= 35
                            orderby p.Edad ascending
                            select new { p.Nombre, p.Edad };
            foreach (var persona in consulta3)
            {
                Console.WriteLine($"{persona.Nombre} ({persona.Edad} años)");
            }
        }
    }
};

  