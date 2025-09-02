// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o número total de eleitores.");
int TotalDeEleitores = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de votos brancos.");
int votosBrancos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de votos nulos");
int votosNulos = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o número de votos válidos.");
int votosValidos = int.Parse(Console.ReadLine());
double percBrancos =(votosBrancos * 100) / TotalDeEleitores;
double percNulos = (votosNulos * 100) / TotalDeEleitores;
double percValidos = (votosValidos * 100) / TotalDeEleitores;
Console.WriteLine("Resultados");
Console.WriteLine($"Percentual de votos brancos é {percBrancos}");
Console.WriteLine($"Percentual de votos nulos é {percNulos}");
Console.WriteLine($"Percentual de votos válidos é {percValidos}");

