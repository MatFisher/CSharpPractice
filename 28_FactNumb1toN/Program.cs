// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("ВВедите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int FactNumbers(int numb)
{
    int sum = 1;
    for (int i = 1; i <= numb; i++)
    {
        checked
        {
            sum = sum * i;
        }
    }
    return sum;
}

int result = FactNumbers(number);
Console.WriteLine(result);
Console.ReadKey();