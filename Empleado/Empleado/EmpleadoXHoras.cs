using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class EmpleadoXHoras : Empleado
    {
        private decimal sueldo;
        private decimal horas;

        public EmpleadoXHoras(string nombre, string apellido, string nss, decimal sueldoXHoras, decimal hrsTrabajadas) : base (nombre, apellido, nss)
        {
            sueldo = sueldoXHoras;
            horas = hrsTrabajadas;
        }

        public decimal Sueldo
        { get { return sueldo; } set { sueldo = (value >= 0)? value:0; } }

        public decimal Horas
        { get { return horas; } set { horas = ((value >= 0) && (value <= 168)) ? value : 0; } }

        public override decimal Ingresos()
        {
            if (Horas <= 40)
                return Sueldo * Horas;
            else
                return (40 * Sueldo) + ((Horas - 40) * Sueldo * 1.5M); 
        }

        public override string ToString()
        {
            return String.Format("empleado por horas: {0}\n{1}: {2:C}; {3}: {4:F2}", base.ToString(), "Sueldo por horas: ", Sueldo, "Horas realizadas: ", Horas);
        }
    }
}
