Console.Write("Введите число: ");
try
{
    var number = int.Parse(Console.ReadLine() ?? "");
    if (number >= 10 && number <= 99)  
    {
        if (number / 10 > number % 10)
            Console.WriteLine($"Наибольшая цифра числа {number} это: {number / 10}");
        else if (number / 10 < number % 10)
            Console.WriteLine($"Наибольшая цифра числа {number} это: {number % 10}");
        else
            Console.WriteLine($"Обе цифры числа {number} равны: {number % 10}");
    }
    else
        throw new ArgumentException();
}
catch
{
    Console.WriteLine("Необходимо ввести число между 10 и 99");
}
