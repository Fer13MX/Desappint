// Programa para la venta de articulos con o sin IVA
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

int n=1;
double pretot=0,preIVA=0,IVA=0;
Boolean cont=false;
string S_N;
do
{
    Console.Clear();
    n=Va.Cant();
    pretot=Va.Cal(n);
    Console.Write($"El total de venta es: {pretot}\n");
    preIVA=Va.Iva(pretot);
    Console.Write($"El total de venta con IVA es: {preIVA}\n");
    IVA=preIVA-pretot;
    Console.Write($"El IVA fue de: {IVA}\n");
    Console.Write("Quieres seguir vendiendo(S/N)? ");
    S_N=Console.ReadLine();
    if(S_N=="S") cont=true;
    else cont=false;
}while(cont==true);