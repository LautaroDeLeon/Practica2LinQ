using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2EJ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresaEmpleado ce = new ControlEmpresaEmpleado();

            Console.WriteLine("Promedios por empresas \n************");
            ce.promedioSalario();
            Console.WriteLine("");

            Console.WriteLine("Peces gordos \n************");
            ce.getSeo("CEO");
            Console.WriteLine("");

            Console.WriteLine("Plantilla \n************");
            ce.getEmpleadosOrdenados();
            Console.WriteLine("");
            Console.WriteLine("Plantilla ordenada por salarios \n************");
            ce.getEmpleadosOrdenadosSalario();
            Console.WriteLine("");

            Console.WriteLine("Ingrese la empresa: (entero 1 a 3)\n1 para El Dorado\n2 para Tienda Inglesa\n3 para Macro Mercado");
            string _Id=Console.ReadLine();
            try
            {
                int _Empresa = int.Parse(_Id);
                ce.getEmpleadosEmpresa(_Empresa);
            }
            catch
            {
                Console.WriteLine("Ha introducido un ID erroneo. Debe ingresar un numero entero");
            }
        }
    }
}
