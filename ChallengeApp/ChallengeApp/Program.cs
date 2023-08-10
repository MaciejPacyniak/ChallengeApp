using ChallengeApp;

Employee Marie = new Employee();
Employee Nick = new Employee();
Employee John = new Employee();
Marie.Name = "Marie";
Nick.Name = "Nick";
John.Name = "John";

Marie.AddPoint(1);
Marie.AddPoint(2);
Marie.AddPoint(3);
Marie.AddPoint(4);
Marie.AddPoint(5000);

Nick.AddPoint(4);
Nick.AddPoint(5);
Nick.AddPoint(6);
Nick.AddPoint(7);
Nick.AddPoint(8);

John.AddPoint(9);
John.AddPoint(10);
John.AddPoint(11);
John.AddPoint(12);
John.AddPoint(13);

List<Employee> list = new List<Employee>();
list.Add(Marie);
list.Add(Nick);
list.Add(John);
int sum = 0;
Employee BestEmployee = new Employee();
foreach (Employee emp in list)
{
    if (emp.Sum() > sum)
    {
        sum = emp.Sum();
        BestEmployee = emp;
    }
}

Console.WriteLine($"Pracownik z najwyższym wynikiem to {BestEmployee.Name} z wynikiem:{sum} punktów");