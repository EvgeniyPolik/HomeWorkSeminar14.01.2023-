Dictionary<bool, string> variants = new  Dictionary<bool, string>
{
    {false, " не "},
    {true, " "}
};
try
{
    Console.Write("Введите первое число: ");
    var a = int.Parse(Console.ReadLine() ?? "0");
    Console.Write("Введите второе число: ");
    var b = int.Parse(Console.ReadLine() ?? "0");
    Console.WriteLine($"Число {a}{variants[a == b*b]}является квадратом числа {b}");
}
catch 
{
    Console.WriteLine("Введеные значения должны быть числами!");
}
