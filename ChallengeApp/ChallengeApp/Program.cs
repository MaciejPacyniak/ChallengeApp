

Console.WriteLine("Podaj imię:");
string imie=Console.ReadLine();
Console.WriteLine("Podaj płeć M lub K:");
char plec = char.Parse(Console.ReadLine());
Console.WriteLine("Podaj wiek:");
int wiek =int.Parse(Console.ReadLine());
if (wiek == 33 && imie == "Ewa")
{
    Console.WriteLine("Masz na imię"+ imie +" i masz "+ wiek + " lat.");
}
else if (wiek < 18 && plec == 'M')
{
    Console.WriteLine("Jestes niepełnoletnim mężczyzną");
}
else if (wiek >= 18 && plec == 'M')
{
    Console.WriteLine("Jestes pełnoletnim mężczyzną");
}
else if (plec == 'K')
{
    Console.WriteLine("Jestes kobieta");
}