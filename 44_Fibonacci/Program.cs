// Показать числа Фибоначчи

int[] Fibbonah(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
}

Console.WriteLine("Какое количество чисел показать?");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = Fibbonah(num);
Console.Write($"{num} чисел Фибоначчи -> ");
PrintArray(arr);
Console.ReadKey();