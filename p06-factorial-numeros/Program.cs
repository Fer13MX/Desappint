// Calcula el factorial de n numeros
long n;
double f;
Console.Clear();
Console.WriteLine("Calculo del factorial de n numeros\n");
Console.Write("Hasta que numero deseas el factorial? "); n= long.Parse(Console.ReadLine());
for(int i=1; i<=n; i++)
{
    f=1;
    for(int j=1;j<=i;j++)
    {
        f*=j;
    }
    Console.Write($"{i} !=");
    Console.Write($" {f} \n");
}

