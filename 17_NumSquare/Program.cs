// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите координату х");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int numbB = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
int quat = Quarter(numbA, numbB);
string result = quat > 0
                ? $"Указанные координаты соответствуют четверти {quat}"
                : "ВВедены некорректные координаты";
Console.WriteLine(result);
Console.ReadKey();