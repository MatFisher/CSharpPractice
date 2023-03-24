// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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

string FindElementFromIndex(int[,] matrix, int line, int column)
{
    string result = "Такого элемента в массиве нет";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == line && j == column)
                result = ($"Значение элемента = {matrix[i, j]}");
        }
    }
    return result;
}

int[,] matrix = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(matrix);
Console.WriteLine("Введите номер строки");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

line -= 1; column -= 1; //Упрощение использования программы для пользователя

string result = FindElementFromIndex(matrix, line, column);
Console.WriteLine(result);
Console.ReadKey();