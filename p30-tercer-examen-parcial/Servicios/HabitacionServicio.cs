// Servicios/HabitacionServicio.cs
using Microsoft.EntityFrameworkCore;
public class HabitacionServicio 
{
    private readonly ContextoDatos ctx;
    public HabitacionServicio(ContextoDatos contexto) => ctx = contexto;
    public List<Habitacion> ObtenerTodo(string cadenabuscar) 
    {
        var _cabitacions = ctx.Habitacions
        	.Include(r=>r.Reservas)
        		.ThenInclude(c=>c.Cliente);
        var habitacions = from h in _habitacions select c;
        if(!string.IsNullOrEmpty(cadenabuscar)) 
        {
            habitacions = habitacions.Where(h=>h.Tipo.Contains(cadenabuscar));
        }
        return habitacions.ToList();
    }
    public bool AgregarActualizar(Habitacion habitacion) 
    {
        try 
        {
            if (habitacion.HabitacionId == 0) ctx.Habitacions.Add(habitacion);
        	else ctx.Habitacions.Update(habitacion);
        	ctx.SaveChanges();
        	return true;
        }
        catch (Exception ex) { return false; }
    }
    public Habitacion EcontrarPorId(int Id) 
    {
        return ctx.Habitacions.Find(Id);
    }
    public bool Borrar(int id) 
    {
        try 
        {
            var habitacion = EcontrarPorId(id);
            if(habitacion==null) return false;
            else ctx.Habitacions.Remove(habitacion);
            ctx.SaveChanges();
            return true;
        } 
        catch (Exception ex) { return false; }
    }
}