// По двум заданным числам проверять является ли первое квадратом второго

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число");
        int numA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int numB = Convert.ToInt32(Console.ReadLine());

        if (numA > numB && 1 == numA / (numB * numB)) Console.WriteLine("Квадратом является");
        else if (numB > numA && 1 == numB / (numA * numA)) Console.WriteLine("Квадратом является");
        else
        {
            Console.WriteLine("Квадратом не является");
        }
        Console.ReadKey();
    }
}