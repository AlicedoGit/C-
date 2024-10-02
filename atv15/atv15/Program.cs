Console.Write("Digite um número positivo:");
int numero = int.Parse(Console.ReadLine());

for  (int i = 0; i <= 10; i++)
{
    Console.WriteLine($" {i} x {numero} = {i*numero}");
}

Console.ReadKey();