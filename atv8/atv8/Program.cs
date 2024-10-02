double GrausC;
double GrausF;

Console.Write("Insira a temperatura em Graus Celsius e converta para fahrenheits: ");
GrausC = Convert.ToDouble(Console.ReadLine());
GrausF = (GrausC * 9 / 5) + 32;

Console.WriteLine($"Convertida a temperatura fica de {GrausF}");
