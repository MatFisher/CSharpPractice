// Спирально заполнить двумерный массив

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

int[,] CreateSpiralMatrix(int rows, int columns)
{
    int[,] spiralMatrix = new int[rows, columns];

    int i = 0;
    int j = 0;

    int RightDirect = 1, DownDirect = 0;
    int direct = 0, sideLength = columns;

    for (int item = 0; item < spiralMatrix.Length; item++)
    {
        spiralMatrix[i, j] = item + 1;

        --sideLength;
        if (sideLength == 0) //Если мы подошли к краю матрицы, необходимо изменить направление
        {
            sideLength = columns * (direct % 2) + rows * ((direct + 1) % 2) - (direct / 2 - 1) - 2;//определяем длину следующей стороны, которую заполняем

            int temp = RightDirect;
            RightDirect = -DownDirect;
            DownDirect = temp;
            direct++;
        }
        i += DownDirect;
        j += RightDirect;
    }

    return spiralMatrix;
}

int[,] matr = CreateSpiralMatrix(8, 8);
Console.WriteLine();
PrintMatrix(matr);
Console.ReadKey();
