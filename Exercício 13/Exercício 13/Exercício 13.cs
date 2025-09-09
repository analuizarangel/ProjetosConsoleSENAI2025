// See https://aka.ms/new-console-template for more information

Console.Write("Digite o primeiro valor: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Digite o terceiro valor: ");
int c = int.Parse(Console.ReadLine());

if (a < b && a < c)
{
    if (b < c)
        Console.WriteLine($"{a}, {b}, {c}");
    else
        Console.WriteLine($"{a}, {c}, {b}");
}
else if (b < a && b < c)
{
    if (a < c)
        Console.WriteLine($"{b}, {a}, {c}");
    else
        Console.WriteLine($"{b}, {c}, {a}");
}
else
{
    if (a < b)
        Console.WriteLine($"{c}, {a}, {b}");
    else
        Console.WriteLine($"{c}, {b}, {a}");
}