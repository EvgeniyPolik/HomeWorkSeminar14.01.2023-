Console.Write("Введите число: ");
try
{
    var number = int.Parse(Console.ReadLine().Substring(2) ?? "");
    Console.WriteLine(number);
}
catch
{
    Console.WriteLine("Необходимо ввести трехзначное число!");
}