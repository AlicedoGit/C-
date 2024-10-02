int numero = 7;

do
{
    Console.Write("Digite um número para descobrir o número secreto: ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 7 )
    {
        Console.WriteLine($"Você digitou: {numero}, número incorreto, tente novamente ");
    }
} 
while (numero != 7) ;

Console.WriteLine("Caraca, vc acertou meus parabéns!");
Console.ReadKey();