public static class Va
{
    public static int Cant()
    {
        int n;
        Console.Write("Cuantos articulos quieres vender? ");
        n=int.Parse(Console.ReadLine());
        return n;
    }
    public static double Cal(int n)
    {
        int[] C = new int[n];
        double[] P = new double[n];
        double sumart=0;
        int i=0;
        while (i<n)
        {
            Console.Write($"Que cantidad quieres vender de el articulo {i+1}? ");
            C[i]=int.Parse(Console.ReadLine());
            Console.Write($"Que precio tiene el articulo {i+1}? ");
            P[i]=double.Parse(Console.ReadLine());
            sumart+=P[i]*C[i];
            i++;
        }
        return sumart;
    }
    public static double Iva(double n)
    {
        if(n<=1200) n+=n*0.15;
        return n;
    }
}