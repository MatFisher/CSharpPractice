// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер четверти");
int numberA = Convert.ToInt32(Console.ReadLine());
string Result(int num)
{
    if (num == 1) return "Координаты х > 0, координаты y > 0";
    if (num == 2) return "Координаты х < 0, координаты y > 0";
    if (num == 3) return "Координаты х < 0, координаты y < 0";
    if (num == 4) return "Координаты х > 0, координаты y < 0";
    return "Введите корректный номер четврети";
}

string res = Result(numberA);
Console.WriteLine(res);
Console.ReadKey();