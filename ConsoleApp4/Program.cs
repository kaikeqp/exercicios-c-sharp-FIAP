Console.WriteLine("digite a nota");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
    return;
}if (nota < 7 && nota >= 4)
{
    Console.WriteLine("Em recuperação");
    return;
}
if (nota < 4)
{
    Console.WriteLine("Reprovado");
}