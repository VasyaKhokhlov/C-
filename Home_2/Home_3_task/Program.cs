/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.Clear();
Console.WriteLine("Введите число: ");
int stg = int.Parse(Console.ReadLine());
int a1 = stg;
if (a1 > 0 && a1 < 6){
    Console.WriteLine("НЕТ");
}else
{
    if (a1>5 && a1<8)
    {
        Console.WriteLine("ДА");
 
    }else
    {
        Console.WriteLine("Ввели не день недели");
    }
}

 

