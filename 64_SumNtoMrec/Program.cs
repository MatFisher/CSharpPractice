// Найти сумму элементов от M до N, N и M заданы

int GetSumNumbers(int num1, int num2, int sum = 0)
{
    if (num1 == num2) return sum += num1;
    else
    {
        sum += num1;
        return GetSumNumbers(++num1, num2, sum);
    }
}

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int sum = GetSumNumbers(numberA, numberB);
Console.WriteLine($"Сумма числе между {numberA} и {numberB} = {sum}");
Console.ReadKey();
