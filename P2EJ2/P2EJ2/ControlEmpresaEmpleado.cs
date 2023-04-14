using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P2EJ2
{
    internal class ControlEmpresaEmpleado
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;
        public ControlEmpresaEmpleado()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "El Dorado" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Tienda Inglesa" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "Macro Mercado" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Lautaro", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "German", Cargo = "Ayudante", EmpresaId = 1, Salario = 4000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Juan", Cargo = "CEO", EmpresaId = 2, Salario = 5000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Santiago", Cargo = "Reponedor", EmpresaId = 2, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Jorge", Cargo = "CEO", EmpresaId = 3, Salario = 9000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Claudio", Cargo = "Ventas", EmpresaId = 3, Salario = 3000 });       
        }
        public void getSeo(string _Cargo)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              where empleado.Cargo == _Cargo
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Nombre
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }

        public void getEmpleadosOrdenadosSalario()
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              orderby empleado.Salario
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }
        public void getEmpleadosEmpresa(int _Empresa)
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados
                                              join empresa in listaEmpresas on empleado.EmpresaId
                                              equals empresa.Id
                                              where empresa.Id == _Empresa
                                              select empleado;
            foreach (Empleado elemento in empleados)
            {
                elemento.getDatosEmpleado();
            }
        }
        public void promedioSalario()
        {
            var consulta = from e in listaEmpleados
                           group e by e.EmpresaId into g
                           select new
                           {
                               empresa = g.Key,
                               promedioSalario = g.Average(e => e.Salario)
                           };
            foreach (var resultado in consulta)
            {
                switch (resultado.empresa)
                {
                    case 1:
                        Console.WriteLine($"Empresa El Dorado - Promedio de salario: {resultado.promedioSalario}");
                        break;
                    case 2:
                        Console.WriteLine($"Empresa Tienda Inglesa - Promedio de salario: {resultado.promedioSalario}");
                        break;
                    case 3:
                        Console.WriteLine($"Empresa Macro Mercado - Promedio de salario: {resultado.promedioSalario}");
                        break;
                }
            }

        }
    }
}
