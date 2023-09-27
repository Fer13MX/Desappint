// See https://aka.ms/new-console-template for more information
Academia GXacademi = new Academia{Nombre="Academia GX para duelistas", Propietario="Cristian Crawler", Domicilio="Av. Egipto 666"};
//Agregar Categorias a la Academia
GXacademi.categorias.Add(new Categoria{Nombre="Clase A", Rango="88s", Costo= 10000});
GXacademi.categorias.Add(new Categoria{Nombre="Clase B", Rango="90s", Costo= 1000});
GXacademi.categorias.Add(new Categoria{Nombre="Clase C", Rango="92s", Costo= 500});
GXacademi.categorias.Add(new Categoria{Nombre="Clase C", Rango="94s", Costo= 400});
//Agregar Categorías a los Jugadores
GXacademi.categorias[2].AgregarJugador(new Jugador{Nombre="Yaden Yuki",AñoNac=1992,Sexo="Hombre",Becado=true});
GXacademi.categorias[1].AgregarJugador(new Jugador{Nombre="Yugi Muto",AñoNac=1990,Sexo="Hombre",Becado=true});
GXacademi.categorias[0].AgregarJugador(new Jugador{Nombre="Seto Kaiba",AñoNac=1988,Sexo="Hombre",Becado=false});
GXacademi.categorias[1].AgregarJugador(new Jugador{Nombre="Joe Wheeler",AñoNac=1990,Sexo="Hombre",Becado=true});
GXacademi.categorias[3].AgregarJugador(new Jugador{Nombre="Mokuba Kaiba",AñoNac=1994,Sexo="Hombre",Becado=false});
GXacademi.categorias[1].AgregarJugador(new Jugador{Nombre="Tristan Taylor",AñoNac=1990,Sexo="Hombre",Becado=true});
GXacademi.categorias[1].AgregarJugador(new Jugador{Nombre="Tea Grandner",AñoNac=1990,Sexo="Mujer",Becado=true});
GXacademi.categorias[1].AgregarJugador(new Jugador{Nombre="Arianne Leadford",AñoNac=1990,Sexo="Mujer",Becado=false});
GXacademi.categorias[0].AgregarJugador(new Jugador{Nombre="Ana Crawler",AñoNac=1988,Sexo="Mujer",Becado=false});

//Reporte
Console.Clear();
Console.WriteLine("Reporte de Categorias en la Academia\n");
Console.WriteLine(GXacademi.ToString());
Console.WriteLine($"\nTotal de Categorias: {GXacademi.categorias.Count()}");
Console.WriteLine($"\nTotal de Hombres: {GXacademi.TotalHombres()}");
Console.WriteLine($"Total de Mujeres: {GXacademi.TotalMujeres()}");

Console.WriteLine("\n>>Datos generales de las categorias\n");
foreach(Categoria categoria in GXacademi.categorias)
{
    Console.WriteLine(categoria.ToString());
}
Console.WriteLine("\n>>Categorias de los Jugadores");
foreach(Categoria categoria in GXacademi.categorias)
{
    Console.WriteLine($"\n>{categoria.Nombre} - {categoria.Rango} - ({GXacademi.categorias.Count()})\n");
    foreach(Jugador jugador in categoria.jugadores)
    {
        Console.WriteLine(jugador.ToString());
    }
    Console.WriteLine($"\n-Subtotal: {categoria.Subtotal(),36:c2}\n");
}
Console.WriteLine($"\n\n-Total: {GXacademi.Total(),39:c2}\n");