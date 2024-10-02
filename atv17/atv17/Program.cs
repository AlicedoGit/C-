double number;

Console.Write("Digite um numero inteiro positivo: ");

while (!double.TryParse(Console.ReadLine(), out number) || number <= 0)
{
    Console.WriteLine("Por favor, insira um numero inteiro positivo: ");
    Console.Write("Digite um numero inteiro positivo");
}

Console.WriteLine($"Numeros impares ate {number} são: ");
for (double i = 1; i <= number; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("Pressione uma tecla para encerrar o programa");
Console.ReadKey();