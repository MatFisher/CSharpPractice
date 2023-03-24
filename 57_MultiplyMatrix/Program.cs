// Найти произведение двух матриц

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

int[,] CheckMultiply(int[,] matrixA, int[,] matrixB)
//В данном методе проходит создание матрицы, которая будет являться 
//результатом произведения а также проведется проверка условия возможности
//умножения данных матриц
{
    int row = (matrixA.GetLength(0) >= matrixB.GetLength(0)) ? matrixA.GetLength(0) : matrixB.GetLength(0);
    int col = (matrixA.GetLength(1) >= matrixB.GetLength(1)) ? matrixA.GetLength(1) : matrixB.GetLength(1);
    int[,] multiplyMatrix = new int[row, col];
    if (matrixA.GetLength(1) == matrixB.GetLength(0) || matrixA.GetLength(0) == matrixB.GetLength(1)) Console.WriteLine("Условия соблюдены, ждите результат");
    else
    {
        Console.WriteLine("Невозможно умножить матрицу А на В. Нужно чтобы число столбцов матрицы 1 было рано числу строк матрицы 2");
        Environment.Exit(0);
    }
    return multiplyMatrix;
}

int[,] MultiplyMatrix(int[,] multmatrix, int[,] matrixA, int[,] matrixB)
{
    int[,] result = multmatrix;
    for (int i = 0; i < multmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multmatrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return result;
}

int[,] matrA = CreateMatrixRndInt(3, 2, 1, 5);
Console.WriteLine("Матрица 1:");
Console.WriteLine();
PrintMatrix(matrA);
Console.WriteLine();

int[,] matrB = CreateMatrixRndInt(2, 4, 5, 10);
Console.WriteLine("матрица 2:");
Console.WriteLine();
PrintMatrix(matrB);
Console.WriteLine();

int[,] multimatrix = CheckMultiply(matrA, matrB);
multimatrix = MultiplyMatrix(multimatrix, matrA, matrB);

Console.WriteLine();
Console.WriteLine("Результат перемножения:");
Console.WriteLine();
PrintMatrix(multimatrix);
Console.ReadKey();
