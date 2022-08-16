Console.WriteLine("digite um valor para: otimista, pessimista e mais provavel");

double otimista = double.Parse(Console.ReadLine());
double pessimista = double.Parse(Console.ReadLine());
double maisProvavel = double.Parse(Console.ReadLine());

double pert = (otimista + pessimista + (4 * maisProvavel)) / 6;
Console.WriteLine($"PERT: {pert:F2}");
