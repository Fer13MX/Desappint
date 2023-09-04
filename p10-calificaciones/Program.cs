// Programa para decir que tan bien va un alumno
using System.Runtime.CompilerServices;

double promsem=0;
string nom="";
Console.Clear();
Console.WriteLine("Hola, este programa te orienta para ver que tal te fue en el semestre");
Console.Write("Dame tu nombre: ");
nom=Console.ReadLine();
promsem=Cal.Prom();
Cal.Men(promsem,nom);