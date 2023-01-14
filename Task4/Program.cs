Console.Write("Введите проверяемое число: ");
try
{
    var n = int.Parse(Console.ReadLine() ?? "");
    for (int i = 1; i <= n; i++)
    if (i%2 == 0)
        Console.Write(i + " ");
}
catch
{
    Console.WriteLine("Введено не число!");
}
