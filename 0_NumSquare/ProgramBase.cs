internal class ProgramBase
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Квадрат числа = {number *= number}");
    }
}