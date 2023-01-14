Console.Write("Введите число: ");
var str = Console.ReadLine() ?? "";
try
{
    var number = int.Parse(str.Substring(2));
    Console.WriteLine($"Третья цифра числа {str} это {number}");
}
catch
{
    Console.WriteLine("Необходимо ввести трехзначное число!");
}