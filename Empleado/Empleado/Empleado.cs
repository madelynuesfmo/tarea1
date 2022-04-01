using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public abstract class Empleado
    {
        private string primerNombre;
        private string primerApellido;
        private string numeroSocial;

        //constructor con 3 parametros
        public Empleado(string nombre, string apellido, string nss) 
        {
            primerNombre = nombre;
            primerApellido = apellido;
            numeroSocial = nss;
        }
        public string Nombre
            { get { return primerNombre; } }

        public string Apellido
            { get { return primerApellido; } }

        public string NombreSocial 
            { get { return numeroSocial; } }

        public override string ToString()
        {
            return string.Format("{0}{1}\n numero de seguro social: {2}", primerNombre, primerApellido, numeroSocial);
        }
        public abstract decimal Ingresos();


    }
}
