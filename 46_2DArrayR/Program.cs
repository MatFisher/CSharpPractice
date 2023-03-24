// Задайте двумерный массив размером m×n, заполненный вещественными числами.

double[,] CreateMatrixRndDouble(double[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Convert.ToDouble(rnd.Next(-100, 100) / 10.0);
            matr[i, j] = Math.Round(matr[i, j], 1);
        }
    }
    return matr;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[3, 4];
matrix = CreateMatrixRndDouble(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.ReadKey();