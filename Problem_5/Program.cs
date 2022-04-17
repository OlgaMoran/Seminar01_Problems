//Напишите программу, которая на вход принимает число (N), а на выходе показывает все целые числа в промежутке от -N до N.
int N = 8;
int x = -N;
while (x < N)
{
    Console.WriteLine(x);
    x++;
}
Console.WriteLine(x);