double decime;

Console.Write("Insira um valor em decimal: ");

decime = Convert.ToDouble(Console.ReadLine());

int resultado = (int)decime;

Console.WriteLine($"O número inserido num valor inteiro fica: {resultado}");