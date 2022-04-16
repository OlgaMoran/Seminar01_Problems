// Напишите программу, которая на вход принимает три числа, а на выходе выдает максимальное из этих чисел.
int a = 55;
int b = 7;
int c = 84562;
int max = a;
if (b > max)
{
    max = b;
}
else
{
    if (c > max)
    {
        max = c;
    }
}
Console.Write("max = ");
Console.WriteLine(max);