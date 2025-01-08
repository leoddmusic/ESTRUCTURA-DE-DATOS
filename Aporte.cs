using System;

public class Aporte
{
    public int EmpleadoId { get; set; }
    public decimal Monto { get; set; }
    public DateTime Fecha { get; set; }

    public Aporte(int empleadoId, decimal monto, DateTime fecha)
    {
        EmpleadoId = empleadoId;
        Monto = monto;
        Fecha = fecha;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Empleado ID: {EmpleadoId}, Monto: {Monto}, Fecha: {Fecha.ToShortDateString()}");
    }
}
