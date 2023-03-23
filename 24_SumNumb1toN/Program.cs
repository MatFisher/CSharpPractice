// Найти сумму чисел от 1 до А

Console.WriteLine("ВВедите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int numb)
{
    int sum = 0;
    for (int i = 1; i <= numb; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");
Console.ReadKey();