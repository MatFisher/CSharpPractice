// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponent(int numA, int numB)
{
    int numHelp = numA;
    for (int index = 1; index < numB; index++)
    {
        numA = numA * numHelp;
    }
    return numA;
}
int exp = Exponent(numberA, numberB);
Console.WriteLine($"Результат = {exp}");
Console.ReadKey();
