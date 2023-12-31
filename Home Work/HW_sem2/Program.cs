﻿/* Задача 10: Напишите программу, которая 
принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Input a three digit number: ");
int a = int.Parse(Console.ReadLine());
int result = a/10%10;
Console.Write(result);

Задача 13: Напишите программу, которая выводит третью 
цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6


using System.Threading.Tasks.Dataflow;

Console.Write("Input a number: ");
int a = int.Parse(Console.ReadLine());

if (a<100)
{
    Console.Write("There is less than 3 digits in this number");
}
else
{
    while (a > 999)
    {
        a /= 10;
    }
    Console.Write(a%10);
}

Задача 15: Напишите программу, которая принимает 
на вход цифру, обозначающую день недели, и проверяет,
 является ли этот день выходным.
6 -> да
7 -> да
1 -> нет


Console.Write("Input a number: ");
int a = int.Parse(Console.ReadLine());

if ((a == 6) || (a == 7))
{
    Console.Write("Yes");
}
else if ((a >= 1) && (a <= 5))
{
    Console.Write("No");
}
else
{
    Console.Write("This is not a day of the week");
}
*/