using Microsoft.EntityFrameworkCore;
public class ContextoDatos : DbContext 
{
    public ContextoDatos(DbContextOptions<ContextoDatos> options) :
    base(options) 
    {

    }
    public DbSet<Reserva> Reservas { get; set; }
    public DbSet<Habitacion> Habitaciones { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    }
