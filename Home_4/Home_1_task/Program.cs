/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
Console.Clear();
Console.Write("Введите число ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень ");
int B = int.Parse(Console.ReadLine());
int stg = A;
for (int i = 1; i < B; i++)
{
    stg = stg * A;
}
Console.Write($"число {A} в степени {B} = {stg}");
