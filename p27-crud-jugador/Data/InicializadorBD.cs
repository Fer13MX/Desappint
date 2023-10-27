public class InicializadorBD 
{
    public static void Inicializar(ContextoDatos contexto) 
    {
        if(contexto.Jugadores.Any()) 
        {
            return;
        }
        var jugadores = new Jugador[] 
        {
            new Jugador {Nombre="Juan Perez",FechaNac=DateTime.Parse("1/1/2000"),NoPlayera=1,Posicion="Portero",Apariciones=20,Goles=0},
            new Jugador {Nombre="Heladio Juarez",FechaNac=DateTime.Parse("10/2/2000"),NoPlayera=2,Posicion="Defensa",Apariciones=50,Goles=10},
            new Jugador {Nombre="Julio Bermeo",FechaNac=DateTime.Parse("10/2/2001"),NoPlayera=3,Posicion="Medio",Apariciones=15,Goles=4},
            new Jugador {Nombre="Julio Walas",FechaNac=DateTime.Parse("15/5/2015"),NoPlayera=12,Posicion="Delantero",Apariciones=45,Goles=20}
        };
            contexto.Jugadores.AddRange(jugadores);
            contexto.SaveChanges();
    }
}