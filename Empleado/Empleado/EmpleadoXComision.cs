using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class EmpleadoXComision : Empleado
    {
        private decimal ventasBrutas;
        private decimal tarifaComision;

        public EmpleadoXComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa) : base (nombre, apellido, nss)
        {
            ventasBrutas = ventas;
            tarifaComision = tarifa;
        }

        public decimal TarifaComision
        { get { return tarifaComision; } set { tarifaComision = (value > 0 && value <1)? value : 0; } }

        public decimal VentasBrutas
        { get { return ventasBrutas; } set { ventasBrutas = (value >= 0) ? value : 0; } }

        public override decimal Ingresos()
        {
            return TarifaComision * VentasBrutas;
        }

        public override string ToString()
        {
            return String.Format("{0}: {1}\n{2}: {3:C}\n{4}: {5:F2}", "empleado por comision: ",  base.ToString(), "Ventas brutas: ", VentasBrutas, "Tarifa de comisión: ", TarifaComision);
        }
    }
}
