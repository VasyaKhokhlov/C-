/*7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.Clear();
Console.WriteLine("Введите число: ");
int stg = int.Parse(Console.ReadLine());
int a1 = stg % 10;
Console.WriteLine(a1);





