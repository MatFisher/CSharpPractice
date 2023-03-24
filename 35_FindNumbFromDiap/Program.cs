// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 130);
    }
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

int NumbOfCut(int[] arr)
{
    int size = arr.Length;
    int numb = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i] < 100 && arr[i] > 9) numb += 1;
    }
    return numb;
}


int[] array = new int[123];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int result = NumbOfCut(array);
Console.WriteLine($"Количество чисел из отрезка = {result}");
Console.ReadKey();
