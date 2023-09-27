/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.Write("Input a: ");
int a = int.Parse(Console.ReadLine()); 
Console.Write("Input b: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.Write("max = a");
}
else
{
    Console.Write("max = b");
}


Задача 4: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.Write("Input a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Input c: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
{ 
    Console.Write("a = max");
}
if (b > a && b > c)
{ 
    Console.Write("b = max");
}
if (c > b && c > a)
{ 
    Console.Write("c = max");
}

Задача 6: Напишите программу, которая на вход принимает 
число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет


Console.Write("Input a number: ");
int a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}


Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8


Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());
int x = 2;

while (x <= N)
{
    Console.Write($"{x}, ");
    x += 2;
}
if (x > N)
{
    Console.Write("The number is invalid");
}
*/