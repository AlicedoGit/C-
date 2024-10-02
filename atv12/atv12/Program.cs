double nota;
Console.Write("Informe a sua nota: ");
nota = Convert.ToDouble(Console.ReadLine());

if (nota >= 90 && nota <= 100) 
{
    Console.WriteLine($"Parabéns, com esse nota {nota} você ganhou nota A");
}

else if (nota >= 80 && nota <= 89)
{
    Console.WriteLine($"Parabéns, com essa nota {nota} você ganhou nota B");
}

else if (nota >= 70 && nota >=79)
{
    Console.WriteLine($"Parabéns, com essa nota {nota} você ganhou nota C");
}

else if (nota >= 60 && nota >= 69)
{
    Console.WriteLine($"Poxa, com essa nota {nota} você ganhou nota D, espero que vá melhor na próxima :)");
}

else
{
    Console.WriteLine($"Poxa, com essa nota {nota} você ganhou nota F, espero que vá melhor na próxima :)");
}