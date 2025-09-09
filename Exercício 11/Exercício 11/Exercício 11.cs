// See https://aka.ms/new-console-template for more information
Console.Write("Digite o ano atual: ");
int anoAtual = int.Parse(Console.ReadLine());

Console.Write("Digite o ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = anoAtual - anoNascimento;

if (idade < 16)
{
    Console.WriteLine("Não vota.");
}
else if ((idade >= 16 && idade < 18) || idade > 70)
{
    Console.WriteLine("Voto facultativo.");
}
else
{
    Console.WriteLine("Voto obrigatório.");
}