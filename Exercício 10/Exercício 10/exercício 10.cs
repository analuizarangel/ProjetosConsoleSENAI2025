// See https://aka.ms/new-console-template for more information
Console.Write("Digite a nota da 1ª avaliação\n");
double nota1 = double.Parse(Console.ReadLine());

Console.Write("Digite a nota da 2ª avaliação\n");
double nota2 = double.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

Console.WriteLine($"Média do aluno: {media:F1}");

if (media >= 6)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}