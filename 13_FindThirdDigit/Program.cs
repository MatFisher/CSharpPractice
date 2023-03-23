// Найти третью цифру числа или сообщить, что её нет

using System;
using System.Globalization;
using System.Reflection;

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int FindThirdDigit(int num)
{
    int size = 0;
    int index = 0;
    int a = num;
    while (a % 10 > 0)
    {
        index = index + 1;
        a = a / 10;
    }
    size = index - 3;
    index = 0;
    while (index < size)
    {
        num = num / 10;
        index++;
    }
    num = num % 10;
    return num;
}

if (number > 100)
{
    int thirdDigit = FindThirdDigit(number);
    Console.WriteLine($"Третья цифра = {thirdDigit}");
}
else Console.WriteLine("Третья цифра отсутствует");
Console.ReadKey();