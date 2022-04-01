using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmpleadoAsalariado empleadoAsalariado = new EmpleadoAsalariado("Madelyn", " Martinez", "111-111-11", 800.00M);
            EmpleadoXHoras empleadoXHoras = new EmpleadoXHoras("Wilfredo", " Quiteño", "222-22-2222", 16.75M, 40.0M);
            EmpleadoXComision empleadoXComision = new EmpleadoXComision("Mauricio", " Villatoro", "333-33-3333", 10000.00M, .06M);
            EmpleadoBaseMasComision empleadoBaseMasComision = new EmpleadoBaseMasComision("Karla", "Martinez",  "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("EMPLEADOS PROCESADOS EN FORMA INDIVIDUAL");

            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoAsalariado, "INGRESOS: ", empleadoAsalariado.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoXHoras, "INGRESOS: ", empleadoXHoras.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoXComision, "INGRESOS: ", empleadoXComision.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoBaseMasComision, "INGRESOS: ", empleadoBaseMasComision.Ingresos());

            Empleado[] empleados = new Empleado[4];

            empleados[0] = empleadoAsalariado;
            empleados[1] = empleadoXHoras;
            empleados[2] = empleadoXComision;
            empleados[3] = empleadoBaseMasComision;

            Console.WriteLine("Empleados procesados en forma polimórfica: ");
            Console.WriteLine("  ");

            foreach (Empleado empleadoActual in empleados)
            {
                Console.WriteLine(empleadoActual);

                if (empleadoActual is EmpleadoBaseMasComision )
                {
                    EmpleadoBaseMasComision empleado = (EmpleadoBaseMasComision)empleadoActual;
                    empleado.SalarioBase *= 1.10M;
                    Console.WriteLine("NUEVO SALARIO BASE CON INCREMENTO DEL 10%: {0:C}", empleado.SalarioBase);
                }

                Console.WriteLine("INGRESOS {0:C}\n", empleadoActual.Ingresos());
            }

            for (int j = 0; j < empleados.Length; j++)
            {
                Console.WriteLine("Empleado {0} es un {1}", j, empleados[j].GetType());
            }
            Console.ReadKey();

        }
    }
}
