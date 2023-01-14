try
{
    Console.Write("Введите делимое число: ");
    var numberA = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите делитель: ");
    var numberB = int.Parse(Console.ReadLine() ?? "");
    var result = numberA % numberB;
    if (result == 0)
        Console.WriteLine($"Число {numberA} кратно числу {numberB}");
    else 
        Console.WriteLine($"Остаток от деления {numberA} на {numberB} равен: {result}");
}
catch
{
    Console.WriteLine("Необходимо ввести два числа!");
}
