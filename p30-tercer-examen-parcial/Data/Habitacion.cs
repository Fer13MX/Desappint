using System.ComponentModel.DataAnnotations;
public class Habitacion 
{
    public int HabitacionId { get; set; }
    [Range(1,30)]
    public int NoHab { get; set; }
    [Required, StringLength(10)]
    public string Tipo { get; set; }
    [Range(1,4)]
    public int Piso { get; set; }
    [Required, Range(1,5000)]
    public double Costo { get; set; }
    public ICollection<Reserva> Reservas { get; set; }
}