int n1, n2;
int soma;
int menos;
int divisão;
int mult;

Console.Write("Informe o primeiro número: ");
n1 = Convert.ToInt16(Console.ReadLine());

Console.Write("Informe o segundo número: ");
n2 = Convert.ToInt16(Console.ReadLine());

soma = n1 + n2;
menos = n1 - n2;
divisão = n1 / n2;
mult = n1 * n2;

Console.WriteLine($"A soma dos valores é {soma}, a subtração dos valores é {menos}, a divisão dos valores é {divisão} e a multiplicação dos valores é {mult}");