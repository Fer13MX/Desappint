// Programa que calcula el volumen de una esfera a partir del radio
double r=0, e=0;
Console.Clear();
Console.WriteLine("Hola, este es un programa que imprime el volumen de una esfera según el valor del radio");
Console.Write("Por favor ingresa el valor del radio: ");
r=double.Parse(Console.ReadLine());
e=Vol.Esf(r);
Console.WriteLine($"El volumen de la esfera es: {e:f2}");
return 0;