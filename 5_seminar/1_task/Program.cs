//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

int[] array = RandomARRAY(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int pol = 0;
int otr = 0;

foreach (int stg in array)
{
    pol += stg > 0 ? stg : 0;
    otr += stg < 0 ? stg : 0;
}

Console.WriteLine($"Положительное {pol}, Отрицательное = {otr} ");

int[] RandomARRAY(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }

    return result;
}


