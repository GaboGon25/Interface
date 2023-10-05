using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra
{
    public class EmpleadoSalarioFijo : Empleado, IIngresosAdicionales
    {
        

        public EmpleadoSalarioFijo(string nombre) : base(nombre)
        {
        }

        public double CalcularIngresosAdicionales()
        {
            return 800;
        }
    }
}
