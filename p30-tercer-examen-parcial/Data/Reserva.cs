using System.ComponentModel.DataAnnotations;
public class Reserva
{
public int ReservaId { get; set; }
public int HabitacionId { get; set; }
public int ClienteId { get; set; }
[DataType(DataType.Date)]
[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
public DateTime InicioReserva { get; set; }
[DataType(DataType.Date)]
[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
public DateTime FinReserva { get; set; }
public int DiasReserva 
    {
        get { return InicioReserva - FinReserva; }
    }
public int CostoTotal 
    {
        get { return DiasReserva*Costo; }
    }    
public Cliente Cliente { get; set; }
public Habitacion Habitacion { get; set; }
}