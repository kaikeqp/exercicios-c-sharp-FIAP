Console.WriteLine("digite um numero inteiro de 1 a 3");
int numero = int.Parse(Console.ReadLine());

switch (numero)
{
    case 1: Console.WriteLine("Bom dia");
        break;
    case 2: Console.WriteLine("Boa tarde");
        break;
    case 3: Console.WriteLine("Boa noite");
        break;
}
