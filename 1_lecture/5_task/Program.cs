int a = 1;
int b = 5;
int c = 4;
int d = 10;

int min = a;

if (a<min) min = a;
if (b<min) min = b;
if (c<min) min = c;
if (d<min) min = d;

Console.Write("min =");
Console.WriteLine(min);