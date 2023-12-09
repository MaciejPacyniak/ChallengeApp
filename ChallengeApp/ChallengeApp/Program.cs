using ChallengeApp;

Console.WriteLine("Witam w programie XYZ do oceny pracowników");
Console.WriteLine("==========================================");
Console.WriteLine("Wpisz ocene liczbowo lub literę: A, B, C, D, E. ");
Console.WriteLine("By zakończyc dodawanie kliknij: q");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejna ocene pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if (input == "A" || input == "B" || input == "C" || input == "D" || input == "E")
    {
        try
        {
            employee.AddGrade(input);
        }
        catch (Exception)
        {
            Console.WriteLine("Exception catched");
        }
    }
    else
    {
        employee.AddGrade(input);
    }
}

try
{
}
catch
{
}
var statistics = employee.GetStatistics();
Console.WriteLine("=====================");
Console.WriteLine("Podsumowanie wyników:");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Min:N2}");