/* Задача 1

Console.Write("Input a number please: ");
int number = int.Parse(Console.ReadLine());
int sqr = number*number;
Console.WriteLine($"The square of the number is {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number,4));
Console.WriteLine($"The square of the number is {sqr1}");

Задача 2 
Console.Write("Input a, please ");
int a = int.Parse(Console.ReadLine());
Console.Write("Input b, please ");
int b = int.Parse(Console.ReadLine());
string result;

if (a == b * b) {
    result = "Yes";
} else {
    result = "No";
}
Console.WriteLine($"The result is {result}");


//Задача 3 

Console.Write("Input the day of the week: ");
int number = int.Parse(Console.ReadLine());
string result = "";
switch (number)
{
    case 1:
        result = "Monday";
        break;
    case 2:
        result = "Tuesday";
        break;
    case 3:
        result = "Wednesday";
        break;
    case 4:
        result = "Thursday";
        break;
    case 5:
        result = "Friday";
        break;
    case 6:
        result = "Saturday";
        break;
    case 7:
        result = "Sunday";
        break;
    default:
        result = "This is not a week day";
        break;
}
Console.WriteLine(result);


//Задача 4 

Console.Write("Input N: ");
int N = int.Parse(Console.ReadLine());

int x = -N;

while (x <= N) 
{
    Console.Write($"{x}, ");
    x++;
}


//Задача 5

Console.Write("Input a three digit number: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(n % 10);
*/