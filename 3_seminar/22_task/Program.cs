// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());
// int[] result = new int[N];
// for (int i = 1; i <= N; i++)
//     result[i - 1] = i * i;
// for (int i = 0; i < N; i++)
//     Console.Write($"{result[i]} ");






Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; // m = -10  N = -1
// int count = 1;
// string s = (count * count).ToString() + (count != N ? ", " : "");
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = -1
}
int[] result = new int[m];
int j = 0;
for (; i <= N; i++)// 1 <= 0
{
    result[j] = i * i;
    j++;
}
for (j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}






