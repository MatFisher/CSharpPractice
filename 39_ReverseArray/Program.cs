// Написать программу по развороту массива

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

void ReverseArray(int[] arr)
{
    int size = arr.Length;
    int temp = 0;
    for (int ind = 0; ind < arr.Length / 2; ind++)
    {
        temp = arr[ind];
        arr[ind] = arr[arr.Length - 1 - ind];
        arr[arr.Length - 1 - ind] = temp;
    }
}

int[] array = CreateArrayRndInt(5, 0, 9);
PrintArray(array);
ReverseArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Array.Reverse(array);
PrintArray(array);
Console.ReadKey();