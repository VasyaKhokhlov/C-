/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
Console.Clear();
Console.Write("Введите число ");
int stg = int.Parse(Console.ReadLine());
int sum = 0;
while (stg > 0)
{
int num = stg % 10;
stg = stg / 10;
sum = sum + num;
}
Console.WriteLine($"сумма всех цифр в числе равна {sum}");
