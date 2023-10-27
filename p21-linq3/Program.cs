//
List<string> frutas = new() {"pera","melon","sandia","durazno","manzana","platano","kiwi","naranja","jicama","piña","papaya","limas","moras","lichis","guamuchiles","chilitos","pitayas","maracuya","xoconostle"};
Console.Clear();
var mfrutas = (from f in frutas where f.StartsWith('m')select f).ToList();
Console.WriteLine("\nFrutas que inician con la letra m "+mfrutas.Count());
mfrutas.ForEach(f=>Console.Write(f+" "));
var anfrutas = (from f in frutas where f.Contains("an")select f).ToList();
Console.WriteLine("\nFrutas que contienen an "+anfrutas.Count());
anfrutas.ForEach(f=>Console.Write(f+" "));
var frutasa = (from f in frutas where f.EndsWith('a')select f).ToList();
Console.WriteLine("\nFrutas que terminan con a "+frutasa.Count());
frutasa.ForEach(f=>Console.Write(f+" "));
var xy = (from f in frutas where (f.Contains('y')||f.Contains('x')) select f).ToList();
Console.WriteLine("\nFrutas que contienen x o y "+frutasa.Count());
xy.ForEach(f=>Console.Write(f+" "));