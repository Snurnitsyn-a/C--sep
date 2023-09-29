/* Задача 11 
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
using System;
using static System.Console;
int num = new Random().Next(100, 1000);

int result = num / 100 * 10 + num % 10;
Write($"{num} -> {result}");


Задача 12 
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно первому, 
то программа выводит остаток деления.


Console.WriteLine("Input the first number: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Input the second number: ");
double b = double.Parse(Console.ReadLine());

if (a%b == 0)
{
    Console.WriteLine("The second number is the multiple of the first one");
}
else
{
    Console.WriteLine("Nope, try again");
}

Задача 14 
Напишите программу, которая принимает на вход 
число и проверяет кратно ли оно одновременно 7 и 23.
*/

Console.Write("Input number: ");
int a = int.Parse(Console.ReadLine());

if (a%7==0 && a%23==0)
{
    Console.Write("This nummber multiple of both 7 and 23");
}
else
{
    Console.Write("Nope, try again");
}