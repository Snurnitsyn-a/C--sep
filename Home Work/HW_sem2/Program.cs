﻿/* Задача 10: Напишите программу, которая 
принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Input a three digit number: ");
int a = int.Parse(Console.ReadLine());
int result = a/10%10;
Console.Write(result);

