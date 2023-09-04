public static class NumArr
{
    public static void Muestra(int[] ar, int n)
    {
        int i=0;
        while(i<n)
        {
            if(i==n-1)
            Console.Write($"{ar[i]}");
            else
            Console.Write($"{ar[i]},");
            i++;
        }
    }
    public static void Suma(int[] ar, int n)
    {
        int i=0, sum=0;
        while(i<n)
        {
            sum+=ar[i];
            i++;
        }
        Console.Write($"\nla suma de los numeros del arreglo es: {sum}");
    }
    public static void SumDiv(int[] ar, int n)
    {
        int i=0; 
        double sum=0,temp=0; 
        while(i<n)
        {
            temp=Convert.ToDouble(ar[i]);
            sum+=temp/2;
            i++;
        }
        Console.Write($"\nla suma de los numeros del arreglo dividido entre 2 es: {sum}\n");
    }
    public static void Inv(int[] ar, int n)
    {
        int i=0;
        while(n>i)
        {
            if(n==i+1)
            Console.Write($"{ar[n-1]}");
            else
            Console.Write($"{ar[n-1]},");
            n--;
        }
        
    }
}
