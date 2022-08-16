const double PI = 3.14159;

Console.WriteLine("informe 3 números");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());

double areaTrianguloRetangulo = (a * c) / 2;
double areaCirculo = PI * (c * c);
double areaTrapezio = ((a + b) * c) / 2;
double areaQuadrado = b * b;
double areaRetangulo = a * b;
Console.WriteLine($"\nárea do triângulo retângulo = {areaTrianguloRetangulo}");
Console.WriteLine($"área do círculo = {areaCirculo}");
Console.WriteLine($"área do trapézio = {areaTrapezio}");
Console.WriteLine($"área do quadrado = {areaQuadrado}");
Console.WriteLine($"área do retângulo = {areaRetangulo}");



