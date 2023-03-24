// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int GetUniqNumber(int[] intArray)
//Данный метод создается с целью более простого его использования
//в другом методе, где создается 3D массив
{
    int nextNumber;
    do nextNumber = new Random().Next(10, 100);
    while (intArray[nextNumber] != 0);
    intArray[nextNumber] = 1;
    return nextNumber;
}
int[,,] Generate3DArray(int rows, int columns, int layers, int[] intArray)
{
    int[,,] returnArray = new int[rows, columns, layers];

    if (rows * columns * layers < 90)
    {
        for (int i = 0; i < returnArray.GetLength(0); i++)
        {
            for (int j = 0; j < returnArray.GetLength(1); j++)
            {
                for (int k = 0; k < returnArray.GetLength(2); k++)
                {
                    returnArray[i, j, k] = GetUniqNumber(intArray);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
    }
    return returnArray;

}

void Print3DArray(int[,,] int3DArray)
{
    for (int i = 0; i < int3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int3DArray.GetLength(1); j++)
        {
            for (int k = 0; k < int3DArray.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {int3DArray[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }
}

Console.WriteLine();
int[] intArray = new int[100];
int[,,] array3D = Generate3DArray(2, 2, 2, intArray);
Print3DArray(array3D);
Console.ReadKey();
