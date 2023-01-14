Console.Write("Введите проверяемое число: ");
try
{
    var n = int.Parse(Console.ReadLine() ?? "");
    if (n%2 == 0)
        Console.WriteLine($"Число {n} - четное");
    else 
        Console.WriteLine($"Число {n} - нечетное");
}
catch
{
    Console.WriteLine("Введено не число!");
}