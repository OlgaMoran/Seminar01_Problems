// Напишите программу, которая на вход принимает число и выдает является ли число четным (делится ли оно на два без остатка).
int a = 88552;
int remainder = a % 2;
if(remainder == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}