// See https://aka.ms/new-console-template for more information
Tienda mitienda = new Tienda{Nombre="Ferreteria las Lomas", Domicilio="Av. luis Moya 345", Propietario="Carlos Castaneda"};
//Agregar CLientes a la Tienda
mitienda.Clientes.Add(new Cliente {Nombre="Felipe Calderon", RFC="JELI120240", Domicilio="Las Lomas 123", Correo="calde@msn.com"});
mitienda.Clientes.Add(new Cliente {Nombre="Enrique Peña", RFC="PEÑA121250", Domicilio="5 de Mayo 321", Correo="quique@msn.com"});
mitienda.Clientes.Add(new Cliente {Nombre="Andres Lopez", RFC="AMLO101145", Domicilio="Palacio Naxional 321", Correo="peje@yahoo.com"});
mitienda.Clientes.Add(new Cliente {Nombre="Xochitl Gelatinas", RFC="GELA666666", Domicilio="Danone 123", Correo="xochitl@recidencia.gob.mx"});
//Agregar ventas a los clientes
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="Martillo", Cantidad=10, Precio= 60.5});
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="Pala", Cantidad=2, Precio= 1170.55});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="Clavo", Cantidad=2.5, Precio= 160.34});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="Cinta de Aislar", Cantidad=5, Precio= 71.34});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="Pinzas", Cantidad=1, Precio= 650.33});
mitienda.Clientes[2].AgregarVenta(new Venta {Articulo="Thiner", Cantidad=5, Precio= 65.00});
//Reporte
Console.Clear();
Console.WriteLine("Reporte de Ventas en Tienda\n");
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"\nTotal de Clientes: {mitienda.Clientes.Count()}");
Console.WriteLine($"\nTotal de Ventas: {mitienda.TotalVentas()}");

Console.WriteLine(">>Datos generales de los clientes");
foreach(Cliente cliente in mitienda.Clientes)
{
    Console.WriteLine(cliente.ToString());
}
Console.WriteLine("\n>>Ventas de los clientes");
foreach(Cliente cliente in mitienda.Clientes)
{
    Console.WriteLine($"\n>{cliente.Nombre} - {cliente.RFC} - ({cliente.Ventas.Count()})\n");
    foreach(Venta venta in cliente.Ventas)
    {
        Console.WriteLine(venta.ToString());
    }
    Console.WriteLine($"\n-Subtotal: {cliente.Subtotal(),36:c2}\n");
}
Console.WriteLine($"\n\n-Total: {mitienda.Total(),40:c2}\n");