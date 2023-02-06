//ДЗ 2.3 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
string[] days = new String[]{"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.Write("Ведите день недели: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7) Console.WriteLine(days[day-1] + " - выходной");
else if (day < 6 && day > 0) Console.WriteLine(days[day-1] + " - не выходной");
else 
{
    System.Console.WriteLine("Не является днем недели");
}
