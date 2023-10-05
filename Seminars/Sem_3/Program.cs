/* Задача 1 
Напишите программу, которая принимает на вход число и выдает количество цифр в числе
456 -> 3
78 -> 2
765434 -> 6
*/

Console.WriteLine("Input number please: ");
int x = int.Parse(Console.ReadLine());
int digits = GetDigits2(x);
Console.WriteLine($"The number of digits is {digits}");


int GetDigits(int number) // Method 1
{
    string digitsString = number.ToString();
    int count = digitsString.Length;
    return count;
}

int GetDigits2(int number) // Method 2
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count ++;
    }
    return count;
}