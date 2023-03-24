// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Random rnd = new Random();

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

int[,] SumIndexMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

matrix = SumIndexMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.ReadKey();


