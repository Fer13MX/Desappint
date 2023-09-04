//Biblioteca para las calificaciones de los alumnos
public static class Cal
{
    public static void Men(double d, string n)
    {
        if(d>=0 &&d<=5.9)
        {
            Console.Write($"{n}\t");
            Console.Write($"{d}\t");
            Console.Write("D\t");
            Console.Write("Andas Mal\t");
        }
        if(d>=6 &&d<=7.5)
        {
            Console.Write($"{n}\t");
            Console.Write($"{d}\t");
            Console.Write("C\t");
            Console.Write("Mucho Mejor\t");
        }
        if(d>=7.6 &&d<=8.5)
        {
            Console.Write($"{n}\t");
            Console.Write($"{d}\t");
            Console.Write("B\t");
            Console.Write("Muy Bien\t");
        }
        if(d>=8.6 &&d<=10)
        {
            Console.Write($"{n}\t");
            Console.Write($"{d}\t");
            Console.Write("A\t");
            Console.Write("Excelente\t"); 
        }
    }
    public static double Prom()
    {
        double promsem;
        do
        {
            Console.Write("Por favor escribe un promedio valido: ");
            promsem=double.Parse(Console.ReadLine());
        }while(promsem<0 || promsem>10);
        return promsem;
    }
}