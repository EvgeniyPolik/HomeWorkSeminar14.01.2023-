Console.Write("Введите число: ");
try
{
    var str = (Console.ReadLine() ?? "");
    string result;
    if (str.Length == 3)  // Убедимся что введено имено трехзначное число
    {
        int number = int.Parse(str);
        result = str.Remove(1,1);
    }
    else
        throw new ArgumentException();
    Console.WriteLine($"Результат удаления второй цифры из {str} это: {result}");
}
catch
{
    Console.WriteLine("Необходимо ввести трехзначное число!");
}
