using System.Runtime.InteropServices;

public class Jugador
{
    public string Nombre {get; set;}
    public int AñoNac {get; set;}
    public string Sexo {get; set;}
    public bool Becado {get; set;}
    public string Beca(bool Becado)
    {
        string b="";
        if(Becado==true)
        {
            b="Si";
        }
        else
        {
            b="No";
        }
        return b;
    }
    public Jugador() {}
    public Jugador(string nombre,int añonac,string sexo,bool becado)=>(Nombre,AñoNac,Sexo,Becado) = (nombre,añonac,sexo,becado);
    public override string ToString() => $"Nombre:{Nombre,-18} Año:{AñoNac,-8}Genero:{Sexo,-8}Tiene beca:{Beca(Becado),-8}";

}