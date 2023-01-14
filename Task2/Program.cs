Dictionary<int, string> dayOfWeek = new Dictionary<int, string>{
    {1, "Понедельник"},
    {2, "Вторник"},
    {3, "Среда"},
    {4, "Четверг"},
    {5, "Пятница"},
    {6, "Суббота"},
    {7, "Воскресение"},
};
Console.Write("Введите номер дня: ");
try
{
    var numberDay = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Выбранный день недели: {dayOfWeek[numberDay]}");
}
catch
{
    Console.WriteLine("Необходимо ввести число от 1 до 7 включительно");
}
