using Microsoft.EntityFrameworkCore;
public class ClienteServicio 
{
    private readonly ContextoDatos ctx;
    public ClienteServicio(ContextoDatos contexto) => ctx = contexto;
    public List<Cliente> ObtenerTodo(string cadenabuscar) 
    {
        var _clientes = ctx.Clientes
        	.Include(r=>r.Reservas)
        		.ThenInclude(h=>h.Habitacion);
        var clientes = from c in _clientes select c;
        if(!string.IsNullOrEmpty(cadenabuscar)) 
        {
            clientes = clientes.Where(c=>c.Apeido.Contains(cadenabuscar) || c.Nombre.Contains(cadenabuscar));
        }
        return clientes.ToList();
    }
    public bool AgregarActualizar(Cliente cliente) 
    {
        try 
        {
            if (cliente.Id == 0) ctx.Clientes.Add(cliente);
            else ctx.Clientes.Update(cliente);
            ctx.SaveChanges();
            return true;
        }
        catch (Exception ex) { return false; }
    }
    public Cliente EcontrarPorId(int Id) 
    {
        return ctx.Clientes.Find(Id);
    }
    public bool Borrar(int id) {
        try 
        {
            var cliente = EcontrarPorId(id);
            if(cliente==null) return false;
            else ctx.Clientes.Remove(eliente);
            ctx.SaveChanges();
            return true;
        } catch (Exception ex) { return false; }
    }
}