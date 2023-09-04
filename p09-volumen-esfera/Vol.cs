//Biblioteca para calcular el volumen de una esfera
public static class Vol
{
    public static double Esf(double r)
    {
        double e = 0, c=4, t=3, pi=0, pot=0;
        e=c/t;
        pi=System.Math.PI;
        pot=Math.Pow(r,3);
        e=c/t*pi*pot;
        return e;
    }
}