// Определить, присутствует ли в заданном массиве, некоторое число 

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

bool FindNumber(int[] ar, int num)
{
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] == num) return true;
    }
    return false;
}

int[] array = CreateArrayRndInt(10, 0, 10);
PrintArray(array);
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string output = FindNumber(array, number) ? "Да" : "Нет";
Console.WriteLine(output);
Console.ReadKey();