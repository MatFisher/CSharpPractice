// Задать массив из 8 элементов и вывести их на экран

using System.Drawing;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    array[i] = new Random().Next(1, 10);
    return array;
}

void PrintArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]} ");
}

int[] array = FillArray(8);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.ReadKey();