using System;

class Program
{
    static void Main(string[] args)
    {
        Asociacion asociacion = new Asociacion();

        // Cargar datos al iniciar
        asociacion.CargarDatos();

        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n=== Sistema de Registro de Aportes ===");
            Console.WriteLine("1. Agregar empleado");
            Console.WriteLine("2. Registrar aporte");
            Console.WriteLine("3. Mostrar empleados");
            Console.WriteLine("4. Mostrar aportes por empleado");
            Console.WriteLine("5. Mostrar reporte general");
            Console.WriteLine("6. Guardar y salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el ID del empleado: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el nombre del empleado: ");
                    string nombre = Console.ReadLine();
                    asociacion.AgregarEmpleado(new Empleado(id, nombre));
                    break;

                case "2":
                    Console.Write("Ingrese el ID del empleado que realiza el aporte: ");
                    int empleadoId = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el monto del aporte: ");
                    decimal monto = decimal.Parse(Console.ReadLine());
                    asociacion.RegistrarAporte(new Aporte(empleadoId, monto, DateTime.Now));
                    break;

                case "3":
                    asociacion.MostrarEmpleados();
                    break;

                case "4":
                    Console.Write("Ingrese el ID del empleado: ");
                    int empleadoConsultaId = int.Parse(Console.ReadLine());
                    asociacion.MostrarAportesPorEmpleado(empleadoConsultaId);
                    break;

                case "5":
                    asociacion.MostrarReporteGeneral();
                    break;

                case "6":
                    asociacion.GuardarDatos();
                    salir = true;
                    Console.WriteLine("¡Gracias por usar el sistema!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }
}
