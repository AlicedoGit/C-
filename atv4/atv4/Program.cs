const double Pi = 3.14;
double raio;
double result;

Console.Write("Informe o raio do cículo desejado: ");
raio = Convert.ToDouble(Console.ReadLine());
result = Pi * (raio * raio);
Console.WriteLine($"Seu círculo de raio {raio} tem sua área total considerando Pi, {Pi}, de {result}");
