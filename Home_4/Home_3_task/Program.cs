/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.Write("Будет создан массив длиной A в диапвзоне 0-A");
Console.Write("Введите любое число (A): ");
int num = Convert.ToInt32(Console.ReadLine());

int[] stg = new int[num];
for (int i = 0; i < num; i++)
{
    stg[i] = new Random().Next(num+1);
    Console.Write(stg[i] + ",");
}
Console.WriteLine($"[{String.Join(",", stg)}]");