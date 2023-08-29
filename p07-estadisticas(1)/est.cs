//Biblioteca de funvciones de estadisticas para un arreglo de numeros flotantes
public static class Est
{
    public static string ImprimeS(double[] a)
    {
        return String.Join(",",a);
    }
    public static void Imprime(double[] a)
    {
        for(int i=0; i< a.Length;i++)
        Console.Write($"{a[i]:f2} ");
    }
    public static double Mayor(double[] a)
    {
        double m=a[0];
        foreach(double n in a)
            if(n>m) m=n;
        return m;
    }
    public static double Menor(double[] a)
    {
        double m=a[0];
        foreach(double n in a)
            if(n<m) m=n;
        return m;
    }
    public static double Promedio(double[] a)
    {
        double p=0;
        foreach(double n in a)
            p+=n;
        return p/a.Length;
    }
    public static double Varianza(double[] a, double p)
    {
        double s=0;
        foreach(double n in a)
            Math.Pow(n-p,2);
        return s/a.Length;
    }
}