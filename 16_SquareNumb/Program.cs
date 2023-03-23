// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SquareNumbers(numberA, numberB) ? "является" : "не является");


bool SquareNumbers(int numA, int numB)
{
    return numA * numA == numB || numB * numB == numA;
}

Console.ReadKey();