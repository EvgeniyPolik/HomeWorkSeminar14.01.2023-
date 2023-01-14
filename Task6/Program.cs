Console.Write("Введите число: ");
try
{
    var str = (Console.ReadLine() ?? "");
    int result;
    if (str.Length == 3)  // Убедимся что введено имено трехзначное число
    {
        int number = int.Parse(str);
        result = number / 10;
        result %= 10;
    }
    else
        throw new ArgumentException();
    Console.WriteLine($"Вторая цифра числа {str} это: {result}");
}
catch
{
    Console.WriteLine("Необходимо ввести трехзначное число!");
}