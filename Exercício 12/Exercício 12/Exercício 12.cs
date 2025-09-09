// See https://aka.ms/new-console-template for more information
Console.Write("Digite o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine());

if (valor1 > valor2)
{
    Console.WriteLine($"O maior valor é: {valor1}");
}
else
{
    Console.WriteLine($"O maior valor é: {valor2}");
}