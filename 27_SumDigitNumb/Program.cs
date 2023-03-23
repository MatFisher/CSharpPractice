// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigitNumb(int num)
{
    int sum = 0;
    while (num % 10 > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

int summ = SumDigitNumb(number);
Console.WriteLine($"Сумма цифр в числе = {summ}");

Console.ReadKey();