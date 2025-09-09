// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Digite o número de maçãs compradas.");
int quantidade = int.Parse(Console.ReadLine());
double preco;
if (quantidade < 12) 
{
    preco = 1.30;
}
 else
{
    preco = 1.00;
}
double total = quantidade * preco;
Console.WriteLine($"O valor total da compra é: R$ {total}");