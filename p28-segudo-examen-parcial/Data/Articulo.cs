using System.ComponentModel.DataAnnotations;
public class Articulo {
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3), MaxLength(25)]
    //[ErrorMessage("Mini 3")]
    //[ErrorMessage("Maximo 3")]
    public string Descripcion {get; set;}
    [Range(typeof(DateTime),"1/1/2023","31/12/2024")]
    //[ErrorMessage("Fecha fuera del rango")]
    public DateTime FechaAlta {get; set;}
    [Range(1,100)]
    //[ErrorMessage("Numeros disponibles")]
    public int Cantidad {get; set;}
    [Range(1,2500)]
    public double Precio {get; set;}
    public string UdeMedida {get; set;}
}