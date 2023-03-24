// Показать натуральные числа от M до N, N и M заданы

void ShowNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        if (secondNum == firstNum - 1) return;
        ShowNumbers(firstNum, secondNum - 1);
        Console.Write($"{secondNum} ");
    }
    else if (firstNum > secondNum)
    {
        if (secondNum - 1 == firstNum) return;
        Console.Write($"{firstNum} ");
        ShowNumbers(firstNum - 1, secondNum);
    }
    else if (firstNum == secondNum)
    {
        Console.Write($"{firstNum} ");
        return;
    }
}

Console.Write("Введите первое натуральное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа от {numberM} до {numberN}: ");
ShowNumbers(numberM, numberN);
Console.ReadKey();
