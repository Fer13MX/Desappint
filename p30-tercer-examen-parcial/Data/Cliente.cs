using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Cliente
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ClienteId {get ; set;}
    [StringLength(30,MinimumLength=3)]
    public String Nombre {get ; set;}
    [StringLength(30,MinimumLength=3)]
    public String Apeido {get ; set;}
    public char Genero {get ; set;}
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
    ApplyFormatInEditMode = true)]
    public DateTime FechaCumple { get; set; }
    [EmailAddress]
    public string Correo {get; set;}
    [StringLength(10,MinimumLength=10)]
    public String Telefono {get ; set;}
    [Display(Name = "Nombre Completo")]
    public string NombreCompleto 
    {
        get { return Nombre + " " + Apeido; }
    }
    public ICollection <Reserva> Reservas {get ; set;} //modela la relacion uno a muchos
}