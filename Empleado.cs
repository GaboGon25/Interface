using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra
{
    public class Empleado
    {
        public string Nombre { get; set; }

        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public virtual double CalcularSalarioBase()
        {
            return 5000;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre :{Nombre}");
            Console.WriteLine($"Salario Base : {CalcularSalarioBase()}");
        }
    }
}
