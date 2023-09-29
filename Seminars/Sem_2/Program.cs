/* Задача 11 
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа*/
using System;
using static System.Console;
int num = new Random().Next(100, 1000);

int result = num / 100 * 10 + num % 10;
Write($"{num} -> {result}");

