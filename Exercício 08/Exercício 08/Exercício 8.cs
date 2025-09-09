// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um valor.");
int valor = int.Parse(Console.ReadLine());
if (valor > 0)
{
    Console.WriteLine("é um valor positivo.");
}
else if (valor < 0)
{
    Console.WriteLine("é um valor negativo.");
}
else
{
    Console.WriteLine("Valores iguais a 0 não são permitidos.");
}