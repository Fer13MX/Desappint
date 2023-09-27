public class Categoria
{
    public string Nombre {get; set;}
    public string Rango {get; set;}
    public int Costo {get; set;}
    public List<Jugador> jugadores {get; set;}
    public Categoria() => jugadores = new List<Jugador>();
    public Categoria(string nombre,string rango,int costo) : this() =>(Nombre,Rango,Costo) = (nombre,rango,costo);
    public void AgregarJugador(Jugador jugador) => jugadores.Add(jugador);
    public int Subtotal()
    {
        int total=0;
        foreach(Jugador jugador in jugadores)
        {
            if(jugador.Becado==false)
            {
                total=total+Costo;    
            }
        }
        return total; 
    }
    public override string ToString() => $"Nombre: {Nombre,-12}Rango: {Rango,-8}Costo: {Costo,-10}";

}