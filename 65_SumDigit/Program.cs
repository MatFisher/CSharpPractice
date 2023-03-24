// Найти сумму цифр числа

int SumDigits(int num)
{
    if (num == 0) return 0;
    return num % 10 + SumDigits(num / 10);
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр равна {result} ");
Console.ReadKey();