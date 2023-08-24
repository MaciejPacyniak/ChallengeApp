using ChallengeApp;

var employee = new Employee("Maciej", "Pacyniak");
employee.AddGrade(20);
employee.AddGrade(5);
employee.AddGrade(14);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Max: {statistics.Min:N2}");