public class Academia 
{ 
    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}
    public List<Categoria> categorias {get; set;}
    public Academia() => categorias= new List<Categoria>();
    public Academia(string nombre,string propietario,string domicilio) : this() =>
        (Nombre,Propietario,Domicilio) = (nombre,propietario,domicilio);
    public void AgregarCategoria(Categoria categoria) => categorias.Add(categoria);
    public int Total()
    {
        int total=0;
        foreach(Categoria categoria in categorias)
            total = total + categoria.Subtotal();
        return total;
    }
    public int TotalCategorias()
    {
        int total=0;
        foreach(Categoria categoria in categorias)
        {
            total = total + categorias.Count();
        }
        return total;
    }
    public int TotalHombres()
    {
        int n=0;
        foreach(Categoria categoria in categorias)
        {
            foreach(Jugador jugador in categoria.jugadores)
            {
                if(jugador.Sexo=="Hombre")
                {
                    n++;    
                }
            }
        }
        return n; 
    }
    public int TotalMujeres()
    {
        int n=0;
        foreach(Categoria categoria in categorias)
        {
            foreach(Jugador jugador in categoria.jugadores)
            {
                if(jugador.Sexo=="Mujer")
                {
                    n++;    
                }
            }
        }
        return n; 
    }
    public override string ToString() => $"Nombre: {Nombre}\nPropietario: {Propietario}\nDomicilio: {Domicilio}";
        

}