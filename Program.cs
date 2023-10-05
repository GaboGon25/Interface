using PracticaProgra;

EmpleadoSalarioFijo empleadoSalarioFijo = new EmpleadoSalarioFijo("Carlos Fuentes");
EmpleadoPorComisiones empleadoPorComisiones = new EmpleadoPorComisiones("Mario Lopez", 5000);

empleadoSalarioFijo.MostrarInformacion();
Console.WriteLine($"Ingresos Adicionales: C${empleadoSalarioFijo.CalcularIngresosAdicionales()}");
Console.WriteLine("------------------------------------------------------------------------------");

empleadoPorComisiones.MostrarInformacion();
Console.WriteLine($"Ingresos Adicionales: C${empleadoPorComisiones.CalcularIngresosAdicionales()}");
