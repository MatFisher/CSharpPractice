// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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

int SumEvenNumbers(int[] arr)
{
    int temp = arr.Length;
    int sumEven = 0;
    for (int pos = 0; pos < temp; pos++)
    {
        if (arr[pos] % 2 == 0) sumEven++;
    }
    return sumEven;
}

int SumOddNumbers(int[] arr)
{
    int temp = arr.Length;
    int sumOdd = 0;
    for (int pos = 0; pos < temp; pos++)
    {
        if (arr[pos] % 2 != 0) sumOdd++;
    }
    return sumOdd;
}

int[] array = CreateArrayRndInt(10, 100, 999);
PrintArray(array);
int sum1 = SumEvenNumbers(array);
int sum2 = SumOddNumbers(array);
Console.WriteLine($"Количество четных чисел = {sum1}");
Console.WriteLine($"Количество нечетных чисел = {sum2}");
Console.ReadKey();