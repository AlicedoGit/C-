double nota1;
double nota2;
double nota3;
double media;

Console.Write("Informe sua primeira nota: ");
nota1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe sua segunda nota: ");
nota2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Informe sua terceira nota: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) /3;
Console.WriteLine($"A média de suas notas foi de {media}");