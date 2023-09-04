//Biblioteca para Calcular distancias entre 2 puntos
public static class Calcs
{
    public static double Distancia(double ax,double ay,double bx,double by)
    {
        double x=0, y=0, d=0;
        x= Math.Pow(ax-bx,2);
        y= Math.Pow(ay-by,2);
        d= Math.Sqrt(x+y);
        return d;
    }
}