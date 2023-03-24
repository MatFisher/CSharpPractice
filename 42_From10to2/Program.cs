// Написать программу преобразования десятичного числа в двоичное

int ConvertToTwo(int number)
{
    int twoNumber = 0;
    for (int i = 0; number != 0; i++)
    {
        twoNumber = twoNumber + (number % 2) * Convert.ToInt32(Math.Pow(10, i));
        number /= 2;
    }
    return twoNumber;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {num} in10 = {ConvertToTwo(num)} in2");
Console.ReadKey();