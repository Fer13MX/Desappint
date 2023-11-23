public class InicializadorBD 
{
    public static void Inicializar(ContextoDatos contexto) 
    {
        if(contexto.Clientes.Any()) 
        {
            return;
        }
        var clientes = new List<Cliente> 
        {
            new Cliente {ClienteId = 1, Nombre = "Sofia", Apeido = "Bulga", Genero= 'M', FechaCumple = DateTime.Parse("2001-09-01"), Correo= "sofybul@uar.edu.rs", Telefono= 4923647100}
        };
        contexto.Clientes.AddRange(clientes);
        contexto.SaveChanges();
        var habitaciones = new List<Habitacion> 
        {
            new Habitacion {HabitacionId = 100, NoHab = 13 , Tipo = "Individual", Piso = 3, Costo = 800}
        };
        contexto.Habitaciones.AddRange(cursos);
        contexto.SaveChanges();
        var reservas = new List<Reserva>
        {
            new Reserva {ReservaId = 1, HabitacionId = habitaciones.Single(h => h.HabitacionId == 100 ).HabitacionId, ClienteId = clientes.Single(c => c.ClienteId == 1 ).ClienteId, InicioReserva = DateTime.Parse("2023-01-01"), FinReserva = DateTime.Parse("2023-01-02")}
        };
        contexto.Reservas.AddRange(reservas);
        contexto.SaveChanges();
    }
}