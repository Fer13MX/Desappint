// Tabla de conversion de peso a otras monedas
int ini=0, fin=0, c=0;
float tcd=16.81f, tcl=21.21f, tce=18.19f, tca=0.048f;
Console.Clear();
Console.WriteLine("Imprime tabla de conversione de monedas\n");
do{
    Console.Write("Inicio: "); ini = int.Parse(Console.ReadLine());
    Console.Write("Fin : "); fin = int.Parse(Console.ReadLine());
}while(fin<ini);
c=ini;
Console.WriteLine("Peso\tDolar\tLibra\tEuro\tPeso A");
Console.WriteLine(new string('-',35));
while(c<=fin)
{
    Console.WriteLine($"{c:f2}\t{c/tcd:f2}\t{c/tcl:f2}\t{c/tce:f2}\t{c/tca:f2}\t");
    c++;
}
Console.WriteLine(new string('-',45));