// Написать программу возведения числа А в целую степень B

int PowNumber(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * PowNumber(numA, numB - 1);
}

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = PowNumber(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");
Console.ReadKey();
