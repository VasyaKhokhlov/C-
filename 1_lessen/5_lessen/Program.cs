int a = 4;
int b = 5;
int c = 2;
int d = 7;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;

Console.Write("max =");
Console.WriteLine(max);