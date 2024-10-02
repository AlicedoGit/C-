string nome;
string sobrenome;
string area;

Console.Write("\nQual seu nome?: ");
nome = Console.ReadLine();
Console.Write("\nE seu sobrenome?: ");
sobrenome = Console.ReadLine();
Console.Write("Agora nos informe qual é sua área de programação em que mais se interessa: ");
area = Console.ReadLine();

Console.WriteLine($"Seu nome é {nome} com sobrenome de {sobrenome} e sua área de maior interrese é {area}");

Console.WriteLine("Pressione uma tecla para encerrar");
Console.ReadKey();