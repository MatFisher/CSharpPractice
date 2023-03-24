// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine();
    }
}

double[] SumColumn(int[,] matrix, double[] array)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            array[i] += matrix[j, i];
        }
    }
    return array;
}

void PrintAverange(double[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {(arr[i] = Math.Round((arr[i] / n), 1))};");
    }
}

Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrixRndInt(n, m, -10, 10);
PrintMatrix(matrix);
double[] result = new double[m];
result = SumColumn(matrix, result);
Console.Write("Среднее арифметическое каждого столбца:");
PrintAverange(result, n);
Console.ReadKey();