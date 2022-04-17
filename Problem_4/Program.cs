//Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// for (int x = 2; x <= 8; x += 2)
//{
//    Console.WriteLine(i);
//}
int N = 20;
int x = 2;
while(x < N - 1)
{
    Console.WriteLine(x);
    x = x + 2;
}
Console.WriteLine(x);