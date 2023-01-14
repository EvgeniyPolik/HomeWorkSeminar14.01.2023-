Console.Write("Введите число: ");
try
{
    var str = (Console.ReadLine() ?? "");
    string result;
    if (str.Length == 3)  // Убедимся что введено имено трехзначное число
    {
        int number = int.Parse(str);
        result = str.Substring(2, 1);
    }
    else
        throw new ArgumentException();
    Console.WriteLine($"Третья цифра числа {str} это: {result}");
}
catch
{
    Console.WriteLine("Введено не трехзначное число!");
}
