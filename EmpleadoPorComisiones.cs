namespace PracticaProgra
{
    public class EmpleadoPorComisiones : Empleado, IIngresosAdicionales
    {
        public double VentasMensuales { get; set; }
        public EmpleadoPorComisiones(string nombre, double ventasMensuales) : base(nombre)
        {
            VentasMensuales = ventasMensuales;
        }

        public double CalcularIngresosAdicionales()
        {
            return 0.1 * VentasMensuales; // Suponemos que se destine un 10% de las ventas entren como ingreso adicional
        }

        public override double CalcularSalarioBase()
        {
            return base.CalcularSalarioBase() + 500; // Salario base por las comisiones
        }
    }
}
