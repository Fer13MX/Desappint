//Calcula la distancia entre 2 puntos A y B en un plano cartesiano
double ax=0, ay=0, bx=0, by=0, d=0;
Console.Clear();
Console.WriteLine("Hola, este es un programa que calcula la distancia entre 2 puntos A y B en un plano cartesiano");
Console.Write("Por favor ingresa el valor del punto A en su coordenada X: ");
ax=double.Parse(Console.ReadLine());
Console.Write("Por favor ingresa el valor del punto A en su coordenada Y: ");
ay=double.Parse(Console.ReadLine());
Console.Write("Por favor ingresa el valor del punto B en su coordenada X: ");
bx=double.Parse(Console.ReadLine());
Console.Write("Por favor ingresa el valor del punto B en su coordenada Y: ");
by=double.Parse(Console.ReadLine());
d=Calcs.Distancia(ax,ay,bx,by);
Console.WriteLine($"La distancia entre el punto A y B que me has dado es: {d:f2}");
return 0;