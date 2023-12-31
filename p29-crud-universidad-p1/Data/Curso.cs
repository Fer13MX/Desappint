using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Curso
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CursoId {get ; set;}
    [StringLength(50,MinimumLength=3)]
    public String Titulo {get ; set;}
    [Range(2,7)]
    public int Creditos {get ; set;}

    public ICollection <Inscripcion> Inscripciones {get ; set;} //modela la relacion uno a muchos
}