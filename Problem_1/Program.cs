﻿//Напишите программу, которая на вход принимает два числа, а на выходе выдает какое число большее, а какое меньшее.
int a = 85;
int b = 6585;
int max = a;
if (a < b)
{
    max = b;
}
Console.Write("max = ");
Console.WriteLine(max);