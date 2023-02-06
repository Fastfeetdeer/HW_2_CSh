//ДЗ 2.2 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
string n = a.ToString();
int len = n.Length;
if (len > 2)
{
    Console.WriteLine(n[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}