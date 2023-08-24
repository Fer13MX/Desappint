// Programa que procesa el pedido de una pizza a elección del usuario

char tam, cub, don;
string[] ings;
string tamaño="", ingredientes="", cubierta, donde;
int cant=0;
float total=0;

static void Menu()
{
    Console.Clear();
    Console.WriteLine("Elije como deseas amar tu pedido de pizza\n");
    Console.WriteLine("Tamaño : [P]equeña-$10 [M]ediana-$20 [G]rande-$30");
    Console.WriteLine("Ingredientes : [E]xtra queso [C]hampiñoness [P]iña , unidos por un + ($5)");
    Console.WriteLine("Cubierta : [D]elgada [G]ruesa");
    Console.WriteLine("Donde la consumes : [A]qui [L]levar");
    Console.WriteLine("Cantidad de pizzas");
}
//Tamaño
tam=char.Parse(args[0].ToUpper());
if(tam=='P')
{
    tamaño="Pequeña";
    total+=10;
}
else if(tam=='M')
{
    tamaño="Mediana";
    total+=10;
}
else if(tam=='G')
{
    tamaño="Grande";
    total+=10;
} 

//Ingredientes
ings= args[1].Split('+');
foreach(string i in ings)
{
    total+=5;
    switch(char.Parse(i.ToUpper()))
    {
        case 'E': ingredientes+="Extraqueso"; break;
        case 'C': ingredientes+="Champiñones"; break;
        case 'P': ingredientes+="Piña"; break; 
    }
}
//Cubierta
cub= char.Parse(args[2].ToUpper());
cubierta= (cub=='D' ? "Delgada": "Gruesa");
//Donde consume
don= char.Parse(args[3].ToUpper());
donde= (don=='A' ? "Aqui" : "Llevar");
//Cantidad
cant=int.Parse(args[4]);
total*=cant;


Console.WriteLine("\nTu pizza queda armada de la siguiente manera: ");
Console.WriteLine($"Tamaño: {tamaño}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Cubierta: {cubierta}");
Console.WriteLine($"Donde: {donde}");
Console.WriteLine($"Cantidad: {cant}");
Console.WriteLine($"Total: {total:n2}");


if(args.Length==0)
{
    Menu();
    return 1;
}
return 0;