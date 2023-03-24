// В матрице чисел найти сумму элементов главной диагонали

int SumDiagonale(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
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

int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(matrix);
int result = SumDiagonale(matrix);
Console.WriteLine($"Сумма элементов диагонали = {result}");
Console.ReadKey();
