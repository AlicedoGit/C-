Console.WriteLine("Informe um mês para descobrir sua estação: ");
string mes = Console.ReadLine();

switch (mes)
{
    case "dezembro":
    case "janeiro":
    case "fevereiro":
        Console.WriteLine($"O mês selecionado {mes} é da estação Verão");
        break;

    case "março":
    case "abril":
    case "maio":
        Console.WriteLine($"O mês selecionado {mes} é da estação Outono");
        break;

    case "junho":
    case "julho":
    case "agosto":
        Console.WriteLine($"O mês selecionado {mes} é da estação Inverno");
        break;

    case "setembro":
    case "outubro":
    case "novembro":
        Console.WriteLine($"O mês selecionado {mes} é da estação Primavera");
        break;


    default:
        Console.WriteLine("");
        break;
}

Console.WriteLine("Digite uma tecla para encerrar o programa!");
Console.ReadKey();