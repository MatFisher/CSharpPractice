// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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

bool IsSquareMatrix(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

void TransposeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[j, i];
            matrix[j, i] = matrix[i, j];
            matrix[i, j] = temp;
        }
    }
}

int[,] array = CreateMatrixRndInt(4, 4, 0, 20);
Console.WriteLine("Начальная матрица");
PrintMatrix(array);
Console.WriteLine();
if (IsSquareMatrix(array))
{
    TransposeMatrix(array);
    Console.WriteLine("Итоговая матрица");
    PrintMatrix(array);
}
else Console.WriteLine("Введена не квадртаная матрица");
Console.ReadKey();