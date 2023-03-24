// Написать программу вычисления функции Аккермана

// В данном методе задана сама функция Аккермана. 
// Сам метод для удобства использован в процессе печати

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    else
        return -1;
}

// В процессе решения решил вывести всю доступную таблицу значений. 
// В итоге при печати каждый раз происходит применение функции.
// Программа выводит все возможные значения, которые можно показать рекурсией и заканчивается
// переполнением стека для наглядности процесса.

void PrintAkkerman(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Akkerman(i, j);
            Console.Write($"m={i}, n={j} A={matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matr = new int[5, 10];
PrintAkkerman(matr);
Console.ReadKey();
