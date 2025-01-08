using System;

public class Empleado
{
    public int Id { get; set; }
    public string Nombre { get; set; }

    public Empleado(int id, string nombre)
    {
        Id = id;
        Nombre = nombre;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}, Nombre: {Nombre}");
    }
}
