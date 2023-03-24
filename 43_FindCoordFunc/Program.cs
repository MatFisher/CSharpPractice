// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

Console.WriteLine("Введите количество функций");
int howMuch = Convert.ToInt32(Console.ReadLine()) * 2;

int[] EnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Параметр {i + 1}");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

double[] Coord(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[0] == arr[2]) Console.WriteLine("Прямые параллельны");
        if (arr[0] == arr[1] && arr[1] == arr[2]) Console.WriteLine("Прямые совпадают");
    }
    double[] ar = new double[arr.Length / 2];
    ar[0] = (arr[3] - arr[1]) / (arr[0] - arr[2]);
    ar[1] = arr[0] * ar[0] + arr[1];
    return ar;
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

int[] m = EnterArray(howMuch);
double[] xy = Coord(m);
PrintArrayDouble(xy);
Console.ReadKey();