// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]} | ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double DiffMaxMin(double[] ar)
{
    int size = ar.Length;
    double max = 0;
    for (int i = 0; i < size; i++)
    {
        if (ar[i] > max) max = ar[i];
    }
    double min = max;
    for (int i = 0; i < size; i++)
    {
        if (ar[i] < min) min = ar[i];
    }
    double result = max - min;
    result = Math.Round(result, 1);
    return result;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArrayDouble(array);
double res = DiffMaxMin(array);
Console.WriteLine($"Разница max и min элементов = {res}");
Console.ReadKey();