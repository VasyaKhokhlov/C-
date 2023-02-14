/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Clear();
Console.WriteLine("Введите число: ");
int stg = int.Parse(Console.ReadLine());
int a1 = stg;
if (stg<=999 && stg>99)
{
    a1 = (stg / 10) %10;
    Console.WriteLine(a1);
} else
{
    if (stg>999 || stg<99)
    {
        Console.WriteLine("Введите трехзначное число");
    }
}


