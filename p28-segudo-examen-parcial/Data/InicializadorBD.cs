public class InicializadorBD 
{
    public static void Inicializar(ContextoDatos contexto) 
    {
        if(contexto.Articulos.Any()) 
        {
            return;
        }
        var articulos = new Articulo[] 
        {
            new Articulo {Descripcion="Pala cuadrada",FechaAlta=DateTime.Parse("1/1/2023"),Cantidad=11,Precio=300.45,UdeMedida="Pieza"},
            new Articulo {Descripcion="Pinzas de chofer",FechaAlta=DateTime.Parse("10/2/2024"),Cantidad=12,Precio=299.0,UdeMedida="Pieza"},
            new Articulo {Descripcion="Tiner",FechaAlta=DateTime.Parse("10/2/2024"),Cantidad=11,Precio=50.0,UdeMedida="Litro"},
            new Articulo {Descripcion="Varilla",FechaAlta=DateTime.Parse("13/5/2023"),Cantidad=20,Precio=500.0,UdeMedida="Kilo"}
        };
            contexto.Articulos.AddRange(articulos);
            contexto.SaveChanges();
    }
}