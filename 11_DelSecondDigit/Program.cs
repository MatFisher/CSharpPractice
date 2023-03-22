// Удалить вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 -999 = {number}");

int DelDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int delDigit = DelDigit(number);
Console.WriteLine($"Число без второй цифры = {delDigit}");
Console.ReadKey();