using System.Globalization;

try
{
    Console.Write("Digite o primeiro número: ");
    double n1;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n1))
    {
        Console.WriteLine("Erro: Digite umnúmero válido");
        Console.WriteLine("Digite o primeiro número: ");
    }

    Console.Write("Digite o segundo número para soma-lo: ");
    double n2;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out n2))
    {
        Console.WriteLine("Erro: Digite um número válido");
        Console.WriteLine("Digite o númerador: ");
    }

    double resultado = n1 + n2;
    Console.WriteLine($"O resultado da soma é: {resultado}");
}

catch (FormatException)
{
    Console.WriteLine("Erro: Por favor digite números válidos");
}

Console.ReadKey();
