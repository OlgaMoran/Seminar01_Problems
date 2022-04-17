// Напишите программу, которая на вход принимает три числа, а на выходе выдает максимальное из этих чисел.
int a = 555;
int b = 71;
int c = 84;
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