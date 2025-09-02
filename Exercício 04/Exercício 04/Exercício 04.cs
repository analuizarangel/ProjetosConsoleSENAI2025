// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite sua idade em anos.");
int anos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite sua idade em meses.");
int meses = int.Parse(Console.ReadLine());
Console.WriteLine("Digite sua idade em dias.");
int dias = int.Parse(Console.ReadLine());
int IdadeEmDias = (anos * 365) + (meses * 30) + dias;
Console.WriteLine($"A sua idade em dias é {IdadeEmDias}");
