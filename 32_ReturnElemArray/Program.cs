// Написать программу замену элементов массива на противоположные

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

int[] ReplaceOppositeArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        ar[i] = -ar[i];
    }
    return ar;
}

int[] array = CreateArrayRndInt(10, -15, 15);
PrintArray(array);
array = ReplaceOppositeArray(array);
Console.WriteLine("Измененный массив");
PrintArray(array);
Console.ReadKey();