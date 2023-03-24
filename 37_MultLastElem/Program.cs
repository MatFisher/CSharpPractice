// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

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

int[] CompArray(int[] arr)
{
    int size = arr.Length;
    int[] temp = size % 2 == 0 ? new int[size / 2] : new int[(size / 2) + 1];
    for (int i = 0; i < temp.Length; i++)
    {
        if (i != size - i - 1) temp[i] = arr[i] * arr[size - i - 1];
        else temp[i] = arr[i];
    }
    return temp;
}

int[] array = CreateArrayRndInt(10, 0, 9);
PrintArray(array);
int[] result = CompArray(array);
PrintArray(result);
Console.ReadKey();