/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();
Console.WriteLine("Введите число: ");
int stg = int.Parse(Console.ReadLine());
int a1 = stg;
if ( stg < -99 || stg > 99 )
{
    for ( int i = 0; a1 => 999 || a1 <= -999; i++ )
    {
        a1 = a1 / 10;
    }
    a1 = a1 % 10;
    Console.WriteLine($"Третья цифра заданного числа {stg} -> {a1}");
}else
{
    Console.WriteLine($"Третья цифра нет{stg}");
}



