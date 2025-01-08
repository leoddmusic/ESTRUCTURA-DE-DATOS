using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class Asociacion
{
    public List<Empleado> Empleados { get; set; }
    public List<Aporte> Aportes { get; set; }

    public Asociacion()
    {
        Empleados = new List<Empleado>();
        Aportes = new List<Aporte>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
        Console.WriteLine($"Empleado {empleado.Nombre} agregado con éxito.");
    }

    public void RegistrarAporte(Aporte aporte)
    {
        Aportes.Add(aporte);
        Console.WriteLine($"Aporte de {aporte.Monto} registrado con éxito.");
    }

    public void MostrarEmpleados()
    {
        Console.WriteLine("Lista de empleados registrados:");
        foreach (var empleado in Empleados)
        {
            empleado.MostrarInformacion();
        }
    }

    public void MostrarAportesPorEmpleado(int empleadoId)
    {
        Console.WriteLine($"Aportes realizados por el empleado con ID {empleadoId}:");
        foreach (var aporte in Aportes)
        {
            if (aporte.EmpleadoId == empleadoId)
            {
                aporte.MostrarInformacion();
            }
        }
    }

    public void MostrarReporteGeneral()
    {
        Console.WriteLine("Reporte general de aportes:");
        foreach (var aporte in Aportes)
        {
            aporte.MostrarInformacion();
        }
    }

    public void GuardarDatos()
    {
        var datos = new
        {
            Empleados = this.Empleados,
            Aportes = this.Aportes
        };

        string json = JsonSerializer.Serialize(datos);
        File.WriteAllText("datos.json", json);
        Console.WriteLine("Datos guardados correctamente.");
    }

    public void CargarDatos()
    {
        if (File.Exists("datos.json"))
        {
            string json = File.ReadAllText("datos.json");
            var datos = JsonSerializer.Deserialize<dynamic>(json);

            this.Empleados = JsonSerializer.Deserialize<List<Empleado>>(datos.GetProperty("Empleados").ToString());
            this.Aportes = JsonSerializer.Deserialize<List<Aporte>>(datos.GetProperty("Aportes").ToString());

            Console.WriteLine("Datos cargados correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontraron datos para cargar.");
        }
    }
}
