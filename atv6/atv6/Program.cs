double salario;
double aumento;
double TotAumento;
double TotFinal;

Console.Write("Insira o seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Insira seu aumento salarial em porcentagem: ");
aumento = Convert.ToDouble(Console.ReadLine());

TotAumento = salario * (aumento / 100);
TotFinal = TotAumento + salario;
Console.WriteLine($"Seu salário atualizado é de {TotFinal}");