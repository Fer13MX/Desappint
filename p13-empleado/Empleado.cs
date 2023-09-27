//Código de clase
public class Empleado
{
    public string Nombre {get ;set}
    public int Edad {get ;set}
    public void ImprimirDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
    }
}