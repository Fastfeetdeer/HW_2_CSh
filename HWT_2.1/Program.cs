// ДЗ 2.1 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Ввидите число");
int a = int.Parse(Console.ReadLine());
if (99 < a && a < 1000)
{
    int res = a / 10 % 10;
    Console.WriteLine(res);      
}
 else 
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
