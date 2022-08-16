Console.WriteLine("digite um valor");
double n = double.Parse(Console.ReadLine());
Console.Write($"fatorial de {n}: ");
var fatorial = 1;
if(n == 0)
{
    Console.WriteLine(fatorial);
}else

for (int i = 1; i <= n; i++)
{
    fatorial = fatorial * i;
}
Console.WriteLine(fatorial);
