using practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public abstract double SueldoBase { get; }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }


        public abstract double CalcularSueldo();

        public void MostrarDetalles()
        {
            Console.WriteLine("El sueldo base es:");
            Console.WriteLine(SueldoBase);
        }
    }
}
