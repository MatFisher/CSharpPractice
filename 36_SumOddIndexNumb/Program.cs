// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SumOddNumbers(int[] arr)
{
    int size = arr.Length;
    int sum = 0;
    for (int i = 0; i < size; i++)
        if (i % 2 == 0) sum += arr[i]; //Нечетные позиции по индексу означают четные для пользователя
    return sum;
}

int[] array = CreateArrayRndInt(4, 1, 15);
PrintArray(array);
int result = SumOddNumbers(array);
Console.WriteLine($"Сумма всех элементов на нечетной позиции = {result}");
Console.ReadKey();