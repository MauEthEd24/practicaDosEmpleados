using practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica.Clases
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override double SueldoBase => 8000;
        public double CalcularBonificacion()
        {
            return SueldoBase + 1000;
            
        }

        public double DescontarSueldo()
        {
            double sueldoconBono = CalcularBonificacion();
            return sueldoconBono * Constantes.Dscto20;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }
    }
}
