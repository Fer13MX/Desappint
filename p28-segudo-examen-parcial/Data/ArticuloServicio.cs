public class ArticuloServicio 
{
    private readonly ContextoDatos ctx;
    public ArticuloServicio(ContextoDatos contexto) => ctx = contexto;
    public List<Articulo> ObtenerTodo() 
    {
        return ctx.Articulos.ToList();
    }
    public bool AgregarActualizar(Articulo articulo) 
    {
        try 
        {
            if (articulo.Id == 0) 
            	ctx.Articulos.Add(articulo);
            else ctx.Articulos.Update(articulo);
            	ctx.SaveChanges();
            return true;
        }
        catch (Exception ex) { return false; }
    }
    public Articulo EcontrarPorId(int Id) 
    {
        return ctx.Articulos.Find(Id);
    }
    public bool Borrar(int id) 
    {
        try
        {
            var Articulo = EcontrarPorId(id);
            if(Articulo==null) 
            	return false;
            else 
            	ctx.Articulos.Remove(Articulo);
            ctx.SaveChanges();
            return true;
        } catch (Exception ex) { return false; }
    }
}