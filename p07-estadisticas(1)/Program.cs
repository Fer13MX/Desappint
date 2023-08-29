// See https://aka.ms/new-console-template for more information
const int MAX=100;
int n=0;
double[] califs=null;
double may=0, men=0, prom=0, var=0, desv=0;
Console.Clear();
Console.WriteLine("Cuantos elementos? ");
n= int.Parse(Console.ReadLine());
if(n>MAX)
{
    Console.WriteLine("El maximo de elementos es {0}", MAX);
    return 1;
}
califs = new double[n];
for(int i=0;i<califs.Length;i++)
{
    Console.WriteLine($"calif[i]= ");
    califs[i]= double.Parse(Console.ReadLine());
}
Console.WriteLine($"Los elementos del arreglo son: {Est.ImprimeS(califs)}");

Est.Imprime(califs);
may = Est.Mayor(califs);
men = Est.Menor(califs);
prom = Est.Promedio(califs);
var = Est.Varianza(califs,prom);
desv = Math.Sqrt(var);
Console.WriteLine("\nResumen de Estadisticas");
Console.WriteLine($"Cantidad de calificaciones{califs.Length}");
Console.WriteLine($"El Mayor      es:{may:f2}");
Console.WriteLine($"El Menor      es:{men:f2}");
Console.WriteLine($"El Promedio   es:{prom:f2}");
Console.WriteLine($"La Varianza   es:{var:f2}");
Console.WriteLine($"La Desviacion es:{desv:f2}");
return 0;